namespace Cripto_GSD
{
    partial class Form1
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSaida = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.btnAbrirManual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 56);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(113, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Algoritmo AES-128  ";
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
            this.txtEntrada.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.txtEntrada.Location = new System.Drawing.Point(40, 118);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(540, 90);
            this.txtEntrada.TabIndex = 4;
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
            this.btnCriptografar.Location = new System.Drawing.Point(40, 222);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(80, 23);
            this.btnCriptografar.TabIndex = 5;
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
            this.btnDescriptografar.Location = new System.Drawing.Point(135, 222);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(90, 23);
            this.btnDescriptografar.TabIndex = 6;
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
            this.btnLimpar.Location = new System.Drawing.Point(240, 222);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(50, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblSaida.Location = new System.Drawing.Point(40, 272);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(59, 15);
            this.lblSaida.TabIndex = 8;
            this.lblSaida.Text = "Resultado";
            // 
            // txtSaida
            // 
            this.txtSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaida.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.txtSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(110)))), ((int)(((byte)(40)))));
            this.txtSaida.Location = new System.Drawing.Point(40, 290);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSaida.Size = new System.Drawing.Size(540, 90);
            this.txtSaida.TabIndex = 9;
            // 
            // btnAbrirManual
            // 
            this.btnAbrirManual.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirManual.FlatAppearance.BorderSize = 0;
            this.btnAbrirManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbrirManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbrirManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirManual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btnAbrirManual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAbrirManual.Location = new System.Drawing.Point(40, 418);
            this.btnAbrirManual.Name = "btnAbrirManual";
            this.btnAbrirManual.Size = new System.Drawing.Size(310, 23);
            this.btnAbrirManual.TabIndex = 11;
            this.btnAbrirManual.Text = "→ Abrir Criptografia Manual (Método Próprio)";
            this.btnAbrirManual.UseVisualStyleBackColor = false;
            this.btnAbrirManual.Click += new System.EventHandler(this.btnAbrirManual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(620, 540);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.btnAbrirManual);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(636, 579);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalho de GSD — Criptografia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAbrirManual;
    }
}