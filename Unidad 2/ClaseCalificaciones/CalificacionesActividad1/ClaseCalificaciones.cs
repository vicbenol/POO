using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesActividad1
{
    class ClaseCalificaciones
    {
        //Atributos de la clase
        public decimal calificaciones=0, promedio, suma;
        public int aprobados = 0;
        public int reprobados = 0;


        //Metodo de clase
        public void ProcedimientoCal()
        {

            if (calificaciones < 70 && calificaciones > 0)
            {
                reprobados++;
            }
            else
            {
                aprobados++;
            }
            suma += calificaciones;
            promedio = suma / (aprobados + reprobados);
           

        }
        
             
          

    }
}
