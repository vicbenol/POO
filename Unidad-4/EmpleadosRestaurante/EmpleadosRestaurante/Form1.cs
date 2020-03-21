using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosRestaurante
{
    public partial class Form1 : Form
    {
        Empleado objchalan = new Empleado();
        Mesero objmese = new Mesero();
        Repartidor objrepa = new Repartidor();
        Cajera objcaje = new Cajera();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcuMese_Click(object sender, EventArgs e)
        {
            objmese.calcularSueldoM();
            objmese.DiaM = int.Parse(cmbDiaMese.Text.ToString());
            objmese.SueldoM = double.Parse(txtSueldoMese.Text.ToString());
            objmese.PropinaM = double.Parse(txtPropinaMese.Text.ToString());
            lblPagaMese.Text = objmese.PagaM.ToString();
        }

        private void btnCalcuRepa_Click(object sender, EventArgs e)
        {
            objrepa.calcularSueldoR();
            objrepa.DiaR = int.Parse(cmbDiasRepa.Text.ToString());
            objrepa.SueldoR = int.Parse(txtSueldoRepaDia.Text.ToString());
            objrepa.PropinaR = int.Parse(txtPropiRepa.Text.ToString());
            objrepa.Zona = cmbZonaRepa.Text.ToString();
            objrepa.PedidosEnt = int.Parse(txtPediRepa.Text.ToString());
            lblPagaRepa.Text = objrepa.PagaR.ToString();
        }

        private void btnCalcuCaja_Click(object sender, EventArgs e)
        {
            objcaje.calcularSueldoC();
            objcaje.DiaC = int.Parse(cmbDiasCaja.Text.ToString());
            objcaje.SueldoC = int.Parse(txtSueldoCajaDia.Text.ToString());
            objcaje.NumCaja = cmbNumCaja.Text.ToString();
            lblTotalCaja.Text = objcaje.PagaC.ToString();
        }
    }
}
