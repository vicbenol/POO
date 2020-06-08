using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Figura
    {
        //Atributos de la clase 
        private double num1, num2, num3, num4, area, perimetro;
        private string figuras, tipos;
        //Metodo de la clase
        public string Tipos
        {
            set
            {
                tipos = value;
            }
            get
            {
                return tipos;
            }
        }
        public string Figuras
        {
            set
            {
                figuras = value;
            }
            get
            {
                return figuras;
            }
        }
        public double Num4
        {
            set
            {
                num4 = value;
            }
            get
            {
                return num4;
            }
        }
        public double Num3
        {
            set
            {
                num3 = value;
            }
            get
            {
                return num3;
            }
        }
        public double Num2
        {
            set
            {
                num2 = value;
            }
            get
            {
                return num2;
            }
        }
        public double Num1
        {
            set
            {
                num1 = value;
            }
            get
            {
                return num1;
            }
        }
        public double Perimetro
        {
            set
            {
                perimetro = value;
            }
            get
            {
                return perimetro;
            }
        }
        public double Area
        {
            set
            {
                area = value;
            }
            get
            {
                return area;
            }
        }
        public Figura()
        {
            Num1 = 0;
            Perimetro = 0;
            Area = 0;
        }

    }
}
