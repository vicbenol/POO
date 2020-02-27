namespace MayorDeEdad
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
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsted = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(127, 12);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(79, 20);
            this.dtpNacimiento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de nacimiento:";
            // 
            // lblUsted
            // 
            this.lblUsted.AutoSize = true;
            this.lblUsted.Location = new System.Drawing.Point(12, 65);
            this.lblUsted.Name = "lblUsted";
            this.lblUsted.Size = new System.Drawing.Size(52, 13);
            this.lblUsted.TabIndex = 2;
            this.lblUsted.Text = "Usted es:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(70, 65);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(0, 13);
            this.lblEdad.TabIndex = 3;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(221, 13);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MayorDeEdad.Properties.Resources.FB_IMG_1512020842592;
            this.ClientSize = new System.Drawing.Size(315, 328);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblUsted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNacimiento);
            this.Name = "Form1";
            this.Text = "INE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsted;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnSacar;
    }
}

