using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StreamEjemplo2
{
    class Clasebyte
    {
        public void Guardar()
        {
            using (Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read))
            {
                long quantity = fs.Length;
                Console.WriteLine($"Si jala me la jalo {quantity} veces");

                for (long con = quantity; con > 0; con--)
                {
                    fs.Seek(-con, SeekOrigin.End);
                    int valor = fs.ReadByte();
                    Console.WriteLine($"Posicion{con}: {(char)valor}");
                }
                //Muy importante cerrarel stream
                fs.Close();

                Console.ReadKey();
            }
        }
    }
}
