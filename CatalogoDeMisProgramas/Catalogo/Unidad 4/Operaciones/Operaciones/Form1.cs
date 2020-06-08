using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        Operaciones objoperacion = new Operaciones();
        Suma objsumar = new Suma();
        Resta objrestar = new Resta();
        Multiplicacion objmultiplicar = new Multiplicacion();
        Division objdividir = new Division();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void cmbSignos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (cmbSignos.Text)
            {
                case "+":
                    objsumar.Sumar();
                    objsumar.Num1 = float.Parse(txtNum1.Text.ToString());
                    objsumar.Num2 = float.Parse(txtNum2.Text.ToString());
                    lblResultado.Text = objsumar.Resul.ToString();
                    break;

                case "-":
                    objrestar.Restar();
                    objrestar.Num1 = float.Parse(txtNum1.Text.ToString());
                    objrestar.Num2 = float.Parse(txtNum2.Text.ToString());
                    lblResultado.Text = objrestar.Resul.ToString();
                    break;

                case "*":
                    objmultiplicar.Multiplicar();
                    objmultiplicar.Num1 = float.Parse(txtNum1.Text.ToString());
                    objmultiplicar.Num2 = float.Parse(txtNum2.Text.ToString());
                    lblResultado.Text = objmultiplicar.Resul.ToString();
                    break;

                case "/":
                    objdividir.Dividir();
                    objdividir.Num1 = float.Parse(txtNum1.Text.ToString());
                    objdividir.Num2 = float.Parse(txtNum2.Text.ToString());
                    lblResultado.Text = objdividir.Resul.ToString();
                    break;
            }
        }
    }
}
