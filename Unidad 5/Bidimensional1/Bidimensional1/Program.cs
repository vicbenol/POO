using System;

namespace Bidimensional1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Una matriz de dos columnas y dos filas
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
            Console.WriteLine("La nota del segundo alumno del grupo es {0}", Notas[0, 1]);
            Console.WriteLine("La nota del tercer alumno del grupo es {0}", Notas2[0, 2]);

        }
    }
}
