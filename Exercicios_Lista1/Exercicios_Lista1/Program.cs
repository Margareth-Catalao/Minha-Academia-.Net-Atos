namespace Exercicios_Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercìcio 1:
            //1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            /*
             float num1, num2, media;

             Console.WriteLine("Digite o primeiro numero");
             num1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Digite o segundo numero");
             num2 = float.Parse(Console.ReadLine());

             media = (num1 + num2) / 2;
             Console.WriteLine("A média é:" + ((num1 + num2) / 2));

             */

            //Exercício 2;
            //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer

            /*
             *  int num1, num2, num3, num4, media;

              //entradas
              Console.WriteLine("Digite o primeiro numero");
              num1 = int.Parse(Console.ReadLine());

              Console.WriteLine("Digite o segundo numero");
              num2 = int.Parse(Console.ReadLine());

              Console.WriteLine("Digite o terceiro numero");
              num3 = int.Parse(Console.ReadLine());

              Console.WriteLine("Digite o quarto numero");
              num4 = int.Parse(Console.ReadLine());

              //processamento
              media = (num1 + num2 + num3 + num4) / 4;

              //saída

              Console.WriteLine("A média é:" + ((num1 + num2 + num3 + num4) / 4));
            */

            //Exercício 3:
            //3) Escreva uma seqüência de atribuições, em forma de programa em C# e no Visual Studio,
            //para trocar entre si os valores de duas variáveis ​​A e B.\\

            /*int a, b;

            //Entrada

            Console.WriteLine("Digite valor inicial de a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o valor inicial de b");
            b = int.Parse(Console.ReadLine());

            //Processamentp

            a = a + b;
            b = a - b;
            a = a - b;

            //Saída

            Console.WriteLine("Digite o valor final de a:  " + a);

            Console.WriteLine("digite o valor final de b:  " + b);
            */

            //Exercício 4:
            //4) Faça um programa em C# e no Visual Studio que adiciona dados na forma DDMMAAAA e imprima na
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis ​​diferentes.

            /*
            int dia, mes, ano;
            Console.WriteLine("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            //Apresentar AAAAMMDD

            Console.WriteLine(ano + "" + mes + "" + dia);
            int ano2;
            ano2 = ano % 100;
            Console.WriteLine(ano2);
            Console.WriteLine(ano2 + "" + mes + "" + dia);
            */

            //Exercício 5:
            //5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel
            //(medido em Km/ l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            //consumo para percorrê-la(medido em l).

            /*
            double distancia, volume, consumo;

            Console.WriteLine("Informe a distancia total percorrida; ");
            distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o volume de conbustivel: ");
            volume = double.Parse(Console.ReadLine());

            consumo = distancia / volume;

            Console.WriteLine("O consumo foi de: " + consumo);
            */

            //Exercício 6:

            //6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B,
            //é, o código ,a quantidade e o valor unitário de cada peça peças, isto é, o valor unitário de cada peça
            //de IPI(única) a ser acrescentada.
            /*
             * 
            double codA, qntA, vuA, percIPIA, vtA;
            double codB, qntB, vuB, percIPIB, vtB;

            Console.WriteLine("Informe o Codigo do parafuso, a quantidade de parafusos vendidos e o valor unitário de cada parafuso A: ");
            codA = double.Parse(Console.ReadLine());
            qntA = double.Parse(Console.ReadLine());
            vuA = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Codigo do parafuso, a quantidade de parafusos vendidos e o valor unitário de cada parafuso B: ");
            codB = double.Parse(Console.ReadLine());
            qntB = double.Parse(Console.ReadLine());
            vuB = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o % de IPI do parafuso A");
            percIPIA = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o % de IPI do parafuso B");
            percIPIB = double.Parse(Console.ReadLine());

            vtA = (qntA * vuA);
            vtA = vtA + (vtA * percIPIA / 100);

            Console.WriteLine("Valor total dos parafusos A:" + vtA);

            vtB = (qntB * vuB);
            vtB = vtB + (vtB * percIPIB / 100);

            Console.WriteLine("Valor total dos parafusos B:" + vtB);
            */

            //Exercício 7:
            //7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, ou seu salário fixo,
            //o total de vendas por ele efetuado e o percentual que ganha sobre o total de vendas.
            //Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.
            /*
            
            double NumVend, Salfixo, TotalVend, PercTV, SalTotal, comissao;

            Console.WriteLine("Informe o Numero do vendedor");
            NumVend = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o salario fixo R$ ");
            Salfixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Total de vendas: ");
            TotalVend = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o percentual sobre o Total de vendas: ");
            PercTV = double.Parse(Console.ReadLine());

            comissao = TotalVend * PercTV / 100;
            SalTotal = Salfixo + comissao;

            Console.WriteLine("Informe o numero do vendedor; " + NumVend);
            Console.WriteLine("Informe o salario total R$" + SalTotal);
            */

            //Exercício 8:
            //8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
            //A fórmula de conversão é F = (9 * C + 160) / 5.
            /*
            double Celsius;
            double Fahrenheit;

            Console.WriteLine("Temperatura em Celsius: ");
            Celsius = double.Parse(Console.ReadLine());

            Fahrenheit = (9 * Celsius + 160) / 5;

            Console.WriteLine("Apresente a temperatura em Fahrenheit: " + Fahrenheit);
            */

            //Exercício 9:
            //9) Uma vende seus produtos no sistema de entrada mais duas ofertas, sendo a entrada maior
            //do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            //Por exemplo, se o valor da entrada é igual a R$ 27,0, e as duas prestações são iguais a R$ 27,0;
            // se o valor da entrega,2 por R$ 30,75 a entrada é de R$ 1,75 e as duas 102 são iguais a R$ 100.
            //Escreva um programa em C# e no Visual Studio que aceita o valor da entrega e entrega o valor
            //da entrada e das duas regras, de acordo com as acima.
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção eo
            //conseqüente pagamento dos boletos das duas prestações.
            /*
            
            Console.WriteLine("Informe o Valor da Mercadoria");
            double mercadoria = double.Parse(Console.ReadLine());

            double prestacao = 0;

            double resto = mercadoria % 3;
            mercadoria = mercadoria - resto;

            prestacao = mercadoria / 3;

            double entrada = prestacao + resto;

            Console.WriteLine(" entrada de " + entrada + " e 2x de " + prestacao);
            */

            //Exercício 10:
            // 10) Um programa para gerenciar os mecanismos de saque de uma caixa eletrônica deve possuir algum
            //para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
            //testado o saque.Um conceito possível seria da “distribuição ótima” no sentido de que as
            //notas de menor valor foram distribuídas em número mínimo possível.
            //Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa Deveria indicar uma nota de R$ 50,00,
            //três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
            //Escreva um programa que receba o valor da quantia solicitada e restitua a distribuição das notas
            //de acordo com o critério da “distribuição ótima”.
            /*
            
            double saque = 0;
            int total200 = 0, total100 = 0, total50 = 0, total20 = 0, total10 = 0, total5 = 0, total2 = 0, total1 = 0;

            Console.WriteLine("Informar o valor do saque; ");
            saque = double.Parse(Console.ReadLine());

            total200 = (int)(saque / 200);
            Console.WriteLine("notas de 200: " + total200);
            saque = saque - (200 * total200);

            total100 = (int)(saque / 100);
            Console.WriteLine("notas de 100: " + total100);
            saque = saque - (100 * total100);

            total50 = (int)(saque / 50);
            Console.WriteLine("notas de 50: " + total50);
            saque = saque - (50 * total50);

            total20 = (int)(saque / 20);
            Console.WriteLine("notas de 20; " + total20);
            saque = saque - (20 * total20);

            total10 = (int)(saque / 10);
            Console.WriteLine("notas de 10; " + total20);
            saque = saque - (10 * total10);

            total5 = (int)(saque / 5);
            Console.WriteLine("notas de 5; " + total5);
            saque = saque - (5 * total5);

            total2 = (int)(saque / 2);
            Console.WriteLine("notas de 2; " + total2);
            saque = saque - (2 * total2);

            total1 = (int)(saque / 1);
            Console.WriteLine("notas de 1; " + total1);
            saque = saque - (1 * total1);
            */

            //Exercício 11:
            //Escreva um programa em C# para ler o número de votos de um município,
            //o número de votos brancos, nulos e válidos.
            //Calcule o percentual que cada um representa em relação ao total de rendimento.
            /*
            double votosBrancos, percBrancos;
            double votosNulos, percNulos;
            double votosValidos, percValidos;
            double votosTotais;
            string nomeMunicipio;

            Console.WriteLine("Informe o nome do Município; \n");
            nomeMunicipio = Console.ReadLine();

            Console.WriteLine("\nInforme o numero Total de votos; \n");
            votosTotais = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o número de votos Brancos: \n");
            votosBrancos = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o número de votos Nulos: \n");
            votosNulos = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o número de votos Válidos: \n");
            votosValidos = double.Parse(Console.ReadLine());

            votosTotais = votosBrancos + votosNulos + votosValidos;
            percBrancos = (votosBrancos * 100) / votosTotais;
            percNulos = (votosNulos * 100) / votosTotais;
            percValidos = (votosValidos * 100) / votosTotais;

            Console.WriteLine("\nO percentual de votos no Municipio " + nomeMunicipio + " foi:\n");
            Console.WriteLine("\nInforme o percentual de votos Brancos: \n" + percBrancos + "%\n");
            Console.WriteLine("\nInforme o percentual de votos Nulos: \n" + percNulos + "%\n");
            Console.WriteLine("\nInforme o percentual de votos Válidos: \n" + percValidos + "%\n");
            */

            //Exercício 12;
            //12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.Sabendo - se
            //que o preço do combustível é de R$6,90, escreva um algoritmo para ler a
            //marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia,
            //o número de litros de combustível gasto e o valor total(R$) recebido
            //dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.

            //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia

            //Média do consumo = Total quilometragem / quantidade de combustível gasto

            //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
            /*
            
            double marcInicio, marcFim;
            double qntCombustivel, ValorTotal;
            double mediaConsumo, lucroDia;
            double quilTotal;

            Console.WriteLine("Marcação odômetro inicio do dia em Km; ");
            marcInicio = double.Parse(Console.ReadLine());

            Console.WriteLine("Marcação odômetro fim do dia Km; ");
            marcFim = double.Parse(Console.ReadLine());

            quilTotal = marcFim - marcInicio;

            Console.WriteLine("Quatidade de Combustíbusvel em litros; ");
            qntCombustivel = double.Parse(Console.ReadLine());

            mediaConsumo = quilTotal / qntCombustivel;

            Console.WriteLine("Valor Total recebido: ");
            ValorTotal = double.Parse(Console.ReadLine());

            lucroDia = ValorTotal - (qntCombustivel * 6.90);

            Console.WriteLine("Média do consumo em Km/l: " + mediaConsumo + " e o lucro líquido do dia R$" + lucroDia);
            */

            //Exercício 13:
            // 13) Uma loja vende bicicletas com um acréscimo de 50 % sobre o preço de custo.
            // Ela paga a cada vendedor, mais uma comissao  de 15% sobre o
            //  preço de custo de cada bicicleta vendida.Desenvolva um programa que leia
            //  o valor do salário mínimo,
            //  o preço de custo de cada bicicleta
            //  e o número de bicicletas vendidas pelo vendedor,
            //  calcule e mostre:
            //  o salário do empregado
            /*
            
            
            double salMinimo, precoCusto, salEmpr, comissao;
            int nBVendidas;

            Console.WriteLine("Preco de custo de cada bicicleta: ");
            precoCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor do Salário Minimo: ");
            salMinimo = double.Parse(Console.ReadLine());
            Console.WriteLine("Número de bicicletas vendidas: ");
            nBVendidas = int.Parse(Console.ReadLine());

            comissao = precoCusto * 0.15;

            salEmpr = salMinimo + (comissao * nBVendidas);

            Console.WriteLine("Salário do Empregado: " + salEmpr);
            */

        }
    }
}