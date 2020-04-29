using System;

namespace Bidimensional2
{
    public class Program
    {
       public static void Main()
        {
            int[][] notas;
            notas = new int[3][];
            notas[0] = new int[10];
            notas[1] = new int[15];
            notas[2] = new int[12];

            for (int i=0;i<notas.Length;i++)
            {
                for(int j=0; j<notas[i].Length;j++)
                {
                    notas[i][j] = i + j;
                }
            }
            for (int i=0;i<notas.Length;i++)
            {
                for (int j=0;j<notas[i].Length;j++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
