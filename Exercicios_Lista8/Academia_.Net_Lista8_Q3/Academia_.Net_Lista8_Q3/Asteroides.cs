using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_.Net_Lista8_Q3
{
    internal class Asteroides
    {
        private int posicaoX;
        private int posicaoY;
        private int tamanho;
        private int velocidade;
        private int energia;

        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public int Tamanho { get; set; }
        public int Velocidade { get; set; }
        public int Energia { get; set; }

        //CONSTRUTORES
        public Asteroides()
        {

        }
        public Asteroides(int posicaoX, int posicaoY, int tamanho, int velocidade, int energia)
        {
            this.PosicaoX = posicaoX;
            this.PosicaoY = posicaoY;
            this.Tamanho = tamanho;
            this.velocidade = velocidade;
            this.Energia = energia;
        }

        public Asteroides(int posicaoX, int posicaoY)
        {
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;


        }

    }
}
