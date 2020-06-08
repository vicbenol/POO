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
    public partial class FrmUnidad4 : Form
    {
        public FrmUnidad4()
        {
            InitializeComponent();
        }

        private void btnEjeInt_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 4\InterfacesEjercicio1\InterfacesEjercicio1\bin\Debug\InterfacesEjercicio1.exe");
        }

        private void btnEmpRes_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 4\EmpleadosRestaurante\EmpleadosRestaurante\bin\Debug\EmpleadosRestaurante.exe");
        }

        private void btnFigGeo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 4\FigurasGeometricas1y2\FigurasGeometricas\bin\Debug\FigurasGeometricas.exe");
        }

        private void btnOpera_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 4\Operaciones\Operaciones\bin\Debug\Operaciones.exe");
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\Unidad 4\Proyecto Unidad 4\StarWarsBird\StarWarsBird\bin\Debug\StarWarsBird.exe");
        }

        private void btnRegUni4_Click(object sender, EventArgs e)
        {
            FrmCatalogo FormuCata = new FrmCatalogo();
            FormuCata.Show();
            this.Close();
        }
    }
}
