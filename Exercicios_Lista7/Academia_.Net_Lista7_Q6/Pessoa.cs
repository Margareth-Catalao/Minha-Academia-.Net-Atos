using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_.Net_Lista7_Q6
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;

        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

      public void MostraDados()
        {
            Console.WriteLine("Nome: " + this.nome + "Idade: " + this.idade + "Altura: " + this.altura);
        }
    }
}
