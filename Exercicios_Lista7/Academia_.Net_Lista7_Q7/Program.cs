using System.Runtime.Intrinsics.X86;
using System;
using System.ComponentModel.Design;

namespace Academia_.Net_Lista7_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7 - Crie uma classe denominada Elevador para armazenar as informações de um 
            elevador dentro de um prédio.A classe deve armazenar o andar atual(térreo = 0), 
            total de andares no prédio(desconsiderando o térreo), capacidade do elevador e 
            quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:

            Inicializa: que deve receber como parâmetros a capacidade do elevador e 
            o total de andares no prédio(os elevadores sempre começam no térreo e vazio);
            Entra: para acrescentar uma pessoa no elevador(só deve acrescentar se ainda houver espaço);
            Sai: para remover uma pessoa do elevador(só deve remover se houver alguém dentro dele);
            Sobe : para subir um andar(não deve subir se já estiver no último andar);
            Desce: para descer um andar(não deve descer se já estiver no térreo);
            Encapsular todos os atributos da classe(criar os métodos set e get).*/

             Elevador elevador = new Elevador();

             while (true)
             {
                 Console.WriteLine("------ELEVADOR------");
                 Console.WriteLine("1 - Inicializa elevador\n2 - Entrar no elevador\n3 - Sair do elevador\n4 - Subir um andar\n5 - Descer um andar"+
                     "\n6 - Sair");
                 int opcao = int.Parse(Console.ReadLine());

                 switch (opcao)
                 {
                     case 1:
                         Console.WriteLine("Qual a lotacao máxima?");
                         int lotacao = int.Parse(Console.ReadLine());
                         Console.WriteLine("Qual o total de andares?");
                         int capacidade = int.Parse(Console.ReadLine());
                         elevador.Inicializa(lotacao, capacidade);
                         break;

                     case 2:
                         elevador.Entra();
                         break;
                     case 3:
                         elevador.Sai();
                         break;
                     case 4:
                         elevador.Sobe();
                         break;
                     case 5:
                         elevador.Desce();
                         break;
                     case 6:
                         return;
                         default:
                         break;

                 }
                 Console.WriteLine("Elevador no andar: " + elevador.Andar + "\n Lotacão: " + elevador.Lotacao + " pessoas");
             }

            /*Elevador elevador = new Elevador();
            while (true)
            {
                Console.WriteLine("1 - Inicializa elevador\n2 - Entrar no elevador\n3 - Sair do elevador\n4 - Subir um andar\n5 - Descer um andar" +
                    "\n6 - Sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Qual a lotação máxima?");
                        int lotacao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o total de andares?");
                        int capacidade = int.Parse(Console.ReadLine());
                        elevador.Inicializa(lotacao, capacidade);
                        break;
                    case 2:
                        elevador.Entra();
                        break;
                    case 3:
                        elevador.Sai();
                        break;
                    case 4:
                        elevador.Sobe();
                        break;
                    case 5:
                        elevador.Desce();
                        break;
                    case 6:
                        return;
                }
                Console.WriteLine("Elevador no andar: " + elevador.Andar + "\nLotação: " + elevador.Lotacao + " pessoas");
            }*/


        }
    }
}