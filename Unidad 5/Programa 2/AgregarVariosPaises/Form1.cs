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

namespace AgregarVariosPaises
{
    public partial class Form1 : Form
    {
        ClasePaises[] Paises;
        int cant;
        int con;
        public Form1()
        {
            InitializeComponent();
            //Aqui desabilitamos los textos que no ocuparemos para escribir
            gpbEmbajada.Enabled = false;
            btnBuscar.Enabled = false;
            txtBuscar.Enabled = false;
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            //Aqui agregamos el contador y validamos la cantidad que agregara por el usuario
            cant = (int)nudCant.Value;
            Paises = new ClasePaises[cant];
            con = 0;
            //En el mismo boton habilitamos unos campos
            nudCant.Enabled = false;
            gpbEmbajada.Enabled = true;


        }  

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            //Entrada de datos
            int Encu = 0;
            //Aqui usamos un for para ver si el pais ingresado existe
            for(int i=0;i<Paises.Length;i++)
            {
                if(txtBuscar.Text==Paises[i].NomPais)
                {
                    txtPais.Text =Paises[i].NomPais;
                    txtHabitantes.Text =Convert.ToString(Paises[i].Habitantes);
                    txtIdioma.Text = Paises[i].Idioma;
                    txtColor1.Text = Paises[i].coloresBand[0];
                    txtColor2.Text = Paises[i].coloresBand[1];
                    txtColor3.Text = Paises[i].coloresBand[2];
                    i = Paises.Length;
                    Encu = 1;

                }
            }
            //Por si no se encuentra se manda un mensaje de error
            if (Encu==0)
            {
                MessageBox.Show("No existe el pais", "Embajada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImprimirDatos()
        {
            //Son para imprimir los datos 
            string DatosPais="";
            for (int i = 0; i < con; i++)
            {
                string datos = Paises[i].ImprimirDatos();
                DatosPais += datos + Environment.NewLine;
            }
            MessageBox.Show(DatosPais);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Estos if son para agregar los datos de los paises en el cual cuenta con el contador para agregar los paises solicitados
           
                if (con < cant)
                {
                    Paises[con] = new ClasePaises();
                    Paises[con].NomPais = txtPais.Text;
                    Paises[con].Habitantes = Convert.ToInt32(txtHabitantes.Text);
                    Paises[con].Idioma = txtIdioma.Text;
                    Paises[con].coloresBand[0] = txtColor1.Text;
                    Paises[con].coloresBand[1] = txtColor2.Text;
                    Paises[con].coloresBand[2] = txtColor3.Text;
                    con++;
                    MessageBox.Show("Guardado correctamente");
                txtPais.Clear();
                txtHabitantes.Clear();
                txtIdioma.Clear();
                txtColor1.Clear();
                txtColor2.Clear();
                txtColor3.Clear();
                    txtPais.Focus();
                }
                //Este if es para cuando alla llegado a su limite se activan varias cosas y te manda un aviso
                if (con == cant)
                {
                    cant = 0;
                    MessageBox.Show("Se guardaron todos los paises");
                txtPais.Clear();
                txtHabitantes.Clear();
                txtIdioma.Clear();
                txtColor1.Clear();
                txtColor2.Clear();
                txtColor3.Clear();
                txtPais.Focus();
                btnBuscar.Enabled = true;
                txtBuscar.Enabled = true;
                }
            
        }
    }
}
