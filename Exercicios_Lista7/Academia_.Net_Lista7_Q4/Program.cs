using System.Runtime.CompilerServices;

namespace Academia_.Net_Lista7_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Faça um programa que represente a arvore genealógica da tua familia. 
            //    Para isso, uma classe Pessoa precisa ser indicar quem são seus pais, 
            //    alem deinformações básicas sobre a pessoa.

            Pessoa pessoaFilho = new Pessoa();
            Console.WriteLine("------Dados do Filho------");
            pessoaFilho.nome = "Diego";
            Console.WriteLine("Nome: " + pessoaFilho.nome);
            pessoaFilho.idade = 12;
            Console.WriteLine("Idade: " + pessoaFilho.idade);

            Pessoa pessoaMae = new Pessoa();
            Console.WriteLine("------Dados da Mãe------");
            pessoaMae.nome = "EriKa";
            Console.WriteLine("Nome: " + pessoaMae.nome);
            pessoaMae.idade = 35;
            Console.WriteLine("Idade: " + pessoaMae.idade);

            Pessoa pessoaPai = new Pessoa();
            Console.WriteLine("------Dados do Pai------");
            pessoaPai.nome = "Sergio";
            Console.WriteLine("Nome: " + pessoaMae.nome);
            pessoaPai.idade = 31;
            Console.WriteLine("Idade: " + pessoaPai.idade);

            Pessoa pAvoMae = new Pessoa();
            Console.WriteLine("------Dados do Avô Materno------");
            pAvoMae.nome = "Paulo";
            Console.WriteLine("Nome: " + pAvoMae.nome);
            pAvoMae.idade = 65;
            Console.WriteLine("Idade: " + pAvoMae.idade);

            Pessoa mAvoMae = new Pessoa();
            Console.WriteLine("------Dados do Avó Materna------");
            mAvoMae.nome = "Ana";
            Console.WriteLine("Nome: " + mAvoMae.nome);
            mAvoMae.idade = 68;
            Console.WriteLine("Idade: " + mAvoMae.idade);


            Pessoa pAvoPai = new Pessoa();
            Console.WriteLine("------Dados do Avô Paterno------");
            pAvoPai.nome = "João";
            Console.WriteLine("Nome: " + pAvoPai.nome);
            pAvoPai.idade = 62;
            Console.WriteLine("Idade: " + pAvoPai.idade);

            Pessoa mAvoPai = new Pessoa();
            Console.WriteLine("------Dados do Avó Paterna------");
            mAvoPai.nome = "Maria";
            Console.WriteLine("Nome: " + mAvoPai.nome);
            mAvoPai.idade = 60;
            Console.WriteLine("Idade: " + mAvoPai.idade);

            //operação que faz a ligação entre Filho, Mâe, Pai e Avô.
            pessoaPai.pai = pAvoPai;
            pessoaPai.mae = mAvoPai;
            pessoaMae.mae = mAvoMae;    
            pessoaMae.pai = pAvoMae;
            pessoaFilho.mae = pessoaMae;
            pessoaFilho.pai = pessoaPai;


           
        }
    }
}