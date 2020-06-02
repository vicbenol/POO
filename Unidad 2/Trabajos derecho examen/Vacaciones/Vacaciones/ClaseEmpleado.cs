using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacaciones
{
    class ClaseEmpleado
    {
        //Atributos de la clase
        public int anios, vaca;

        //Metodo de la clase
        public void DiasVacaciones()
        {
            if (anios >= 0 && anios <= 5)
            {
                vaca = 5;
            }
            else
                if (anios >= 6 && anios <= 10) 
            {
                vaca = 10;
            }
            else 
                if (anios >=11 && anios <=20)
            {
                vaca = anios;
            }
            else 
                if (anios>=21 && anios<=45)
            {
                vaca = anios + 2;
            }


        }
    }
}
