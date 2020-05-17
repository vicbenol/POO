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

        public ClaseSodas()
        {
            Tamano = new string[3];
            Precio = new int[3];
            Cant = new int[3];
            Venta = new int[3];
        }
    }
}
