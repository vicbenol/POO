using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StreamEjemplo3
{
    class ClaseByte
    {
        public void Guardar()
        {
            using (Stream fs = new FileStream("./Archivo.txt", FileMode.Open, FileAccess.Read))
            {

                long quantity = fs.Length;
                Console.WriteLine($"Se almacenaron {quantity} espacios de bytes");

                StreamReader sr = new StreamReader(fs);
                string todo = sr.ReadToEnd();
                Console.WriteLine(todo);
                //Muy importante cerrar el Stream
                fs.Close();

                Console.ReadKey();
            }
        }
    }
}
