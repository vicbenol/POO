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
    public partial class FrmUnidad5 : Form
    {
        public FrmUnidad5()
        {
            InitializeComponent();
        }

        private void btnArrEje1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\ArreglosEjercicio1\ArreglosEjercicio1\bin\Debug\netcoreapp3.1\ArreglosEjercicio1");
        }

        private void btnBidiCon_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\Bidimensional1\Bidimensional1\bin\Debug\netcoreapp3.1\Bidimensional1");
        }

        private void btnBidForm_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\Bidimensional3\Bidimensional3\bin\Debug\Bidimensional3.exe");
        }

        private void btnFutbol_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\EquipoFutbol\EquipoFutbol\bin\Debug\EquipoFutbol.exe");
        }

        private void btnSodas_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\GuardaSodas\GuardaSodas\bin\Debug\GuardaSodas.exe");
        }

        private void btnSumaMat_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\MatrizSumaFCD\MatrizSumaFCD\bin\Debug\MatrizSumaFCD.exe");
        }

        private void btnMayMe_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\NumeroMayorMenor\NumeroMayorMenor\bin\Debug\NumeroMayorMenor.exe");
        }

        private void btnDatPas_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\Programa 1\PaisesDelMundo\bin\Debug\PaisesDelMundo.exe");
        }

        private void btnDatPaises_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\Programa 2\AgregarVariosPaises\bin\Debug\AgregarVariosPaises.exe");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\Programa 3\ElAlumnoYElMaestro\bin\Debug\ElAlumnoYElMaestro.exe");
        }

        private void btnAlumsyMast_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 5\Programa 4\AlumnosDocentes\bin\Debug\AlumnosDocentes.exe");
        }

        private void btnRegUnidad5_Click(object sender, EventArgs e)
        {
            FrmCatalogo FormularioCat = new FrmCatalogo();
            FormularioCat.Show();
            this.Close();
        }
    }
}
