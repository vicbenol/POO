﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayorMenor
{
    class ClaseNumeros
    {
        public int Mayor { get; set; }
        public int Menor { get; set; }
        public int [] NumCant { get; set; }
        public int Cant { get; set; }

        public string CalcularMay(int Mayor, string maymer,int Menor)
        {
            int m = 0;
            int NumeroMay = 0;
            int r = 0;
            int NumeroMen = 0;
            for (int i = 0; i < NumCant.GetLength(0); i++)
            {
                if (NumCant[i] > Mayor)
                {
                    Mayor = NumCant[i];
                    NumeroMay = m;
                }
                m++;
                if (NumCant[i] < Menor)
                {
                    Menor = NumCant[i];
                    NumeroMen = r;
                }
                r++;
                
            }
            maymer = "El numero mayor es: " + Mayor+ "\nEl numero menor es: " + Menor;
            return maymer;
        }
       
        
    }
    
}
