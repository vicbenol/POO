using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Cajera:Empleado
    {
        public void calcularSueldoC()
        {
            switch (NumCaja)
            {
                case "1":
                    PagaC = (SueldoC * DiaC) + ((SueldoC * DiaC) * .03);
                    break;
                case "2":
                    PagaC = (SueldoC * DiaC);
                    break;
            }

            
        }
    }
}
