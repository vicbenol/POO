using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElAlumnoYElMaestro
{
    class ClaseMaestro
    {
        public int Sueldo { get; set; }
        public string MatMas { get; set; }
        
        public string ImprimirMas()
        {
            string cadena;
            cadena = "Materias impartidas:"+ MatMas;
            return cadena;
        }
         
    }
}
