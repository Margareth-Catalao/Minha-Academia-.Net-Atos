using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_.Net_Lista7_Q2
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public float peso;
        public double cpf;
        public double id;
        public string nacionalidade;
        private bool ativo;

        public void estar()
        {
            ativo= true;
            Console.WriteLine("Cliente ativo!");
        }
        public void naoEstar()
        {
            ativo = false;
            Console.WriteLine("Cliente inativo");  
        }
        public bool estaAtivo()
        {
            return ativo;
        }

    }
}
