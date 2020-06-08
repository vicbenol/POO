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
    public partial class FrmUnidad1 : Form
    {
        public FrmUnidad1()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCatalogo frmCat = new FrmCatalogo();
            frmCat.Show();
        }

        private void btnPriSol_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\victo\Desktop\CatalogoDeMisProgramas\Catalogo\MiPrimeraSolucion\MiPrimeraSolucion\bin\Debug\MiPrimeraSolucion.exe");
        }
    }
}
