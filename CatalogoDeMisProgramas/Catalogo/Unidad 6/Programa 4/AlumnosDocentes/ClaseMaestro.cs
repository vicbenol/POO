using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosDocentes
{
    class ClaseMaestro:ClasePersona
    {
        public string[,] nomMas;
        public string Maestro()
        {
            string Cadenita;
            Cadenita = "Datos maestro";
            for (int m = 0; m < CantMas; m++)
            {
                Cadenita += "\n Nombre: " + nomMas[m, 0] + " " +
                    "\n Nacimiento: " + nomMas[m, 1] + " " +
                    "\n Curp: " + nomMas[m, 2] + " " +
                    "\n Telefono: " + nomMas[m, 3] + " " +
                    "\n Email: " + nomMas[m, 4] + " " +
                    "\n No. de control: " + nomMas[m, 5] + " " +
                    "\n Sueldo: " + nomMas[m, 6] + " " +
                    "\n Materias impartidas: " + nomMas[m, 7] + " ";
            }
            return Cadenita;
        }
    }
}
