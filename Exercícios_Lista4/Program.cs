namespace Exercícios_Lista4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos 
            //e então mostre na tela a quantidade de números pares e ímpares.

            /*int i;
            int par = 0, impar = 0;
            int[] vetor = new int[10];
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor" + i);
                vetor[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    //Console.WriteLine("O elementos pares é " + i)

                    par++;
                }
                else
                {
                    impar++;
                }

            }
            Console.WriteLine("A quantidade de números pares é: " + par);
            Console.WriteLine("A quantidade de números impares é: " + impar);*/

            //2 - Escreva um algoritmo que leia valores para dois vetores de 20 elementos e 
            //então realize a soma dos elementos da mesma posição, armazenando o resultado
            //em um outro vetor.

            /*int[] vetorA = new int[20];
            int[] vetorB = new int[20];
            int[] vetorAB = new int[20];
            int i;

            Console.WriteLine("------Leitura dos elementos de A------");
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o valor" + i);
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("------Leitura dos elemnetos de B------");
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o valor" + i);
                vetorB[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 20; i++)
            {

                vetorAB[i] = vetorA[i] + vetorB[i];
                Console.WriteLine(" Os elementos do vetor AB são: " + vetorAB[i]);

            }*/


            // 3.Escreva um índice o que leia os valores para um vetor de 20 elementos e 
            //mostre na tela da posição dos valores correspondentes aos números primos.

            /* int tamanho = 5;
            int[] vetor = new int[tamanho];
            int i;

            Console.WriteLine("-------Leituras do elementos do vetor------");

            for (i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um Valor para a posição " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < tamanho; i++)
            {
                int count = 0;
                for (int x = 1; x <= vetor[i]; x++)
                {

                    if (vetor[i] % x == 0)
                    {

                        count++;
                    }

                }
                {
                    if (count == 2)
                    {
                        Console.WriteLine("O valor da " + "posição " + i + ":" + vetor[i] + " è um " +
                            "número primo");
                    }

                }

            }*/

            //4.Escreva um vetor de valores que leia dois e faça o mesmo 
            //a multiplicação dos elementos.Mostre o vetor resultante.

            /* int[] vetor1 = new int[2];
             int[] vetor2 = new int[2];
             int i;

             int[] resultado = new int[2];

             for (i = 0; i < vetor1.Length; i++)
             {
                 Console.WriteLine("Digite o valor ");
                 vetor1[i] = int.Parse(Console.ReadLine());
             }
             for (i = 0; i < vetor2.Length; i++)
             {
                 Console.WriteLine("Digite o valor ");
                 vetor2[i] = int.Parse(Console.ReadLine());
             }

             for (i = 0; i < resultado.Length; i++)
             {

                 resultado[i] = vetor1[i] * vetor2[i];
                 Console.WriteLine("O vetor resultante é: " + resultado[i]);
             }*/


            /* 5.Escreva um mundo que leia um vetor de 80 elementos inteiros. 
              Encontre e mostre o menor elemento e sua posição. */

            /* int tamanho = 80;
             int[] vetor = new int[tamanho];
             int i;
             int menorElemento;

             Console.WriteLine("-------Leituras do elementos do vetor------");

             for (i = 0; i < tamanho; i++)
             {
                 Console.WriteLine("Digite um Valor para a posição " + i + " do vetor:");
                 vetor[i] = int.Parse(Console.ReadLine());

             }
             menorElemento = vetor[0];
             for (i = 1; i < tamanho; i++)
             {
                 if (vetor[i] <= menorElemento)
                 {
                     menorElemento = vetor[i];
                 }
             }
             for (i = 0; i < tamanho; i++)
             {
                 if (vetor[i] == menorElemento)
                 {
                     Console.WriteLine("O valor da posição " + i + ":" + menorElemento + " é o menor número");
                 }
             }*/


            //Resolução da questão 5 conforme exemplo de aula:


            /*int[] vetor = new int[5];
            int i, menor = 1000000, posicao = 0;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o valor " + i + " :");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i;
                }
            }

            Console.WriteLine("O valor da posição " + posicao + " : " + menor + " é o menor!");*/

            /* 6.Fazer um estudo de ordem de leitura. Exemplo:
         uma.lê: | 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
         b.escreve: | 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |*/

            /*int[] vetor = new int[10];
            int i;

            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe o Valor da posição " + i + " do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }

            for (i = 9; i >= 0; i--)
            {
                Console.WriteLine("Escreve: " + vetor[i]);
            }*/

            /* 7.Fazer um conjunto de números escolhidos em um vetor e escrever todos os números pares
           após todos os números ímpares.Exemplo:
           uma.lê: | 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
           b.escreve: | 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |*/

            /*int[] vetor = new int[10];
            int i;

            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o número da posição " + i + " : ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine("Par: " + vetor[i]);
                }

            }
            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {

                    Console.WriteLine("Impar: " + vetor[i]);
                }
            }*/

            /* 8.Fazer um vetor de busca que leia números reais em um número e escreva a posição de cada 
             número menor que zero desse vetor.Exemplo:
             uma.lê: | 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
             b.escreve: | 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .*/

            /*float[] vetor = new float[5];
            int i;

            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o número real da posição " + i + ": ");
                vetor[i] = float.Parse(Console.ReadLine());
            }

            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.WriteLine("A posição " + i + " contém um valor menor do que zero!");
                }
            }*/

            /*9.Escreva um vetor que use os valores para um vetor de ordem de 10 elementos e, em seguida, 
            ordene em crescente os valores desse vetor, usando um auxiliar.*/

            /*int[] vetor = new int[] { 7, 40, 3, 9, 21, 0, 63, 31, 7, 22 };
            int menorValor = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j + 1] < vetor[j])
                    {
                        menorValor = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = menorValor;
                    }
                }
            }

            Console.WriteLine("Valores do vetor ordenado em ordem crescente; ");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] + " ");

            }*/

            /* 10.Escreva um algoritmo que leia um vetor inteiro de 20 posições.Crie um segundo vetor, 
                 substituindo os valores nulos por 2.Mostre os vetores lidos e o vetor resultado.*/

            /*int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int i = 0;

            for (i = 0; i < vetor1.Length; i++)
            {

                Console.WriteLine("Digite o valor da posição " + i + " do primeiro vetor; ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == 0 || vetor1[i] == null)
                {
                    vetor2[i] = 2;
                }
                else
                {
                    vetor2[i] = vetor1[i];

                }
            }

            for (i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("\nValor da posição " + i + " do segundo vetor: " + vetor1[i]);
            }


            for (i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("\nValor da posição " + i + "do vetor resultado: " + vetor2[i]);
            }*/

            /*11.Escreva um programa que leia em um vetor de 5 posições.
               Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            int[] vetor = new int[5];
            int i;

            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe o Valor da posição " + i + " do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("\nElementos do vetor: " + vetor[i]);
            }
            
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine("\nValores escritos na ordem inversa: " + vetor[i]);
              
            }*/

            /*12.Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, 
               fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), 
               senão escrever a mensagem "O número fornecido não existe no vetor!".*/

            /*int[] vetorV = new int[5];
            int numero;
            int i;

            for (i = 0; i < vetorV.Length; i++)
            {
                Console.WriteLine("Digite os valores para o vetor V na posisção:  " + i + 1);
                vetorV[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o número que deseja buscar: ");
            numero = int.Parse(Console.ReadLine());
            bool existe = false;

            for (i = 0; i < vetorV.Length; i++)
            {

                if (numero == vetorV[i])
                {

                    Console.WriteLine("O número " + numero + " existe e esta na posição " + (i + 1) + " do vetor!");
                    existe = true;

                }
            }

            if (!existe)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }*/

            /*13.Escreva um algoritm para ler um vetor de inteiros positivos e imprimir quantas vezes 
      aparece os números inteiros 2, 4,8 terá no máximo 100 posições.
      Sair do programa quando  for digitado - 1 ou quando atingir o máximo de posições do vetor.*/

            /*int tamanho = 5;
            int[] vetor = new int[tamanho];
            int num2 = 0, num4 = 0, num8 = 0;
            int i;

            for (i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um número inteiro positivo na posição " + (i) + " do vetor;");
                int numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                {
                    return;
                }
                else if (numero == 2)
                {
                    num2++;
                }
                else if (numero == 4)
                {
                    num4++;
                }
                else if (numero == 8)
                {
                    num8++;
                }

                Console.WriteLine("O numero 2 apareceu " + num2 + " vezes!");
                Console.WriteLine("O numero 4 apareceu " + num4 + " vezes!");
                Console.WriteLine("O numero 8 apareceu " + num8 + " Vezes!\n");

            }*/

            /*14.Escreva um programa que leia um código numérico  e um vetor de 50 posições de números.
              Se o código for zero, termine o programa.Se o código for 1, mostre o vetor 
              na ordem que foi lido.Se o código for 2, mostre o último vetor na ordem inversa, 
              do elemento até o primeiro.*/

            /* int tamanho = 50;
             int[] vetor = new int[tamanho];
             int i = 0;
             int opcao;

             for (i = 0; i < tamanho; i++)
             {
                 Console.WriteLine("Digite o numero da posição " + i + " do vetor.");
                 vetor[i] = int.Parse(Console.ReadLine());

             }

             while (true)
             {

                 Console.WriteLine("Escolha uma das opções a seguir: 0 - Fim," +
                "1- leia o vetor na ordem que foi escrito,2 - Leia o verto na ordem inversa. ");
                 opcao = int.Parse(Console.ReadLine());

                 if (opcao == 0)
                 {
                     return;
                 }
                 else if (opcao == 1)
                 {
                     for (i = 0; i < tamanho; i++)
                     {
                         Console.WriteLine("Vetor na ordem que foi escrito; ");
                         vetor[i] = int.Parse(Console.ReadLine());
                     }

                 }
                 else if (opcao == 2)
                 {
                     for (i = tamanho - 1; i >= 0; i--)
                     {
                         Console.WriteLine("Vetor na ordem intersa" + vetor[i]);
                     }
                 }*\

              /* 15.Faça um programa em C que declare um vetor inteiro de 20 elementos, 
                 leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, 
                 inverta sua ordem.Assim, o valor do primeiro elemento do primeiro vetor
                 deve ser o valor do elemento do segundo vetor, por último exemplo.
                 Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.*/

            /*int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Digite o número da posição " + i + " do vetor1: ");
                vetor1[i] = int.Parse(Console.ReadLine());
                vetor2[19 - i] = vetor1[i];
            }

            Console.Write("Elementos do vetor1: ");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write(", " + vetor1[i]);
            }

            Console.Write("\nElementos do vetor2: ");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write(", " + vetor2[i]);
            }*/

            //16.Escreva um escreva que leia 2 vetores X[10] e Y[10] e os escreva.Crie, 
            //a seguir, um vetor para cada uma das operações:
            //• União de X com Y
            //• A diferença entre X e Y
            //• A interseção entre X e Y

            /*int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] y = new int[10] { 1, 6, 30, 4, 5, 60, 7, 9, 10, 11 };

            int[] uniao = new int[20];
            int[] diferenca = new int[10];
            int[] interseccao = new int[10];

            Console.WriteLine("UNIÃO");

            x.CopyTo(uniao, 0);
            int auxU = 10;

            for (int i = 0; i < y.Length; i++) //elementos de x e elementos de y que não estão em x.
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }
                    if (j == (x.Length - 1))
                    {
                        uniao[auxU] = y[i];
                        auxU++;
                    }
                }

            }
            for (int i = 0; i < auxU; i++)
            {
                Console.WriteLine(uniao[i]);
            }

            Console.WriteLine("DIFERENÇA:");

            int auxD = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }
                    if (j == (y.Length - 1))
                    {
                        diferenca[auxD] = x[i];
                        auxD++;
                    }


                }

            }
            for (int i = 0; i < auxD; i++)
            {
                Console.WriteLine(diferenca[i]);
            }

            Console.WriteLine("Intersecção");

            int auxI = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[i])
                    {
                        interseccao[auxI] = x[i];
                        auxI++;
                        break;
                    }
                }
            }
            for (int i = 0; i < auxI; i++)
            {
                Console.WriteLine(interseccao[i]);
            }*/


        }
    }
}