namespace PrimeiroWinFormsDotNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_SalvarDpto = new System.Windows.Forms.Button();
            this.textBox_NomeDpto = new System.Windows.Forms.TextBox();
            this.textBox_LocalizacaoDpto = new System.Windows.Forms.TextBox();
            this.textBox_OrcamentoDpto = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_Localizacao = new System.Windows.Forms.Label();
            this.label_Orcamento = new System.Windows.Forms.Label();
            this.button_VoltarMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SalvarDpto
            // 
            this.button_SalvarDpto.Location = new System.Drawing.Point(285, 218);
            this.button_SalvarDpto.Name = "button_SalvarDpto";
            this.button_SalvarDpto.Size = new System.Drawing.Size(112, 34);
            this.button_SalvarDpto.TabIndex = 0;
            this.button_SalvarDpto.Text = "Salvar";
            this.button_SalvarDpto.UseVisualStyleBackColor = true;
            this.button_SalvarDpto.Click += new System.EventHandler(this.button_SalvarDpto_Click);
            // 
            // textBox_NomeDpto
            // 
            this.textBox_NomeDpto.Location = new System.Drawing.Point(285, 43);
            this.textBox_NomeDpto.Name = "textBox_NomeDpto";
            this.textBox_NomeDpto.Size = new System.Drawing.Size(150, 31);
            this.textBox_NomeDpto.TabIndex = 1;
            // 
            // textBox_LocalizacaoDpto
            // 
            this.textBox_LocalizacaoDpto.Location = new System.Drawing.Point(285, 104);
            this.textBox_LocalizacaoDpto.Name = "textBox_LocalizacaoDpto";
            this.textBox_LocalizacaoDpto.Size = new System.Drawing.Size(150, 31);
            this.textBox_LocalizacaoDpto.TabIndex = 2;
            // 
            // textBox_OrcamentoDpto
            // 
            this.textBox_OrcamentoDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_OrcamentoDpto.Location = new System.Drawing.Point(285, 160);
            this.textBox_OrcamentoDpto.Name = "textBox_OrcamentoDpto";
            this.textBox_OrcamentoDpto.Size = new System.Drawing.Size(150, 31);
            this.textBox_OrcamentoDpto.TabIndex = 3;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(192, 43);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(65, 25);
            this.label_Nome.TabIndex = 4;
            this.label_Nome.Text = "Nome:";
            // 
            // label_Localizacao
            // 
            this.label_Localizacao.AutoSize = true;
            this.label_Localizacao.Location = new System.Drawing.Point(174, 104);
            this.label_Localizacao.Name = "label_Localizacao";
            this.label_Localizacao.Size = new System.Drawing.Size(105, 25);
            this.label_Localizacao.TabIndex = 5;
            this.label_Localizacao.Text = "Localizacao:";
            // 
            // label_Orcamento
            // 
            this.label_Orcamento.AutoSize = true;
            this.label_Orcamento.Location = new System.Drawing.Point(174, 166);
            this.label_Orcamento.Name = "label_Orcamento";
            this.label_Orcamento.Size = new System.Drawing.Size(105, 25);
            this.label_Orcamento.TabIndex = 6;
            this.label_Orcamento.Text = "Orcamento:";
            // 
            // button_VoltarMenuPrincipal
            // 
            this.button_VoltarMenuPrincipal.Location = new System.Drawing.Point(630, 38);
            this.button_VoltarMenuPrincipal.Name = "button_VoltarMenuPrincipal";
            this.button_VoltarMenuPrincipal.Size = new System.Drawing.Size(112, 34);
            this.button_VoltarMenuPrincipal.TabIndex = 7;
            this.button_VoltarMenuPrincipal.Text = "Voltar";
            this.button_VoltarMenuPrincipal.UseVisualStyleBackColor = true;
            this.button_VoltarMenuPrincipal.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_VoltarMenuPrincipal);
            this.Controls.Add(this.label_Orcamento);
            this.Controls.Add(this.label_Localizacao);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.textBox_OrcamentoDpto);
            this.Controls.Add(this.textBox_LocalizacaoDpto);
            this.Controls.Add(this.textBox_NomeDpto);
            this.Controls.Add(this.button_SalvarDpto);
            this.Name = "Form1";
            this.Text = "Cadastro de Departamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_SalvarDpto;
        private TextBox textBox_NomeDpto;
        private TextBox textBox_LocalizacaoDpto;
        private TextBox textBox_OrcamentoDpto;
        private Label label_Nome;
        private Label label_Localizacao;
        private Label label_Orcamento;
        private Button button_VoltarMenuPrincipal;
    }
}