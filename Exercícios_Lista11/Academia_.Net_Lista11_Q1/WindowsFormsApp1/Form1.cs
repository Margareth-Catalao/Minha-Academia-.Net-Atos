using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> listaNomes = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            inserirTextBoxListaNomes();
        }

        private void textBoxNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                inserirTextBoxListaNomes();
            }
            
        }
        private void inserirTextBoxListaNomes()
        {
         
            if (textBoxNomeCompleto.Text.Length == 0 )
            {
                MessageBox.Show("Para adicionar um nome é preciso digitar algo!", "ATEÑCÃO");
            }
            else
            {
                textBoxListaNomes.Text += textBoxNomeCompleto.Text.ToUpper() + Environment.NewLine;
                textBoxNomeCompleto.Text = string.Empty;

                //Verificar se o nome jé existe na lista
                if (listaNomes.Contains(textBoxNomeCompleto.Text.ToUpper()))
                {
                    MessageBox.Show("Nome já cadastrado!", "ATENCÃO");
                }
                else
                {
                    listaNomes.Add(textBoxNomeCompleto.Text);
                    listaNomes.Sort();

                    //Inserir conteúdo na lista ordenadamente
                    atualizarTextBoxLista();

                    textBoxNomeCompleto.Text = string.Empty;
                }
            }
            textBoxNomeCompleto.Focus();
        }
        private void atualizarTextBoxLista()
        {
            textBoxListaNomes.Text = string.Empty;
            foreach(var i in listaNomes)
            {
                textBoxListaNomes.Text += i + Environment.NewLine;
            }
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
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNomeCompleto.Clear();
        }
    }
}
