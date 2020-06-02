using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasetaDeCobro
{
    public partial class Form1 : Form
    {
        ClaseVehiculo objCaseta = new ClaseVehiculo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            objCaseta.vehiculo = cmbVehiculos.Text.ToString();
            objCaseta.SacarPrecio();
            lblPrecio2.Text = objCaseta.precio.ToString();
        }
    }
}
