using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Academia_.Net_Lista7_Q7
{
    class Elevador
     {
        private int andar;
        private int totalAndares;
        private int capacidade;
        private int lotacao;

        public int Andar { get => andar; set => andar = value; }
        public int TotalAndares { get => totalAndares; set => totalAndares = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        public int Lotacao { get => lotacao; set => lotacao = value; }


        public void Inicializa(int capacidade, int totalAndares)
         {
             Andar = 0;
             TotalAndares = totalAndares;
             Capacidade = capacidade;
             Lotacao = 0;    

         }
         public void Entra()
         {
             if (Lotacao < Capacidade)
             {
                 Console.WriteLine("Entraram no elevador.");
                 Lotacao++;
             }
             else
             {
                 Console.WriteLine("Elevador lotado!");
             }

         }
         public void Sai()
         {
             if(Lotacao > 0)
             {
                 Console.WriteLine("Sairam do elevador.");
                 Lotacao--;
             }
             else
             {
                 Console.WriteLine("Elevador vazio!");
             }

         }
         public void Sobe()
         {
             if(Andar < TotalAndares)
             {
                 Console.WriteLine("Elevador subindo!");
                 Andar++;
             }
             else
             {
                 Console.WriteLine("Elevador no último andar!");
             }
         }
         public void Desce()
         {
             if (Andar > 0)
             {
                 Console.WriteLine("Elevador descendo!");
                 Andar--;
             }
             else
             {
                 Console.WriteLine("Elevador no térreo!");
             }
         }

        /*private int andar;
        private int totalAndares;
        private int capacidade;
        private int lotacao;

        public int Andar { get => andar; set => andar = value; }
        public int TotalAndares { get => totalAndares; set => totalAndares = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        public int Lotacao { get => lotacao; set => lotacao = value; }

        public void Inicializa(int capacidade, int totalAndares)
        {
            Andar = 0;
            TotalAndares = totalAndares;
            Capacidade = capacidade;
            Lotacao = 0;
        }

        public void Entra()
        {
            if (Lotacao < Capacidade)
            {
                Lotacao++;
                Console.WriteLine("Alguém entrou no elevador");
            }
            else
                Console.WriteLine("Lotado");
        }

        public void Sai()
        {
            if (Lotacao > 0)
            {
                Lotacao--;
                Console.WriteLine("Alguém saiu do elevador");
            }
            else
                Console.WriteLine("Elevador já está vazio!");
        }

        public void Sobe()
        {
            if (Andar < TotalAndares)
            {
                Andar++;
                Console.WriteLine("Subiu um andar");
            }
            else
            {
                Console.WriteLine("Já está na cobertura");
            }
        }

        public void Desce()
        {
            if (Andar > 0)
            {
                Andar--;
                Console.WriteLine("Desceu um andar");
            }
            else
            {
                Console.WriteLine("Já está no térreo");
            }
        }*/


    }

}
