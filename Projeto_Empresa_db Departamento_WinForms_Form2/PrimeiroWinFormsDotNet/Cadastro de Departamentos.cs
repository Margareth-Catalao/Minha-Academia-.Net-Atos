using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimeiroWinFormsDotNet
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Menu_Principal menuPrincipal;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Menu_Principal menu )
        {
            menuPrincipal = menu;
            InitializeComponent();
             
        }


        private void button_SalvarDpto_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento(textBox_NomeDpto.Text, textBox_LocalizacaoDpto.Text, textBox_OrcamentoDpto.Text);

            /* bool sucesso = d.gravarDepartamento();
            if (sucesso == true)
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Departamento!", "Erro!");*/

            if (d.gravarDepartamento())
            {
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao salvar Departamento!", "Erro!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Close();
        }
    }
}