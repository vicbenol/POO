using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregarVariosPaises
{
    class ClasePaises
    {
        public string NomPais { get; set; }
        public string Idioma { get; set; }
        public int Habitantes { get; set; }
        public string[] coloresBand { get; set; }
        public string Buscar { get; set; }
        //Constructor de la clase 
        public ClasePaises()
        {
            coloresBand = new string[3];
        }
        public string Imprimirdatos()
        {
            string cadena;
            cadena = "Pais:" + NomPais + "\n Habitantes:" + Habitantes + "\nIdioma:" + Idioma + "\n Colores principales de la bandera:";

            for (int i = 0; i < 3; i++)
            {
                cadena += coloresBand[i] + " ";
            }
            return cadena;
        }
    }
}
