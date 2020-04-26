using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElAlumnoYElMaestro
{
    class ClaseAlumno:ClasePersona
    {
       
        public string Materias { get; set; }
        public string Calificaciones { get; set; }
        public int Cant { get; set; }
        public string[,] MatCal { get; set; }
       
        public string ImprimirAlumno()
        {
            string Cadenita;
            Cadenita = "Materia:" + Materias +"\nCalificaciones"+Calificaciones;
            return Cadenita;
        }
       
       
    }
}
