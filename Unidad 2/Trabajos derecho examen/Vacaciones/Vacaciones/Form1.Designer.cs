namespace Vacaciones
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
            this.lblAnios = new System.Windows.Forms.Label();
            this.lblVacaciones = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtAnios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.Location = new System.Drawing.Point(26, 24);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(94, 13);
            this.lblAnios.TabIndex = 0;
            this.lblAnios.Text = "Años Trabajando :";
            // 
            // lblVacaciones
            // 
            this.lblVacaciones.AutoSize = true;
            this.lblVacaciones.Location = new System.Drawing.Point(26, 58);
            this.lblVacaciones.Name = "lblVacaciones";
            this.lblVacaciones.Size = new System.Drawing.Size(105, 13);
            this.lblVacaciones.TabIndex = 1;
            this.lblVacaciones.Text = "Dias de Vacaciones:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(137, 58);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(13, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(232, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 36);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular Vacaciones:";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtAnios
            // 
            this.txtAnios.Location = new System.Drawing.Point(126, 21);
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(100, 20);
            this.txtAnios.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 113);
            this.Controls.Add(this.txtAnios);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblVacaciones);
            this.Controls.Add(this.lblAnios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnios;
        private System.Windows.Forms.Label lblVacaciones;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtAnios;
    }
}

