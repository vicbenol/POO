using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraSolucion
{
    public partial class Form1 : Form
    {
        ClasePrimeraSolucion objsuma = new ClasePrimeraSolucion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            objsuma.num = int.Parse(txtNumeros.Text.ToString());
            objsuma.num1 = int.Parse(txtNumero2.Text.ToString());
            objsuma.Sumanumeros();
            lblResultado.Text = objsuma.rel.ToString();
            txtNumeros.Text = "";
            txtNumero2.Text = "";

        }
    }
}
