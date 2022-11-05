namespace Exercicios_Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) Crie uma Matriz 5x3.Na primeira coluna, solicite que o usuário preencha.
             A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro 
             dos elementos da 1ª coluna.*/

            /* int[,] matriz = new int[5, 3];

             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 Console.WriteLine("Preencha a primeira coluna da matriz: " + (i + 1));
                 matriz[i, 0] = int.Parse(Console.ReadLine());
             }

             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 matriz[i, 1] = matriz[i, 0] + 10;
                 matriz[i, 2] = matriz[i, 0] * 2;
             }

             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     Console.WriteLine("Mostre a matriz: " + matriz[i, j]);
                 }
                 Console.WriteLine();
             }*/

            /*2) Solicite ao usuário preencher uma Matriz 3x3

            Informe ao usuário:

            A soma dos elementos de cada linha

            -Ex: Linha 1: 30
             Linha 2: 17

            A soma dos elementos de cada coluna
            Ex: Coluna 1: 23
             Coluna 2: 36*/

            /* int[,] matriz = new int[3, 3];

             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {

                     Console.Write("Prencha os elementos a matriz [" + (i + 1) + "," + (j + 1) + "]: ");
                     matriz[i, j] = int.Parse(Console.ReadLine());
                 }
             }
             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {

                     Console.Write("Mostrar matriz; [" + matriz[i, j] + "]: ");


                 }
                 Console.WriteLine();
             }
             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 int somaLinha = 0;
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     somaLinha += matriz[i, j];

                 }
                 Console.WriteLine("Linha " + (i + 1) + ": " + somaLinha + "");
             }
             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 int somaColuna = 0;
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {


                     somaColuna += matriz[j, i];
                 }

                 Console.WriteLine("Coluna " + (i + 1) + ": " + somaColuna);
             }*/

            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            /* int[,] matriz = new int[4, 4];

             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     Console.Write("Popule a matriz [" + (i + 1) + "," + (j + 1) + "]: ");
                     matriz[i, j] = int.Parse(Console.ReadLine());
                 }
             }
             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     Console.Write("[" + matriz[i, j] + "]");

                 }
                 Console.WriteLine();
             }
             for (int i = 0; i < matriz.GetLength(0); i++)
             {

                 Console.WriteLine("Elemneto da Diaginal principal [" + (i + 1) + "," + (i + 1) + "]: " + matriz[i, i]);

             }*/

            /* 4) Preencha uma matriz 5x5 e informe:
            -Quantos números são pares
            - Quantos números são impares
            - Quantos números são positivos
            - Quantos números são negativos
            - Quantos zeros existem!*/

            /* int[,] matriz = new int[5, 5];
             int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;

             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     Console.Write("Preencha a matriz [" + (i + 1) + "," + (j + 1) + "] :");
                     matriz[i, j] = int.Parse(Console.ReadLine());
                 }
             }

              for (int i = 0; i < matriz.GetLength(0); i++)
              {
                  for (int j = 0; j < matriz.GetLength(1); j++)
                  {
                      Console.Write("["+ matriz[i,j] +"]");

                  }
                  Console.WriteLine();
              }
             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     if (matriz[i, j] % 2 == 0 && matriz[i, j] != 0)
                     {
                         pares++;

                     }
                     else
                     {
                         impares++;

                     }
                     if (matriz[i, j] > 0 && matriz[i, j] != 0)
                     {
                         positivos++;

                     }
                     else if (matriz[i, j] < 0 && matriz[i, j] != 0)
                     {
                         negativos++;

                     }
                     else
                     {
                         zeros++;

                     }
                 }

             }
             Console.WriteLine("A quantidade de números pares é: " + pares);
             Console.WriteLine("A quantidade de números positivos é: " + positivos);
             Console.WriteLine("A quantidade de números negativos é: " + negativos);
             Console.WriteLine("A quantidade de números zeros:" + zeros);*/

            /*5) Leia duas matrizes 2x3 de números duplos. 
          Imprima a soma destas duas matrizes.*/

            /* double[,] matriz1 = new double[2, 3];
             double[,] matriz2 = new double[2, 3];
             double[,] matrizResultado = new double[2, 3];

             for (int i = 0; i < matriz1.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz1.GetLength(1); j++)
                 {
                     Console.Write("\nPreencha a matriz 1 [" + (i + 1) + "," + (j + 1) + "] :");
                     matriz1[i, j] = double.Parse(Console.ReadLine());
                 }
             }
             for (int i = 0; i < matriz2.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz2.GetLength(1); j++)
                 {
                     Console.Write("\nPreencha a matriz 2[" + (i + 1) + "," + (j + 1) + "] :");
                     matriz2[i, j] = double.Parse(Console.ReadLine());
                 }
             }

             for (int i = 0; i < matrizResultado.GetLength(0); i++)
             {
                 for (int j = 0; j < matrizResultado.GetLength(1); j++)
                 {


                     matrizResultado[i, j] = matriz1[i, j] + matriz2[i, j];
                     Console.Write("\nMatriz Resultado[" + matrizResultado[i, j] + "]");

                 }
             }*/

            /* 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0 - 9.
          Após isso determine o maior número da matriz.
          Random random = new Random(); int randomNumber = random.Next(0, 100);*/

            /* Random random = new Random();
             int[,] M = new int[4, 4];
             int maiorNumero = 0;

             for (int i = 0; i < M.GetLength(0); i++)
             {
                 for (int j = 0; j < M.GetLength(1); j++)
                 {
                     M[i, j] = random.Next(0, 100);
                 }
             }
             for (int i = 0; i < M.GetLength(0); i++)
             {
                 for (int j = 0; j < M.GetLength(1); j++)
                 {
                     if (maiorNumero < M[i, j])
                     {
                         maiorNumero = M[i, j];
                     }
                 }
             }
             Console.WriteLine("O maior número da matriz M é: " + maiorNumero);*/

            /*7) Leia duas matrizes A e B com 3x3 elementos. 
               Construir uma matriz C, onde cada elemento de C
               é a subtração do elemento correspondente de A com B.

            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C = new int[3, 3];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("\nPreencha a A [" + (i + 1) + "," + (j + 1) + "] :");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("\nPreencha a B [" + (i + 1) + "," + (j + 1) + "] :");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {

                    C[i, j] = A[i, j] - B[i, j];
                    Console.Write("\nMatriz C [" + C[i, j] + "]");

                }
            }*/

            /*8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta 
              e inversa a que foram lidos.*/

            /*int[,] matriz = new int[4, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Preencha a matriz [" + (i + 1) + "," + (j + 1) + "] :");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(" \n[" + matriz[i, j] + "] Matriz");

                }
                Console.WriteLine(); ;
            }
            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write("\n [" + matriz[i, j] + "] Matriz invertida ");

                }
                Console.WriteLine();
            }*/
            /*9) Leia uma matriz 3x3.Em seguida, solicite um número qualquer ao usuário e pesquise
              na matriz se o número existe. Caso, seja verdade imprima a mensagem:  
           “O número existe no vetor” , caso contrário “Número inexistente”.*/

            /* int[,] matriz = new int[3, 3];
            int numero;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Popule a matriz [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (numero == matriz[i, j])
                    {
                        Console.WriteLine("O número existe no vetor!");
                        return;
                    }
                }
            }
            Console.WriteLine("Número inexistente!");*/

            /* 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, 
                 em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.*/

            /*Random random = new Random();
            int[,] A = new int[4, 4];
            int[,] B = new int[4, 4];
            int somaA = 0, somaB = 0;
            int mediaA = 0, mediaB = 0;
            int acimaA = 0, abaixoA = 0, naMediaA = 0;
            int acimaB = 0, abaixoB = 0, naMediaB = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = random.Next(0, 10);
                    Console.Write(" Matriz A [" + (i + 1) + "," + (j + 1) + "] :" + A[i, j]);
                    somaA += A[i, j];
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {

                    B[i, j] = A[i, j] = random.Next(0, 10);
                    Console.Write(" Matriz B [" + (i + 1) + "," + (j + 1) + "] :" + B[i, j]);
                    somaB += B[i, j];
                }
            }
            mediaA = somaA / 16;
            mediaB = somaB / 16;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (mediaA == A[i, j])
                    {
                        naMediaA++;

                    }
                    else if (mediaA > A[i, j])
                    {
                        acimaA++;
                    }
                    else if (mediaA < A[i, j])
                    {
                        abaixoA++;
                    }

                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (mediaB == B[i, j])
                    {
                        naMediaB++;

                    }
                    else if (mediaB > B[i, j])
                    {
                        acimaB++;
                    }
                    else if (mediaA < A[i, j])
                    {
                        abaixoB++;
                    }

                }
            }
            Console.WriteLine("\nMédia da Matriz A: " + mediaA);
            Console.WriteLine("Média da Matriz B: " + mediaB);
            Console.WriteLine("Elementos na média em A:  " + naMediaA);
            Console.WriteLine("Elementos na média em B:  " + naMediaB);
            Console.WriteLine("Elementos acima da média em A:  " + acimaA);
            Console.WriteLine("Elementos acima da média em B:  " + acimaB);
            Console.WriteLine("Elementos abaixo da média em A:  " + abaixoA);
            Console.WriteLine("Elementos abaixo da média em B:  " + abaixoB);*/


            /* 11) Leia uma matriz A de tipo double de dimenção 3x3, 
             crie uma nova matriz resultante da divisão dos elementos 
             da matriz A pela soma dos seus indices.*/

            /* Random random = new Random();
             double[,] A = new double[3, 3];
             double[,] B = new double[3, 3];

             for (int i = 0; i < A.GetLength(0); i++)
             {
                 for (int j = 0; j < A.GetLength(1); j++)
                 {
                     A[i, j] = random.Next(0, 10);
                     Console.Write(" Matriz A [" + (i + 1) + "," + (j + 1) + "] :" + A[i, j]);

                 }
                 Console.WriteLine();
             }
             for (int i = 0; i < A.GetLength(0); i++)
             {
                 for (int j = 0; j < A.GetLength(1); j++)
                 {
                     if ((i + j) == 0 || A[i, j] == 0)
                     {

                         Console.WriteLine("Não existe divisão por zero!O valor [" + i + "," + j + "] não pode ser dividido por zero!");
                         A[i, j] = 0;
                     }
                     else
                     {
                         B[i, j] = A[i, j] / (i + j);
                     }
                 }
                 Console.WriteLine();
             }
             for (int i = 0; i < B.GetLength(0); i++)
             {
                 for (int j = 0; j < B.GetLength(1); j++)
                 {

                     Console.Write(" Matriz B [" + (i + 1) + "," + (j + 1) + "] :" + B[i, j]);

                 }
                 Console.WriteLine();
             }*/

            /* 12) Escreva um programa que leia os valores de uma matriz 4x3, 
             e em seguida mostre na tela apenas os valores cuja soma dos índices(i + j) 
             seja um número par.*/

            /*int[,] matriz = new int[4, 3];
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Preencha a matriz [" + (i + 1) + "," + (j + 1) + "] :");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine("Valor cuja soma dos índices [" + (i + 1) + "," + (j + 1) + "] é um número par: " + matriz[i, j]);
                    }
                }
            }*/

            /*13) Escreva um programa que leia uma matriz de ordem 5(ou seja, seja 5x5),onde 
             a soma dos elementos da diagonal principal é igual aos elementos da
             diagonal secundária.*/

            /*int[,] matriz = new int[5, 5];
            int somaDiagonalP = 0, somaDiagonalS = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Popule a matriz [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0, j = matriz.GetLength(0) - 1; i < matriz.GetLength(0); i++, j--)

            {
                somaDiagonalP += matriz[i, i];
                somaDiagonalS += matriz[i, j];

            }
            if (somaDiagonalP == somaDiagonalS)
            {
                Console.WriteLine("A soma de elementos de ambas diagonais é: " + somaDiagonalP);
            }
            else
            {
                Console.WriteLine("A soma dos elementos da Diagonal Principal É: " + somaDiagonalP + " e a soma dos elementos da Diagonal Secundária é: " + somaDiagonalS);
            }*/

            /*14) Escreva um programa que leia uma matriz de ordem 5 e leia os elementos da diagonal 
           principal(da esquerda para a direita) são os mesmos da diagonal secundaria(direita pra esquerda).*/

            /* int[,] matriz = new int[5, 5];
             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     Console.Write("Popule a matriz [" + (i + 1) + "," + (j + 1) + "]: ");
                     matriz[i, j] = int.Parse(Console.ReadLine());

                 }
             }
             bool DiagonaisIguais = true;
             for (int i = 0, j = matriz.GetLength(0) - 1; i < matriz.GetLength(0); i++, j--)
             {

                 if (matriz[i, i] != matriz[i, j])
                 {
                     DiagonaisIguais = false;
                     break;
                 }

             }
             if (DiagonaisIguais)
             {
                 Console.WriteLine("Os elementos das diagonais são iguais!");
             }
             else
             {
                 Console.WriteLine("Os elemnetos das diagonais são diferentes!");
             }*/

            /* 15) Escreva um programa em C# para 
            ler os valores e somar duas matrizes 4 x 4. 
            Mostrar a matriz resultante.*/

            /* int[,] matriz1 = new int[4, 4];
             int[,] matriz2 = new int[4, 4];
             int[,] matrizResultado = new int[4, 4];

             for (int i = 0; i < matriz1.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz1.GetLength(1); j++)
                 {
                     Console.Write("\nPreencha a matriz 1 [" + (i + 1) + "," + (j + 1) + "] :");
                     matriz1[i, j] = int.Parse(Console.ReadLine());
                 }
             }
             for (int i = 0; i < matriz2.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz2.GetLength(1); j++)
                 {
                     Console.Write("\nPreencha a matriz 2[" + (i + 1) + "," + (j + 1) + "] :");
                     matriz2[i, j] = int.Parse(Console.ReadLine());
                 }
             }
             for (int i = 0; i < matrizResultado.GetLength(0); i++)
             {
                 for (int j = 0; j < matrizResultado.GetLength(1); j++)
                 {

                     matrizResultado[i, j] = matriz1[i, j] + matriz2[i, j];
                     Console.Write("\nMatriz Resultado[" + matrizResultado[i, j] + "]");

                 }

                 Console.WriteLine();
             }*/

            /* 16) Escreveu um animal para transportar uma matriz 3x4 para outra 4x3.
              Transpor uma matriz significa transformar suas linhas em colunas e vice - versa.*/

            /*int[,] matriz1 = new int[3, 4];
            int[,] matriz2 = new int[4, 3];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("\nPreencha a matriz 1 [" + (i + 1) + "," + (j + 1) + "] : ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz2[j, i] = matriz1[i, j];
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write(" Matriz 1: [" + matriz1[i, j] + "]\n");

                }
                Console.WriteLine();
            }
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write(" Matriz 2 [" + matriz2[i, j] + "]\n");

                }
                Console.WriteLine();
            }*/

            /*17) Desafio: Fazer um programa que leia uma matriz de 10 linhas por 10 colunas, 
               escreva o elemento da linha max, ou seja, o elemento da linha onde se 
               encontra o maior elemento da matriz.Escreva também a linha e a coluna onde foi encontrada.*/

          /*Random random = new Random();
            int[,] M = new int[10, 10];
            int maiorElemento = 0, menorElemento = 9999999, linhaMaior = 0;
            int colunaMaior = 0, ColunaMenor = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = random.Next(0, 100);
                }
            }
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (maiorElemento < M[i, j])
                    {
                        maiorElemento = M[i, j];
                        linhaMaior = i;
                        colunaMaior = j;

                    }
                }
            }
            for (int i = 0; i < M.GetLength(0); i++)
            {
                if (M[linhaMaior, i] < menorElemento)
                {
                    menorElemento = M[linhaMaior, i];
                    ColunaMenor = i;
                }
            }
            Console.WriteLine("O elemento maior " + maiorElemento + " esta na posicao [" + linhaMaior + "," + colunaMaior + "]");
            Console.WriteLine("O elemento menor " + menorElemento + " esta na posicao [" + linhaMaior + "," + colunaMaior + "]");*/

        }
    }
}