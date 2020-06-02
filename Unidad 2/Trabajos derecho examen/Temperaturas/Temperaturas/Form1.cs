using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturas
{
    public partial class Form1 : Form
    {
        ClaseTemperatura objtemperatura = new ClaseTemperatura();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            objtemperatura.temperatura = cmbTemperatura.Text.ToString();
            objtemperatura.num1 =int.Parse (txtGrados.Text.ToString());
            objtemperatura.ConversionTemperaturas();
            lblResultadoF.Text = objtemperatura.farh.ToString();
            lblResultadoC.Text = objtemperatura.centi.ToString();

        }
    }
}
