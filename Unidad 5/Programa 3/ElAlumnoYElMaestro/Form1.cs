using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElAlumnoYElMaestro
{
    public partial class Form1 : Form
    {
        ClasePersona objPerson;
        ClaseAlumno[,] MatCal;
        ClaseMaestro[] MateriaMas;
        int Cant;
        public Form1()
        {
            InitializeComponent();
            //Controles deshabilitados de alumnos
            gpbAlumno.Enabled = false;
            gpbMaestro.Enabled = false;
            btnImprimir.Enabled = false;
            //Controles deshabilitados de maestros    
            btnImpMas.Enabled = false;
           

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //Agregamos el contador y validamos la canridad de materias que quiera ingresar el usuario
            Cant = (int)nudCanAlu.Value;
            MatCal = new ClaseAlumno[Cant,2];
            for (int i = 0; i < Cant; i++)
            {
                MatCal[i, 0] = new ClaseAlumno();
                MatCal[i, 1] = new ClaseAlumno();
                MatCal[i, 0].Materias = Microsoft.VisualBasic.Interaction.InputBox("Materia:" + (i + 1));
                MatCal[i, 1].Calificaciones = Microsoft.VisualBasic.Interaction.InputBox("Calificacion:" + (i + 1));
            }
            btnImprimir.Enabled = true;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Este es el que acumula los datos que se imprimiran 
            ImprimirAlumno();
        }
        private void ImprimirAlumno()
        {
            //Aqui juntamos los datos en una sola variable
            string DatosAlumnos = "";
            for (int i = 0; i < Cant; i++)
            {
                string datitos = MatCal[i, 0].ImprimirAlumno();
                DatosAlumnos += datitos + Environment.NewLine;
            }
           //Es donde se imprimiran
            MessageBox.Show(DatosAlumnos);
        }
           
    

        private void btnElegir_Click(object sender, EventArgs e)
        {
            //Esto es para que se habilite el grupo seleccionado
            switch(cmbOcupacion.Text)
            {
                case "Alumno":
                    gpbAlumno.Enabled = true;
                    gpbMaestro.Enabled = false;
                    break;
                case "Maestro":
                    gpbMaestro.Enabled = true;
                    gpbAlumno.Enabled = false;
                    break;
            }
        }

        private void btnConMas_Click(object sender, EventArgs e)
        {
            //Agregamos el contador y validamos la canridad de materias que quiera ingresar el usuario
            Cant = (int)nudMatMas.Value;
            MateriaMas = new ClaseMaestro[Cant];
        
            for (int i = 0; i < Cant; i++)
            {
                MateriaMas[i] = new ClaseMaestro();
                MateriaMas[i].MatMas = Microsoft.VisualBasic.Interaction.InputBox("Materia" + (i + 1));
            }
            btnImpMas.Enabled = true;
        }


        private void btnImpMas_Click(object sender, EventArgs e)
        {
            ImprimirDatos();
        }
        private void ImprimirDatos()
        {
            string DatosMaestro = "";
            for (int i=0;i<Cant;i++)
            {
                string datos = MateriaMas[i].ImprimirMas();
                DatosMaestro += datos + Environment.NewLine;
            }
            MessageBox.Show(DatosMaestro);
        }
    }
}
