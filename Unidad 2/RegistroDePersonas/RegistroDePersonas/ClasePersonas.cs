using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDePersonas
{
    class ClasePersonas
    {
        //Atributos de la clase
        public int bebe, niños, adulto, tercera, num, num2, num3, num4;
        public string persona;

        //Metodos de clase
        public void RegistroPersonas()
        {
            switch (persona)
            {
                case "Bebes":
                    bebe +=num;
                    break;

                case "Niños":
                    niños += num2;
                    break;

                case "Adultos":
                    adulto += num3;
                    break;

                case "Tercera Edad":
                    tercera += num4;
                    break;

            }

        }
    } 
}
