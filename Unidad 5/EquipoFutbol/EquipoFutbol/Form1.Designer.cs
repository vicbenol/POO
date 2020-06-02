namespace EquipoFutbol
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
            this.lblNomEqu = new System.Windows.Forms.Label();
            this.lblNumEqu = new System.Windows.Forms.Label();
            this.lblFecIni = new System.Windows.Forms.Label();
            this.txtNomTor = new System.Windows.Forms.TextBox();
            this.nudCantEqu = new System.Windows.Forms.NumericUpDown();
            this.dtpIniTorneo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFinTorneo = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatosTorneo = new System.Windows.Forms.Button();
            this.btnDatosEquipo = new System.Windows.Forms.Button();
            this.btnGanador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGanadas = new System.Windows.Forms.NumericUpDown();
            this.nudEmpate = new System.Windows.Forms.NumericUpDown();
            this.nudPerdidas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantEqu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerdidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomEqu
            // 
            this.lblNomEqu.AutoSize = true;
            this.lblNomEqu.Location = new System.Drawing.Point(6, 42);
            this.lblNomEqu.Name = "lblNomEqu";
            this.lblNomEqu.Size = new System.Drawing.Size(101, 13);
            this.lblNomEqu.TabIndex = 0;
            this.lblNomEqu.Text = "Nombre del Torneo:";
            // 
            // lblNumEqu
            // 
            this.lblNumEqu.AutoSize = true;
            this.lblNumEqu.Location = new System.Drawing.Point(6, 16);
            this.lblNumEqu.Name = "lblNumEqu";
            this.lblNumEqu.Size = new System.Drawing.Size(109, 13);
            this.lblNumEqu.TabIndex = 1;
            this.lblNumEqu.Text = "Cuantos equipos son:";
            // 
            // lblFecIni
            // 
            this.lblFecIni.AutoSize = true;
            this.lblFecIni.Location = new System.Drawing.Point(6, 71);
            this.lblFecIni.Name = "lblFecIni";
            this.lblFecIni.Size = new System.Drawing.Size(82, 13);
            this.lblFecIni.TabIndex = 2;
            this.lblFecIni.Text = "Fecha de inicio:";
            // 
            // txtNomTor
            // 
            this.txtNomTor.Location = new System.Drawing.Point(130, 39);
            this.txtNomTor.Name = "txtNomTor";
            this.txtNomTor.Size = new System.Drawing.Size(100, 20);
            this.txtNomTor.TabIndex = 3;
            // 
            // nudCantEqu
            // 
            this.nudCantEqu.Location = new System.Drawing.Point(130, 14);
            this.nudCantEqu.Name = "nudCantEqu";
            this.nudCantEqu.Size = new System.Drawing.Size(35, 20);
            this.nudCantEqu.TabIndex = 4;
            // 
            // dtpIniTorneo
            // 
            this.dtpIniTorneo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIniTorneo.Location = new System.Drawing.Point(130, 65);
            this.dtpIniTorneo.Name = "dtpIniTorneo";
            this.dtpIniTorneo.Size = new System.Drawing.Size(83, 20);
            this.dtpIniTorneo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Terminacion del torneo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFinTorneo
            // 
            this.dtpFinTorneo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinTorneo.Location = new System.Drawing.Point(130, 95);
            this.dtpFinTorneo.Name = "dtpFinTorneo";
            this.dtpFinTorneo.Size = new System.Drawing.Size(91, 20);
            this.dtpFinTorneo.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudPerdidas);
            this.groupBox2.Controls.Add(this.nudEmpate);
            this.groupBox2.Controls.Add(this.nudGanadas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de los partidos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumEqu);
            this.groupBox1.Controls.Add(this.lblNomEqu);
            this.groupBox1.Controls.Add(this.lblFecIni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudCantEqu);
            this.groupBox1.Controls.Add(this.dtpFinTorneo);
            this.groupBox1.Controls.Add(this.txtNomTor);
            this.groupBox1.Controls.Add(this.dtpIniTorneo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 134);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Torneo";
            // 
            // btnDatosTorneo
            // 
            this.btnDatosTorneo.Location = new System.Drawing.Point(102, 152);
            this.btnDatosTorneo.Name = "btnDatosTorneo";
            this.btnDatosTorneo.Size = new System.Drawing.Size(75, 23);
            this.btnDatosTorneo.TabIndex = 11;
            this.btnDatosTorneo.Text = "Guardar";
            this.btnDatosTorneo.UseVisualStyleBackColor = true;
            this.btnDatosTorneo.Click += new System.EventHandler(this.btnDatosTorneo_Click);
            // 
            // btnDatosEquipo
            // 
            this.btnDatosEquipo.Location = new System.Drawing.Point(102, 307);
            this.btnDatosEquipo.Name = "btnDatosEquipo";
            this.btnDatosEquipo.Size = new System.Drawing.Size(75, 36);
            this.btnDatosEquipo.TabIndex = 12;
            this.btnDatosEquipo.Text = "Guardar Datos";
            this.btnDatosEquipo.UseVisualStyleBackColor = true;
            this.btnDatosEquipo.Click += new System.EventHandler(this.btnDatosEquipo_Click);
            // 
            // btnGanador
            // 
            this.btnGanador.Location = new System.Drawing.Point(102, 381);
            this.btnGanador.Name = "btnGanador";
            this.btnGanador.Size = new System.Drawing.Size(75, 23);
            this.btnGanador.TabIndex = 13;
            this.btnGanador.Text = "Ver Ganador";
            this.btnGanador.UseVisualStyleBackColor = true;
            this.btnGanador.Click += new System.EventHandler(this.btnGanador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuantas ganadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cuantas Empate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cuantas perdidas:";
            // 
            // nudGanadas
            // 
            this.nudGanadas.Location = new System.Drawing.Point(105, 16);
            this.nudGanadas.Name = "nudGanadas";
            this.nudGanadas.Size = new System.Drawing.Size(43, 20);
            this.nudGanadas.TabIndex = 3;
            // 
            // nudEmpate
            // 
            this.nudEmpate.Location = new System.Drawing.Point(105, 47);
            this.nudEmpate.Name = "nudEmpate";
            this.nudEmpate.Size = new System.Drawing.Size(43, 20);
            this.nudEmpate.TabIndex = 4;
            // 
            // nudPerdidas
            // 
            this.nudPerdidas.Location = new System.Drawing.Point(105, 82);
            this.nudPerdidas.Name = "nudPerdidas";
            this.nudPerdidas.Size = new System.Drawing.Size(43, 20);
            this.nudPerdidas.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 446);
            this.Controls.Add(this.btnGanador);
            this.Controls.Add(this.btnDatosEquipo);
            this.Controls.Add(this.btnDatosTorneo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantEqu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerdidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomEqu;
        private System.Windows.Forms.Label lblNumEqu;
        private System.Windows.Forms.Label lblFecIni;
        private System.Windows.Forms.TextBox txtNomTor;
        private System.Windows.Forms.NumericUpDown nudCantEqu;
        private System.Windows.Forms.DateTimePicker dtpIniTorneo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFinTorneo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatosTorneo;
        private System.Windows.Forms.Button btnDatosEquipo;
        private System.Windows.Forms.Button btnGanador;
        private System.Windows.Forms.NumericUpDown nudPerdidas;
        private System.Windows.Forms.NumericUpDown nudEmpate;
        private System.Windows.Forms.NumericUpDown nudGanadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

