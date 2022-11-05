using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Academia_.Net_Lista7_Q6
{
    class Agenda
    {
        public List<Pessoa> pessoas = new List<Pessoa>();
        
        public void ArmazenaPessoa(string nome,  int idade, float altura)
        {
            Pessoa p = new Pessoa(nome,idade, altura);
            pessoas.Add(p);
        }
        public Pessoa BuscaPessoa(string nome)
        {
            Pessoa r = null;
            foreach(Pessoa p in pessoas)
            {
                if (p.nome.Equals(nome))
                {
                    r = p;
                }
                
                   
            }
            return r;
        }

        public void ImprimiAgenda()
        {
            //for( int i = 0; i < pessoas.Count;i++)
            //{
            //    Console.WriteLine("Pessoa" + i + ":" + pessoas[i].nome);
            //}

            foreach(Pessoa p in pessoas)
            {
                Console.WriteLine("Nome; "+ p.nome + "Altura: " +p.altura+ "Idade" + p.idade);
            }

        }
        public void RemovePessoa(string nome)
        {
            {
                Pessoa p = BuscaPessoa(nome);
                pessoas.Remove(p);
                Console.WriteLine("Pessoa removida!");
            }
        }



    }

 
}
