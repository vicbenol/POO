namespace CalificacionesActividad1
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
            this.lblCalificaciones = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.lblAprobados2 = new System.Windows.Forms.Label();
            this.lblReprobados2 = new System.Windows.Forms.Label();
            this.lblPromedio2 = new System.Windows.Forms.Label();
            this.btnReportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalificaciones
            // 
            this.lblCalificaciones.AutoSize = true;
            this.lblCalificaciones.Location = new System.Drawing.Point(12, 49);
            this.lblCalificaciones.Name = "lblCalificaciones";
            this.lblCalificaciones.Size = new System.Drawing.Size(117, 13);
            this.lblCalificaciones.TabIndex = 0;
            this.lblCalificaciones.Text = "Agregue calificaciones:";
            this.lblCalificaciones.Click += new System.EventHandler(this.lblCalificaciones_Click);
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(129, 46);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 1;
            this.txtCalificacion.TextChanged += new System.EventHandler(this.txt1cal_TextChanged);
            // 
            // btnCaptura
            // 
            this.btnCaptura.Location = new System.Drawing.Point(235, 44);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(75, 23);
            this.btnCaptura.TabIndex = 2;
            this.btnCaptura.Text = "Capturar";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btt1Cap_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(175, 157);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(86, 13);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio grupal:";
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Location = new System.Drawing.Point(12, 81);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(61, 13);
            this.lblAprobados.TabIndex = 5;
            this.lblAprobados.Text = "Aprobados:";
            this.lblAprobados.Click += new System.EventHandler(this.lblAprobados_Click);
            // 
            // lblReprobados
            // 
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.Location = new System.Drawing.Point(126, 81);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(68, 13);
            this.lblReprobados.TabIndex = 6;
            this.lblReprobados.Text = "Reprobados:";
            // 
            // lblAprobados2
            // 
            this.lblAprobados2.AutoSize = true;
            this.lblAprobados2.Location = new System.Drawing.Point(79, 81);
            this.lblAprobados2.Name = "lblAprobados2";
            this.lblAprobados2.Size = new System.Drawing.Size(13, 13);
            this.lblAprobados2.TabIndex = 7;
            this.lblAprobados2.Text = "0";
            this.lblAprobados2.Click += new System.EventHandler(this.lblAprobados2_Click);
            // 
            // lblReprobados2
            // 
            this.lblReprobados2.AutoSize = true;
            this.lblReprobados2.Location = new System.Drawing.Point(200, 81);
            this.lblReprobados2.Name = "lblReprobados2";
            this.lblReprobados2.Size = new System.Drawing.Size(13, 13);
            this.lblReprobados2.TabIndex = 8;
            this.lblReprobados2.Text = "0";
            this.lblReprobados2.Click += new System.EventHandler(this.lblReprobados2_Click);
            // 
            // lblPromedio2
            // 
            this.lblPromedio2.AutoSize = true;
            this.lblPromedio2.Location = new System.Drawing.Point(267, 157);
            this.lblPromedio2.Name = "lblPromedio2";
            this.lblPromedio2.Size = new System.Drawing.Size(13, 13);
            this.lblPromedio2.TabIndex = 9;
            this.lblPromedio2.Text = "0";
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(186, 189);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(75, 23);
            this.btnReportar.TabIndex = 10;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 278);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.lblPromedio2);
            this.Controls.Add(this.lblReprobados2);
            this.Controls.Add(this.lblAprobados2);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificaciones);
            this.Name = "Form1";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificaciones;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.Label lblAprobados2;
        private System.Windows.Forms.Label lblReprobados2;
        private System.Windows.Forms.Label lblPromedio2;
        private System.Windows.Forms.Button btnReportar;
    }
}

