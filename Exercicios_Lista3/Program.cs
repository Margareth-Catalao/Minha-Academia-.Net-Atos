namespace Exercicios_Lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando uma entrada de dados
             (informando se ele está errado e repetindo a solicitação até que seja correto).
             Após o programa em VS deve informar todos os números pares existentes entre 1 e o número especificado pelo usuário.
             Exemplo:
             Digite um número inteiro positivo: -8
                 Valor incorreto!
                 Digite um número inteiro positivo: 8
                 Número digitado: 8
                 Números inteiros pares entre 1 e 8: 2, 4, 6.

             int numero;
             int i = 0;
             int contagem = 0;

             do
             {
                 Console.Write("Digite um número positivo: ");
                 numero = int.Parse(Console.ReadLine());
                 if (numero <= 0)
                 {
                     Console.WriteLine("Valor Incorreto; " + numero);
                 }
             } while (numero <= 0);

             Console.Write("Números inteiros pares entre 1 a  " + numero + ":\t");
             for (i = 1; i < numero; i++)
             {
                 if (i % 2 == 0)
                 {
                     Console.Write(i + "\t");

                 }*/

            /*2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
           informar um outro número. Caso positivo, o programa em VS deve ser repetido.

           Exemplo:
           Digite um número inteiro positivo: 8
           Numero digitado: 8
           Números inteiros pares entre 1 e 8: 2, 4, 6.

           Deseja informar outro número(s/ n)? S

           Digite um número inteiro positivo: 12
           Numero digitado: 20
           Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

           Deseja informar outro número(s/ n)? N


           int numero;
           int i = 1;
           int resposta;


           do
           {
               do
               {
                   Console.Write("Digite um número positivo: ");
                   numero = int.Parse(Console.ReadLine());
                   if (numero <= 0)
                   {
                       Console.WriteLine("Valor incorreto! " + numero);
                   }
               } while (numero <= 0);
               Console.Write("Digite números inteiros pares entre 1 a  " + numero + ":\t");
               for (i = 1; i <= numero; i++)
               {
                   if (i % 2 == 0)
                   {
                       Console.Write(i + "\t");
                   }
               }
               Console.WriteLine("\nDeseja Informar outro número. Responda 1 - sim ou 2 - não: ");
               resposta = int.Parse(Console.ReadLine());


           } while (resposta == 1);*/

            /*3.Fazer um laço(repetição) que fique solicitando números ao usuário.
            Se o usuário digitar 0 ou programa em VS deve parar.
            Caso contrário, o programa em VS deve informar se o número
            é par ou ímpar e se ele é um número primo*/


            /*int numero;


            do
            {
                Console.WriteLine("Informe um número ou 0 para sair:");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Este número é par! " + numero);
                }
                else
                {
                    Console.WriteLine("Este número é impar! " + numero);
                }

                //Regra de negócio;

                int qntDivisoesPerfeitas = 0;
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        qntDivisoesPerfeitas++;
                    }
                }
                if (qntDivisoesPerfeitas > 2)
                {
                    Console.WriteLine("Este número não é primo! ");
                }
                else
                {
                    Console.WriteLine("Este número é primo! ");
                }


            } while (numero != 0);*/

            /*4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            de votos em branco. 

            int qntVotosJoao = 0, qntVotosZeca = 0, qntVotosBrancos = 0, fim = 0;
            int op = 4;


            Console.WriteLine("-------Votação Iniciada------\n");

            while (op != 0)
            {

                Console.WriteLine("Opções de voto: \n1-Candidato João. \n2-Candidato Zeca.\n" +
                    "3-Votos em branco.\n0-FIM");
                Console.WriteLine("Digite a opção desejada");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:

                        fim = 0;
                        break;

                    case 1:

                        Console.WriteLine(" Voto em João!");
                        qntVotosJoao++;
                        break;

                    case 2:

                        Console.WriteLine("Voto em Zeca!");
                        qntVotosZeca++;
                        break;

                    case 3:

                        Console.WriteLine("voto em branco");
                        qntVotosBrancos++;

                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                }


            }

            Console.Clear();
            Console.WriteLine("Quantidade de votos do Candidato João: " + qntVotosJoao);
            Console.WriteLine("Quantidade de votos do Candidato Zeca: " + qntVotosZeca);
            Console.WriteLine("Quantidade de votos em Branco: " + qntVotosBrancos);*/

            /* 5.Modifique o programa em VS anterior para aceitar votos nulos
             (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
             Ao final, informe o nome do candidato vencedor, o número de votos nulos
             e o número de pessoas que votaram.

             int votosJoao = 0, votosZeca = 0, votosBrancos = 0, votosNulos = 0;
             int voto = 5, qntEleitores;

             Console.WriteLine("-------Votação iniciada!------\n");
             while (voto != 0)
             {

                 Console.WriteLine("1-Candidato João\n2-Candidato Zeca\n3 - Voto em branco\n4-Voto nulo\n0-FIM \n");
                 Console.WriteLine("Digite a opçãp desejada: ");
                 voto = int.Parse(Console.ReadLine());

                 switch (voto)
                 {
                     case 0:

                         Console.WriteLine("-------FIM!------");
                         break;

                     case 1:
                         Console.WriteLine("Voto em João.");
                         votosJoao++;
                         break;

                     case 2:
                         Console.WriteLine("Voto em Zeca.");
                         votosZeca++;
                         break;

                     case 3:

                         Console.WriteLine("Voto em branco.");
                         votosBrancos++;
                         break;

                     case 4:
                         Console.WriteLine("Voto nulo.");
                         votosNulos++;
                         break;

                     default:
                         Console.WriteLine("Opção inválida\n");
                         break;

                 }

             }
             Console.Clear();
             Console.WriteLine("Quantidade de votos em João: " + votosJoao);
             Console.WriteLine("Quantidade de votos em Zeca: " + votosZeca);
             Console.WriteLine("Quantidade de votos em Branco: " + votosBrancos);
             Console.WriteLine("Quantidade de votos Nulos: " + votosNulos);

             qntEleitores = votosBrancos + votosJoao + votosZeca + votosNulos;
             Console.WriteLine("A quantidade de eleitores é: " + qntEleitores);

             if (votosJoao > votosZeca)
             {
                 Console.WriteLine("O Candidato vencedor é João");
             }
             else
             {
                 Console.WriteLine("O Candidato vencedor é Zeca");
             }*/

            /*6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            Ao final, mostre a idade digitada.

            int idade = 0;

            while (idade <= 0)
            {
                Console.Clear();
                Console.WriteLine("Digite uma idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(idade + " é uma idade válida!");*/

            /*7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
            A cada solicitação, teste se o usuário informou um valor válido. 
            Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            informe que ele está incorreto e saia do programa em VS.
            Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            informe que está errada e saia.Se estiver correta, solicite o salário.
            Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            Se estiver correto, mostre todos os valores lidos.

            string nome;
            int idade;
            float salario;
            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                if (nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Digite um nome válido!!");
                }
                else
                {
                    break;
                }
            } while (true);
            do
            {
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade <= 0)
                {
                    Console.WriteLine("Digite uma idade válida!!");
                }
                else
                {
                    break;
                }
            } while (true);
            do
            {
                Console.Write("Salário: ");
                salario = float.Parse(Console.ReadLine());
                if (salario <= 0)
                {
                    Console.WriteLine("Digite um salário válido!!");
                }
                else
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Seus dados são: ");
            Console.WriteLine("Nome: " + nome.ToUpper());
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);
            Console.WriteLine("Salário: " + salario);*/

            /* 8.Faça um programa em VS que solicite um numero inteiro.
             Se o numero não for inteiro, solicite - o até que seja.após,
             informe se ele é par ou impar.
             Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

             int numero;
             string verifica = " ";

             do
             {
                 Console.WriteLine("Digite um número inteiro: ");
                 numero = int.Parse(Console.ReadLine());
                 if (numero % 2 == 0)
                 {
                     Console.WriteLine("Este número é par!");
                 }
                 else
                 {
                     Console.WriteLine("Este número é impar;");
                 }

                 Console.WriteLine("Deseja inseir outro número(use: S para sim e N para não");

             } while (verifica == " ");*/

            /*9.Faça um programa em VS para Ler a quantidade de filhos
            de cada uma das 30 pessoas que visitaram
            o zoológico num determinado dia, imprimindo:
            Quantas pessoas tem entre 1 e 3 filhos.
            Quantas pessoas tem entre 4 e 7 filhos.
            Quantas pessoas tem mais de 8 filhos.
            Quantas pessoas não tem filhos.

            int filhos, f0 = 0, f1a3 = 0, f4a7 = 0, f8ouMais = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Quantos filhos a pessoa " + i + " tem: ");
                filhos = int.Parse(Console.ReadLine());

                if (filhos == 0)
                {
                    f0++;
                }
                if (filhos >= 1 && filhos <= 3)
                {
                    f1a3++;

                }
                if (filhos >= 4 && filhos <= 7)
                {
                    f4a7++;

                }
                if (filhos >= 8)
                {
                    f8ouMais++;

                }

            }

            Console.WriteLine("Quantidade de pessoas não tem filhos: " + f0);
            Console.WriteLine("Quantidade de pessoas que tem entre 1 e 3 filhos; " + f1a3);
            Console.WriteLine("Quantidade de pessoas que tem entre 4 e 7 filhos; " + f4a7);
            Console.WriteLine("Quantidade de pessoas que tem 8 ou mais filhos: " + f8ouMais);*/

            /*10.Leia o nome, sexo e idade de 50 pessoas e após imprimir:
            Número de pessoas do sexo masculino.
            Número de pessoas do sexo feminino.
            Número de pessoas com idade inferior a 30 anos.
            Número de pessoas com idade superior a 60 anos.
            Média de idade das mulheres.

            int idade = 0, masculino = 0, feminino = 0, idMenor30 = 0, idMaior60 = 0, idMulheres = 0, MediaIdMelheres = 0;
            char sexo;
            string nome;

            for (int i = 1; i < 6; i++) //fiz para 5 pessoas por orientação do professor
            {
                Console.WriteLine("Digite o nome da pessoa " + i + " :\n");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o sexo da pessoa " + i + "(F para sexo feminino e M para sexo marculino): \n");
                sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("Digite a idade da pessoa " + i + " : \n");
                idade = int.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    masculino++;

                }
                if (sexo == 'F')
                {
                    feminino++;
                    idMulheres += idade;

                }
                if (idade < 30)
                {
                    idMenor30++;
                }
                if (idade > 60)
                {
                    idMaior60++;

                }

                MediaIdMelheres = idMulheres / feminino;

            }

            Console.WriteLine("Número de pessoas do sexo masculino: " + masculino);
            Console.WriteLine("Número de pessoas do sexo feminino: " + feminino);
            Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + idMenor30);
            Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + idMaior60++);
            Console.WriteLine("Média de idade das mulheres: " + MediaIdMelheres);*/

            /*11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
            a média aritmética da turma e a quantidade de alunos da turma.Usar - 1 para encerrar a leitura.


            double nota = 0, maiorNota = 0, menorNota = 99999, media, somaNotas = 0;
            int qntAlunos = 0;


            while (true)
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());

                if (nota == -1)
                {
                    break;
                }
                else
                {
                    qntAlunos++;
                    somaNotas++;
                    media = somaNotas / qntAlunos;
                }
                if (nota > maiorNota)
                {
                    maiorNota = nota;
                }
                if (nota < menorNota)
                {
                    menorNota = nota;
                }

            }
            Console.WriteLine("A nota mais alta é: " + maiorNota);
            Console.WriteLine("A nota mais baixa é: " + menorNota);
            Console.WriteLine("A média de nota da turma é: " + (somaNotas / qntAlunos));
            Console.WriteLine("A quantidade de alunos da turma é: " + qntAlunos);*/

            /*12.Apresentar o total da soma dos cem primeiros números inteiros.

            int soma = 0;

            for (int i = 0; i <= 100; i++)
            {
                soma += i;
            }

            Console.WriteLine(soma);*/

            /*13.Elaborar um programa que apresenta o somatório dos valores pares existentes
            entre 1 e 500.

            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);*/

            /*14.Mostrar as potências de 2 variações de 0 a 10.

            for (int i = 0; i <= 10; i++)
            {
                Math.Pow(2, i);
                Console.WriteLine("Potência de 2: " + Math.Pow(2, i));
            }*/

            /*15.Ler 4 valores referências a notas escolares de um aluno e
            imprimir uma mensagem dizendo se ele está aprovado
            ou reprovado, após ter sua média ponderando, considerando
            pesos 2, 1, 2, e 4, respectivamente.
            Considerar nota 7,0 como mínima para aprovação.

            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Digite a nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 4: ");
            nota4 = double.Parse(Console.ReadLine());

            media = ((nota1 * 2) + (nota2 * 1) + (nota3 * 2) + (nota4 * 4)) / 4;

            if (media >= 70)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
            }*/

            /*16.ler um número n qualquer menor ou igual a50 e apresentar o valor obtido da
            multiplicação sucessiva de n por 3 enquanto o produto for menor que 250
            (n * 3; n * 3 * 3; n * 3 * 3 * 3; etc).

            double numero;

            Console.WriteLine("Digite o número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero <= 50)
            {
                for (int i = 1; ; i++)
                {
                    double produto = numero * (3 * i);

                    if (produto > 250)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(produto);
                    }

                }
            }*/

            /*17.apresentar os quadrados dos números inteiros de 15 a 200.

            for (int i = 15; i <= 200; i++)
            {

                Console.WriteLine("O quadodrado do numero " + i + " é " + Math.Pow(i, 2));
            }*/


            /*18.Elaborar um programa que apresente o valor de uma potência de uma base qualquer
            superior a um expoente qualquer, ou seja, NM.

            int baseDaPotencia, expoente;

            Console.WriteLine("Escreva a base: ");
            baseDaPotencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o expoente: ");
            expoente = int.Parse(Console.ReadLine());


            Console.WriteLine("Resultado: " + Math.Pow(baseDaPotencia, expoente));*/

            /*19.A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
            coletando dados sobre o salário e número de filhos. A prefeitura deseja saber:

            a) média do salário da população;
            b) média do número de filhos;
            c) maior salário;
            d) percentual de pessoas com salário até R$ 100,00.
            O final da leitura de dados se dará com a entrada de um salário negativo.

            double salario = 0, mediaSalario = 0, mediaFilhos = 0, maiorSalario = 0, menorSalario = 0;
            double percSal100 = 0, numFilhos = 0;
            int participantes = 0;

            while (true)
            {
                Console.WriteLine("Digite o salário: \n" +
                    "");
                salario = double.Parse(Console.ReadLine());

                if (salario < 0)
                {
                    break;
                }
                participantes++;

                Console.WriteLine("Informe o número de filhos: \n");
                numFilhos = int.Parse(Console.ReadLine());

                mediaSalario = (mediaSalario + salario) / participantes;
                mediaFilhos = (mediaFilhos + numFilhos) / participantes;

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }
                if (salario <= 100)
                {
                    menorSalario++;
                    percSal100 = menorSalario * 100 / participantes;
                }
                Console.Clear();

                Console.WriteLine("Média do salário da população: " + mediaSalario);
                Console.WriteLine("Média do número de filhos: " + mediaFilhos);
                Console.WriteLine("Maior salário: " + maiorSalario);
                Console.WriteLine("Percentual de pessoas com salário até R$ 100,00: " + percSal100 + "%");

            }*/

            /*20.foi realizada uma pesquisa de algumas características físicas da população de uma
            certa região, a qual coletou os seguintes dados referentes a cada habitante para
            serem analisados:
            -sexo(masculino e feminino)
            - cor dos olhos(azuis, verdes ou castanhos)
            -cor dos cabelos(louros, castanhos, pretos)
            -idade

            faça um algoritmo que determine e escreva:

            -a maior idade dos habitantes
            -a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            e que tenham olhos verdes e cabelos louros.
            O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

            int maiorIdade = 0, mulheres18a35 = 0, idade;
            string sexo, corOlhos, corCabelo;

            while (true)
            {
                Console.WriteLine("Digite a Idade: ou -1 para sair");
                idade = int.Parse(Console.ReadLine());

                if (idade == 1)
                {
                    break;
                }

                Console.WriteLine("Digite o sexo (Feminino ou Masculino): ");
                sexo = Console.ReadLine();
                Console.WriteLine("Digite a cor dos olhos:(verdes, azuis ou castanhos)");
                corOlhos = Console.ReadLine();
                Console.WriteLine("Digite A cor dos Cabelos:(Castanhos, louros, pretos)");
                corCabelo = Console.ReadLine();

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                if ((sexo == "Feminino") && (idade >= 18 && idade <= 35) && (corOlhos == "verdes") && (corCabelo == "louros"))
                {
                    mulheres18a35++;
                }

                Console.WriteLine("A maior idade dos habitantes; " + maiorIdade);
                Console.WriteLine("A quantidade de indivíduos do sexo feminino " +
                "cuja idade está entre 18 e 35 anos inclusive " +
                "e que tenham olhos verdes e cabelos louros: " + mulheres18a35++);
            }*/

        }


    }
}
