using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Bidimensional3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Primero agregamos las variables y el arreglo
        int i, j;
        string ConArreglo;
        int[,] ArregloBidi = new int[100, 100];
        TextWriter archivobidi;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtColumnas.Clear();
            txtFilas.Clear();
            ConArreglo = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int filas, columnas;
            filas = Convert.ToInt16(txtFilas.Text);
            columnas = Convert.ToInt16(txtColumnas.Text);

            int[,] ArregloBidi = new int[10, 10];

            for (i=0;i<filas;i++)
            {
                ConArreglo += "\n";
                for(j=0;j<columnas;j++)
                {
                    ArregloBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Ingresa el valor" + i + ", " + j));
                    ConArreglo += ArregloBidi[i, j] + ", ";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            archivobidi = new StreamWriter("archivoBidi.txt");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConArreglo, "Elementos del arreglo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            archivobidi.Write(ConArreglo);
            archivobidi.Close();
        }
    }
}
