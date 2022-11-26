using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_.Net_Lista9_Q3
{
    public class Figurinhas
    {
        public string CodigoFigurinha { get; set; }
        public string Selecao { get; set; }
        public string NomeJogador { get; set; }

        public Figurinhas(string codigo, string selecao, string jogador)
        {
            CodigoFigurinha = codigo;
            Selecao = selecao;
            NomeJogador = jogador;
        }
    }
}
