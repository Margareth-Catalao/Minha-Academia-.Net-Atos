using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_.Net_Lista9_Q3
{
    public class Util
    {
        public static void gravarFigurinhaArquivo(Figurinhas figurinha, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);
            escritor.WriteLine(figurinha.CodigoFigurinha + ";" + figurinha.Selecao + ";" + figurinha.NomeJogador);
            escritor.Flush();
            escritor.Close();

        }

        public static void popularArquivoNaListaFigurinha(List<Figurinhas> lista, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                Figurinhas figurinha;
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);

                do
                {
                    linha = leitor.ReadLine();
                    dadosLinha = linha.Split(":");
                    figurinha = new Figurinhas(dadosLinha[0], dadosLinha[1], dadosLinha[2]);
                    lista.Add(figurinha);
                }while(!leitor.EndOfStream);
                leitor.Close();
            }catch(Exception ex)
            {
                Console.WriteLine("Deu problema no arquivo ou o arquivo esta vazio!");  
            }
        
        }

        public static void mostrarListaFigurinhas(List<Figurinhas>lista, string nomeArquivo, string tipo)
        {
            Console.WriteLine("Lista de figurinhas....." + tipo.ToUpper());
            StreamWriter escritor = new StreamWriter(nomeArquivo);
            foreach(var i in lista)
            {
                Console.WriteLine("Codigo: " + i.CodigoFigurinha + "Selecão: " + i.Selecao + "Jogador: " + i.NomeJogador);
                Console.WriteLine("----------------------------------------------------------------------------");

                escritor.WriteLine("Codigo: " + i.CodigoFigurinha + "Selecão: " + i.Selecao + "Jogador: " + i.NomeJogador);
                escritor.WriteLine("----------------------------------------------------------------------------");

            }
            escritor.Close();
        }

        public static bool jaNaListaDeFigurinhas(Figurinhas figurinha, List<Figurinhas> lista)
        {
            foreach(var i in lista)
            {
                if(figurinha.CodigoFigurinha == i.CodigoFigurinha)
                {
                    return true;//Figurinha licalizada pelo codigo
                }
            }

            return false;
        }
        
        

    }
}
