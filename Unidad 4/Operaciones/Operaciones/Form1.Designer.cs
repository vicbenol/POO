namespace Operaciones
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cmbSignos = new System.Windows.Forms.ComboBox();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(145, 13);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // cmbSignos
            // 
            this.cmbSignos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSignos.FormattingEnabled = true;
            this.cmbSignos.Items.AddRange(new object[] {
            "+",
            "*",
            "-",
            "/"});
            this.cmbSignos.Location = new System.Drawing.Point(118, 12);
            this.cmbSignos.Name = "cmbSignos";
            this.cmbSignos.Size = new System.Drawing.Size(21, 21);
            this.cmbSignos.TabIndex = 2;
            this.cmbSignos.SelectedIndexChanged += new System.EventHandler(this.cmbSignos_SelectedIndexChanged);
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(251, 16);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 3;
            this.lblIgual.Text = "=";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(270, 16);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "0";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(12, 54);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 160);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.cmbSignos);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cmbSignos;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnResultado;
    }
}

