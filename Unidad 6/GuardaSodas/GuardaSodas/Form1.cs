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

namespace GuardaSodas
{
    public partial class Form1 : Form
    {
        ClaseSodas objsodas = new ClaseSodas();
        ClaseSodas[] Sodas2;
        TextWriter archivosodas;
        int Con;
        int Can;
        int Num;
        int Num2;
        int Num3;

        public Form1()
        {
            InitializeComponent();
            //Inabilitamos algunos algunas cosas
            gpbDatos.Enabled = false;
            gpbVenta.Enabled = false;
            btnComprar.Enabled = false;
            btnElegir.Enabled = false;
        }

        private void btnAgreRef_Click(object sender, EventArgs e)
        {
            //En este espacio le damos valor a la cantidad de marcas que quiere agregar el usuario
            //Tambien habilitamos un groupbox
            Can = (int)nudCanRef.Value;
            Sodas2 = new ClaseSodas[Can];
            Con = 0;
            Num = 0;
            gpbDatos.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Codigo para el error provider
            if (txtMarca.Text == "")
            {
                errorProvider1.SetError(txtMarca, "Agrega la marca del refresco");
                txtMarca.Focus();
                return;
            }
            if (txtTamano1.Text == "")
            {
                errorProvider1.SetError(txtTamano1, "Agrega el tamaño y si no quiere agregar ponga (No hay)");
                txtTamano1.Focus();
                return;
            }
            if (txtTamano2.Text == "")
            {
                errorProvider1.SetError(txtTamano2, "Agrega el tamaño y si no quiere agregar ponga (No hay)");
                txtTamano2.Focus();
                return;
            }
            if (txtTamano3.Text == "")
            {
                errorProvider1.SetError(txtTamano3, "Agrega el tamaño y si no quiere agregar ponga (No hay)");
                txtTamano3.Focus();
                return;
            }
            int Precio;
            if (!int.TryParse(txtPrecio1.Text, out Precio))
            {
                errorProvider1.SetError(txtPrecio1, "Debes ingresar el precio o su no contiene un 0");
                txtPrecio1.Focus();
                return;
            }
            int Precio2;
            if (!int.TryParse(txtPrecio2.Text, out Precio2))
            {
                errorProvider1.SetError(txtPrecio2, "Debes ingresar el precio o su no contiene un 0");
                txtPrecio2.Focus();
                return;
            }
            int Precio3;
            if (!int.TryParse(txtPrecio3.Text, out Precio3))
            {
                errorProvider1.SetError(txtPrecio3, "Debes ingresar el precio");
                txtPrecio3.Focus();
                return;
            }
            //Se almacenan los datos agrregados por el usuario
            if (Con < Can)
            {
                Sodas2[Con]= new ClaseSodas();
                Sodas2[Con].Marca = txtMarca.Text;

                Sodas2[Con].Tamano[0] = txtTamano1.Text;
                Sodas2[Con].Tamano[1] = txtTamano2.Text;
                Sodas2[Con].Tamano[2] = txtTamano3.Text;

                Sodas2[Con].Precio[0] = Convert.ToInt32(txtPrecio1.Text);
                Sodas2[Con].Precio[1] = Convert.ToInt32(txtPrecio2.Text);
                Sodas2[Con].Precio[2] = Convert.ToInt32(txtPrecio3.Text);

                Sodas2[Con].Cant[0] = (int)nudCanTam1.Value;
                Sodas2[Con].Cant[1] = (int)nudCanTam2.Value;
                Sodas2[Con].Cant[2] = (int)nudCanTam3.Value;
                Con++;
                MessageBox.Show("Se guardo correctamente");
                txtMarca.Clear();
                txtPrecio1.Clear();
                txtPrecio2.Clear();
                txtPrecio3.Clear();
                txtTamano1.Clear();
                txtTamano2.Clear();
                txtTamano3.Clear();
                nudCanTam1.Value = 0;
                nudCanTam2.Value = 0;
                nudCanTam3.Value = 0;
            }
            //Cuando se allan guardado todos los datos mandara un mensaje y se habilitara el otro groupbox
            if(Con==Can)
            {
                Can = 0;
                MessageBox.Show("Se guardaron todos los datos");
                gpbVenta.Enabled = true;
                gpbDatos.Enabled = false;

            }
            archivosodas.Write(objsodas.ImprimirSoda());
            archivosodas.Close();
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Este codigo es para que cuando el usuario busque su bebida le aparezcan todos los datos de ella 
            int encu = 0;

            for (int p = 0; p < Sodas2.Length; p++)
            {
                if(txtBuscarSoda.Text==Sodas2[p].Marca)
                {
                    txtBusMar.Text = Sodas2[p].Marca;
                    txtBusPre1.Text = Convert.ToString(Sodas2[p].Precio[0]);
                    txtBusPre2.Text= Convert.ToString(Sodas2[p].Precio[1]);
                    txtBusPre3.Text= Convert.ToString(Sodas2[p].Precio[2]);
                    txtBusTam1.Text = Convert.ToString(Sodas2[p].Tamano[0]);
                    txtBusTam2.Text = Convert.ToString(Sodas2[p].Tamano[1]);
                    txtBusTam3.Text = Convert.ToString(Sodas2[p].Tamano[2]);
                    txtCanDis1.Text = Convert.ToString(Sodas2[p].Cant[0]);
                    txtCanDis2.Text = Convert.ToString(Sodas2[p].Cant[1]);
                    txtCanDis3.Text= Convert.ToString(Sodas2[p].Cant[2]);
                    p = Sodas2.Length;
                    encu = 1;
                }
            }
            if(encu==0)
            {
                MessageBox.Show("Este producto no esta disponible", "Cafeteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnComprar.Enabled = true;
            btnElegir.Enabled = true;
            btnBuscar.Enabled = false;
            txtBuscarSoda.Enabled = false;
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            //Este boton es por si quiere comprar otra bebida
            btnBuscar.Enabled = true;
            txtBuscarSoda.Enabled = true;
            txtBuscarSoda.Clear();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Este boton es para cuando el usuario compre un articulo se dismiuyala cantidad de bebidas 
            int Cantidad;
            int Stock;
            int Cantidad2;
            int Stock2;
            int Cantidad3;
            int Stock3;
            btnBuscar.Enabled = true;
            Cantidad = (int)nudBusCan1.Value;
            Stock = Convert.ToInt32(txtCanDis1.Text);
            Cantidad2 = (int)nudBusCan2.Value;
            Stock2 = Convert.ToInt32(txtCanDis2.Text);
            Cantidad3 = (int)nudBusCan3.Value;
            Stock3 = Convert.ToInt32(txtCanDis3.Text);
            
                if (Cantidad <= Stock)
                {
                   Sodas2[Num].Cant[0] = Stock - Cantidad;
                    Num++;
                }
                else
            {
                MessageBox.Show("No hay suficiente refresco tamano 1", "Cafeteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                if(Cantidad2<=Stock2)
            {
                Sodas2[Num2].Cant[1] = Stock2 - Cantidad2;
                Num2++;
            }
            else
            {
                MessageBox.Show("No hay suficiente refresco tamano 2", "Cafeteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                if(Cantidad3<=Stock3)
            {
                Sodas2[Num3].Cant[2] = Stock3 - Cantidad3;
                Num3++;
            }
            else
            {
                MessageBox.Show("No hay suficiente refresco tamano 3", "Cafeteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Su compra fue establecida actualice datos en el boton (Buscar)", "Cafeteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nudBusCan1.Value = 0;
            nudBusCan2.Value = 0;
            nudBusCan3.Value = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            archivosodas = new StreamWriter("archivoSoda.txt");
        }
    }
}
