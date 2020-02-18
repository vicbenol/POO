using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionesActividad1
{
    
    public partial class Form1 : Form
    {
        ClaseCalificaciones objcalificaciones = new ClaseCalificaciones();

        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void btt1Cap_Click(object sender, EventArgs e)
        {
            objcalificaciones.calificaciones = int.Parse(txtCalificacion.Text.ToString());
            objcalificaciones.ProcedimientoCal();
            txtCalificacion.Clear();
        }

        private void txt1cal_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAlumagregados_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void lblCalificaciones_Click(object sender, EventArgs e)
        {

        }

        private void lblAprobados_Click(object sender, EventArgs e)
        {

        }

        private void txtAlumnos_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void lblAprobados2_Click(object sender, EventArgs e)
        {

        }

        private void lblReprobados2_Click(object sender, EventArgs e)
        {

        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            lblAprobados2.Text =objcalificaciones.aprobados.ToString();
            lblReprobados2.Text =objcalificaciones.reprobados.ToString();
            lblPromedio2.Text =objcalificaciones.promedio.ToString();
        }
    }
}
