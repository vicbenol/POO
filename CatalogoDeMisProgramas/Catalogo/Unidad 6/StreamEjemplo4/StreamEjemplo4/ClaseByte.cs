using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StreamEjemplo4
{
    class ClaseByte
    {
        public void Guardar()
        {
            using (Stream fs = new FileStream("./Escribirarchivo.txt", FileMode.Create, FileAccess.Write))
            {
                    using(StreamWriter sw= new StreamWriter(fs))
                {
                    sw.WriteLine("Hola, mando este texto desde C#");
                }
            }
            Console.ReadKey();
        }
    }
}
