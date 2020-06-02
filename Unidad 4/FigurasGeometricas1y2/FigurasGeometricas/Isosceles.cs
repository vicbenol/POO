using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Isosceles:Figura
    {
        public void isosceles()
        {
            Perimetro = Num1 * 3;
            Area = (Num1 * Num2) / 2;
        }
    }
}
