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
    public partial class FrmUnidad2y3 : Form
    {
        public FrmUnidad2y3()
        {
            InitializeComponent();
        }

        private void btnCasDeCobro_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\CasetaDeCobro\CasetaDeCobro\bin\Debug\CasetaDeCobro.exe");
        }

        private void btnCFE_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\CFE\CFE\bin\Debug\CFE.exe");
        }

        private void btnClaCal_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\ClaseCalificaciones\CalificacionesActividad1\bin\Debug\CalificacionesActividad1.exe");
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Cuadrado\Cuadrado\bin\Debug\Cuadrado.exe");
        }

        private void btnEmbote_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Embotelladora\Embotelladora\bin\Debug\Embotelladora.exe");
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Examen2y3\MayorDeEdad\bin\Debug\MayorDeEdad.exe");
        }

        private void btnFigGeo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\FigurasGeometricas\FigurasGeometricas\bin\Debug\FigurasGeometricas.exe");
        }

        private void btnMayEdad_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\MayorDeEdad\MayorDeEdad\bin\Debug\MayorDeEdad.exe");
        }

        private void btnConcierto_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\RegistroDePersonas\RegistroDePersonas\bin\Debug\RegistroDePersonas.exe");
        }

        private void btnTempe_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Temperaturas\Temperaturas\bin\Debug\Temperaturas.exe");
        }

        private void btnVaca_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 2\Vacaciones\Vacaciones\bin\Debug\Vacaciones.exe");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Frm32 Formulario32 = new Frm32();
            Formulario32.Show();
            this.Hide();
        }

        private void btnRegIni2_Click(object sender, EventArgs e)
        {
            FrmCatalogo FormularioCat = new FrmCatalogo();
            FormularioCat.Show();
            this.Hide();
        }
    }
}
