using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Exercicios_Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1 - Faça um programa para calcular e mostrar a Área de Um Triângulo a Partir dos Valores da Base e altura lidos pelo Teclado: 
           Área do triângulo = (base * altura) / 2;Teste se a base ou a altura digitada não foi igual a zero.
            */

            /*  double a, b, h;

              Console.WriteLine("Digite o valor da base do triangulo");
              b = double.Parse(Console.ReadLine());

              Console.WriteLine("Digite o valor da altura do triangulo");
              h = double.Parse(Console.ReadLine());

              a = b * h / 2;

              if (b == 0 || h == 0)

              {
                  Console.WriteLine("Digite um valor maior do zero");

              }
              else
              {
                  Console.WriteLine("A area do triangulo é: " + a);
              }*/

            //2 - Faça um programa para ler um número e se ele é par ou ímpar.

            /*
            int num;

            Console.WriteLine("Digite o número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Este número é par: " + num);
            }

            else
            {
                Console.WriteLine("Este número é impar: " + num);
            }
            */

            //3 - Escrever um Algoritmo superior para ler quatro valores inteiros, 
            // calcular a sua média, e escrever na tela os valores que são superiores a média.

            /*
            int valor1, valor2, valor3, valor4;
            int media;

            Console.WriteLine("Digite o Valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor 3: ");
            valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor 4: ");
            valor4 = int.Parse(Console.ReadLine());

            media = (valor1 + valor2 + valor3 + valor4) / 4;

            Console.WriteLine("A média é: " + media);

            if (valor1 > media)
            {
                Console.WriteLine("Digite o Valor " + valor1 + " è superrior a média.");
            }

            if (valor2 > media)
            {
                Console.WriteLine("O Valor " + valor2 + " è superior a média.");
            }
            if (valor3 > media)
            {
                Console.WriteLine("O Valor " + valor3 + " è superior a média.");
            }

            if (valor4 > media)
            {
                Console.WriteLine("O Valor " + valor4 + " è superior a média.");
            }
            */

            //4 - Escrever um programa para ler a quantidade de horas aula dada por dois professores 
            //e valor por hora recebida por cada um deles.
            //Mostrar na tela qual dos professores tem o maior salário total.
            /*

            double qntHora1, qntHora2;
            double valorHora1, valorHora2;
            double salTotal1, salTotal2;

            Console.WriteLine("A quantidade de horas/aula do professor 1 é: ");
            qntHora1 = double.Parse(Console.ReadLine());

            Console.WriteLine("A quantidade de horas/aula do professor 2 é: ");
            qntHora2 = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor hora/aula recebido pelo professor 1 é R$ ");
            valorHora1 = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor hora/aula recebido pelo professor 2 é R$ ");
            valorHora2 = double.Parse(Console.ReadLine());

            salTotal1 = qntHora1 * valorHora1;
            salTotal2 = qntHora2 * valorHora2;

            if (salTotal1 > salTotal2)
            {
                Console.WriteLine("O professor 1 recebe o maior salário R$" + salTotal1);
            }

            else
            {
                Console.WriteLine("O professor 2 recebe o maior salário R$" + salTotal2);
            }
            */

            //5 - Escrever um programa para ler duas notas de um aluno e escrever na tela a “Aprovado”
            //se a média das duas notas for maior ou igual a 7,0.
            //Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            //é a média entre a nota do exame e a média das 2 notas.
            //Se esta média final for maior ou igual a 5.0, o programa deve escrever “Aprovado”, caso contrário deve
            //escrever “Reprovado”.

            /*
            double nota1, nota2;
            double media, mediaFinal, exame;


            Console.WriteLine("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7.0)
            {

                Console.WriteLine("Aprovado");

            }
            else
            {
                Console.WriteLine("Nota do Exame: ");
                exame = double.Parse(Console.ReadLine());
                mediaFinal = (exame + media) / 2;

                if (mediaFinal >= 5)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }

            }

            */
            //6 - Faça um programa em C# e no Visual Studio para o nome (totalmente em maiúsculo), a altura (metros)
            //e o peso (kg) de uma pessoa.
            //O programa deve calcular o Índice de Massa Corporativa(IMC), exibi - lo ao usuário e
            //informar sua conforme a tabela.
            //O cálculo do imc = peso / (altura * altura)

            //IMC
            //menor que 18-> baixo peso
            //maior que 18 e menor que 25->peso normal
            //maior que 25 e menor que 30->sobrepeso
            //maior que 30 e menor que 35->obesidade
            //maior que 35->obesidade grau sério
            /*
            string nome;
            double altura = 0, peso = 0, imc;

            Console.WriteLine("Digite o Nome: ");
            nome = Console.ReadLine().ToUpper();

            Console.WriteLine(nome + ", digite sua Altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine(nome + ", digite seu Peso; ");
            peso = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Valor do IMC: " + imc);

            if (imc <= 18)
            {
                Console.WriteLine("Baixo peso");
            }
            if (imc > 18 && imc <= 25)
            {
                Console.WriteLine("Peso normal");
            }
            if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            if (imc > 30 && imc <= 35)
            {
                Console.WriteLine("Obesidade");
            }
            if (imc >= 35)
            {
                Console.WriteLine("Obesidade grau sério");
            }*/

            //7 - Faça um programa em C# e no VS para uma frase qualquer e uma palavra de pesquisa.
            //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            //exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.
            /*
            string frase = "";
            string palavra = "";

            Console.WriteLine("Digite uma frase");
            frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra encontra-se na frase");
            }
            else
            {
                Console.WriteLine("A palavra não encontra-se na frase");
            }*/

            //8 - Faça um programa no VS que inclua o código, nome, salário base e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicione ao seu salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicione ao seu salário final 7 % do total de vendas.
            //por fim, se o total de vendas for maior que R$ 5000,00, adicione ao seu salário E final 10 % do total de vendas.
            /*
            string nome;
            double salBase, totalVendas, salTotal, codFuncionario;

            Console.WriteLine("Digite o nome do código do funcinário: ");
            codFuncionario = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o salário base do funcionário: ");
            salBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas do funcionário: ");
            totalVendas = double.Parse(Console.ReadLine());

            salTotal = 0;

            if (totalVendas > 500 && totalVendas < 1000)
            {
                salTotal = salBase + (totalVendas * 0.05);
                Console.WriteLine("O vendedor receberá: " + salTotal);

            }
            if (totalVendas > 1000 && totalVendas < 5000)
            {
                salTotal = salBase + (totalVendas * 0.07);
                Console.WriteLine("O vendedor receberá: " + salTotal);

            }
            if (totalVendas > 5000)
            {
                salTotal = salBase + (totalVendas * 0.10);
                Console.WriteLine("O vendedor receberá: " + salTotal);

            }
            */
            //9-Faça um programa no VS que receberá do usuário 3 valores de glicemia em jejum, representando 
            //uma diária de glicemia diária de um paciente diabético. Para cada valor recebido e analisado, 
            //informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            //Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.


            //Além disso, o programa deve fazer a média dos 3 valores de glicemia avaliados.E se a média for
            //menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média para maior que
            //150, avisá - lo que será necessário adicionar 2 unidades de insulina.
            /*
            double glic1, glic2, glic3, glicDiaria, mediaGlic;

            Console.WriteLine("informe o primeiro valor da glicemia em jejum");
            glic1 = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o segundo valor da glicemia em jejum");
            glic2 = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o terceiro valor da glicemia em jejum");
            glic3 = double.Parse(Console.ReadLine());


            glicDiaria = glic1 + glic2 + glic3;
            mediaGlic = glicDiaria / 3;

            if (glicDiaria < 65)
            {

                Console.WriteLine("Risco de hipoglicemia");
            }
            if (glicDiaria > 250)
            {

                Console.WriteLine("Risco de hiperglicemia" + glicDiaria);
            }

            if (mediaGlic < 80)
            {
                Console.WriteLine("È preciso diminuir 2 unidades de insulina." + mediaGlic);
            }
            else if (mediaGlic > 150)
            {
                Console.WriteLine("Será necessário adicionar 2 unidades de insulina. " + mediaGlic);
            }*/

            //10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
            //O programa deve mostrar os dados do atleta mais novo e mais alto.
            /*
            double alturaA, alturaB;
            int idadeA, idadeB;
            string nomeA, nomeB;

            Console.WriteLine("Digite o nome do primeiro Atleta; ");
            nomeA = Console.ReadLine();

            Console.WriteLine("Digite o nome do segundo Atleta; ");
            nomeB = Console.ReadLine();

            Console.WriteLine("Digite a idade do primeiro Atleta; ");
            idadeA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do primeiro Atleta; ");
            idadeB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do primeiro Atleta; ");
            alturaA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do segundo Atleta; ");
            alturaB = double.Parse(Console.ReadLine());

            if (idadeA > idadeB)
            {
                Console.WriteLine("Dados do atleta mais jovem: " + nomeB + ", " + idadeB + ", " + alturaB);
            }
            else
            {
                Console.WriteLine("Dados do atleta mais jovem: " + nomeA + ", " + idadeA + ", " + alturaA);
            }

            if (alturaA > alturaB)
            {
                Console.WriteLine("Dados do atleta mais alto: " + nomeB + ", " + idadeB + ", " + alturaB);
            }
            else
            {
                Console.WriteLine("Dados do atleta mais alto: " + nomeA + ", " + idadeA + ", " + alturaA);
            }*/

            //11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis
            //(uma para hora e outra para minutos).O programa deve exibir se a hora digitada
            //está ou não válida.Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
            /*
            int horas, minutos;

            Console.WriteLine("Digite a hora: ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a minutos: ");
            minutos = int.Parse(Console.ReadLine());

            if (horas >= 0 && horas <= 23 && minutos >= 0 && minutos <= 59)
            {
                Console.WriteLine("Hora Válida " + horas + ":" + minutos + "h");
            }
            else
            {
                Console.WriteLine("Hora invalida");
            }*/

            //12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e
            //número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
            //R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
            //armazenando - o na variável "extra", caso contrário zerar tal variável.A hora
            //excedente de trabalho vale R$ 20,00.
            //No final do processamento, exibir o salário total e o salário excedente do operário.
            /*

            double codigo, horas, salario;
            double extra, salarioTotal = 0;

            Console.WriteLine("Digite o código do operário: ");
            codigo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de horas trabalhadas pelo operário: ");
            horas = double.Parse(Console.ReadLine());


            if (horas < 50)
            {
                salario = horas * 10;
                Console.WriteLine("Salário do empregado: " + salario);

            }
            if (horas > 50)
            {
                horas -= 50;
                extra = horas * 20;
                salario = 10 * 50;
                salarioTotal = salario + extra;
                Console.WriteLine("Salario Total como horas extras além de 50 horas: " + salarioTotal);
            }*/

            //13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
            //seu peso ideal, utilizando as seguintes fórmulas:Para homens: (72.7 * h) - 58. Para mulheres: (62.1 * h) - 44.7
            /*
            double altura, pesoIdeal;
            char sexo;

            Console.WriteLine("Digite seu sexo: ");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());


            if (sexo == 'f')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("O seu peso ideal será: " + pesoIdeal);
            }
            else if (sexo == 'm')
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("O seu peso ideal será: " + pesoIdeal);

            }*/

            //14 - Faça um programa que peça o tamanho de um arquivo para download(em MB) e a velocidade de um
            //link de Internet(em Mbps). Em seguida, calcule e informe o tempo aproximado de download
            //do arquivo usando este link(em minutos).
            /*
            double tamArq, velocLink;
            double tempdownload;

            Console.WriteLine("Informe o tamanho do aquivo e MB: ");
            tamArq = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade do link de Internet e Mbp/s: ");
            velocLink = double.Parse(Console.ReadLine());

            tempdownload = tamArq * velocLink / 8;

            Console.WriteLine("O tempo aproximado de download é " + tempdownload + " minutos");
            */

            //15 - Faça um programa para uma loja de tintas.O programa deve pedir o tamanho em metros quadrados
            //da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            //e que a tinta é vendida em latas de 18 litros, que custa R$ 80,00.
            //Informe ao usuário a quantidade de latas de tinta compradas e o preço total
            /*
            double TamArea, qntLatas, precTotal;

            Console.WriteLine("Informe o tamanho em m2 da area a ser pintada");
            TamArea = double.Parse(Console.ReadLine());

            qntLatas = TamArea / 54;
            precTotal = qntLatas * 80;

            Console.WriteLine("A quantidade de latas será: " + qntLatas + " e o preço total será R$ " + precTotal);
            */

            //16 - Escreva um jogo que leia o placar de um primeiro jogo da copa do Brasil.
            //Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            //na tela uma mensagem indicando que o time de fora já se classificou para próxima fase.
            //Caso contrário, a mostre uma mensagem indicando que os dois times vão se ver
            //enfrentar novamente em um novo jogo.
            //ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            //ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            //plus: caso ocorra um segundo jogo, leia e diga quem passou de novo jogo.
            /*
            double golTCasa, golTFora;

            Console.WriteLine("------Placar------");

            Console.WriteLine("Time da Casa: ");
            golTCasa = double.Parse(Console.ReadLine());

            Console.WriteLine("Time de Fora: ");
            golTFora = double.Parse(Console.ReadLine());

            if (golTFora > golTCasa && golTFora > 2)
            {
                Console.WriteLine("Time de casa " + golTCasa + " X " + golTFora + " Time de fora " + " : " + "O time de fora já se classificou.");
            }
            else if (golTFora < golTCasa && golTCasa > 2)
            {
                Console.WriteLine("Time de casa " + golTCasa + " X " + +golTFora + " Time de fora " + " : " + "Os dois times se enfrentarâo novamente em um novo jogo.");
            }*/
            /*
            17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos
            os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

            double a, b, c;
            Console.WriteLine("informe os tres numeros");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n");

            if ((a < (b + c)) && (b < (a + c)) && (c < (a + b)))
            {
                Console.WriteLine("è um triangulo");
                if (a == b && b == c)
                {
                    Console.WriteLine("è um triangulo equilatero");
                }

                else if (a == b || a == c || b == c)
                {

                    Console.WriteLine("è um triangulo isosceles");
                }
                else
                {

                    Console.WriteLine("è um triangulo escaleno");
                }
            }

            else
            {

                Console.WriteLine("não è um triagulo");
            }*/

            //18 - Escreveu programa então que leia 3 valores pelo teclado e informe qual o maior deles.
            /*
            double valor1, valor2, valor3;

            Console.WriteLine("Informe o primeiro valor 1: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor 2: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor 3: ");
            valor3 = double.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("O Valor " + valor1 + " é o maior.");
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine("O Valor " + valor2 + " é o maior.");
            }
            else if (valor3 > valor1 && valor3 > valor2)
            {
                Console.WriteLine("O Valor " + valor3 + " é o maior.");
            }*/

            //20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. 
            //O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            //plus: você pode gerar o número de forma randomica(função random c#).
            /*
            int numSecreto = 12, jogadas = 3, numEscolhido;

            Console.WriteLine("------JOGO DE ADIVINHAÇÃO------");

            do
            {

                Console.WriteLine("Digite o número escolhido: ");
                numEscolhido = int.Parse(Console.ReadLine());

                if (numEscolhido != numSecreto)
                {
                    jogadas -= 1;
                    Console.WriteLine("Não foi dessa vez! Você errou! \n");

                    if (numEscolhido < numSecreto)
                    {
                        Console.WriteLine("O número secreto é maior!\n");
                    }
                    else
                    {
                        Console.WriteLine("O numero é secreto é menor!\n");
                    }

                    if (jogadas > 1)
                    {
                        Console.WriteLine("Tente outra vez! Você possui mais " + jogadas + " jogadas.\n");
                    }

                    else if (jogadas == 0)
                    {
                        Console.WriteLine("\nTente outra vez! Ultima jogada!\n" + jogadas);
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Você acertou! Parabéns!");
                    break;
                }

            }

            while (jogadas > 0)*/


        }
    }
}