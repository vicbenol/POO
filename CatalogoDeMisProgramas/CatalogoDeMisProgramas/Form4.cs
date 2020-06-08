using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CatalogoDeMisProgramas
{
    public partial class Frm32 : Form
    {
        public Frm32()
        {
            InitializeComponent();
        }

        private void btnCasDeCob_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Trabajos derecho examen\CasetaDeCobro\CasetaDeCobro\bin\Debug\CasetaDeCobro.exe");
        }

        private void btnCFEDerExa_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Trabajos derecho examen\CFE\CFE\bin\Debug\CFE.exe");
        }

        private void btnCuaDer_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Trabajos derecho examen\Cuadrado\Cuadrado\bin\Debug\Cuadrado.exe");
        }

        private void btnMayEdadDer_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Trabajos derecho examen\MayorDeEdad\MayorDeEdad\bin\Debug\MayorDeEdad.exe");
        }

        private void btnTemDer_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Trabajos derecho examen\Temperaturas\Temperaturas\bin\Debug\Temperaturas.exe");
        }

        private void btnVacDer_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Trabajos derecho examen\Vacaciones\Vacaciones\bin\Debug\Vacaciones.exe");
        }

        private void btnRegUni2_Click(object sender, EventArgs e)
        {
            FrmUnidad2y3 Formulario2y3 = new FrmUnidad2y3();
            Formulario2y3.Show();
            this.Hide();
        }
    }
}
