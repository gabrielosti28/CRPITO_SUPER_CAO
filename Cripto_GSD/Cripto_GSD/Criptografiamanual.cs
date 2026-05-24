#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cripto_GSD
{
    // ============================================================
    //  Criptografia Manual — Algoritmo "TrigShift v2"
    //
    //  CAMADAS (em ordem):
    //   [1] Sal aleatório de 4 bytes no início
    //   [2] Deslocamento TrigShift usando hash SHA-256 da senha
    //   [3] Permutação Fisher-Yates dos bytes
    //   [4] Codificação Base64
    //   [5] Codificação I/l (esteganografia visual)
    //
    //  FÓRMULA DO DESLOCAMENTO (posição i, hash H):
    //    byteChave    = H[i % 32]
    //    d = byteChave + (int)(sen(i)*10) + (int)(cos(i)*10) + (int)(log(i+2)*5)
    //    byte_cifrado = (byte_original + d) mod 256
    // ============================================================

    internal static class CriptografiaManual
    {
        // ── Hash da senha → 32 bytes únicos ──────────────────────────────
        private static byte[] GerarHashChave(string senha)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
                return sha.ComputeHash(Encoding.UTF8.GetBytes(senha));
        }

        // ── Deslocamento por posição usando hash + trig + log ─────────────
        private static int Deslocamento(int i, byte[] chaveHash)
        {
            double sen = Math.Sin(i);
            double cos = Math.Cos(i);
            double log = Math.Log(i + 2);
            int byteChave = chaveHash[i % chaveHash.Length];

            return byteChave
                 + (int)(sen * 10)
                 + (int)(cos * 10)
                 + (int)(log * 5);
        }

        // ── Permutação Fisher-Yates (embaralha a ORDEM dos bytes) ─────────
        private static byte[] Permutar(byte[] dados, byte[] chaveHash)
        {
            int n = dados.Length;
            int[] indices = Enumerable.Range(0, n).ToArray();

            for (int i = n - 1; i > 0; i--)
            {
                int j = (chaveHash[i % chaveHash.Length] + i) % (i + 1);
                int tmp = indices[i]; indices[i] = indices[j]; indices[j] = tmp;
            }

            byte[] resultado = new byte[n];
            for (int i = 0; i < n; i++)
                resultado[i] = dados[indices[i]];
            return resultado;
        }

        private static byte[] DesfazerPermutacao(byte[] dados, byte[] chaveHash)
        {
            int n = dados.Length;
            int[] indices = Enumerable.Range(0, n).ToArray();

            for (int i = n - 1; i > 0; i--)
            {
                int j = (chaveHash[i % chaveHash.Length] + i) % (i + 1);
                int tmp = indices[i]; indices[i] = indices[j]; indices[j] = tmp;
            }

            byte[] resultado = new byte[n];
            for (int i = 0; i < n; i++)
                resultado[indices[i]] = dados[i];
            return resultado;
        }

        // ── Codificação I/l (esteganografia visual) ───────────────────────
        // Cada caractere do Base64 vira 8 bits: I=1, l=0
        // Numa fonte com serifa (Courier New), I e l ficam idênticos visualmente
        private static string CodificarIL(string base64)
        {
            var sb = new StringBuilder();
            foreach (char c in base64)
            {
                int val = (int)c;
                for (int b = 7; b >= 0; b--)
                    sb.Append(((val >> b) & 1) == 1 ? 'I' : 'l');
            }
            return sb.ToString();
        }

        private static string DecodificarIL(string ilTexto)
        {
            
            if (ilTexto.Length % 8 != 0)
                throw new ArgumentException("Texto invalido: comprimento nao e multiplo de 8.");

            var chars = new List<char>();
            for (int i = 0; i < ilTexto.Length; i += 8)
            {
                int val = 0;
                for (int b = 0; b < 8; b++)
                    val = (val << 1) | (ilTexto[i + b] == 'I' ? 1 : 0);
                chars.Add((char)val);
            }
            return new string(chars.ToArray());
        }

        // ── Criptografar ──────────────────────────────────────────────────
        public static string Criptografar(string texto, string senha)
        {
            byte[] chaveHash = GerarHashChave(senha);

            // Sal aleatório de 4 bytes
            byte[] sal = new byte[4];
            new Random().NextBytes(sal);

            // Junta sal + texto
            byte[] bytes = sal.Concat(Encoding.UTF8.GetBytes(texto)).ToArray();

            // Aplica deslocamento TrigShift
            byte[] cifrado = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                int d = Deslocamento(i, chaveHash);
                cifrado[i] = (byte)(((bytes[i] + d) % 256 + 256) % 256);
            }

            // Embaralha a ordem dos bytes
            byte[] permutado = Permutar(cifrado, chaveHash);

            // Base64 → I/l
            return CodificarIL(Convert.ToBase64String(permutado));
        }

        // ── Descriptografar ───────────────────────────────────────────────
        public static string Descriptografar(string ilTexto, string senha)
        {
            byte[] chaveHash = GerarHashChave(senha);

            // I/l → Base64 → bytes
            byte[] permutado = Convert.FromBase64String(DecodificarIL(ilTexto));

            // Desfaz permutação
            byte[] cifrado = DesfazerPermutacao(permutado, chaveHash);

            // Subtrai deslocamento
            byte[] bytes = new byte[cifrado.Length];
            for (int i = 0; i < cifrado.Length; i++)
            {
                int d = Deslocamento(i, chaveHash);
                bytes[i] = (byte)(((cifrado[i] - d) % 256 + 256) % 256);
            }

            // Remove sal (primeiros 4 bytes) e converte para texto
            return Encoding.UTF8.GetString(bytes.Skip(4).ToArray());
        }

       
    }
}
