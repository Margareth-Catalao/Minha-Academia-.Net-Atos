using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWinFormsDotNet
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Menu_Principal menuPrincipal;

        public Form()
        {
            InitializeComponent();
        }
        public Form(Menu_Principal menu)
        {
            menuPrincipal = menu;
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {

            Empregado empregado = new Empregado (textBox_NomeColaborador.Text, textBox_idGerente.Text, comboBox_funcao.Text, textBox_idDepartamento.Text, textBox_dataAdmissao.Text, textBox_salario.Text, textBox_comissao.Text);

            if (empregado.gravarEmpregado())
            {
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao salvar Departamento!", "Erro!");
            }
        }

        private void button_VoltarMenuPrincipal2_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Close();
        }
    }
}
