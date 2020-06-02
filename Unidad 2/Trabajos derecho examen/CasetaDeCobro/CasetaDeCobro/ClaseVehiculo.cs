using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasetaDeCobro
{
    class ClaseVehiculo
    {
        //Atributos de la clase
        public int precio;
        public string vehiculo;

        //Metodo de la clase
        public void SacarPrecio()
        {
            switch (vehiculo)
            {
                case "Motocicleta":
                    precio = 50;
                    break;

                case "Carro":
                    precio = 112;
                    break;

                case "Autobus":
                    precio = 170;
                    break;

                case "Trailer":
                    precio = 250;
                    break;
            }
        }
    }
}
