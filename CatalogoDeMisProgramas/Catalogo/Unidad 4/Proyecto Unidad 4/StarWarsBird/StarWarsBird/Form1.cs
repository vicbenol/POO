using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsBird
{
    public partial class Form1 : Form,InterBird
    {
        NeneBird objnene = new NeneBird();
        PapaBird objpapa = new PapaBird();

        Random posiciones = new Random();

        public Form1()
        {
            InitializeComponent();
            //Aqui se agrega el metodo para activar el teclado
            this.KeyPreview = true;
            objnene.IniciarJuego();
        }
        //Nuevo metodo para iniciar el juego
        public void IniciarJuego()
        {
            Jugador.Location = new Point(19, 225);
            objnene.Distancia = posiciones.Next(-160, 118);
            TuboArriba.Location = new Point(270, -173 - objnene.Distancia);
            TuboAbajo.Location = new Point(270, 319 - objnene.Distancia);
            lblPuntaje.Text = objnene.Puntaje.ToString();
            objnene.IniciarJuego();
        }
        //error de dedo
        private void ptbTuboAbajo_Click(object sender, EventArgs e)
        {

        }
        //error de dedo
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //movimiento de la imagen 
            int CantidadMovimientos = 5;
            if (objpapa.ContadorMovimientos<=CantidadMovimientos)
            {
                Jugador.Image = Properties.Resources.pajaro;
                objpapa.ContadorMovimientos++;
            }
            if ((objpapa.ContadorMovimientos>CantidadMovimientos/2) && (objpapa.ContadorMovimientos<=CantidadMovimientos*2))
            {
                Jugador.Image = Properties.Resources.pajaro;
            }
            objpapa.ContadorMovimientos = (objpapa.ContadorMovimientos > CantidadMovimientos * 2) ? 0 : objpapa.ContadorMovimientos;

            //Movimiento de volar y de caida
            int ly = Jugador.Location.Y;
            int lx = Jugador.Location.X;

            if (objnene.Volar)
            {
                ly = ly - 15;
                objnene.Volar = false;
            }
            else
            {
                ly++;
            }
            Jugador.Location = new Point(Jugador.Location.X, ly);

            //Contador de puntaje y choque de algun objeto reiniciar
            if((Jugador.Bounds.IntersectsWith(Barra.Bounds)) || (Jugador.Bounds.IntersectsWith(TuboArriba.Bounds)) || (Jugador.Bounds.IntersectsWith(TuboAbajo.Bounds)))
            {
                objnene.IniciarJuego();

            }
            // de lo contrario seguira contando y la locacion del puntaje
            lblPuntaje.Location = new Point(Jugador.Location.X + 30, Jugador.Location.Y - 25);
            lblPuntaje.Text = (TuboArriba.Location.X == Jugador.Location.X) ? Convert.ToString((Convert.ToInt32(lblPuntaje.Text) + 1)).ToString() : lblPuntaje.Text;


        }
        //Este metodo es para activar la barra Space para que el objeto se eleve
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Space))
            {
                objnene.Volar = true;
            }
        }
        //Apariciones nuevas de los obtaculos (Tubos)
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TuboAbajo.Location.X>-140)
            {
                TuboAbajo.Location = new Point((TuboAbajo.Location.X) - 1, TuboAbajo.Location.Y);
                TuboArriba.Location = new Point((TuboArriba.Location.X) - 1, TuboArriba.Location.Y);
            }
            else 
            {
                objnene.Distancia = posiciones.Next(-170, 118);
                TuboAbajo.Location = new Point(400, 319 + objnene.Distancia);
                TuboArriba.Location = new Point(400, -173 + objnene.Distancia);
            }
        }
        //Movimiento del piso
        private void timer3_Tick(object sender, EventArgs e)
        {
            Barra.Location = (Barra.Location.X > -480) ? new Point((Barra.Location.X) - 1, Barra.Location.Y) : Barra.Location = new Point(-9, Barra.Location.Y);
        }
    }
}
