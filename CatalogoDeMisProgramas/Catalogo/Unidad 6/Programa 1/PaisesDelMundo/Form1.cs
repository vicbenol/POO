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

namespace PaisesDelMundo
{
    public partial class Form1 : Form
    {
        ClasePais objPaises;
        TextWriter archivoPais;
        int con;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            archivoPais = new StreamWriter("archivopais.txt");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objPaises = new ClasePais();

            objPaises.NomPais = txtPais.Text;
            objPaises.Idioma = txtIdioma.Text;
            objPaises.Habitantes = Convert.ToInt32(txtHabitantes.Text);
            objPaises.coloresBand[0] = txtColor1.Text;
            objPaises.coloresBand[1] = txtColor2.Text;
            objPaises.coloresBand[2] = txtColor3.Text;
            //estos if funcionan para saber si el usuario agrego texto alguno si no agrego nada marca error
            //este if es si no agrego ningun pais y le apachurra al boton le marca error y le aviso el porque
            if (txtPais.Text == "") 
            {
                errorProvider1.SetError(txtPais, "Debes ingresar un pais");
                txtPais.Focus();
                return;
            }
            errorProvider1.SetError(txtPais, "");
            // este if es lo mismo que el de arriba solo que este es el del idioma 
            if (txtIdioma.Text == "")
            {
                errorProvider1.SetError(txtIdioma, "Debes ingresar el idioma predominante");
                txtIdioma.Focus();
                return;
            }
            errorProvider1.SetError(txtIdioma, "");
           //Este es el if de los habitantes donde cambio un poco porque aqui es de si no son numeros marca error
            int Habitantes;
            if (!int.TryParse(txtHabitantes.Text, out Habitantes))
            {
                errorProvider1.SetError(txtHabitantes, "Debes ingresar numeros de habitantes");
                txtHabitantes.Focus();
                return;
            }
            errorProvider1.SetError(txtHabitantes, "");
            //Estos tres if que siguen son los de los colores si no agrega ningun texto
            //color 1 
            if (txtColor1.Text == "")
            {
                errorProvider1.SetError(txtColor1, "Debes ingresar un color principal");
                txtPais.Focus();
                return;
            }
            errorProvider1.SetError(txtColor1, "");
            //color 2
            if (txtColor2.Text == "")
            {
                errorProvider1.SetError(txtColor2, "Debes ingresar un color principal");
                txtColor2.Focus();
                return;
            }
            errorProvider1.SetError(txtColor2, "");
            //Color 3
            if (txtColor3.Text == "")
            {
                errorProvider1.SetError(txtColor3, "Debes ingresar un color principal");
                txtColor3.Focus();
                return;
            }
            errorProvider1.SetError(txtColor3, "");
            //Ahora el codigo de como imprimirlos 
            lblImpPais.Text = objPaises.NomPais;
            lblImpHab.Text = objPaises.Habitantes.ToString();
            lblImpIdi.Text = objPaises.Idioma;
            lblImpCol1.Text = objPaises.coloresBand[0];
            lblImpCol2.Text = objPaises.coloresBand[1];
            lblImpCol3.Text = objPaises.coloresBand[2];


           
            //Despues de esto ya que se guarden los datos con estos codigos limpiaremos los espacios
            txtPais.Clear();
            txtHabitantes.Clear();
            txtIdioma.Clear();
            txtColor1.Clear();
            txtColor2.Clear();
            txtColor3.Clear();
            //y le ponemos el focus para que genere el otro
            txtPais.Focus();

            archivoPais.Write(objPaises.Copiar());
            archivoPais.Close();
        }

       
    }
}
