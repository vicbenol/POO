using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorDeEdad
{
    public partial class Form1 : Form
    {
        ClasePersona objedad = new ClasePersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            objedad.anioAc = int.Parse(DateTime.Today.Year.ToString());
            objedad.mesAc = int.Parse(DateTime.Today.Month.ToString());
            objedad.diaAc = int.Parse(DateTime.Today.Day.ToString());
            objedad.anioNac = int.Parse(dtpNacimiento.Value.Year.ToString());
            objedad.mesNac = int.Parse(dtpNacimiento.Value.Month.ToString());
            objedad.diaNac = int.Parse(dtpNacimiento.Value.Day.ToString());
            objedad.mayorEdad();
            lblEdad.Text = objedad.Mayor;
            objedad.Mayor = "";
        }
    }
}
