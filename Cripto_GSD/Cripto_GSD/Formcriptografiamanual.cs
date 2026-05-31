
using System;
using System.Windows.Forms;

namespace Cripto_GSD
{
    
    public partial class FormCriptografiaManual : Form
    {
        
        public FormCriptografiaManual()
        {
            InitializeComponent();
        }

    private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEntrada.Text)) return;

            if (string.IsNullOrWhiteSpace(txtChave.Text))
            {
                MessageBox.Show("Digite uma senha.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

           
                txtChave.Focus();

                
                return;
            }
            else{
            
                // Criptografa o texto e exibe o resultado
                txtSaida.Text = CriptografiaManual.Criptografar(
                    txtEntrada.Text,
                    txtChave.Text);
            }

        }

        
        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEntrada.Text)) return;

            if (string.IsNullOrWhiteSpace(txtChave.Text))
            {
                MessageBox.Show("Digite a senha usada na criptografia.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtChave.Focus();

                return;
            }

            try
            {
                txtSaida.Text = CriptografiaManual.Descriptografar(
                    txtEntrada.Text,
                    txtChave.Text);
            }
            catch
            {
                MessageBox.Show("Texto inválido ou senha incorreta.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnLimpar_Click(object sender, EventArgs e)
        {
         
            txtEntrada.Clear();

           
            txtSaida.Clear();

            txtChave.Text = "";

            txtEntrada.Focus();
        }

        private void btnAbrirManual_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

            f.ShowDialog();
        }

     
    }

}
