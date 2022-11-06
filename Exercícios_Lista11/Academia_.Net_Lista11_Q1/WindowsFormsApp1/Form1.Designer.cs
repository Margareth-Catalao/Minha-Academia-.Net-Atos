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
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.labelNomeCompleto.Location = new System.Drawing.Point(28, 23);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(143, 20);
            this.labelNomeCompleto.TabIndex = 0;
            this.labelNomeCompleto.Text = "Nome completo: ";
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(167, 20);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(525, 26);
            this.textBoxNomeCompleto.TabIndex = 1;
            this.textBoxNomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomeCompleto_KeyPress);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.Black;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.ForeColor = System.Drawing.Color.White;
            this.buttonInserir.Location = new System.Drawing.Point(110, 79);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 41);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // textBoxListaNomes
            // 
            this.textBoxListaNomes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxListaNomes.Location = new System.Drawing.Point(110, 126);
            this.textBoxListaNomes.Multiline = true;
            this.textBoxListaNomes.Name = "textBoxListaNomes";
            this.textBoxListaNomes.Size = new System.Drawing.Size(368, 387);
            this.textBoxListaNomes.TabIndex = 3;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(628, 494);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 40);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Fechar";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(617, 52);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 41);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(733, 546);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.textBoxListaNomes);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxNomeCompleto);
            this.Controls.Add(this.labelNomeCompleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.TextBox textBoxListaNomes;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

