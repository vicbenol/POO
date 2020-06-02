using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesEjercicio1
{
    public partial class Form1 : Form
    {
        Sumar objsuma = new Sumar();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objsuma.num = double.Parse(txtNum1.Text.ToString());
            objsuma.num2 = double.Parse(txtNum2.Text.ToString());
            objsuma.ProcedimientoSumar();
            lblResultado.Text = objsuma.res.ToString();
        }
    }
}
