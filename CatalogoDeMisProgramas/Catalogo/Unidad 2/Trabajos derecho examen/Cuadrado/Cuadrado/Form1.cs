using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrado
{
    public partial class Form1 : Form
    {
        ClaseCuadrado objcuadrado = new ClaseCuadrado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            objcuadrado.num = int.Parse(txtMedida.Text.ToString());
            objcuadrado.Procedimientocuadrado();
            lblPerimetro2.Text = objcuadrado.per.ToString();
            lblArea2.Text = objcuadrado.area.ToString();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMedida.Clear();
            
        }
    }
}
