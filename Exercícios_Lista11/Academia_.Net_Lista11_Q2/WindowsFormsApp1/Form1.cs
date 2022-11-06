using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

          List<Pessoa> listaPessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
         
        }

        //Método que trata evendto de um componente
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if(textBoxNomeCompleto.Text.Length == 0 && textBoxEmail.Text.Length ==0)
            {
                MessageBox.Show("Digite algo nos campos Nome completo e email!", "Alerta");
            }
            else
            {
                
                if (listaPessoas.Exists(pessoa => pessoa.Email == textBoxEmail.Text))
                {
                    MessageBox.Show("Email já existente na lista", "Alerta");
                }
                else
                {
                    Pessoa pessoa = new Pessoa(textBoxNomeCompleto.Text, textBoxEmail.Text);
                    listaPessoas.Add(pessoa);
                    atualizartextBoxListaNomes();
                    atualizartextBoxListaEmail();
                    atualizarListaDominios();
                }
            }

        }
        private void atualizartextBoxListaNomes()
        {
            textBoxListaNomes.Text += String.Empty;

            foreach (var i in listaPessoas)
            {
                textBoxListaNomes.Text += i.Nome + Environment.NewLine;
            }
        }
        private void atualizartextBoxListaEmail()
        {
            textBoxListaEmail.Text += String.Empty;
            foreach (var i in listaPessoas)
            {
                textBoxListaEmail.Text += i.Email + Environment.NewLine;
            }
        }

        private void atualizarListaDominios()
        {
        
            foreach (var i in listaPessoas)
            {
                string[] info = i.Email.Split("@");
                textBoxListaDominios.Text += info[1] + Environment.NewLine;
            }
        }
        
        private void buttonListar_Click(object sender, EventArgs e)
        {
           
            atualizarListaDominios();

        }
        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxListaNomes.Clear();
            textBoxListaEmail.Clear();
            textBoxListaDominios.Clear();
            textBoxNomeCompleto.Clear();
            textBoxEmail.Clear();

        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Deseja mesmo sair do sistema? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Sair.Equals(DialogResult.No))
            {

            }
            else
            {
                Application.Exit();
            }

        }
      
    }

}


