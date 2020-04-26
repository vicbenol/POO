namespace ElAlumnoYElMaestro
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
            this.gpbAlumno = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.dtpNacAlu = new System.Windows.Forms.DateTimePicker();
            this.nudCanAlu = new System.Windows.Forms.NumericUpDown();
            this.txtCarAlu = new System.Windows.Forms.TextBox();
            this.txtNumAlu = new System.Windows.Forms.TextBox();
            this.txtEmaAlu = new System.Windows.Forms.TextBox();
            this.txtTelAlu = new System.Windows.Forms.TextBox();
            this.txtCurpAlu = new System.Windows.Forms.TextBox();
            this.txtNomAlu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbMaestro = new System.Windows.Forms.GroupBox();
            this.txtSueMas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnImpMas = new System.Windows.Forms.Button();
            this.btnConMas = new System.Windows.Forms.Button();
            this.dtpNacMas = new System.Windows.Forms.DateTimePicker();
            this.nudMatMas = new System.Windows.Forms.NumericUpDown();
            this.txtNumMas = new System.Windows.Forms.TextBox();
            this.txtEmailMas = new System.Windows.Forms.TextBox();
            this.txtTelMas = new System.Windows.Forms.TextBox();
            this.txtCurpMas = new System.Windows.Forms.TextBox();
            this.txtNomMas = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbOcupacion = new System.Windows.Forms.ComboBox();
            this.btnElegir = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.NombreAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NacimientoAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurpAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarreraAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalificacionAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanAlu)).BeginInit();
            this.gpbMaestro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAlumno
            // 
            this.gpbAlumno.Controls.Add(this.btnImprimir);
            this.gpbAlumno.Controls.Add(this.btnContar);
            this.gpbAlumno.Controls.Add(this.dtpNacAlu);
            this.gpbAlumno.Controls.Add(this.nudCanAlu);
            this.gpbAlumno.Controls.Add(this.txtCarAlu);
            this.gpbAlumno.Controls.Add(this.txtNumAlu);
            this.gpbAlumno.Controls.Add(this.txtEmaAlu);
            this.gpbAlumno.Controls.Add(this.txtTelAlu);
            this.gpbAlumno.Controls.Add(this.txtCurpAlu);
            this.gpbAlumno.Controls.Add(this.txtNomAlu);
            this.gpbAlumno.Controls.Add(this.label10);
            this.gpbAlumno.Controls.Add(this.label7);
            this.gpbAlumno.Controls.Add(this.label6);
            this.gpbAlumno.Controls.Add(this.label5);
            this.gpbAlumno.Controls.Add(this.label4);
            this.gpbAlumno.Controls.Add(this.label3);
            this.gpbAlumno.Controls.Add(this.label2);
            this.gpbAlumno.Controls.Add(this.label1);
            this.gpbAlumno.Location = new System.Drawing.Point(12, 59);
            this.gpbAlumno.Name = "gpbAlumno";
            this.gpbAlumno.Size = new System.Drawing.Size(249, 354);
            this.gpbAlumno.TabIndex = 0;
            this.gpbAlumno.TabStop = false;
            this.gpbAlumno.Text = "Alumno";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(92, 315);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(185, 277);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(58, 23);
            this.btnContar.TabIndex = 20;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // dtpNacAlu
            // 
            this.dtpNacAlu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacAlu.Location = new System.Drawing.Point(127, 61);
            this.dtpNacAlu.Name = "dtpNacAlu";
            this.dtpNacAlu.Size = new System.Drawing.Size(100, 20);
            this.dtpNacAlu.TabIndex = 19;
            // 
            // nudCanAlu
            // 
            this.nudCanAlu.Location = new System.Drawing.Point(127, 280);
            this.nudCanAlu.Name = "nudCanAlu";
            this.nudCanAlu.Size = new System.Drawing.Size(40, 20);
            this.nudCanAlu.TabIndex = 18;
            // 
            // txtCarAlu
            // 
            this.txtCarAlu.Location = new System.Drawing.Point(127, 242);
            this.txtCarAlu.Name = "txtCarAlu";
            this.txtCarAlu.Size = new System.Drawing.Size(100, 20);
            this.txtCarAlu.TabIndex = 15;
            // 
            // txtNumAlu
            // 
            this.txtNumAlu.Location = new System.Drawing.Point(127, 210);
            this.txtNumAlu.Name = "txtNumAlu";
            this.txtNumAlu.Size = new System.Drawing.Size(100, 20);
            this.txtNumAlu.TabIndex = 14;
            // 
            // txtEmaAlu
            // 
            this.txtEmaAlu.Location = new System.Drawing.Point(127, 173);
            this.txtEmaAlu.Name = "txtEmaAlu";
            this.txtEmaAlu.Size = new System.Drawing.Size(100, 20);
            this.txtEmaAlu.TabIndex = 13;
            // 
            // txtTelAlu
            // 
            this.txtTelAlu.Location = new System.Drawing.Point(127, 134);
            this.txtTelAlu.Name = "txtTelAlu";
            this.txtTelAlu.Size = new System.Drawing.Size(100, 20);
            this.txtTelAlu.TabIndex = 12;
            // 
            // txtCurpAlu
            // 
            this.txtCurpAlu.Location = new System.Drawing.Point(127, 97);
            this.txtCurpAlu.Name = "txtCurpAlu";
            this.txtCurpAlu.Size = new System.Drawing.Size(100, 20);
            this.txtCurpAlu.TabIndex = 11;
            // 
            // txtNomAlu
            // 
            this.txtNomAlu.Location = new System.Drawing.Point(127, 35);
            this.txtNomAlu.Name = "txtNomAlu";
            this.txtNomAlu.Size = new System.Drawing.Size(100, 20);
            this.txtNomAlu.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Carrera:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cuantas materias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "No. de control:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // gpbMaestro
            // 
            this.gpbMaestro.Controls.Add(this.txtSueMas);
            this.gpbMaestro.Controls.Add(this.label12);
            this.gpbMaestro.Controls.Add(this.btnImpMas);
            this.gpbMaestro.Controls.Add(this.btnConMas);
            this.gpbMaestro.Controls.Add(this.dtpNacMas);
            this.gpbMaestro.Controls.Add(this.nudMatMas);
            this.gpbMaestro.Controls.Add(this.txtNumMas);
            this.gpbMaestro.Controls.Add(this.txtEmailMas);
            this.gpbMaestro.Controls.Add(this.txtTelMas);
            this.gpbMaestro.Controls.Add(this.txtCurpMas);
            this.gpbMaestro.Controls.Add(this.txtNomMas);
            this.gpbMaestro.Controls.Add(this.label15);
            this.gpbMaestro.Controls.Add(this.label16);
            this.gpbMaestro.Controls.Add(this.label17);
            this.gpbMaestro.Controls.Add(this.label18);
            this.gpbMaestro.Controls.Add(this.label19);
            this.gpbMaestro.Controls.Add(this.label20);
            this.gpbMaestro.Controls.Add(this.label21);
            this.gpbMaestro.Location = new System.Drawing.Point(302, 59);
            this.gpbMaestro.Name = "gpbMaestro";
            this.gpbMaestro.Size = new System.Drawing.Size(262, 321);
            this.gpbMaestro.TabIndex = 1;
            this.gpbMaestro.TabStop = false;
            this.gpbMaestro.Text = "Maestro";
            // 
            // txtSueMas
            // 
            this.txtSueMas.Location = new System.Drawing.Point(134, 223);
            this.txtSueMas.Name = "txtSueMas";
            this.txtSueMas.Size = new System.Drawing.Size(100, 20);
            this.txtSueMas.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Sueldo:";
            // 
            // btnImpMas
            // 
            this.btnImpMas.Location = new System.Drawing.Point(99, 280);
            this.btnImpMas.Name = "btnImpMas";
            this.btnImpMas.Size = new System.Drawing.Size(75, 23);
            this.btnImpMas.TabIndex = 44;
            this.btnImpMas.Text = "Imprimir";
            this.btnImpMas.UseVisualStyleBackColor = true;
            this.btnImpMas.Click += new System.EventHandler(this.btnImpMas_Click);
            // 
            // btnConMas
            // 
            this.btnConMas.Location = new System.Drawing.Point(198, 249);
            this.btnConMas.Name = "btnConMas";
            this.btnConMas.Size = new System.Drawing.Size(58, 23);
            this.btnConMas.TabIndex = 41;
            this.btnConMas.Text = "Contar";
            this.btnConMas.UseVisualStyleBackColor = true;
            this.btnConMas.Click += new System.EventHandler(this.btnConMas_Click);
            // 
            // dtpNacMas
            // 
            this.dtpNacMas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacMas.Location = new System.Drawing.Point(134, 55);
            this.dtpNacMas.Name = "dtpNacMas";
            this.dtpNacMas.Size = new System.Drawing.Size(100, 20);
            this.dtpNacMas.TabIndex = 40;
            // 
            // nudMatMas
            // 
            this.nudMatMas.Location = new System.Drawing.Point(134, 254);
            this.nudMatMas.Name = "nudMatMas";
            this.nudMatMas.Size = new System.Drawing.Size(40, 20);
            this.nudMatMas.TabIndex = 39;
            // 
            // txtNumMas
            // 
            this.txtNumMas.Location = new System.Drawing.Point(134, 187);
            this.txtNumMas.Name = "txtNumMas";
            this.txtNumMas.Size = new System.Drawing.Size(100, 20);
            this.txtNumMas.TabIndex = 35;
            // 
            // txtEmailMas
            // 
            this.txtEmailMas.Location = new System.Drawing.Point(134, 150);
            this.txtEmailMas.Name = "txtEmailMas";
            this.txtEmailMas.Size = new System.Drawing.Size(100, 20);
            this.txtEmailMas.TabIndex = 34;
            // 
            // txtTelMas
            // 
            this.txtTelMas.Location = new System.Drawing.Point(134, 118);
            this.txtTelMas.Name = "txtTelMas";
            this.txtTelMas.Size = new System.Drawing.Size(100, 20);
            this.txtTelMas.TabIndex = 33;
            // 
            // txtCurpMas
            // 
            this.txtCurpMas.Location = new System.Drawing.Point(134, 88);
            this.txtCurpMas.Name = "txtCurpMas";
            this.txtCurpMas.Size = new System.Drawing.Size(100, 20);
            this.txtCurpMas.TabIndex = 32;
            // 
            // txtNomMas
            // 
            this.txtNomMas.Location = new System.Drawing.Point(134, 19);
            this.txtNomMas.Name = "txtNomMas";
            this.txtNomMas.Size = new System.Drawing.Size(100, 20);
            this.txtNomMas.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Cuantas materias:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "No. de maestro:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Email:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Telefono:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Curp:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Fecha de nacimiento:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ocupacion:";
            // 
            // cmbOcupacion
            // 
            this.cmbOcupacion.FormattingEnabled = true;
            this.cmbOcupacion.Items.AddRange(new object[] {
            "Alumno",
            "Maestro"});
            this.cmbOcupacion.Location = new System.Drawing.Point(86, 15);
            this.cmbOcupacion.Name = "cmbOcupacion";
            this.cmbOcupacion.Size = new System.Drawing.Size(121, 21);
            this.cmbOcupacion.TabIndex = 3;
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(213, 13);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 4;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreAlu,
            this.NacimientoAlu,
            this.CurpAlu,
            this.TelefonoAlu,
            this.EmailAlu,
            this.NumeroAlu,
            this.CarreraAlu,
            this.MateriaAlu,
            this.CalificacionAlu});
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 499);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(249, 150);
            this.dgvAlumnos.TabIndex = 5;
            // 
            // NombreAlu
            // 
            this.NombreAlu.HeaderText = "Nombre";
            this.NombreAlu.Name = "NombreAlu";
            // 
            // NacimientoAlu
            // 
            this.NacimientoAlu.HeaderText = "Nacimiento";
            this.NacimientoAlu.Name = "NacimientoAlu";
            // 
            // CurpAlu
            // 
            this.CurpAlu.HeaderText = "Curp";
            this.CurpAlu.Name = "CurpAlu";
            // 
            // TelefonoAlu
            // 
            this.TelefonoAlu.HeaderText = "Telefono";
            this.TelefonoAlu.Name = "TelefonoAlu";
            // 
            // EmailAlu
            // 
            this.EmailAlu.HeaderText = "Email";
            this.EmailAlu.Name = "EmailAlu";
            // 
            // NumeroAlu
            // 
            this.NumeroAlu.HeaderText = "No. de control";
            this.NumeroAlu.Name = "NumeroAlu";
            // 
            // CarreraAlu
            // 
            this.CarreraAlu.HeaderText = "Carrera";
            this.CarreraAlu.Name = "CarreraAlu";
            // 
            // MateriaAlu
            // 
            this.MateriaAlu.HeaderText = "Materias";
            this.MateriaAlu.Name = "MateriaAlu";
            // 
            // CalificacionAlu
            // 
            this.CalificacionAlu.HeaderText = "Calificaciones";
            this.CalificacionAlu.Name = "CalificacionAlu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 694);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.cmbOcupacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gpbMaestro);
            this.Controls.Add(this.gpbAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbAlumno.ResumeLayout(false);
            this.gpbAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanAlu)).EndInit();
            this.gpbMaestro.ResumeLayout(false);
            this.gpbMaestro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAlumno;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.DateTimePicker dtpNacAlu;
        private System.Windows.Forms.NumericUpDown nudCanAlu;
        private System.Windows.Forms.TextBox txtCarAlu;
        private System.Windows.Forms.TextBox txtNumAlu;
        private System.Windows.Forms.TextBox txtEmaAlu;
        private System.Windows.Forms.TextBox txtTelAlu;
        private System.Windows.Forms.TextBox txtCurpAlu;
        private System.Windows.Forms.TextBox txtNomAlu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbMaestro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbOcupacion;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Button btnImpMas;
        private System.Windows.Forms.Button btnConMas;
        private System.Windows.Forms.DateTimePicker dtpNacMas;
        private System.Windows.Forms.NumericUpDown nudMatMas;
        private System.Windows.Forms.TextBox txtNumMas;
        private System.Windows.Forms.TextBox txtEmailMas;
        private System.Windows.Forms.TextBox txtTelMas;
        private System.Windows.Forms.TextBox txtCurpMas;
        private System.Windows.Forms.TextBox txtNomMas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NacimientoAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurpAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarreraAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalificacionAlu;
        private System.Windows.Forms.TextBox txtSueMas;
        private System.Windows.Forms.Label label12;
    }
}

