using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Circulo:Figura
    {
        public void circulo()
        {
            Perimetro = 2 * 3.14159*Num1;
            Area = 3.14159 * Math.Pow (Num1, 2); //Codigo para elevar a la potencia cuadratica
        }
    }
}
