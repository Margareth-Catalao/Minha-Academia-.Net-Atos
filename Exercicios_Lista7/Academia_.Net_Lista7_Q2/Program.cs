using System.Runtime.Intrinsics.X86;

namespace Academia_.Net_Lista7_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2 - Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. 
            //Faça métodos para apresentar os dados.Faça a leitura pelo teclado dos atributos 
            //e crie um construtor para fazer o instanciamento.

            Console.WriteLine("Dados Cadastrais do Cliente\n");

            Pessoa pessoa = new Pessoa();
            pessoa.nome = "Paulo Andrade";
            Console.WriteLine("Nome: " +pessoa.nome);
            pessoa.idade = 51;
            Console.WriteLine("Idade: " +pessoa.idade + " anos");    
            pessoa.altura = 1.75;
            Console.WriteLine("Altura: " +pessoa.altura + " metros");
            pessoa.peso = 65;
            Console.WriteLine("Peso: " +pessoa.peso + "kg");
            pessoa.cpf = 09989756745;
            Console.WriteLine("CPF:" +pessoa.cpf);
            pessoa.id = 1069784;
            Console.WriteLine("Identidade:" + pessoa.id);

            Console.WriteLine("\nSituação do Cliente;");

            bool retorno;
            pessoa.estar();
            retorno = pessoa.estaAtivo();
            Console.WriteLine("Status do Cliente: "+retorno);
            pessoa.naoEstar();
            retorno = pessoa.estaAtivo();
            Console.WriteLine("Status do Cliente; " +retorno);

        }
    }
}