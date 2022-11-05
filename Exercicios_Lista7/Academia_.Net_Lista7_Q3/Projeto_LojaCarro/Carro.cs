using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LojaCarro
{
    public class Carro
    {
        public string placa;
        public string modelo;
        public string cor;
      

        //public Carro(string placa, string modelo, string cor, int ano, string marca)
        //{
        //    this.placa = placa;
        //    this.modelo = modelo;
        //    this.cor = cor;
           
        //}

        public string getplaca()
        {
            return placa;
        }
        public void steplaca(string placa)
        {
            this.placa = placa;
        }
        public string getmodelo()
        {
            return modelo;
        }
        public void stemodelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getCor()
        {
            return cor;
        }
        public void steCor(string cor)
        {
            this.cor = cor;
        }
        
        


    }
}
