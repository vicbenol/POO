namespace StarWarsBird
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TuboArriba = new System.Windows.Forms.PictureBox();
            this.ptbPiso = new System.Windows.Forms.PictureBox();
            this.Jugador = new System.Windows.Forms.PictureBox();
            this.TuboAbajo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.Barra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TuboArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barra)).BeginInit();
            this.SuspendLayout();
            // 
            // TuboArriba
            // 
            this.TuboArriba.BackColor = System.Drawing.Color.Transparent;
            this.TuboArriba.Image = global::StarWarsBird.Properties.Resources.DX_25_350_500x500__3_;
            this.TuboArriba.ImageLocation = "";
            this.TuboArriba.Location = new System.Drawing.Point(134, -173);
            this.TuboArriba.Name = "TuboArriba";
            this.TuboArriba.Size = new System.Drawing.Size(75, 320);
            this.TuboArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TuboArriba.TabIndex = 0;
            this.TuboArriba.TabStop = false;
            // 
            // ptbPiso
            // 
            this.ptbPiso.BackColor = System.Drawing.Color.Transparent;
            this.ptbPiso.Image = global::StarWarsBird.Properties.Resources.d4jk8c9_3c4b8e22_5a63_4d9b_a2f8_126c45fce2fc;
            this.ptbPiso.Location = new System.Drawing.Point(-274, 445);
            this.ptbPiso.Name = "ptbPiso";
            this.ptbPiso.Size = new System.Drawing.Size(83, 55);
            this.ptbPiso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPiso.TabIndex = 2;
            this.ptbPiso.TabStop = false;
            // 
            // Jugador
            // 
            this.Jugador.BackColor = System.Drawing.Color.Transparent;
            this.Jugador.Image = global::StarWarsBird.Properties.Resources.pajaro;
            this.Jugador.Location = new System.Drawing.Point(19, 225);
            this.Jugador.Name = "Jugador";
            this.Jugador.Size = new System.Drawing.Size(83, 55);
            this.Jugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jugador.TabIndex = 3;
            this.Jugador.TabStop = false;
            // 
            // TuboAbajo
            // 
            this.TuboAbajo.BackColor = System.Drawing.Color.Transparent;
            this.TuboAbajo.Image = global::StarWarsBird.Properties.Resources.DX_25_350_500x500__2_;
            this.TuboAbajo.Location = new System.Drawing.Point(134, 319);
            this.TuboAbajo.Name = "TuboAbajo";
            this.TuboAbajo.Size = new System.Drawing.Size(75, 320);
            this.TuboAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TuboAbajo.TabIndex = 5;
            this.TuboAbajo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPuntaje.Location = new System.Drawing.Point(52, 198);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(13, 13);
            this.lblPuntaje.TabIndex = 6;
            this.lblPuntaje.Text = "0";
            // 
            // Barra
            // 
            this.Barra.Image = global::StarWarsBird.Properties.Resources.d4jk8c9_3c4b8e22_5a63_4d9b_a2f8_126c45fce2fc__2_;
            this.Barra.Location = new System.Drawing.Point(-274, 443);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(779, 24);
            this.Barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barra.TabIndex = 7;
            this.Barra.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::StarWarsBird.Properties.Resources.espacio__2_;
            this.ClientSize = new System.Drawing.Size(292, 464);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.TuboAbajo);
            this.Controls.Add(this.Jugador);
            this.Controls.Add(this.ptbPiso);
            this.Controls.Add(this.TuboArriba);
            this.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Star Wars Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.TuboArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TuboArriba;
        private System.Windows.Forms.PictureBox ptbPiso;
        private System.Windows.Forms.PictureBox Jugador;
        private System.Windows.Forms.PictureBox TuboAbajo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.PictureBox Barra;
    }
}

