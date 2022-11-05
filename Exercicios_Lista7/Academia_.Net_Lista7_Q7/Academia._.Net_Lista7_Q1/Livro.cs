using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia._.Net_Lista7_Q1
{
    internal class Livro
    {
        public string titulo;
        public string autor;
        public string editora;
        public int anoPublicacao;
        public bool emEstoque;

        public void existir()
        {
            emEstoque = true;
            Console.WriteLine("Exite o livro em estoque!");
        }
        public void naoExistir()
        {
             emEstoque = false;
            Console.WriteLine("Não existe o livro em estoque!");
        }
        public bool estaEmEstoque()
        {
            return emEstoque;
        }



 

    }
}
