namespace AgregarVariosPaises
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtColor3 = new System.Windows.Forms.TextBox();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.txtHabitantes = new System.Windows.Forms.TextBox();
            this.lblHabitantes = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.gpbEmbajada = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.gpbEmbajada.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(152, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtColor3
            // 
            this.txtColor3.Location = new System.Drawing.Point(294, 74);
            this.txtColor3.Name = "txtColor3";
            this.txtColor3.Size = new System.Drawing.Size(100, 20);
            this.txtColor3.TabIndex = 25;
            // 
            // lblColor3
            // 
            this.lblColor3.AutoSize = true;
            this.lblColor3.Location = new System.Drawing.Point(198, 77);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(67, 13);
            this.lblColor3.TabIndex = 24;
            this.lblColor3.Text = "Tercer color:";
            // 
            // txtColor2
            // 
            this.txtColor2.Location = new System.Drawing.Point(294, 43);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(100, 20);
            this.txtColor2.TabIndex = 23;
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Location = new System.Drawing.Point(198, 50);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(79, 13);
            this.lblColor2.TabIndex = 22;
            this.lblColor2.Text = "Segundo color:";
            // 
            // txtColor1
            // 
            this.txtColor1.Location = new System.Drawing.Point(294, 13);
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(100, 20);
            this.txtColor1.TabIndex = 21;
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Location = new System.Drawing.Point(198, 16);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(65, 13);
            this.lblColor1.TabIndex = 20;
            this.lblColor1.Text = "Primer color:";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(77, 70);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(100, 20);
            this.txtIdioma.TabIndex = 19;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(6, 73);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(41, 13);
            this.lblIdioma.TabIndex = 18;
            this.lblIdioma.Text = "Idioma:";
            // 
            // txtHabitantes
            // 
            this.txtHabitantes.Location = new System.Drawing.Point(77, 43);
            this.txtHabitantes.Name = "txtHabitantes";
            this.txtHabitantes.Size = new System.Drawing.Size(100, 20);
            this.txtHabitantes.TabIndex = 17;
            // 
            // lblHabitantes
            // 
            this.lblHabitantes.AutoSize = true;
            this.lblHabitantes.Location = new System.Drawing.Point(6, 46);
            this.lblHabitantes.Name = "lblHabitantes";
            this.lblHabitantes.Size = new System.Drawing.Size(61, 13);
            this.lblHabitantes.TabIndex = 16;
            this.lblHabitantes.Text = "Habitantes:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(77, 15);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 15;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(6, 22);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 14;
            this.lblPais.Text = "Pais:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(553, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(457, 31);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(80, 13);
            this.lblBuscar.TabIndex = 29;
            this.lblBuscar.Text = "Buscar un pais:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(543, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 30;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 17);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(82, 13);
            this.lblCantidad.TabIndex = 32;
            this.lblCantidad.Text = "Cuantos paises:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(200, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(100, 15);
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(46, 20);
            this.nudCant.TabIndex = 34;
            // 
            // gpbEmbajada
            // 
            this.gpbEmbajada.Controls.Add(this.txtPais);
            this.gpbEmbajada.Controls.Add(this.lblPais);
            this.gpbEmbajada.Controls.Add(this.lblHabitantes);
            this.gpbEmbajada.Controls.Add(this.txtHabitantes);
            this.gpbEmbajada.Controls.Add(this.lblIdioma);
            this.gpbEmbajada.Controls.Add(this.txtIdioma);
            this.gpbEmbajada.Controls.Add(this.lblColor1);
            this.gpbEmbajada.Controls.Add(this.txtColor1);
            this.gpbEmbajada.Controls.Add(this.txtColor3);
            this.gpbEmbajada.Controls.Add(this.lblColor2);
            this.gpbEmbajada.Controls.Add(this.lblColor3);
            this.gpbEmbajada.Controls.Add(this.txtColor2);
            this.gpbEmbajada.Location = new System.Drawing.Point(12, 41);
            this.gpbEmbajada.Name = "gpbEmbajada";
            this.gpbEmbajada.Size = new System.Drawing.Size(416, 128);
            this.gpbEmbajada.TabIndex = 35;
            this.gpbEmbajada.TabStop = false;
            this.gpbEmbajada.Text = "Embajada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 229);
            this.Controls.Add(this.gpbEmbajada);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.gpbEmbajada.ResumeLayout(false);
            this.gpbEmbajada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.Label lblColor3;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.TextBox txtHabitantes;
        private System.Windows.Forms.Label lblHabitantes;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.GroupBox gpbEmbajada;
    }
}

