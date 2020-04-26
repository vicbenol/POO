using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosDocentes
{
    class ClasePersona
    {
        //Atributos de la clase
        private int  cantAlu, cantMas;
        //Metodo de clase
       
        public int CantAlu
        {
            set
            {
                cantAlu = value;
            }
            get
            {
                return cantAlu;
            }
        }
        public int CantMas
        {
            set
            {
                cantMas = value;
            }
            get
            {
                return cantMas;
            }
        }

    }
}
