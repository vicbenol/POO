using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Repartidor:Empleado
    {
      public void calcularSueldoR()
        {
            switch (Zona)
            {
                case "1":
                    PagaR = (PedidosEnt * 5) + ((DiaR * SueldoR) + PropinaR);
                    return;

                case "2":
                    PagaR = (PedidosEnt * 2) + ((DiaR * SueldoR) + PropinaR);
                    return;
            }
        }
    }
}
