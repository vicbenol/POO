using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Empleado
    {
        //Atributos de la clase
        private double sueldoM, sueldoR, sueldoC, pagaM, pagaR, pagaC, propinaM, propinaR, abonos;
        private int diaM, diaR, diaC, pedidosEnt;
        private string nombre, zona, numcaja;

        //Metodo de las clases
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Zona
        {
            set
            {
                zona = value;
            }
            get
            {
                return zona;
            }
        }
        public double SueldoM
        {
            set
            {
                sueldoM = value;
            }
            get
            {
                return sueldoM;
            }
        }
        public double SueldoR
        {
            set
            {
                sueldoR = value;
            }
            get
            {
                return sueldoR;
            }
        }
        public double SueldoC
        {
            set
            {
                sueldoC = value;
            }
            get
            {
                return sueldoC;
            }
        }
        public double PagaM
        {
            set
            {
                pagaM = value;
            }
            get
            {
                return pagaM;
            }
        }
        public double PagaR
        {
            set
            {
                pagaR = value;
            }
            get
            {
                return pagaR;
            }
        }
        public double PagaC
        {
            set
            {
                pagaC = value;
            }
            get
            {
                return pagaC;
            }
        }
        public double PropinaM
        {
            set
            {
                propinaM = value;
            }
            get
            {
                return propinaM;
            }
        }
        public double PropinaR
        {
            set
            {
                propinaR = value;
            }
            get
            {
                return propinaR;
            }
        }
        public double Abonos
        {
            set
            {
                abonos = value;
            }
            get
            {
                return abonos;
            }
        }
        public string NumCaja
        {
            set
            {
                numcaja = value;
            }
            get
            {
                return numcaja;
            }
        }
        public int DiaM
        {
            set
            {
                diaM = value;
            }
            get
            {
                return diaM;
            }
        }
        public int DiaR
        {
            set
            {
                diaR = value;
            }
            get
            {
                return diaR;
            }
        }
        public int DiaC
        {
            set
            {
                diaC = value;
            }
            get
            {
                return diaC;
            }
        }
        public int PedidosEnt
        {
            set
            {
                pedidosEnt = value;
            }
            get
            {
                return pedidosEnt;
            }
        }
    }
}
