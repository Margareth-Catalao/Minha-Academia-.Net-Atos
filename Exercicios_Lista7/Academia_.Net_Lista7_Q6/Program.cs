using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Academia_.Net_Lista7_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar
            //as seguintes operações:
            //void armazenaPessoa(String nome, int idade, float altura);
            //void removePessoa(String nome);
            //Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            //void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda.

            //Pessoa p = new Pessoa("João", 20, 175);
            //p.MostraDados();

            int op;
            Agenda a = new Agenda();
            string nome;
            float altura;
            int idade;
            Pessoa consulta = null;

            while (true)
            {
                Console.WriteLine("------AGENDA-----");
                Console.WriteLine("Digite 1 para cadastrar pessoa; \nDigite 2 para buscar pessoa\n" +
                "Digite 3 para remover pessoa: \nDigite 4 para sair: ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("\nDigite o nome da pessoa: ");
                    nome = Console.ReadLine(); 

                    Console.WriteLine("Digite a idade da pessoa");
                    idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a altura da pessoa");
                    altura = float.Parse(Console.ReadLine());

                    a.ArmazenaPessoa(nome,idade, altura);
                    Console.Clear();

                    //p.MostraDados();

                }
                if(op == 2)
                {
                    Console.WriteLine("\nDigite o nome da pessoa:");
                    nome = Console.ReadLine();
                    consulta = a.BuscaPessoa(nome);
                    if(consulta!= null)
                    {
                        Console.WriteLine("\nPessoa ENCONTRADA! Nome: " + consulta.nome + " Idade: " + consulta.idade + " Altura: " + consulta.altura);


                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada!");
                    }

                }
                if(op == 3)
                {
                    Console.WriteLine("Digite o nome da pessoa a ser removida; \n");
                    nome = Console.ReadLine(); // terminra na classe pessoa
                    a.RemovePessoa(nome);
                    
                }

                if(op == 4)
                {
                    break;
                }
            }

         

        }
    }
}