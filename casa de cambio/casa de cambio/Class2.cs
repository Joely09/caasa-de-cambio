using System;
using System.Collections.Generic;
using System.Text;

namespace casa_de_cambio
{
    class Modelo
    {
        
        private double resultado;
        public double Resultado
        {
            get { return this.resultado; }
            set { this.resultado = value; }
        }
       
        public void bolivaresadolares (double bs,int de)
        {
            if (de == 1)
            {
                 this.resultado= bs / 4125598.38;

            }
            else 
            {
                this.resultado= bs * 4125598.38;

            }
           
        }
        public double bolivaresapeso(double bs,int de)
        {
            if (de == 1)
            {
                return bs / 1072.85;

            }
            else
            {
                return bs * 1072.85;

            }

        }
        public double bolivaresasoles(double bs,int de)
        {
            if (de == 1)
            {
                return bs / 1013260.85;

            }
            else
            {
                return bs * 1013260.85;

            }

        }
    }
}
