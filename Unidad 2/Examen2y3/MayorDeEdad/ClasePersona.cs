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
        public int anioAc = 0, anioNac = 0, mesAc = 0, mesNac = 0, diaAc = 0, diaNac = 0;
        public string Mayor;
        //Metodo de la clase 
        public void mayorEdad()
        {
            if (anioAc - anioNac > 18) 
            {
                Mayor = "Es mayor de edad";
            }
            else if (anioAc - anioNac == 18)
                if (mesAc > mesNac)
                {
                    Mayor = "Es mayor de edad";
                }
            else if (mesAc == mesNac)
                    if (diaAc >= diaNac)
                    {
                        Mayor = "Es mayor de edad";
                    }                                                   
        }
    }
}
