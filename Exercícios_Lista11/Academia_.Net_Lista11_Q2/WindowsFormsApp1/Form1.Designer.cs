namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.textBoxListaNomes = new System.Windows.Forms.TextBox();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.labelCabecalho = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.textBoxListaDominios = new System.Windows.Forms.TextBox();
            this.buttonListar = new System.Windows.Forms.Button();
            this.labelListaNomes = new System.Windows.Forms.Label();
            this.textBoxListaEmail = new System.Windows.Forms.TextBox();
            this.labelListaEmails = new System.Windows.Forms.Label();
            this.labelCadEmails = new System.Windows.Forms.Label();
            this.buttonLimpar2 = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompleto.Location = new System.Drawing.Point(14, 70);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(146, 20);
            this.labelNomeCompleto.TabIndex = 0;
            this.labelNomeCompleto.Text = "Nome Completo: ";
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(164, 70);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(407, 26);
            this.textBoxNomeCompleto.TabIndex = 1;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.DimGray;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(18, 163);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(90, 44);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "Cadastrar";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // textBoxListaNomes
            // 
            this.textBoxListaNomes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxListaNomes.Location = new System.Drawing.Point(67, 226);
            this.textBoxListaNomes.Multiline = true;
            this.textBoxListaNomes.Name = "textBoxListaNomes";
            this.textBoxListaNomes.Size = new System.Drawing.Size(358, 363);
            this.textBoxListaNomes.TabIndex = 3;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCabecalho.BackColor = System.Drawing.Color.DimGray;
            this.panelCabecalho.Controls.Add(this.labelCabecalho);
            this.panelCabecalho.Controls.Add(this.buttonSair);
            this.panelCabecalho.Location = new System.Drawing.Point(0, -2);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1315, 66);
            this.panelCabecalho.TabIndex = 4;
            // 
            // labelCabecalho
            // 
            this.labelCabecalho.AutoSize = true;
            this.labelCabecalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCabecalho.Location = new System.Drawing.Point(27, 24);
            this.labelCabecalho.Name = "labelCabecalho";
            this.labelCabecalho.Size = new System.Drawing.Size(200, 25);
            this.labelCabecalho.TabIndex = 1;
            this.labelCabecalho.Text = "Cadastro de Emails";
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(1213, 14);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(85, 39);
            this.buttonSair.TabIndex = 0;
            this.buttonSair.Text = "Fechar";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(93, 119);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 20);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email: ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(164, 116);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(407, 26);
            this.textBoxEmail.TabIndex = 6;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.BackColor = System.Drawing.Color.DimGray;
            this.buttonLimparCampos.FlatAppearance.BorderSize = 0;
            this.buttonLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimparCampos.ForeColor = System.Drawing.Color.White;
            this.buttonLimparCampos.Location = new System.Drawing.Point(1213, 79);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(85, 42);
            this.buttonLimparCampos.TabIndex = 7;
            this.buttonLimparCampos.Text = "Limpar";
            this.buttonLimparCampos.UseVisualStyleBackColor = false;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // textBoxListaDominios
            // 
            this.textBoxListaDominios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxListaDominios.Location = new System.Drawing.Point(906, 226);
            this.textBoxListaDominios.Multiline = true;
            this.textBoxListaDominios.Name = "textBoxListaDominios";
            this.textBoxListaDominios.Size = new System.Drawing.Size(358, 363);
            this.textBoxListaDominios.TabIndex = 9;
            // 
            // buttonListar
            // 
            this.buttonListar.BackColor = System.Drawing.Color.DimGray;
            this.buttonListar.FlatAppearance.BorderSize = 0;
            this.buttonListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListar.Location = new System.Drawing.Point(906, 177);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(90, 43);
            this.buttonListar.TabIndex = 10;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = false;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // labelListaNomes
            // 
            this.labelListaNomes.AutoSize = true;
            this.labelListaNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaNomes.Location = new System.Drawing.Point(160, 188);
            this.labelListaNomes.Name = "labelListaNomes";
            this.labelListaNomes.Size = new System.Drawing.Size(176, 20);
            this.labelListaNomes.TabIndex = 11;
            this.labelListaNomes.Text = " Nomes Cadastrados";
            // 
            // textBoxListaEmail
            // 
            this.textBoxListaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxListaEmail.Location = new System.Drawing.Point(488, 226);
            this.textBoxListaEmail.Multiline = true;
            this.textBoxListaEmail.Name = "textBoxListaEmail";
            this.textBoxListaEmail.Size = new System.Drawing.Size(358, 363);
            this.textBoxListaEmail.TabIndex = 8;
            // 
            // labelListaEmails
            // 
            this.labelListaEmails.AutoSize = true;
            this.labelListaEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaEmails.Location = new System.Drawing.Point(1023, 188);
            this.labelListaEmails.Name = "labelListaEmails";
            this.labelListaEmails.Size = new System.Drawing.Size(149, 20);
            this.labelListaEmails.TabIndex = 13;
            this.labelListaEmails.Text = "Lista de domínios";
            // 
            // labelCadEmails
            // 
            this.labelCadEmails.AutoSize = true;
            this.labelCadEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadEmails.Location = new System.Drawing.Point(552, 187);
            this.labelCadEmails.Name = "labelCadEmails";
            this.labelCadEmails.Size = new System.Drawing.Size(169, 20);
            this.labelCadEmails.TabIndex = 14;
            this.labelCadEmails.Text = "Emails Cadastrados";
            // 
            // buttonLimpar2
            // 
            this.buttonLimpar2.BackColor = System.Drawing.Color.DimGray;
            this.buttonLimpar2.FlatAppearance.BorderSize = 0;
            this.buttonLimpar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar2.Location = new System.Drawing.Point(594, 82);
            this.buttonLimpar2.Name = "buttonLimpar2";
            this.buttonLimpar2.Size = new System.Drawing.Size(90, 37);
            this.buttonLimpar2.TabIndex = 15;
            this.buttonLimpar2.Text = "Limpar";
            this.buttonLimpar2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1315, 627);
            this.Controls.Add(this.buttonLimpar2);
            this.Controls.Add(this.labelCadEmails);
            this.Controls.Add(this.labelListaEmails);
            this.Controls.Add(this.labelListaNomes);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxListaDominios);
            this.Controls.Add(this.textBoxListaEmail);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.textBoxListaNomes);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxNomeCompleto);
            this.Controls.Add(this.labelNomeCompleto);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário 1";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.TextBox textBoxListaNomes;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelCabecalho;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonLimparCampos;
        private System.Windows.Forms.TextBox textBoxListaDominios;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Label labelListaNomes;
        private System.Windows.Forms.TextBox textBoxListaEmail;
        private System.Windows.Forms.Label labelListaEmails;
        private System.Windows.Forms.Label labelCadEmails;
        private System.Windows.Forms.Button buttonLimpar2;
    }
}

