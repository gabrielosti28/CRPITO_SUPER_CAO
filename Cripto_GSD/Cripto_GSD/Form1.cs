using System;                           
using System.IO;                        
using System.Security.Cryptography;    
using System.Text;                      
using System.Windows.Forms;            

namespace Cripto_GSD
{

    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        // Chave AES utilizada na criptografia
        private static readonly byte[] _key = Encoding.UTF8.GetBytes("MinhaChaveAES128");

        // Vetor de inicialização utilizado pelo AES
        private static readonly byte[] _iv = Encoding.UTF8.GetBytes("VetorInicialAES!");

        // Evento do botão Criptografar
        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo está vazio
            if (string.IsNullOrWhiteSpace(txtEntrada.Text))
            {
                // Exibe mensagem de aviso
                MessageBox.Show("Digite um texto para criptografar.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     // Encerra o método
                return;
            }

            try
            {
                // Criptografa o texto e exibe o resultado
                txtSaida.Text = CriptografarAES(txtEntrada.Text);
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro
                MessageBox.Show("Erro ao criptografar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        // Evento do botão Descriptografar
        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo está vazio
            if (string.IsNullOrWhiteSpace(txtEntrada.Text))
            {
                // Exibe mensagem de aviso
                MessageBox.Show("Cole o texto criptografado.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 // Encerra o método
                    return;
            }

            try
            {
                // Descriptografa o texto e exibe o resultado
                txtSaida.Text = DescriptografarAES(txtEntrada.Text);
            }
            catch
            {
                // Exibe mensagem de erro
                MessageBox.Show("Texto inválido ou chave incorreta.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

         // Evento do botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa o campo de entrada
            txtEntrada.Clear();
                // Limpa o campo de saída
                txtSaida.Clear();

            // Define o foco no campo de entrada
            txtEntrada.Focus();

}

        // Evento do botão Abrir Manual
        private void btnAbrirManual_Click(object sender, EventArgs e)
        {
            // Cria o formulário de criptografia manual
            FormCriptografiaManual f = new FormCriptografiaManual();


                // Abre o formulário
                f.ShowDialog();

}

        // Criptografa um texto usando AES
        private static string CriptografarAES(string texto)
        {
            // Cria uma instância do AES
            using (Aes aes = Aes.Create())
            {
                // Define a chave
                aes.Key = _key;

    // Define o vetor de inicialização
    aes.IV = _iv;

                // Cria o criptografador
                ICryptoTransform enc = aes.CreateEncryptor();

                // Cria um fluxo em memória
                using (MemoryStream ms = new MemoryStream())

                // Aplica a criptografia ao fluxo
                using (CryptoStream cs = new CryptoStream(ms, enc, CryptoStreamMode.Write))
                {
                    // Converte o texto para bytes
                    byte[] bytes = Encoding.UTF8.GetBytes(texto);

                    // Criptografa os bytes
                    cs.Write(bytes, 0, bytes.Length);

                    // Finaliza a criptografia
                    cs.FlushFinalBlock();

                    // Retorna o resultado em Base64
                    return Convert.ToBase64String(ms.ToArray());
                }
            }

}

        // Descriptografa um texto criptografado com AES
        private static string DescriptografarAES(string base64)
        {
            // Cria uma instância do AES
            using (Aes aes = Aes.Create())
            {
                // Define a chave
                aes.Key = _key;

            // Define o vetor de inicialização
                 aes.IV = _iv;

                // Cria o descriptografador
                ICryptoTransform dec = aes.CreateDecryptor();

                // Converte o Base64 para bytes
                byte[] dados = Convert.FromBase64String(base64);

                // Carrega os dados criptografados
                using (MemoryStream ms = new MemoryStream(dados))

                // Descriptografa os dados
                using (CryptoStream cs = new CryptoStream(ms, dec, CryptoStreamMode.Read))

                // Lê o texto descriptografado
                using (StreamReader sr = new StreamReader(cs, Encoding.UTF8))
                {
                    // Retorna o texto original
                    return sr.ReadToEnd();
                }
            }

}

    }
}