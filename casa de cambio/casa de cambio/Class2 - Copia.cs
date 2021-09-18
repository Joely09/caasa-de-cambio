using System;
using System.Collections.Generic;
using System.Text;
using casa_de_cambio;

namespace controlador
{
    class Controlador
    {
        private Vista oDisplay;
        private Modelo omodelo;
        public void Casacambio ()

        { oDisplay = new Vista();
            oDisplay.inicioconsola();
            if (oDisplay.Tipomoneda == 1)
            {
                omodelo = new Modelo();
                omodelo.bolivaresadolares(oDisplay.Cantidadbs, 1);
            }
            if (oDisplay.Tipomoneda == 2)
            {
                omodelo = new Modelo();
                omodelo.bolivaresadolares(oDisplay.Cantidadbs, 1);
            }
            if (oDisplay.Tipomoneda == 3)
            {
                omodelo = new Modelo();
                omodelo.bolivaresadolares(oDisplay.Cantidadbs, 1);
            }
            if (oDisplay.Tipomoneda == 4)
            {
                omodelo = new Modelo();
                omodelo.bolivaresadolares(oDisplay.Cantidadbs, 2);
            }
            if (oDisplay.Tipomoneda == 5)
            {
                omodelo = new Modelo();
                omodelo.bolivaresadolares(oDisplay.Cantidadbs, 2);
            }
            if (oDisplay.Tipomoneda == 6)
            {
                omodelo = new Modelo();
                omodelo.bolivaresadolares(oDisplay.Cantidadbs, 2);
            }
            oDisplay.respuesta(omodelo.Resultado);

        }
    }
}
