using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDePersonas
{
    public partial class Concierto : Form
    {
        ClasePersonas objclasePersonas = new ClasePersonas();
        public Concierto()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            objclasePersonas.persona = cmbPersonas.Text.ToString();
            objclasePersonas.num = int.Parse(cmbCantidad.Text.ToString());
            objclasePersonas.num2 = int.Parse(cmbCantidad.Text.ToString());
            objclasePersonas.num3 = int.Parse(cmbCantidad.Text.ToString());
            objclasePersonas.num4 = int.Parse (cmbCantidad.Text.ToString());
            objclasePersonas.RegistroPersonas();
            cmbPersonas.Text = "";
            cmbCantidad.Text = "";

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            lblBebes2.Text = objclasePersonas.bebe.ToString();
            lblNiños2.Text = objclasePersonas.niños.ToString();
            lblAdultos2.Text = objclasePersonas.adulto.ToString();
            lblTercera2.Text = objclasePersonas.tercera.ToString();

        }

        private void Concierto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
