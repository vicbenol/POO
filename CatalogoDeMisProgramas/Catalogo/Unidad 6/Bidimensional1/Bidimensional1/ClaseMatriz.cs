using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bidimensional1
{
    class ClaseMatriz
    {
        public void copiar()
        {
            using (Stream fs = new FileStream("./archivomatriz.txt", FileMode.Create, FileAccess.Write))
            {
                int[,] Notas = new int[2, 2];
                Notas[0, 0] = 1;
                Notas[0, 1] = 2;
                Notas[1, 0] = 3;
                Notas[1, 1] = 4;

                int[,] Notas2 =
                {
                {1,2,3,4,5,6,7,8,9,10},
                {11,12,13,14,15,16,17,18,19,20 }
                };
                using (StreamWriter sw = new StreamWriter(fs))
                {    
                    sw.WriteLine("La nota del segundo alumno del grupo es {0}", Notas[0, 1]);
                    sw.WriteLine("La nota del tercer alumno del grupo es {0}", Notas2[0, 2]);
                }
                //Muy importante cerrar el Stream
                fs.Close();
            }
            Console.ReadKey();


        }
    }
}
