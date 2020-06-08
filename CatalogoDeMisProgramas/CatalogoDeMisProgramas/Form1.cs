using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoDeMisProgramas
{
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void btnUnidad1_Click(object sender, EventArgs e)
        {
            FrmUnidad1 formulario = new FrmUnidad1();
            formulario.Show();
            this.Hide();
        }

        private void btnUnidad2_Click(object sender, EventArgs e)
        {
            FrmUnidad2y3 formulario2 = new FrmUnidad2y3();
            formulario2.Show();
            this.Hide();
        }

        private void btnUnidad4_Click(object sender, EventArgs e)
        {
            FrmUnidad4 formulario4 = new FrmUnidad4();
            formulario4.Show();
            this.Hide();
        }

        private void btnUnidad5_Click(object sender, EventArgs e)
        {
            FrmUnidad5 formuUnidad5 = new FrmUnidad5();
            formuUnidad5.Show();
            this.Hide();
        }

        private void btnUnidad6_Click(object sender, EventArgs e)
        {
            FrmUnidad6 FormuUnidad6 = new FrmUnidad6();
            FormuUnidad6.Show();
            this.Hide();
        }
    }
}
