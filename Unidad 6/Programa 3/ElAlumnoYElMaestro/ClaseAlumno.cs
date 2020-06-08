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
        public string[] Mat { get; set; }
        public string [] Cal { get; set; }
       
        public string ImprimirAlumno()
        {
            string Cadenita;
            Cadenita = "Mataerias y calificaciones";
            for (int c = 0; c < Cant; c++)
            {
                Cadenita += "\nCalificacion: " + Cal[c] + " ";
            }
            for (int i = 0; i < Cant; i++)
            {
                Cadenita += "\nMateria: "+ Mat[i] + " ";
            }
            return Cadenita;
        }
        
       
       
    }
}
