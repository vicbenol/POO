using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Escaleno:Figura
    {
        public void escaleno()
        { 
                    Perimetro = Num1 + Num2 + Num3;
                    Area = (Num1 * Num4) / 2;
        }
    }
}
