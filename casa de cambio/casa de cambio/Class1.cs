using System;
using System.Collections.Generic;
using System.Text;

namespace casa_de_cambio
{
    class Vista
    {
        private double cantidadbs;
        private int tipomoneda;
        public double Cantidadbs
        {
            get { return this.cantidadbs; }
            set { this.cantidadbs = value; }
        }
        public int Tipomoneda
        {
            get { return this.tipomoneda; }
            set { this.tipomoneda = value; }
        }
        public void inicioconsola()
        {
            Console.WriteLine("casa de cambio\n");
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("ingrese la moneda a cambiar\n");
            Console.WriteLine("\t1 - dolar/bolivares\n");
            Console.WriteLine("\t2 - peso colombiano/bolivares\n");
            Console.WriteLine("\t3 - soles/bolivares\n");
            Console.WriteLine("\t4 - bolivares/otra moneda\n");
            Console.WriteLine("su opcion es: \n");
            switch (Console.ReadLine())
            {
                case "1":
                    this.tipomoneda = 4;
                    break;
                case "2":
                    this.tipomoneda = 5;
                    break;
                case "3":
                    this.tipomoneda = 6;
                    break;
                case "4":
                    this.tipomoneda = 0;
                    break;
            }
            Console.WriteLine("ingrese la cantidad a cambiar: \n");
            this.cantidadbs = Convert.ToDouble(Console.ReadLine());
            if (this.tipomoneda == 0)
            {
                Console.WriteLine("seleccionar moneda: \n");
                Console.WriteLine("\t1 - dolar\n");
                Console.WriteLine("\t2 - peso colombiano\n");
                Console.WriteLine("\t3 - soles\n");
                Console.WriteLine("su opcion es: \n");

                switch (Console.ReadLine())
                {
                    case "1":
                        this.tipomoneda = 1;
                        break;
                    case "2":
                        this.tipomoneda = 2;
                        break;
                    case "3":
                        this.tipomoneda = 3;
                        break;

                }
            }
            Console.Write("pulse cualquier tecla para cerrar este menu\n");
            Console.ReadKey();
        }
        public void respuesta(double r)
        {
            Console.WriteLine("el tipo de cambio es: {0} ",r);
        }
    }
}
