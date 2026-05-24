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

        // Chave e IV fixos de 16 bytes (AES-128)
        private static readonly byte[] _key = Encoding.UTF8.GetBytes("MinhaChaveAES128");
        private static readonly byte[] _iv = Encoding.UTF8.GetBytes("VetorInicialAES!");

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEntrada.Text))
            {
                MessageBox.Show("Digite um texto para criptografar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                txtSaida.Text = CriptografarAES(txtEntrada.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criptografar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEntrada.Text))
            {
                MessageBox.Show("Cole o texto criptografado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                txtSaida.Text = DescriptografarAES(txtEntrada.Text);
            }
            catch
            {
                MessageBox.Show("Texto inválido ou chave incorreta.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear();
            txtSaida.Clear();
            txtEntrada.Focus();
        }

        private void btnAbrirManual_Click(object sender, EventArgs e)
        {
            FormCriptografiaManual f = new FormCriptografiaManual();
            f.ShowDialog();
        }

        // ── AES helpers ────────────────────────────────────────────────────

        private static string CriptografarAES(string texto)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = _iv;

                ICryptoTransform enc = aes.CreateEncryptor();
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, enc, CryptoStreamMode.Write))
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(texto);
                    cs.Write(bytes, 0, bytes.Length);
                    cs.FlushFinalBlock();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private static string DescriptografarAES(string base64)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = _iv;

                ICryptoTransform dec = aes.CreateDecryptor();
                byte[] dados = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(dados))
                using (CryptoStream cs = new CryptoStream(ms, dec, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs, Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}