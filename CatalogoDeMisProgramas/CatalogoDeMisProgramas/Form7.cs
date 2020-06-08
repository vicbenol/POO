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
    public partial class FrmUnidad6 : Form
    {
        public FrmUnidad6()
        {
            InitializeComponent();
        }

        private void btnArcBidiCon_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\Bidimensional1\Bidimensional1\bin\Debug\netcoreapp3.1\Bidimensional1");
        }

        private void btnArcBidiForm_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\Bidimensional3\Bidimensional3\bin\Debug\Bidimensional3.exe");
        }

        private void btnEquFutArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\EquipoFutbol\EquipoFutbol\bin\Debug\EquipoFutbol.exe");
        }

        private void btnSodArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\GuardaSodas\GuardaSodas\bin\Debug\GuardaSodas.exe");
        }

        private void btnMatArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\MatrizSumaFCD\MatrizSumaFCD\bin\Debug\MatrizSumaFCD.exe");
        }

        private void btnMayMenArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\NumeroMayorMenor\NumeroMayorMenor\bin\Debug\NumeroMayorMenor.exe");
        }

        private void btnDatPaArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\Programa 1\PaisesDelMundo\bin\Debug\PaisesDelMundo.exe");
        }

        private void btnDatPasArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\Programa 2\AgregarVariosPaises\bin\Debug\AgregarVariosPaises.exe");
        }

        private void btnAluMasArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\Programa 3\ElAlumnoYElMaestro\bin\Debug\ElAlumnoYElMaestro.exe");
        }

        private void btnAlumsMassArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\Programa 4\AlumnosDocentes\bin\Debug\AlumnosDocentes.exe");
        }

        private void btnStreArc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\StreamEjemplo\StreamEjemplo\bin\Debug\netcoreapp3.1\StreamEjemplo");
        }

        private void btnStreArc2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\StreamEjemplo2\StreamEjemplo2\bin\Debug\netcoreapp3.1\StreamEjemplo2");
        }

        private void btnStreArc3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\StreamEjemplo3\StreamEjemplo3\bin\Debug\netcoreapp3.1\StreamEjemplo3");
        }

        private void btnStreArc4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 6\StreamEjemplo4\StreamEjemplo4\bin\Debug\netcoreapp3.1\StreamEjemplo4");
        }

        private void btnRegUni6_Click(object sender, EventArgs e)
        {
            FrmCatalogo FormularioCat = new FrmCatalogo();
            FormularioCat.Show();
            this.Close();
        }
    }
}
