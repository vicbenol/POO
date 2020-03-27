using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsBird
{
    class NeneBird:PapaBird,InterBird
    {
        public void IniciarJuego()
        {
            Distancia = 0;
            Puntaje = "0";
            Volar = false;
        }
    }
}
