using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosDocentes
{
    class ClaseAlumno:ClasePersona
    {
        public string[,] nomAlu;
        public string Alumno()
        {
            string Cadena;
            Cadena = "Datos alumno";
            for(int i=0;i<CantAlu;i++)
            {
                Cadena += "\n Nombre: " + nomAlu[i, 0] + " " +
                    "\n Nacimiento: " + nomAlu[i, 1] + " " +
                    "\nCurp: " + nomAlu[i, 2] + " " +
                    "\nTelefono: " + nomAlu[i, 3] + " " +
                    "\nEmail: " + nomAlu[i, 4] + " " +
                    "\nNo. de control: " + nomAlu[i, 5] + " " +
                    "\n Carrera: " + nomAlu[i, 6] + " " +
                    "\n Cuantas materias cursas: " + nomAlu[i, 7] + " " +
                    "\n Promedio: " + nomAlu[i, 8] + " ";
            }
            return Cadena;
        }
    }
}
