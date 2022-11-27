namespace Academia_.Net_Lista8_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*3) Imagine um jogo com asteróides e uma nave de ataque, que deve destruir os asteróides que voam em todas as plataformas.Dessa forma, crie um programa em C# que representa
            A lista de asteroides que não passou de ser 'inseridos no jogo'.Para, faça uma classe que único(os isso(privados) posição x, posição y asteroide em
            um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).Para esses atributos privados, gerar os métodos de acesso
            (propriedades getter e setter).Além disso, implementar 3 construtores(sobre): um vazio, outro tipo passando todos os parâmetros de um objeto Asteroide, e um
            terceiro que constrói um asteroide com posição xe posição y.
            O programa principal(main) deve conter uma lista de Asteroides por parte do usuário.Nesse programa principal, construir um método de classe que exiba todos os
            asteróides da lista.*/

            List<Asteroides> lista_asteroides = new List<Asteroides>();
            Random random = new Random();
           /* Asteroides asteroide1 = new Asteroides(0, 0, 1, 1, 1);   
            lista_asteroides.Add(asteroide1);
            Asteroides asteroide2 = new Asteroides();
            asteroide2.Tamanho = 2;
            asteroide2.PosicaoX = 1;
            asteroide2.PosicaoY = 1;
            asteroide2.Velocidade = 2;
            asteroide2.Energia = 2;
            lista_asteroides.Add(asteroide2);*/

            for(int i = 0; i < 50; i++)
             {
                 Asteroides asteroide = new Asteroides();
                 asteroide.PosicaoX = random.Next(0,100);
                 asteroide.PosicaoY = random.Next(0, 100);
                 asteroide.Tamanho = random.Next(0, 10);
                 asteroide.Velocidade = random.Next(1,5);
                 asteroide.Energia = random.Next(1,5);
                 lista_asteroides.Add(asteroide);
             }

             foreach(Asteroides i in lista_asteroides)
             {
                 Console.WriteLine("Asteroide");
                 Console.WriteLine(i.PosicaoX + " " + i.PosicaoY + " " + i.Tamanho + " " + i.Velocidade + " " + i.Energia + " ");
             }

        }
    }
}