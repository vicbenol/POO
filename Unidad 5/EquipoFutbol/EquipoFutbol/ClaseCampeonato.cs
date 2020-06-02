using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoFutbol
{
    class ClaseCampeonato
    {
        public string NombreTorneo { get; set; }
        public int NumEquipos { get; set; }
        public int NumPartidos { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int PunWin { get; set; }
        public int PunLost { get; set; }
        public int PunIgual { get; set; }

        public string[,] PunPartido { get; set; }
        public int[] PunFinal { get; set; }

        public void CalculcarPunObtenido()
        {
            int p = 0;

            for (int i = 0; i < PunPartido.GetLength(0); i++)
            {
                int suma = 0;
                int acum = 0;
                for (int j = 1; j < PunPartido.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(PunPartido[i, j]);
                    acum += suma;
                }
                PunFinal[p] = acum;
                p++;
            }


        }
        public string CalcularGanador(int Mayor, string Ganador)
        {


            int NumeroGanador = 0;
            int f = 0;
            for (int i = 0; i < PunFinal.Length; i++)
            {
                if (PunFinal[i] > Mayor)
                {
                    Mayor = PunFinal[i];
                    NumeroGanador = f;
                }
                f++;
            }
            Ganador = "El equipo Ganador es " + PunPartido[NumeroGanador, 0] + " Con " + Mayor + " puntos";
            return Ganador;
        }
    }
}
