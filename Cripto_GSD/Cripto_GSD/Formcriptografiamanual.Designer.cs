namespace Cripto_GSD
{
    partial class FormCriptografiaManual
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitulo.Location = new System.Drawing.Point(235, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Criptografia Manual";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblEntrada.Location = new System.Drawing.Point(40, 100);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(94, 15);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Texto de entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.White;
            this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntrada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(40, 118);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(580, 80);
            this.txtEntrada.TabIndex = 4;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblChave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblChave.Location = new System.Drawing.Point(270, 217);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(138, 15);
            this.lblChave.TabIndex = 5;
            this.lblChave.Text = "Chave numérica (inteiro)";
            // 
            // txtChave
            // 
            this.txtChave.BackColor = System.Drawing.Color.White;
            this.txtChave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChave.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtChave.Location = new System.Drawing.Point(270, 235);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(110, 25);
            this.txtChave.TabIndex = 6;
            this.txtChave.Text = "7";
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriptografar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriptografar.FlatAppearance.BorderSize = 0;
            this.btnCriptografar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptografar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btnCriptografar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCriptografar.Location = new System.Drawing.Point(175, 275);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(80, 23);
            this.btnCriptografar.TabIndex = 7;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = false;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.BackColor = System.Drawing.Color.Transparent;
            this.btnDescriptografar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescriptografar.FlatAppearance.BorderSize = 0;
            this.btnDescriptografar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDescriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDescriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescriptografar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btnDescriptografar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDescriptografar.Location = new System.Drawing.Point(270, 275);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(99, 23);
            this.btnDescriptografar.TabIndex = 8;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = false;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLimpar.Location = new System.Drawing.Point(375, 275);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(63, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSaida
            // 
            this.txtSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(110)))), ((int)(((byte)(40)))));
            this.txtSaida.Location = new System.Drawing.Point(40, 340);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSaida.Size = new System.Drawing.Size(580, 70);
            this.txtSaida.TabIndex = 11;
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblExplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblExplicacao.Location = new System.Drawing.Point(40, 444);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(0, 15);
            this.lblExplicacao.TabIndex = 13;
            // 
            // FormCriptografiaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(660, 640);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.lblExplicacao);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(676, 679);
            this.Name = "FormCriptografiaManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criptografia Manual — Método VigShift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declaração dos controles
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Button btnLimpar;
    }
}