namespace CFE
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
            this.lblKw = new System.Windows.Forms.Label();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKw
            // 
            this.lblKw.AutoSize = true;
            this.lblKw.Location = new System.Drawing.Point(12, 19);
            this.lblKw.Name = "lblKw";
            this.lblKw.Size = new System.Drawing.Size(158, 13);
            this.lblKw.TabIndex = 0;
            this.lblKw.Text = "Introduce kilowatts consumidos:";
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(176, 16);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(100, 20);
            this.txtkilo.TabIndex = 1;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(86, 49);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(84, 13);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Establecimiento:";
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Items.AddRange(new object[] {
            "Casa",
            "Negocio"});
            this.cmbLugar.Location = new System.Drawing.Point(176, 46);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(121, 21);
            this.cmbLugar.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 106);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(113, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad en dinero es:";
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(131, 106);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(13, 13);
            this.lblDinero.TabIndex = 5;
            this.lblDinero.Text = "0";
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(201, 101);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(75, 23);
            this.btnPrecio.TabIndex = 6;
            this.btnPrecio.Text = "Precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 283);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.txtkilo);
            this.Controls.Add(this.lblKw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKw;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Button btnPrecio;
    }
}

