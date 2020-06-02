using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class frmFigGeo : Form
    {
        Figura objfigurin = new Figura();
        Cuadrado objcuadradin = new Cuadrado();
        Escaleno objescalenin = new Escaleno();
        Isosceles objisoscelin = new Isosceles();
        Equilatero objequilaterin = new Equilatero();
        Circulo objcirculin = new Circulo();

        public frmFigGeo()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (cmbFigura.Text)
            {
                case "Cuadrado":
                    objcuadradin.cuadrado();
                    objcuadradin.Num1 = double.Parse(txtMedida.Text.ToString());
                    lblArea2.Text = objcuadradin.Area.ToString();
                    lblPerimetro2.Text = objcuadradin.Perimetro.ToString();
                    break;
                case "Circulo":
                    objcirculin.circulo();
                    objcirculin.Num1 = double.Parse(txtMedida.Text.ToString());
                    lblArea2.Text = objcirculin.Area.ToString();
                    lblPerimetro2.Text = objcirculin.Perimetro.ToString();
                    break;
            }
                    switch (cmbTipo.Text)
                    {
                        case "Escaleno":
                            objescalenin.escaleno();
                            objescalenin.Num1 = double.Parse(txtMedida.Text.ToString());
                            objescalenin.Num2 = double.Parse(txtMedida2.Text.ToString());
                            objescalenin.Num3 = double.Parse(txtMedida3.Text.ToString());
                            objescalenin.Num4 = double.Parse(txtMedida4.Text.ToString());
                            lblArea2.Text = objescalenin.Area.ToString();
                            lblPerimetro2.Text = objescalenin.Perimetro.ToString();
                            break;

                        case "Isosceles":
                            objisoscelin.isosceles();
                            objisoscelin.Num1 = double.Parse(txtMedida.Text.ToString());
                            objisoscelin.Num2 = double.Parse(txtMedida2.Text.ToString());
                            lblArea2.Text = objisoscelin.Area.ToString();
                            lblPerimetro2.Text = objisoscelin.Perimetro.ToString();
                            break;
                        case "Equilatero":
                            objequilaterin.equilatero();
                            objequilaterin.Num1 = double.Parse(txtMedida.Text.ToString());
                            objequilaterin.Num2 = double.Parse(txtMedida2.Text.ToString());
                            objequilaterin.Num3 = double.Parse(txtMedida3.Text.ToString());
                            lblArea2.Text = objequilaterin.Area.ToString();
                            lblPerimetro2.Text = objequilaterin.Perimetro.ToString();
                            break;
                    }            
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFigura.Text)
            {
                case "Cuadrado":
                    txtMedida.Enabled = true;
                    lblMedida.Enabled = true;
                    lblMedida.Text = "Agrega medida";
                    txtMedida2.Enabled = false;
                    txtMedida3.Enabled = false;
                    txtMedida4.Enabled = false;
                    lblMedida2.Enabled = false;
                    lblMedida3.Enabled = false;
                    lblMedida4.Enabled = false;
                    cmbTipo.Enabled = false;
                    break;

                case "Triangulo":
                    cmbTipo.Enabled = true;
                    break;

                case "Circulo":
                    txtMedida.Enabled = true;
                    lblMedida.Enabled = true;
                    lblMedida.Text = "Agrega radio";
                    txtMedida2.Enabled = false;
                    txtMedida3.Enabled = false;
                    txtMedida4.Enabled = false;
                    lblMedida2.Enabled = false;
                    lblMedida3.Enabled = false;
                    lblMedida4.Enabled = false;
                    cmbTipo.Enabled = false;
                    break;
            }

        }

        private void txtMedida2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Escaleno":
                    txtMedida.Enabled = true;
                    txtMedida2.Enabled = true;
                    txtMedida3.Enabled = true;
                    txtMedida4.Enabled = true;
                    lblMedida.Enabled = true;
                    lblMedida2.Enabled = true;
                    lblMedida3.Enabled = true;
                    lblMedida4.Enabled = true;
                    lblMedida.Text = "Agrega base";
                    lblMedida2.Text = "Agrega altura";
                    lblMedida3.Text = "Agrega su lado 1";
                    lblMedida4.Text = "Agrega su lado 2";
                    break;

                case "Isosceles":
                    txtMedida.Enabled = true;
                    lblMedida.Enabled = true;
                    lblMedida2.Enabled = true;
                    txtMedida2.Enabled = true;
                    lblMedida.Text = "Agrega lados";
                    lblMedida2.Text = "Agrega altura";
                    txtMedida4.Enabled = false;
                    txtMedida3.Enabled = false;
                    lblMedida3.Enabled = false;
                    lblMedida4.Enabled = false;
                    break;

                case "Equilatero":
                    txtMedida.Enabled = true;
                    txtMedida2.Enabled = true;
                    txtMedida3.Enabled = true;
                    txtMedida4.Enabled = false;
                    lblMedida.Enabled = true;
                    lblMedida2.Enabled = true;
                    lblMedida3.Enabled = true;
                    lblMedida4.Enabled = false;
                    lblMedida.Text = "Agrega base";
                    lblMedida2.Text = "Agrega altura";
                    lblMedida3.Text = "Agrega los lados";
                    break;
            }
        }
    }
}
