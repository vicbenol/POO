using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFE
{
    class ClaseRecibo
    {
        //Atributo de la clase
        public double kw, dine;
        public string lugar;
        //Procedimiento de la clase
        public void ReciboLuz()
        {
            switch (lugar)
            {
                case "Casa":
                    if (kw>=0 && kw<=250)
                    {
                        dine = kw * 0.65;
                    }
                    else
                        if (kw>=251 && kw<=500)
                    {
                        dine = kw * 0.85;
                    }
                    else
                        if (kw>=501 && kw<=1200)
                    {
                        dine = kw * 1.5;
                    }
                    else
                        if (kw>=1201 && kw<=2100)
                    {
                        dine = kw * 2.5;
                    }
                    else
                        if (kw>=2101)
                    {
                        dine = kw * 3;
                    }
                    break;

                case "Negocio":
                    if (kw>=0)
                    {
                        dine = kw * 5;
                    }
                    break;

            }
               
        }
    }
}
