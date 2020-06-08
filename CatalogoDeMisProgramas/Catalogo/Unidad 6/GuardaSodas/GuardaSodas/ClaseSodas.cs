using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardaSodas
{
    class ClaseSodas
    {
        
        public string Marca { get; set; }
       
        public string [] Tamano { get; set; }
        public int [] Precio { get; set; }
        public int [] Cant { get; set; }
        public int [] Venta { get; set; }
        public int [] Sodas2 { get; set; }

        public ClaseSodas()
        {
            Tamano = new string[3];
            Precio = new int[3];
            Cant = new int[3];
            Venta = new int[3];
        }
        public string ImprimirSoda()
        {
            string Cadena;
            Cadena = "Marca: " + Marca;
            
            for (int t = 0; t < 3; t++) 
            {
                Cadena += "\nTamano: " + Tamano[t] + " ";
            }
            for (int p = 0; p < 3; p++) 
            {
                Cadena += "\nPrecio: " + Precio[p] + " ";
            }
            for (int c = 0; c < 3; c++)
            {
                Cadena += "\n Cantidad: " + Cant[c] + " ";
            }
            return Cadena;
            
        }
    }
}
