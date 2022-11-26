namespace PrimeiroWinFormsDotNet
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_NomeColaborador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_DataAdmissao = new System.Windows.Forms.Label();
            this.label_Salario = new System.Windows.Forms.Label();
            this.label_Comissao = new System.Windows.Forms.Label();
            this.textBox_NomeColaborador = new System.Windows.Forms.TextBox();
            this.comboBox_funcao = new System.Windows.Forms.ComboBox();
            this.textBox_idDepartamento = new System.Windows.Forms.TextBox();
            this.textBox_dataAdmissao = new System.Windows.Forms.TextBox();
            this.textBox_salario = new System.Windows.Forms.TextBox();
            this.textBox_comissao = new System.Windows.Forms.TextBox();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.label_Gerente = new System.Windows.Forms.Label();
            this.textBox_idGerente = new System.Windows.Forms.TextBox();
            this.button_VoltarMenuPrincipal2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_NomeColaborador
            // 
            this.label_NomeColaborador.AutoSize = true;
            this.label_NomeColaborador.Location = new System.Drawing.Point(56, 30);
            this.label_NomeColaborador.Name = "label_NomeColaborador";
            this.label_NomeColaborador.Size = new System.Drawing.Size(197, 25);
            this.label_NomeColaborador.TabIndex = 0;
            this.label_NomeColaborador.Text = "Nome do Colaborador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Função:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departamento:";
            // 
            // label_DataAdmissao
            // 
            this.label_DataAdmissao.AutoSize = true;
            this.label_DataAdmissao.Location = new System.Drawing.Point(82, 222);
            this.label_DataAdmissao.Name = "label_DataAdmissao";
            this.label_DataAdmissao.Size = new System.Drawing.Size(162, 25);
            this.label_DataAdmissao.TabIndex = 3;
            this.label_DataAdmissao.Text = "Data de Admissão:";
            // 
            // label_Salario
            // 
            this.label_Salario.AutoSize = true;
            this.label_Salario.Location = new System.Drawing.Point(167, 274);
            this.label_Salario.Name = "label_Salario";
            this.label_Salario.Size = new System.Drawing.Size(69, 25);
            this.label_Salario.TabIndex = 4;
            this.label_Salario.Text = "Salário:";
            // 
            // label_Comissao
            // 
            this.label_Comissao.AutoSize = true;
            this.label_Comissao.Location = new System.Drawing.Point(146, 325);
            this.label_Comissao.Name = "label_Comissao";
            this.label_Comissao.Size = new System.Drawing.Size(94, 25);
            this.label_Comissao.TabIndex = 5;
            this.label_Comissao.Text = "Comissão:";
            // 
            // textBox_NomeColaborador
            // 
            this.textBox_NomeColaborador.Location = new System.Drawing.Point(253, 34);
            this.textBox_NomeColaborador.Name = "textBox_NomeColaborador";
            this.textBox_NomeColaborador.Size = new System.Drawing.Size(375, 31);
            this.textBox_NomeColaborador.TabIndex = 7;
            // 
            // comboBox_funcao
            // 
            this.comboBox_funcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_funcao.FormattingEnabled = true;
            this.comboBox_funcao.Items.AddRange(new object[] {
            "Gerente",
            "Funcionário"});
            this.comboBox_funcao.Location = new System.Drawing.Point(255, 121);
            this.comboBox_funcao.Name = "comboBox_funcao";
            this.comboBox_funcao.Size = new System.Drawing.Size(182, 33);
            this.comboBox_funcao.TabIndex = 8;
            this.comboBox_funcao.Text = " ";
            // 
            // textBox_idDepartamento
            // 
            this.textBox_idDepartamento.Location = new System.Drawing.Point(255, 172);
            this.textBox_idDepartamento.Name = "textBox_idDepartamento";
            this.textBox_idDepartamento.Size = new System.Drawing.Size(183, 31);
            this.textBox_idDepartamento.TabIndex = 9;
            // 
            // textBox_dataAdmissao
            // 
            this.textBox_dataAdmissao.Location = new System.Drawing.Point(255, 222);
            this.textBox_dataAdmissao.Name = "textBox_dataAdmissao";
            this.textBox_dataAdmissao.Size = new System.Drawing.Size(183, 31);
            this.textBox_dataAdmissao.TabIndex = 10;
            // 
            // textBox_salario
            // 
            this.textBox_salario.Location = new System.Drawing.Point(256, 271);
            this.textBox_salario.Name = "textBox_salario";
            this.textBox_salario.Size = new System.Drawing.Size(183, 31);
            this.textBox_salario.TabIndex = 11;
            // 
            // textBox_comissao
            // 
            this.textBox_comissao.Location = new System.Drawing.Point(255, 325);
            this.textBox_comissao.Name = "textBox_comissao";
            this.textBox_comissao.Size = new System.Drawing.Size(184, 31);
            this.textBox_comissao.TabIndex = 12;
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Location = new System.Drawing.Point(255, 377);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(112, 34);
            this.button_Cadastrar.TabIndex = 13;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // label_Gerente
            // 
            this.label_Gerente.AutoSize = true;
            this.label_Gerente.Location = new System.Drawing.Point(163, 81);
            this.label_Gerente.Name = "label_Gerente";
            this.label_Gerente.Size = new System.Drawing.Size(77, 25);
            this.label_Gerente.TabIndex = 15;
            this.label_Gerente.Text = "Gerente:";
            // 
            // textBox_idGerente
            // 
            this.textBox_idGerente.Location = new System.Drawing.Point(256, 75);
            this.textBox_idGerente.Name = "textBox_idGerente";
            this.textBox_idGerente.Size = new System.Drawing.Size(183, 31);
            this.textBox_idGerente.TabIndex = 16;
            // 
            // button_VoltarMenuPrincipal2
            // 
            this.button_VoltarMenuPrincipal2.Location = new System.Drawing.Point(628, 163);
            this.button_VoltarMenuPrincipal2.Name = "button_VoltarMenuPrincipal2";
            this.button_VoltarMenuPrincipal2.Size = new System.Drawing.Size(112, 34);
            this.button_VoltarMenuPrincipal2.TabIndex = 17;
            this.button_VoltarMenuPrincipal2.Text = "Voltar";
            this.button_VoltarMenuPrincipal2.UseVisualStyleBackColor = true;
            this.button_VoltarMenuPrincipal2.Click += new System.EventHandler(this.button_VoltarMenuPrincipal2_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_VoltarMenuPrincipal2);
            this.Controls.Add(this.textBox_idGerente);
            this.Controls.Add(this.label_Gerente);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.textBox_comissao);
            this.Controls.Add(this.textBox_salario);
            this.Controls.Add(this.textBox_dataAdmissao);
            this.Controls.Add(this.textBox_idDepartamento);
            this.Controls.Add(this.comboBox_funcao);
            this.Controls.Add(this.textBox_NomeColaborador);
            this.Controls.Add(this.label_Comissao);
            this.Controls.Add(this.label_Salario);
            this.Controls.Add(this.label_DataAdmissao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_NomeColaborador);
            this.Name = "Form";
            this.Text = "Cadastro Empregado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_NomeColaborador;
        private Label label2;
        private Label label3;
        private Label label_DataAdmissao;
        private Label label_Salario;
        private Label label_Comissao;
        private TextBox textBox_NomeColaborador;
        private ComboBox comboBox_funcao;
        private TextBox textBox_idDepartamento;
        private TextBox textBox_dataAdmissao;
        private TextBox textBox_salario;
        private TextBox textBox_comissao;
        private Button button_Cadastrar;
        private Label label_Gerente;
        private TextBox textBox_idGerente;
        private Button button_VoltarMenuPrincipal2;
    }
}