// ════════════════════════════════════════════════════════════════════════════
//  FormCriptografiaManual.Designer.cs
//
//  Este arquivo é gerado e gerenciado pelo Designer do Visual Studio.
//  Ele descreve COMO a janela é montada: posição, tamanho e propriedades
//  de cada controle (botão, caixa de texto, rótulo, etc.).
//
//  Você PODE editar manualmente — mas o Designer pode sobrescrever
//  suas alterações se você arrastar controles pela tela.
//
//  ALTERAÇÕES feitas para compatibilidade com CriptografiaManual.cs:
//    • txtChave agora aceita qualquer texto (senha livre, não só números)
//    • Label do campo de senha atualizado para "Senha (qualquer texto)"
//    • Text padrão do campo de senha alterado de "7" para "" (vazio)
// ════════════════════════════════════════════════════════════════════════════

namespace Cripto_GSD
{
    partial class FormCriptografiaManual
    {
        // "IContainer components" guarda todos os controles do formulário.
        // É usado pelo método Dispose() para liberar memória quando a janela fecha.
        private System.ComponentModel.IContainer components = null;

        // Dispose() é chamado automaticamente pelo .NET quando o formulário é fechado.
        // "disposing = true" significa que os recursos gerenciados (controles) devem ser liberados.
        // "base.Dispose(disposing)" chama o mesmo método na classe pai (Form).
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // InitializeComponent() é chamado pelo construtor do formulário.
        // Aqui TODOS os controles são criados, configurados e adicionados à janela.
        // A ordem de adição a "this.Controls.Add()" define a ordem de tabulação (Tab).
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
            this.btnAbrirManual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitulo.Location = new System.Drawing.Point(213, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Criptografia Manual ";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblEntrada.Location = new System.Drawing.Point(40, 80);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(94, 15);
            this.lblEntrada.TabIndex = 1;
            this.lblEntrada.Text = "Texto de entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.White;
            this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntrada.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEntrada.Location = new System.Drawing.Point(40, 98);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(580, 80);
            this.txtEntrada.TabIndex = 2;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblChave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblChave.Location = new System.Drawing.Point(215, 200);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(175, 15);
            this.lblChave.TabIndex = 3;
            this.lblChave.Text = "Senha (pode ser qualquer texto)";
            // 
            // txtChave
            // 
            this.txtChave.BackColor = System.Drawing.Color.White;
            this.txtChave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChave.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtChave.Location = new System.Drawing.Point(215, 218);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(230, 25);
            this.txtChave.TabIndex = 4;
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
            this.btnCriptografar.Location = new System.Drawing.Point(175, 262);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(90, 23);
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
            this.btnDescriptografar.Location = new System.Drawing.Point(280, 262);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(100, 23);
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
            this.btnLimpar.Location = new System.Drawing.Point(395, 262);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSaida
            // 
            this.txtSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaida.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(110)))), ((int)(((byte)(40)))));
            this.txtSaida.Location = new System.Drawing.Point(40, 310);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSaida.Size = new System.Drawing.Size(580, 80);
            this.txtSaida.TabIndex = 8;
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblExplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblExplicacao.Location = new System.Drawing.Point(40, 410);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(0, 15);
            this.lblExplicacao.TabIndex = 9;
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
            this.btnAbrirManual.Location = new System.Drawing.Point(245, 406);
            this.btnAbrirManual.Name = "btnAbrirManual";
            this.btnAbrirManual.Size = new System.Drawing.Size(170, 23);
            this.btnAbrirManual.TabIndex = 10;
            this.btnAbrirManual.Text = "← Voltar ao AES";
            this.btnAbrirManual.UseVisualStyleBackColor = false;
            this.btnAbrirManual.Click += new System.EventHandler(this.btnAbrirManual_Click);
            // 
            // FormCriptografiaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(660, 460);
            this.Controls.Add(this.btnAbrirManual);
            this.Controls.Add(this.lblExplicacao);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(676, 499);
            this.Name = "FormCriptografiaManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criptografia Manual — TrigShift v3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // ── Declaração dos campos privados ──────────────────────────────────────────
        // Estes campos são as "variáveis" que armazenam cada controle.
        // São declarados aqui para que o arquivo .cs principal possa acessá-los
        // (por exemplo: txtEntrada.Text, txtChave.Text, txtSaida.Text)
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
        private System.Windows.Forms.Button btnAbrirManual;
    }
}