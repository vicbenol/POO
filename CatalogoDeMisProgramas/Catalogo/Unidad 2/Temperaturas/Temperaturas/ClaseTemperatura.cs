using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    class ClaseTemperatura
    {
        //Atributos de la clase
        public double farh, centi, num1;
        public string temperatura;
        //Metodo de la clase
        public void ConversionTemperaturas()
        {
            switch (temperatura)
            {
                case "Fahrenheit":
                    centi = (num1 - 32) / 1.8;
                    break;

                case "Centigrados":
                    farh = (num1 * 1.8) + 32;
                    break;


            }
        }
    }
}
