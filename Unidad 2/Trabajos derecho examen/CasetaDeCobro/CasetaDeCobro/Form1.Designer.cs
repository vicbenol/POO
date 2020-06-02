namespace CasetaDeCobro
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
            this.btnPrecio = new System.Windows.Forms.Button();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(234, 34);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(75, 23);
            this.btnPrecio.TabIndex = 0;
            this.btnPrecio.Text = "Sacar precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(12, 39);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(89, 13);
            this.lblVehiculo.TabIndex = 1;
            this.lblVehiculo.Text = "Vehiculo a pasar:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(12, 78);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 13);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo:";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(55, 78);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(13, 13);
            this.lblPrecio2.TabIndex = 3;
            this.lblPrecio2.Text = "0";
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Items.AddRange(new object[] {
            "Motocicleta",
            "Carro",
            "Autobus",
            "Trailer"});
            this.cmbVehiculos.Location = new System.Drawing.Point(107, 36);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(121, 21);
            this.cmbVehiculos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 100);
            this.Controls.Add(this.cmbVehiculos);
            this.Controls.Add(this.lblPrecio2);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.btnPrecio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.ComboBox cmbVehiculos;
    }
}

