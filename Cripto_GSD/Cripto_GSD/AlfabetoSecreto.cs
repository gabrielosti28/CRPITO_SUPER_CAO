using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto_GSD
{
    internal class AlfabetoSecreto
    {

        private static char[] GerarAlfabeto(byte[] chaveHash)
        {
            char[] alfabeto = { 'ç', '4', '*', '~', 'r', 'w', '$', 'c', '@', 't', '&', '0',
            'O', 'q', 'X', '1' };
            for (int i = 15; i > 0; i--)
            {
                int j = chaveHash[i % chaveHash.Length] % (i + 1);
                char temporario = alfabeto[i];
                alfabeto[i] = alfabeto[j];
                alfabeto[j] = temporario;
            }
            return alfabeto;
        }
        public static string Codificar(byte[] dados, byte[] chaveHash)
        {
            char[] alfa = GerarAlfabeto(chaveHash);

            var sb = new StringBuilder(dados.Length * 2);

            foreach (byte b in dados)
            {
            
                sb.Append(alfa[b >> 4]);
                sb.Append(alfa[b & 0x0F]);
            }

            return sb.ToString();
        }
        public static byte[] Decodificar(string texto, byte[] chaveHash)
        {
            if (texto.Length % 2 != 0)
                throw new ArgumentException("Texto invalido: comprimento nao e par, ele DEVE ser par");
            char[] alfa = GerarAlfabeto(chaveHash);
            var inversao = new Dictionary<char, int>();
            for (int i = 0; i < 16; i++)
            {
                inversao[alfa[i]] = i;
            }
            byte[] resultado = new byte[texto.Length / 2];

            for (int i = 0; i < texto.Length; i += 2)
            {
                int alto = inversao[texto[i]];
                int baixo = inversao[texto[i + 1]];
                resultado[i / 2] = (byte)((alto << 4) | baixo);
            }
            return resultado;
        }





    }
}
