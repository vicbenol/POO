namespace Cuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLado = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblArea2 = new System.Windows.Forms.Label();
            this.lblPerimetro2 = new System.Windows.Forms.Label();
            this.lblPermetro = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLado.Location = new System.Drawing.Point(12, 20);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(113, 13);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Introduce una medida:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArea.Location = new System.Drawing.Point(93, 64);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblArea2
            // 
            this.lblArea2.AutoSize = true;
            this.lblArea2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArea2.Location = new System.Drawing.Point(131, 64);
            this.lblArea2.Name = "lblArea2";
            this.lblArea2.Size = new System.Drawing.Size(13, 13);
            this.lblArea2.TabIndex = 2;
            this.lblArea2.Text = "0";
            // 
            // lblPerimetro2
            // 
            this.lblPerimetro2.AutoSize = true;
            this.lblPerimetro2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPerimetro2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPerimetro2.Location = new System.Drawing.Point(131, 92);
            this.lblPerimetro2.Name = "lblPerimetro2";
            this.lblPerimetro2.Size = new System.Drawing.Size(13, 13);
            this.lblPerimetro2.TabIndex = 3;
            this.lblPerimetro2.Text = "0";
            // 
            // lblPermetro
            // 
            this.lblPermetro.AutoSize = true;
            this.lblPermetro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPermetro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPermetro.Location = new System.Drawing.Point(71, 92);
            this.lblPermetro.Name = "lblPermetro";
            this.lblPermetro.Size = new System.Drawing.Size(54, 13);
            this.lblPermetro.TabIndex = 4;
            this.lblPermetro.Text = "Perimetro:";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(131, 17);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(100, 20);
            this.txtMedida.TabIndex = 5;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(246, 15);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(131, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cuadrado.Properties.Resources.FB_IMG_1513056220090;
            this.ClientSize = new System.Drawing.Size(323, 271);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.lblPermetro);
            this.Controls.Add(this.lblPerimetro2);
            this.Controls.Add(this.lblArea2);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblLado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Area y perimetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblArea2;
        private System.Windows.Forms.Label lblPerimetro2;
        private System.Windows.Forms.Label lblPermetro;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

