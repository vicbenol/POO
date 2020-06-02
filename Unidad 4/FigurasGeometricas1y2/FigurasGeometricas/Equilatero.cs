using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Equilatero:Figura
    {
        public void equilatero()
        {
            Perimetro = (Num2 * 2) + Num1;
            Area = (Num1 + Num3) / 2;
        }
    }
}
