using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlumnosDocentes
{
    public partial class Form1 : Form
    {
        ClasePersona objpersona = new ClasePersona();
        ClaseAlumno objalumno = new ClaseAlumno();
        ClaseMaestro objmaestro = new ClaseMaestro();
        TextWriter archivoalum;
        TextWriter archivomas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //Estos codigosson para desabilitar los botones de imprimir
            btnImprimir.Enabled = false;
            btnImprimir2.Enabled = false;
            archivoalum = new StreamWriter("archivosAlumnos");
            archivomas = new StreamWriter("archivoMaestros");
        }

        private void btnAgregarAlu_Click(object sender, EventArgs e)
        {
            //Agregamos primeramente la cantidad de alumnos
            objalumno.CantAlu = Convert.ToInt32(txtCantAlu.Text);
            //Aqui inciamos nuestra matriz 
            objalumno.nomAlu = new string[objalumno.CantAlu, 9];
            //Este es para agregar y guardar los datos del alumno.
            for (int i = 0; i < objalumno.CantAlu; i++)
            {
                objalumno.nomAlu[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Nombre" + (i + 1), "ITSN");
                objalumno.nomAlu[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Nacimiento" + (i + 1), "ITSN");
                objalumno.nomAlu[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Curp" + (i + 1), "ITSN");
                objalumno.nomAlu[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Telefono" + (i + 1), "ITSN");
                objalumno.nomAlu[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Email" + (i + 1), "ITSN");
                objalumno.nomAlu[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("No. de control" + (i + 1), "ITSN");
                objalumno.nomAlu[i, 6] = Microsoft.VisualBasic.Interaction.InputBox("Carrera" + (i + 1), "ITSN");
                objalumno.nomAlu[i, 7] = Microsoft.VisualBasic.Interaction.InputBox("Cuantas materias cursas" + (i + 1), "ITSN");
                objalumno.nomAlu[i, 8] = Microsoft.VisualBasic.Interaction.InputBox("Promedio" + (i + 1), "ITSN");
            }
            //Este boton es para imprimir todos los datos que agregaste

            btnImprimir.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Este es para imprimir los datos de los alumnos agregados
            for (int i = 0; i < objalumno.CantAlu; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dtgAlumno);
                fila.Cells[0].Value = objalumno.nomAlu[i, 0];
                fila.Cells[1].Value = objalumno.nomAlu[i, 1];
                fila.Cells[2].Value = objalumno.nomAlu[i, 2];
                fila.Cells[3].Value = objalumno.nomAlu[i, 3];
                fila.Cells[4].Value = objalumno.nomAlu[i, 4];
                fila.Cells[5].Value = objalumno.nomAlu[i, 5];
                fila.Cells[6].Value = objalumno.nomAlu[i, 6];
                fila.Cells[7].Value = objalumno.nomAlu[i, 7];
                fila.Cells[8].Value = objalumno.nomAlu[i, 8];


                dtgAlumno.Rows.Add(fila);
                archivoalum.Write(objalumno.Alumno());
                archivoalum.Close();
            }
        }

        private void dtgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregsrMas_Click(object sender, EventArgs e)
        {
            //Agregamos primeramente la cantidad de maestros
            objmaestro.CantMas = Convert.ToInt32(txtAgrMas.Text);
            //Aqui inciamos nuestra matriz 
            objmaestro.nomMas = new string[objmaestro.CantMas, 8];
            //Este es para agregar y guardar los datos del maestro.
            for (int i = 0; i < objmaestro.CantMas; i++)
            {
                objmaestro.nomMas[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Nombre" + (i + 1), "ITSN");
                objmaestro.nomMas[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Nacimiento" + (i + 1), "ITSN");
                objmaestro.nomMas[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Curp" + (i + 1), "ITSN");
                objmaestro.nomMas[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Telefono" + (i + 1), "ITSN");
                objmaestro.nomMas[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Email" + (i + 1), "ITSN");
                objmaestro.nomMas[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("No. de maestro" + (i + 1), "ITSN");
                objmaestro.nomMas[i, 6] = Microsoft.VisualBasic.Interaction.InputBox("Sueldo" + (i + 1), "ITSN");
                objmaestro.nomMas[i, 7] = Microsoft.VisualBasic.Interaction.InputBox("Cuantas materias imparte" + (i + 1), "ITSN");
            }
            //Este es para activar el boton elque imprimira todos los datos 
            btnImprimir2.Enabled = true;
        }

        private void btnImprimir2_Click(object sender, EventArgs e)
        {
            //Este es para imprimir los datos de los alumnos agregados cada maestro en diferente columna.
            for (int i = 0; i < objmaestro.CantMas; i++)
            {
                DataGridViewRow fila2 = new DataGridViewRow();
                fila2.CreateCells(dtgMaestro);
                fila2.Cells[0].Value = objmaestro.nomMas[i, 0];
                fila2.Cells[1].Value = objmaestro.nomMas[i, 1];
                fila2.Cells[2].Value = objmaestro.nomMas[i, 2];
                fila2.Cells[3].Value = objmaestro.nomMas[i, 3];
                fila2.Cells[4].Value = objmaestro.nomMas[i, 4];
                fila2.Cells[5].Value = objmaestro.nomMas[i, 5];
                fila2.Cells[6].Value = objmaestro.nomMas[i, 6];
                fila2.Cells[7].Value = objmaestro.nomMas[i, 7];

                dtgMaestro.Rows.Add(fila2);
                archivomas.Write(objmaestro.Maestro());
                archivomas.Close();
            }
        }
    }
}
