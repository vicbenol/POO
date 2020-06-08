namespace Temperaturas
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
            this.lblGrados = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.cmbTemperatura = new System.Windows.Forms.ComboBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblResultadoF = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblCentigrados = new System.Windows.Forms.Label();
            this.lblResultadoC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Location = new System.Drawing.Point(12, 25);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(106, 13);
            this.lblGrados.TabIndex = 0;
            this.lblGrados.Text = "Introduce los grados:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(26, 58);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(92, 13);
            this.lblTemperatura.TabIndex = 1;
            this.lblTemperatura.Text = "Elige temperatura:";
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(124, 22);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 2;
            // 
            // cmbTemperatura
            // 
            this.cmbTemperatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemperatura.FormattingEnabled = true;
            this.cmbTemperatura.Items.AddRange(new object[] {
            "Fahrenheit",
            "Centigrados"});
            this.cmbTemperatura.Location = new System.Drawing.Point(124, 55);
            this.cmbTemperatura.Name = "cmbTemperatura";
            this.cmbTemperatura.Size = new System.Drawing.Size(121, 21);
            this.cmbTemperatura.TabIndex = 3;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(133, 113);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(60, 13);
            this.lblFahrenheit.TabIndex = 4;
            this.lblFahrenheit.Text = "Fahrenheit:";
            // 
            // lblResultadoF
            // 
            this.lblResultadoF.AutoSize = true;
            this.lblResultadoF.Location = new System.Drawing.Point(199, 113);
            this.lblResultadoF.Name = "lblResultadoF";
            this.lblResultadoF.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoF.TabIndex = 5;
            this.lblResultadoF.Text = "0";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(43, 108);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblCentigrados
            // 
            this.lblCentigrados.AutoSize = true;
            this.lblCentigrados.Location = new System.Drawing.Point(133, 140);
            this.lblCentigrados.Name = "lblCentigrados";
            this.lblCentigrados.Size = new System.Drawing.Size(66, 13);
            this.lblCentigrados.TabIndex = 7;
            this.lblCentigrados.Text = "Centigrados:";
            // 
            // lblResultadoC
            // 
            this.lblResultadoC.AutoSize = true;
            this.lblResultadoC.Location = new System.Drawing.Point(199, 140);
            this.lblResultadoC.Name = "lblResultadoC";
            this.lblResultadoC.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoC.TabIndex = 8;
            this.lblResultadoC.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 300);
            this.Controls.Add(this.lblResultadoC);
            this.Controls.Add(this.lblCentigrados);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblResultadoF);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.cmbTemperatura);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblGrados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.ComboBox cmbTemperatura;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblResultadoF;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblCentigrados;
        private System.Windows.Forms.Label lblResultadoC;
    }
}

