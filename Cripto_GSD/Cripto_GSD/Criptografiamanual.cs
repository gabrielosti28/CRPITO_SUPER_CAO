
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cripto_GSD
{
    // ============================================================
    //  Criptografia Manual 
    //
    //  CAMADAS (em ordem):
    //   [1] Sal aleatório de 4 bytes no início
    //   [2] Deslocamento COM ENCADEAMENTO (modo CBC manual)   
    //   [3] Permutação Fisher-Yates dos bytes
    //   [4] Codificação Hex com alfabeto embaralhado pela chave         
    //   [5] Codificação I/l (esteganografia visual)
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

        private static int Deslocamento(int i, byte[] chaveHash, int anterior)
        {
            double sen = Math.Sin(i);
            double cos = Math.Cos(i);
            double log = Math.Log(i + 2);
            int byteChave = chaveHash[i % chaveHash.Length];

            return byteChave + (int)(sen * 10) + (int)(cos * 10) + (int)(log * 5) + anterior;           // encadeia com o byte anterior
        }

        // ── Permutação Fisher-Yates ───────────────────────
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


      // Alfabeto que utilizo
        private static string CodificarHex(byte[] dados, byte[] chaveHash)
        {
            return AlfabetoSecreto.Codificar(dados, chaveHash);
        }

        private static byte[] DecodificarHex(string texto, byte[] chaveHash)
        {
            return AlfabetoSecreto.Decodificar(texto, chaveHash);
        }

        // ── Codificação I/l  ──────────────────────────────
        private static string CodificarIL(string texto)
        {
            var sb = new StringBuilder();
            foreach (char c in texto)
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

            // Junta sal mais o texto em bytes
            byte[] bytes = sal.Concat(Encoding.UTF8.GetBytes(texto)).ToArray();

            // A cada passo, o anterior recebe o byte que acabou de ser cifrado
            byte[] cifrado = new byte[bytes.Length];
            int anterior = chaveHash[0]; // valor inicial: não é zero, é derivado da chave

            for (int i = 0; i < bytes.Length; i++)
            {
                int d = Deslocamento(i, chaveHash, anterior);
                cifrado[i] = (byte)(((bytes[i] + d) % 256 + 256) % 256);
                anterior = cifrado[i]; // o byte recém cifrado vira o 'anterior' da próxima rodada
            }

            byte[] permutado = Permutar(cifrado, chaveHash);

            // ──  Hex embaralhado → I/l ─────────────────
            // Substituímos Convert.ToBase64String pelo nosso CodificarHex
            return CodificarIL(CodificarHex(permutado, chaveHash));
        }

        // ── Descriptografar ───────────────────────────────────────────────
        public static string Descriptografar(string ilTexto, string senha)
        {
            byte[] chaveHash = GerarHashChave(senha);

            // ──  I/l → Hex embaralhado → bytes
            // Substituímos Convert.FromBase64String pelo nosso DecodificarHex
            byte[] permutado = DecodificarHex(DecodificarIL(ilTexto), chaveHash);

            // Desfaz permutação 
            byte[] cifrado = DesfazerPermutacao(permutado, chaveHash);

            // ──  subtrai deslocamento com encadeamento
            // Precisa percorrer na mesma ordem, usando o byte CIFRADO como 'anterior'
            // não o descriptografado — o encadeamento usa sempre o lado cifrado
            byte[] bytes = new byte[cifrado.Length];
            int anterior = chaveHash[0]; // mesmo valor inicial usado na criptografia

            for (int i = 0; i < cifrado.Length; i++)
            {
                int d = Deslocamento(i, chaveHash, anterior);
                bytes[i] = (byte)(((cifrado[i] - d) % 256 + 256) % 256);
                anterior = cifrado[i]; // usa o byte CIFRADO (não o descriptografado) — igual ao cifrar
            }

            // Remove sal e retorna o texto original (sem alteração)
            return Encoding.UTF8.GetString(bytes.Skip(4).ToArray());
        }
    }
}