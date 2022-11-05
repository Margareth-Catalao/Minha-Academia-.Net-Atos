using System.Runtime.CompilerServices;

namespace Projeto_LojaCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-Faça um programa para controlar o aluguel de carros.
            //Deve ter as classes Carro, Aluguel e Cliente.

            Carro carro = new Carro();
            Console.WriteLine("Informacões sobre o veículo:  ");
            carro.placa = "kzxryhbk";
            Console.WriteLine("Placa: " +carro.placa);
            carro.modelo = "corsa";
            Console.WriteLine("Modelo: " + carro.modelo);
            carro.cor ="preta";
            Console.WriteLine("Placa: " + carro.cor);



            Cliente cliente = new Cliente();
            //cliente.nome = Console.ReadLine();
            Console.WriteLine("Informacões sobre o cliente:  ");
            cliente.nome = "Margareth";
            Console.WriteLine("Nome: " + cliente.nome);
            //cliente.idade = int.Parse(Console.ReadLine());
            cliente.idade = 38;
            Console.WriteLine("Idade: " + cliente.idade + " anos.");

            Aluguel aluguel = new Aluguel();
            Console.WriteLine("Informacões sobre o Aluguel:  ");
            aluguel.dataInicio = new DateTime (2022, 10, 10, 10, 0, 0);
            Console.WriteLine("Data de Inicio: " + aluguel.dataInicio);
            aluguel.dataFim = new DateTime(2022, 10, 15, 10, 0, 0);
            Console.WriteLine("Data de Término: " + aluguel.dataFim);
            aluguel.valorDiraria = 240;
            Console.WriteLine("Valor da diária: " + aluguel.valorDiraria);
            aluguel.carro = carro;
            aluguel.cliente = cliente;
          



        }
    }
}