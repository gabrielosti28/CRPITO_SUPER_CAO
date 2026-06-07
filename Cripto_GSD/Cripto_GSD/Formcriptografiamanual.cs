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

            txtSaida.Text = CriptografiaManual.Criptografar(txtEntrada.Text);
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEntrada.Text)) return;

            try
            {
                txtSaida.Text = CriptografiaManual.Descriptografar(txtEntrada.Text);
            }
            catch
            {
                MessageBox.Show("Texto inválido.", "Erro",
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
            Form1 f = new Form1();

            f.ShowDialog();
        }


    }

}