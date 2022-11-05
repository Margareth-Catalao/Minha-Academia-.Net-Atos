namespace Exercícios_Lista6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
               Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e
               que não esteja na lista.Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e
               exibir a lista ordenada. */

            /*string nomeCompleto;
            List<string> nomesPessoas = new List<string>();
            int continuar = 0;
            string[] dadosNome;

            do
            {
                do
                {
                    Console.WriteLine("Digite o seu nome completo: ");
                    nomeCompleto = Console.ReadLine().ToUpper();
                    dadosNome = nomeCompleto.Split(" ");
                    Console.Write(dadosNome[0]);

                } while (dadosNome.Length <= 1);

                if (nomesPessoas.Contains(nomeCompleto))
                {
                    Console.WriteLine("Nome já Cadastrado");
                }
                else
                {
                    nomesPessoas.Add(nomeCompleto);
                }
                Console.Write(" 1 - para continuar: 2 - para sair: ");
                continuar = int.Parse(Console.ReadLine());

            } while (continuar == 1);

            nomesPessoas.Sort();
            Console.WriteLine("Pessoas Cadastradas");
            foreach (var item in nomesPessoas)
            {
                Console.WriteLine(item);
            }*/

            //2.Fazer um programa em VS que popule uma lista com números inteiros(0 a 1000) que sejam sorteados
            //randomicamente.O programa deve pedir ao usuário quantos números deseja armazenar. Ao final, o programa
            //deve exibir os números populados na lista.

            /* List<int> listNum = new List<int>();
             int qntNum;
             Random gerador = new Random();

             Console.WriteLine("Quantos números inteiro deseja armazenar: ");
             qntNum = int.Parse(Console.ReadLine());

             for (int i = 0; i < qntNum; i++)
             {
                 listNum.Add(gerador.Next(0, 1000));
             }

             Console.Clear();

             foreach (int numInteiro in listNum)
             {
                 Console.WriteLine(numInteiro);
             }*/

            /*3.Fazer um programa em VS, usar o menu, cadastrar emails, listar emails e 
            *sair do programa.Os emails digitados devem ser cadastrados em uma lista e 
            *não devem ter emails duplicados, ou seja o programa deve controlar essa 
            *situação. Quando o usuário solicitar uma listagem dos emails, além dessa
            O programa deve listar os domínios de e - mails cadastrados no programa.

           Cardápio
           1 - Cadastro de e-mail
           2 - Listar
           3 - Sair
           Opção:*/

            /* List<string> emails = new List<string>();
             List<string> dominios = new List<string>();
             string email;
             int menu;

             while (true)
             {
                 Console.WriteLine("______Menu______");
                 Console.WriteLine("Digite a opcão desejada\n1 - Cadastro de e-mail\n2 - Listar\n3 - Sair");
                 menu = int.Parse(Console.ReadLine());

                 switch (menu)
                 {
                     case 1:
                         Console.WriteLine("Digite o endereco de email: ");
                         email = Console.ReadLine();
                         if (emails.Contains(email))
                         {
                             Console.WriteLine("Endereco de email já cadastrado!");
                         }
                         else
                         {
                             emails.Add(email);
                         }
                         break;

                     case 2:
                         Console.WriteLine("Listar emails cadatrados");
                         foreach (string i in emails)
                         {
                             string[] dom = i.Split("@");
                             if (!emails.Contains(dom[1]))
                             {
                                 dominios.Add(dom[1]);

                             }
                             Console.WriteLine(i);
                         }
                         Console.WriteLine("Listar domínios");
                         foreach (string j in dominios)
                         {
                             Console.WriteLine(j);
                         }
                         break;

                     case 3:
                         return;
                         break;
                     default:
                         break;

                 }
             }*/

            /* 4.Faça um programa em VS que realize um CRUD(inserir, pesquisar, atualizar e
         deletar) completo em uma lista de nomes de criptomoedas. Neste programa, 
         somente o nome da criptomoeda deve ser cadastrado(em maiúsculo).Ao cadastrar, 
         não pode haver duplicidade de dados na lista. Sempre que a opção do listar para 
         uma listagem deve ser exibida de forma ordenada.Nenhum processo de remover, o 
         usuário entra com o nome da criptomoeda que deseja removedor. Caso o programa 
         encontrado,deve removedor e avisar o usuário que a operação ocorreu corretamente, 
         e caso não encontrou, avisarao usuário que nome não foi encontrado.

           Cardápio
           1 - Cadastrar criptomoeda
           2 - Listar criptomoedas
           3 - Removedor de criptomoeda
           4 - Sair
           Opção:*/

            /* List<string> listaNomeCM = new List<string>();
              int menu;

              while (true)
              {
                  Console.WriteLine("______Menu de Criptomoedas______");
                  Console.WriteLine("Digite a opcão desejada:\n1 - Cadastrar criptomoeda\n" +
                      "2 - Listar criptomoedas\n3 - Removedor de criptomoeda\n4 - Sair");
                  menu = int.Parse(Console.ReadLine());

                  switch (menu)
                  {
                      case 1:
                          Console.WriteLine("Digite o nome da Criptomoeda:");
                          string nome = Console.ReadLine().ToUpper();
                          if (listaNomeCM.Contains(nome))
                          {
                              Console.WriteLine("Nome de Criptomoeda já cadastrado!");
                          }
                          else
                          {
                              listaNomeCM.Add(nome);
                          }
                          break;

                      case 2:
                          listaNomeCM.Sort();
                          Console.WriteLine("Listar criptomoedas cadstradas;");
                          foreach (string i in listaNomeCM)
                          {
                              Console.WriteLine(" " + i);
                          }

                          break;

                      case 3:
                          Console.WriteLine("Digite o nome da Criptomoeda a ser removida: ");
                          nome = Console.ReadLine().ToUpper();
                          if (listaNomeCM.Contains(nome))
                          {
                              listaNomeCM.Remove(nome);
                              Console.WriteLine("Criptomoeda a ser removida!");
                          }
                          else
                          {
                              Console.WriteLine("Esta Criptomoeda não existe no cadastro!");
                          }

                          break;

                      case 4:
                          return;
                          break;
                      default:
                          break;
                  }

              }*/

            /*5.Crie um programa em VS que popule duas listas(lista1 e lista2) com números 
            aleatórios(100 a 200).A quantidade de números deve ser informada pelo usuário.
            Em seguida, o programa deve listar os números das listas 1 e 2  e exibir os dois números que 
            aparecem em ambas as listas.*/

            /* Random random = new Random();
             List<int> lista1 = new List<int>();
             List<int> lista2 = new List<int>();
             int quantidadeNum;

             Console.WriteLine("Informe quantos números serão cadastrado:");
             quantidadeNum = int.Parse(Console.ReadLine());

             for (int i = 0; i < quantidadeNum; i++)
             {
                 lista1.Add(random.Next(100, 200));
                 lista2.Add(random.Next(100, 200));
             }

             foreach (int i in lista1)
             {
                 Console.WriteLine("Lista 1:\n" + i);
             }
             foreach (int i in lista2)
             {
                 Console.WriteLine("Lista 2:\n" + i);
             }
             Console.WriteLine("Numeros iguais existentes em ambas as listas:");
             for (int i = 0; i < lista1.Count; i++)
             {
                 for (int j = 0; j < lista2.Count; j++)
                 {
                     if (lista1[i] == lista2[j])
                     {

                         Console.WriteLine(lista1[i]);

                     }

                 }
             }*/

            /*6.Continuação do exercício 1.Entretanto, quando listar os nomes, mostrar apenas os 
           sobrenomes.Além disso, o programa deve mostrar as pessoas que são da mesma família.*/

           /* List<string> nomes = new List<string>();
            string nome = "";

            do
            {
                Console.WriteLine("Digite um nome completo para adicionar a lista ou -1 para finalizar o cadastro dos nomes:");
                nome = Console.ReadLine();
                string[] validaNome = nome.Split(" ");
                if (nome.Equals("-1"))
                {
                    break;
                }
                if (validaNome.Length < 2)
                {
                    Console.WriteLine("Npme inválido!Digite novamente!");
                }
                else if (nomes.Contains(nome.ToUpper()))
                {
                    Console.WriteLine("Nome já cadastrado!");
                }
                else
                {
                    nomes.Add(nome.ToUpper());
                }

            } while (nomes.Count > 0);

            List<string> sobrenomes = new List<string>();
            List<string> familiares = new List<string>();

            foreach (string n in nomes)
            {
                string[] sobre = n.Split(" ");
                if (!sobrenomes.Contains(sobre.Last()))
                {
                    sobrenomes.Add(sobre.Last());
                }
            }

            Console.WriteLine("Sobrenomes:");
            foreach (string s in sobrenomes)
            {
                Console.WriteLine(s);
                foreach (string n in nomes)
                {
                    string[] nome2 = n.Split(" ");

                    if (nome2.Last().Equals(s) && !familiares.Contains(n))
                    {
                        familiares.Add(n);
                    }
                }
            }
            Console.WriteLine("Familiares: ");
            foreach (string f in familiares)
            {
                Console.WriteLine(f);
            }*/

        }
    }
}