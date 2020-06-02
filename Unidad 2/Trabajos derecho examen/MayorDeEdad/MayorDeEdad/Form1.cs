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
    public partial class lblMayor : Form
    {
        ClasePersona objEdad = new ClasePersona();
        public lblMayor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objEdad.aniosAc = int.Parse(DateTime.Today.Year.ToString());
            objEdad.mesAc = int.Parse(DateTime.Today.Month.ToString());
            objEdad.diaAc = int.Parse(DateTime.Today.Day.ToString());
            objEdad.anioNac = int.Parse(dtpFecha.Value.Year.ToString());
            objEdad.mesNac = int.Parse(dtpFecha.Value.Month.ToString());
            objEdad.diaNac = int.Parse(dtpFecha.Value.Day.ToString());
            objEdad.mayorEdad();
            lblEdad.Text = objEdad.contarMayores;
            objEdad.contarMayores = "";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblEdad.Text = "";
        }
    }
}
