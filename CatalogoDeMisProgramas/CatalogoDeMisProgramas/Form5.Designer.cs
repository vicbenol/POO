namespace CatalogoDeMisProgramas
{
    partial class FrmUnidad4
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
            this.btnEmpRes = new System.Windows.Forms.Button();
            this.btnFigGeo = new System.Windows.Forms.Button();
            this.btnOpera = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.btnRegUni4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmpRes
            // 
            this.btnEmpRes.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpRes.Location = new System.Drawing.Point(12, 12);
            this.btnEmpRes.Name = "btnEmpRes";
            this.btnEmpRes.Size = new System.Drawing.Size(127, 48);
            this.btnEmpRes.TabIndex = 1;
            this.btnEmpRes.Text = "Empleados Restaurante";
            this.btnEmpRes.UseVisualStyleBackColor = true;
            this.btnEmpRes.Click += new System.EventHandler(this.btnEmpRes_Click);
            // 
            // btnFigGeo
            // 
            this.btnFigGeo.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFigGeo.Location = new System.Drawing.Point(166, 12);
            this.btnFigGeo.Name = "btnFigGeo";
            this.btnFigGeo.Size = new System.Drawing.Size(129, 59);
            this.btnFigGeo.TabIndex = 2;
            this.btnFigGeo.Text = "Figuras Geometricas 1 y 2";
            this.btnFigGeo.UseVisualStyleBackColor = true;
            this.btnFigGeo.Click += new System.EventHandler(this.btnFigGeo_Click);
            // 
            // btnOpera
            // 
            this.btnOpera.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpera.Location = new System.Drawing.Point(313, 12);
            this.btnOpera.Name = "btnOpera";
            this.btnOpera.Size = new System.Drawing.Size(128, 35);
            this.btnOpera.TabIndex = 3;
            this.btnOpera.Text = "Operaciones";
            this.btnOpera.UseVisualStyleBackColor = true;
            this.btnOpera.Click += new System.EventHandler(this.btnOpera_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuego.Location = new System.Drawing.Point(456, 31);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(92, 29);
            this.btnJuego.TabIndex = 4;
            this.btnJuego.Text = "Juego";
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // btnRegUni4
            // 
            this.btnRegUni4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegUni4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegUni4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegUni4.Location = new System.Drawing.Point(12, 211);
            this.btnRegUni4.Name = "btnRegUni4";
            this.btnRegUni4.Size = new System.Drawing.Size(75, 30);
            this.btnRegUni4.TabIndex = 5;
            this.btnRegUni4.Text = "Regresar";
            this.btnRegUni4.UseVisualStyleBackColor = false;
            this.btnRegUni4.Click += new System.EventHandler(this.btnRegUni4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(93, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Esta unidad fue de implementacion de herencia y polimorfismo\r\n en la cual una cla" +
    "se papá hereda a una clase hija, tambien se \r\npresento un proyecto de un viejo e" +
    "cho por nosotros.";
            // 
            // FrmUnidad4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalogoDeMisProgramas.Properties.Resources.Tema_5;
            this.ClientSize = new System.Drawing.Size(560, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegUni4);
            this.Controls.Add(this.btnJuego);
            this.Controls.Add(this.btnOpera);
            this.Controls.Add(this.btnFigGeo);
            this.Controls.Add(this.btnEmpRes);
            this.Name = "FrmUnidad4";
            this.Text = "Unidad 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmpRes;
        private System.Windows.Forms.Button btnFigGeo;
        private System.Windows.Forms.Button btnOpera;
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Button btnRegUni4;
        private System.Windows.Forms.Label label1;
    }
}