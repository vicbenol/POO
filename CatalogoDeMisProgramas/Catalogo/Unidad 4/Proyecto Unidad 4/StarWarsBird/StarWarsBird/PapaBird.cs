using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsBird
{
    class PapaBird
    {
        //Atributos de las clases
        private int contadorMovimientos, distancia, jugador;
        private bool volar = false;
        private string puntaje;

        //Metodos de las clases
        public string Puntaje
        {
            set
            {
                puntaje = value;
            }
            get
            {
                return puntaje;
            }
        }
        public int Jugador
        {
            set
            {
                jugador = value;
            }
            get
            {
                return jugador;
            }
        }
        public int ContadorMovimientos
        {
            set
            {
                contadorMovimientos = value;
            }
            get
            {
                return contadorMovimientos;
            }
        }
        public int Distancia
        {
            set
            {
                distancia = value;
            }
            get
            {
                return distancia;
            }
        }
        public bool Volar
        {
            set
            {
                volar = value;
            }
            get
            {
                return volar;
            }
        }
        
        public PapaBird()
        {
            ContadorMovimientos = 1;
        }
    }
}
