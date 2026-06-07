using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cripto_GSD
{
    // ============================================================
    //  Criptografia Manual — TrigShift v3
    //
    //  CAMADAS (em ordem):
    //   [1] Sal aleatório de 4 bytes no início
    //   [2] Deslocamento COM ENCADEAMENTO (Seno + Cosseno + Log)
    //   [3] Permutação Trigonométrica + Collatz
    //   [4] Codificação Hex com alfabeto embaralhado pela chave
    //   [5] Codificação I/l (esteganografia visual)
    //
    
    //   - CHAVE_INTERNA: fixa no programa, protege a senhaAleatoria
    //   - senhaAleatoria: gerada a cada cifração, cifra o texto
    //   - Estrutura da mensagem: [32 bytes senhaCifrada] + [sal(4) + texto cifrado permutados]
    // ============================================================

    internal static class CriptografiaManual
    {
        // ── Chave interna do programa
        private const string CHAVE_INTERNA = "Senh0r+d0s_Aneis_H0bbit_T0lkien_MInecraft";

        // ── Instância estática de Random para evitar seeds iguais por tick ──
        //  Bug sem vergonha
        private static readonly Random _rng = new Random();

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

            return byteChave + (int)(sen * 10) + (int)(cos * 10) + (int)(log * 5) + anterior;
        }

        // ── Sequência de Collatz — retorna quantos passos até chegar em 1 ─
        private static int Collatz(int n)
        {
            int passos = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = n * 3 + 1;
                passos++;
            }
            return passos;
        }

        // ── Permutação Trigonométrica + Collatz + log ───────────────────────────
        private static byte[] Permutar(byte[] dados, byte[] chaveHash)
        {
            int n = dados.Length;
            int[] indices = Enumerable.Range(0, n).ToArray();

            for (int i = n - 1; i > 0; i--)
            {
                int j = Math.Abs(
                    (int)(Math.Sin(i) * 10) +
                    (int)(Math.Cos(i) * 10) +
                    (int)(Math.Log(i + 2) * 5) +
                    chaveHash[i % chaveHash.Length] +
                    Collatz(i + 1 + chaveHash[i % chaveHash.Length])
                ) % (i + 1);

                int tmp = indices[i]; indices[i] = indices[j]; indices[j] = tmp;
            }

            byte[] resultado = new byte[n];
            for (int i = 0; i < n; i++)
                resultado[i] = dados[indices[i]];
            return resultado;
        }

        // ── Desfaz a Permutação Trigonométrica + Collatz ──────────────────
        private static byte[] DesfazerPermutacao(byte[] dados, byte[] chaveHash)
        {
            int n = dados.Length;
            int[] indices = Enumerable.Range(0, n).ToArray();

            for (int i = n - 1; i > 0; i--)
            {
                int j = Math.Abs(
                    (int)(Math.Sin(i) * 10) +
                    (int)(Math.Cos(i) * 10) +
                    (int)(Math.Log(i + 2) * 5) +
                    chaveHash[i % chaveHash.Length] +
                    Collatz(i + 1 + chaveHash[i % chaveHash.Length])
                ) % (i + 1);

                int tmp = indices[i]; indices[i] = indices[j]; indices[j] = tmp;
            }

            byte[] resultado = new byte[n];
            for (int i = 0; i < n; i++)
                resultado[indices[i]] = dados[i];
            return resultado;
        }

        // ── Codificação Hex com alfabeto secreto ──────────────────────────
        private static string CodificarHex(byte[] dados, byte[] chaveHash)
        {
            return AlfabetoSecreto.Codificar(dados, chaveHash);
        }

        // ── Codificação I/l (esteganografia visual) ───────────────────────
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

        // ── Decodificação I/l ─────────────────────────────────────────────
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

        // ── Decodificação Hex com alfabeto secreto ────────────────────────
        private static byte[] DecodificarHex(string texto, byte[] chaveHash)
        {
            return AlfabetoSecreto.Decodificar(texto, chaveHash);
        }

        // ── Criptografar ──────────────────────────────────────────────────
        public static string Criptografar(string texto)
        {
            byte[] chaveInterna = GerarHashChave(CHAVE_INTERNA);

            //_rng sortea os números
            byte[] senhaAleatoria = new byte[32];
            _rng.NextBytes(senhaAleatoria);

            // Cifra a senha aleatória com a chave interna 
            byte[] senhaCifrada = new byte[32];
            int anteriorSenha = chaveInterna[0];
            for (int i = 0; i < 32; i++)
            {
                int d = Deslocamento(i, chaveInterna, anteriorSenha);
                senhaCifrada[i] = (byte)(((senhaAleatoria[i] + d) % 256 + 256) % 256);
                anteriorSenha = senhaCifrada[i];
            }

            // Sal + texto
           //Bug do Random acabou!
            byte[] sal = new byte[4];
            _rng.NextBytes(sal);
            byte[] bytes = sal.Concat(Encoding.UTF8.GetBytes(texto)).ToArray();

            // Cifra o texto com a senha aleatória 
            byte[] cifrado = new byte[bytes.Length];
            int anterior = senhaAleatoria[0];
            for (int i = 0; i < bytes.Length; i++)
            {
                int d = Deslocamento(i, senhaAleatoria, anterior);
                cifrado[i] = (byte)(((bytes[i] + d) % 256 + 256) % 256);
                anterior = cifrado[i];
            }

            // Permuta o resultado com a senha aleatória
            byte[] permutado = Permutar(cifrado, senhaAleatoria);

            // O bloco cifrado já contém o sal interno . não separa o sal aqui
            byte[] mensagemFinal = senhaCifrada.Concat(permutado).ToArray();

            return CodificarIL(CodificarHex(mensagemFinal, chaveInterna));
        }

        // ── Descriptografar ───────────────────────────────────────────────
        public static string Descriptografar(string ilTexto)
        {
            byte[] chaveInterna = GerarHashChave(CHAVE_INTERNA);

            // Decodifica as camadas externas (I/l e Hex)
            byte[] mensagem = DecodificarHex(DecodificarIL(ilTexto), chaveInterna);

            // Extrai apenas a senha cifrada 
            byte[] senhaCifrada = new byte[32];
            Array.Copy(mensagem, 0, senhaCifrada, 0, 32);

            // O restante é o bloco inteiro permutado, que inclui sal cifrado + texto cifrado
            byte[] blocoPermutado = new byte[mensagem.Length - 32];
            Array.Copy(mensagem, 32, blocoPermutado, 0, mensagem.Length - 32);

            // Laço 1 — recupera a senhaAleatoria usando a chave interna
            byte[] senhaAleatoria = new byte[32];
            int anteriorSenha = chaveInterna[0];
            for (int i = 0; i < 32; i++)
            {
                int d = Deslocamento(i, chaveInterna, anteriorSenha);
                senhaAleatoria[i] = (byte)(((senhaCifrada[i] - d) % 256 + 256) % 256);
                anteriorSenha = senhaCifrada[i];
            }

            // Desfaz a permutação do bloco inteiro,  sal + texto ainda cifrados
            byte[] semPermutacao = DesfazerPermutacao(blocoPermutado, senhaAleatoria);

            // Laço 2 — descriptografa o bloco com a senha aleatória recuperada
            byte[] bytes = new byte[semPermutacao.Length];
            int anterior = senhaAleatoria[0];
            for (int i = 0; i < semPermutacao.Length; i++)
            {
                int d = Deslocamento(i, senhaAleatoria, anterior);
                bytes[i] = (byte)(((semPermutacao[i] - d) % 256 + 256) % 256);
                anterior = semPermutacao[i];
            }

            // Pula os 4 bytes de sal e retorna o texto original
            return Encoding.UTF8.GetString(bytes.Skip(4).ToArray());
        }
    }
}