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

namespace EquipoFutbol
{
    public partial class Form1 : Form
    {
        ClaseCampeonato Objcampeon = new ClaseCampeonato();
        TextWriter archivoganador;
        int Mayor;
        string Ganador;
        int Suma;
        public Form1()
        {
            InitializeComponent();
            //Desabilitar los botones.
            btnDatosEquipo.Enabled = false;
            btnGanador.Enabled = false;
        }
        

        private void btnDatosTorneo_Click(object sender, EventArgs e)
        {
            //Este espacio es para atribuuir los datos agregados por el usuario a las variables de nuestra clase 
            Objcampeon.NombreTorneo = txtNomTor.Text;
            Objcampeon.NumEquipos = (int)nudCantEqu.Value;
            Objcampeon.Inicio = dtpIniTorneo.Value;
            Objcampeon.Fin = dtpFinTorneo.Value;
            Objcampeon.PunWin = (int)nudGanadas.Value;
            Objcampeon.PunIgual = (int)nudEmpate.Value;
            Objcampeon.PunLost = (int)nudPerdidas.Value;
            btnDatosEquipo.Enabled = true;
            //cuando le presionas al boton sale este mensaje
            MessageBox.Show(Objcampeon.NombreTorneo, "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDatosEquipo_Click(object sender, EventArgs e)
        {
            // Estos for son para guardar cada dato agregado de los equipos de furbol este es el arreglo bidimensional
            Objcampeon.PunPartido = new string[Objcampeon.NumEquipos, Objcampeon.NumEquipos];
            for (int i = 0; i < Objcampeon.PunPartido.GetLength(0); i++)
            {
                Objcampeon.PunPartido[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Introduce el Nombre del equipo:" + (i + 1));
                for (int t = 1; t < Objcampeon.PunPartido.GetLength(1); t++)
                {
                    Objcampeon.PunPartido[i, t] = Microsoft.VisualBasic.Interaction.InputBox("Introduce el puntaje Obtenido en el partido: " + t);

                }
            }
            Objcampeon.PunFinal = new int[Objcampeon.NumEquipos];
            Objcampeon.CalculcarPunObtenido();
            btnGanador.Enabled = true;
        }

        private void btnGanador_Click(object sender, EventArgs e)
        {
            // el mensaje del equipo ganador del torneo 
            MessageBox.Show(Objcampeon.CalcularGanador(Mayor, Ganador), "Ganador del torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNomTor.Clear();
            archivoganador.Write(Objcampeon.CalcularGanador(Mayor, Ganador));
            archivoganador.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            archivoganador = new StreamWriter("archivoGand.txt");
        }
    }
}
