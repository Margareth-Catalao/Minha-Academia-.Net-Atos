using System.Security.Permissions;

namespace Academia_.Net._Lista7_Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* 8 - Crie uma classe Televisao e uma classe ControleRemoto que pode controlar 
            o volume e trocar os canais da televisão. O controle de volume permite:
            -aumentar ou diminuir a potência do volume de som em uma unidade de cada vez;
            -aumentar e diminuir o número do canal em uma unidade
            - trocar para um canal indicado;
            -consultar o valor do volume do som do canal selecionado.*/

            Controle_Remoto controle = new Controle_Remoto();

            while (true)
            {
                Console.WriteLine("1 - Liga/Desliga\n2 - Aumenta canal\n3 - Diminui canal\n" +
                "4 - Troca canal\n5 - Aumenta volume\n6 - Diminui volume\n7 - Mostra canal\n" +
                "8 - Mostra volume\n9 - Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        controle.BotaoLigar();
                        break;

                    case 2:
                        controle.SubirCanal();
                        break;

                    case 3:
                        controle.DiminuirCanal();
                        break;

                    case 4:
                        Console.WriteLine("Escolha o canal: ");
                        int canal = int.Parse(Console.ReadLine());  
                        controle.EscolherCanal(canal);
                        break;

                    case 5:
                        controle.AumentarVolume();
                        break;

                    case 6:
                        controle.DiminuirVolume();
                        break;

                    case 7:
                        controle.CanalAtual();
                        break;

                    case 8:
                        controle.VolumeAtual();
                        break;

                    case 9:
                        return;
                        break;  
                        default:
                        break;

                        


                }

            }
        }
    }
}