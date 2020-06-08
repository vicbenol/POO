using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ElAlumnoYElMaestro
{
    public partial class Form1 : Form
    {
        ClasePersona objPerson;
        ClaseAlumno objalum;
        int Cant;
        ClaseMaestro[] MateriaMas;
        TextWriter archivoAlu;
        TextWriter archivoMas;
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
            objalum = new ClaseAlumno();
            objalum.Cant = (int)nudCanAlu.Value;

            objalum.Mat = new string[objalum.Cant];
            for (int i = 0; i < objalum.Mat.GetLength(0); i++)
            {
                objalum.Mat[i] = Microsoft.VisualBasic.Interaction.InputBox("Materia: " + (i + 1));
            }

            objalum.Cal = new string[objalum.Cant];
            for(int c=0; c<objalum.Cal.GetLength(0);c++)
            {
                objalum.Cal[c] = Microsoft.VisualBasic.Interaction.InputBox("Calificacion: " + (c + 1));
            }
            btnImprimir.Enabled = true;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Este es el que acumula los datos que se imprimiran 
            MessageBox.Show(objalum.ImprimirAlumno(), "Calificacion y materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            archivoAlu.Write(objalum.ImprimirAlumno());
            archivoAlu.Close();
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
            archivoMas.Write(DatosMaestro);
            archivoMas.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            archivoAlu = new StreamWriter("archivoalumno.txt");
            archivoMas = new StreamWriter("archivomaestro.txt");
        }
    }
}
