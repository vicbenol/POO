using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFE
{
    public partial class Form1 : Form
    {
        ClaseRecibo objrecibo = new ClaseRecibo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            objrecibo.lugar = cmbLugar.Text.ToString();
            objrecibo.kw =int.Parse(txtkilo.Text.ToString());
            objrecibo.ReciboLuz();
            lblDinero.Text = objrecibo.dine.ToString();
        }
    }
}
