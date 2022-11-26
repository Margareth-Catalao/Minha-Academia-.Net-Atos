using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Security.Permissions;

namespace Academia_.Net_Lista9_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* 3.Fazer um programa em VS para gerenciar figurinhas da copa.O programa deve 
              possuir um Menu.

            Menu
            1 - Cadastrar figurinha repetida
            2 - Cadastrar figurinha faltante
            3 - Listar figurinhas repetidas
            4 - Listar figurinhas faltantes
            5 - Sair
            Opção:

            Para este programa, usar a classe Figurinha(codigo_figurinha, selecao, nome_jogador),
            lista que armazena as figurinhas em memória, arquivo .csv com os dados das figurinhas 
            persistidos em disco.

            Para as figurinhas repetidas, deve haver uma lista e um arquivo.csv; 
            o mesmo para as figurinhas faltantes.Toda vez que as opções 3 ou 4 foram 
            selecionadas, além da listagem na tela, gerar um arquivo de saída com os 
            mesmos dados da tela. Esse arquivo é o utilizado para mandar aos amigos.
            nos arquivos .csv.Por exemplo, arquivo de figurinhas repetidas, repetidas.csv

            codigo figurinha; seleçao; nome do jogador
            codigo figurinha; seleçao; nome do jogador
            codigo figurinha; seleçao; nome do jogador
            codigo figurinha; seleçao; nome do jogador
            codigo figurinha; seleçao; nome do jogador*/

            List<Figurinhas> listaRepetidas = new List<Figurinhas>();
            List<Figurinhas> listaFaltantes = new List<Figurinhas>();

            void cadastrarFigurinhaRepetida()
            {
                string codigo;
                string selecao;
                string jogador;
                Figurinhas figurinha;

                Console.WriteLine("Cadastrando figurinha repetida!");

                Console.WriteLine("Codigo da figurinha: ");
                codigo = Console.ReadLine().ToUpper();

                Console.WriteLine("Selecao da figurinha: ");
                selecao = Console.ReadLine().ToUpper();

                Console.WriteLine("Npme do Jogador: ");
                jogador = Console.ReadLine().ToUpper();

                figurinha = new Figurinhas(codigo, selecao, jogador);

                if (Util.jaNaListaDeFigurinhas(figurinha, listaRepetidas))
                {
                    Console.WriteLine("Figurinha já cadastrada!");
                }
                else
                {
                    listaRepetidas.Add(figurinha);
                    Util.gravarFigurinhaArquivo(figurinha, @"D:\Academia_.Net_Atos_2022\repetidas.csv");
                }

                Util.popularArquivoNaListaFigurinha(listaRepetidas, @"D:\Academia_.Net_Atos_2022\repetidas.csv");
                Util.popularArquivoNaListaFigurinha(listaFaltantes, @"D:\Academia_.Net_Atos_2022\faltantes.csv");

                string opcao;

                do
                {
                    Console.WriteLine("1 -  Cadastrar figurinha repetida");
                    Console.WriteLine("2 -  Cadastrar figurinha faltante");
                    Console.WriteLine("3 -  listar figurinha repetida");
                    Console.WriteLine("4 -  listar figurinha faltante");
                    Console.WriteLine("5 -  Sair");
                    Console.WriteLine("Opcão");
                    opcao = Console.ReadLine();

                    switch(opcao)
                    {
                            case "1":

                            cadastrarFigurinhaRepetida();
                            break;

                            case "2":
                            break;

                            case "3":
                            Util.mostrarListaFigurinhas(listaRepetidas, "minhasRepetidas.txt", "Repetidas");
                            break;

                            case "4":
                            break;

                            case "5":
                            break;
                        default:

                            Console.WriteLine("Opcão inaválida!");
                            break;

                    }    

                } while (opcao != "5");
                        





            }

        }
    }
}