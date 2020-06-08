using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeEdad
{
    class ClasePersona
    {
        //Atributos de la clase
        public string contarMayores;
        public int aniosAc = 0, mesAc = 0, diaAc = 0;
        public int anioNac=0, mesNac = 0, diaNac = 0;
        //Metodos de la clase 
        public void mayorEdad()
        {
            if (aniosAc - anioNac > 18)
            {
                contarMayores = "Es mayor de edad";
            }
            else if (aniosAc - anioNac == 18)
                if (mesAc > mesNac)
            {
                contarMayores = "Es mayor de edad";
            }
            else if (mesAc == mesNac )
                if (diaAc > diaNac)
            {
                contarMayores = "Es mayor de edad";
            }
            else if (diaAc == diaNac)
                    {
                        contarMayores = "Es mayor de edad";
                    }
        }
    }
}
