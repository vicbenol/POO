namespace CatalogoDeMisProgramas
{
    partial class FrmUnidad1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPriSol = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPriSol
            // 
            this.btnPriSol.BackgroundImage = global::CatalogoDeMisProgramas.Properties.Resources.Botones;
            this.btnPriSol.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriSol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPriSol.Location = new System.Drawing.Point(171, 12);
            this.btnPriSol.Name = "btnPriSol";
            this.btnPriSol.Size = new System.Drawing.Size(124, 66);
            this.btnPriSol.TabIndex = 0;
            this.btnPriSol.Text = "Mi primera solucion";
            this.btnPriSol.UseVisualStyleBackColor = true;
            this.btnPriSol.Click += new System.EventHandler(this.btnPriSol_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::CatalogoDeMisProgramas.Properties.Resources.Botones;
            this.btnRegresar.Font = new System.Drawing.Font("Viner Hand ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRegresar.Location = new System.Drawing.Point(12, 107);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 36);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(103, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Este programa fue el primero \r\nque se hizo el cual resuelve \r\nun problema matemat" +
    "ico";
            // 
            // FrmUnidad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalogoDeMisProgramas.Properties.Resources.espacio;
            this.ClientSize = new System.Drawing.Size(358, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnPriSol);
            this.Name = "FrmUnidad1";
            this.Text = "Unidad 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPriSol;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
    }
}