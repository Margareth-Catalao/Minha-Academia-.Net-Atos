using System.Runtime.Intrinsics.X86;

namespace Academia._.Net_Lista7_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Crie uma classe Livro que representa os dados básicos de um livro.
            //Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.

            Livro livro = new Livro();
            livro.titulo = "O Andar do Bebado";
            Console.WriteLine("Título: " + livro.titulo);
            livro.autor = "Leonard Mlodinow";
            Console.WriteLine("Autor: " + livro.autor);
            livro.editora = "Zahar";
            Console.WriteLine("Editora: " + livro.editora);
            livro.anoPublicacao = 2008;
            Console.WriteLine("Ano da publicação; " + livro.anoPublicacao);
            
            bool retorno;
            livro.existir();
            retorno = livro.estaEmEstoque();
            Console.WriteLine("Status do Livro; " + retorno);
            livro.naoExistir();
            retorno = livro.estaEmEstoque();
            Console.WriteLine("Status do Livro: " + retorno);
            
           
            
                
        }
    }
}