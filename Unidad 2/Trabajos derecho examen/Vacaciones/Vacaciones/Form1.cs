using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacaciones
{
    public partial class Form1 : Form
    {
        ClaseEmpleado objvacaciones = new ClaseEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objvacaciones.anios = int.Parse(txtAnios.Text.ToString());
            objvacaciones.DiasVacaciones();
            lblDias.Text = objvacaciones.vaca.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
