using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StreamEjemplo
{
    class ClaseByte
    {
        public void Guardar()
        {
            using (Stream fs = new FileStream("./Archivo.txt", FileMode.Open, FileAccess.Read))
            {
                
                long quantity = fs.Length;
                Console.WriteLine($"Se utilizaron los bytes {quantity} veces");
                for (long count = 0; count < quantity; count++)
                {
                    fs.Seek(count, SeekOrigin.Begin);
                    int valor = fs.ReadByte();
                    Console.WriteLine($"Posicion{count}: {(char)valor}");
                }
                //Muy importante cerrar el Stream
                fs.Close();

                Console.ReadKey();
            }
        }
    }
}
