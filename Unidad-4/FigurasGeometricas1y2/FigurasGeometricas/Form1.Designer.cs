namespace FigurasGeometricas
{
    partial class frmFigGeo
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
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.lblMedida2 = new System.Windows.Forms.Label();
            this.txtMedida2 = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea2 = new System.Windows.Forms.Label();
            this.lblPerimetro2 = new System.Windows.Forms.Label();
            this.lblMedida3 = new System.Windows.Forms.Label();
            this.lblMedida4 = new System.Windows.Forms.Label();
            this.txtMedida3 = new System.Windows.Forms.TextBox();
            this.txtMedida4 = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Items.AddRange(new object[] {
            "Cuadrado",
            "Triangulo",
            "Circulo"});
            this.cmbFigura.Location = new System.Drawing.Point(101, 12);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 21);
            this.cmbFigura.TabIndex = 0;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.cmbFigura_SelectedIndexChanged);
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(12, 15);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(83, 13);
            this.lblFigura.TabIndex = 1;
            this.lblFigura.Text = "Elige una figura:";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Enabled = false;
            this.lblMedida.Location = new System.Drawing.Point(238, 15);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(102, 13);
            this.lblMedida.TabIndex = 2;
            this.lblMedida.Text = "Agrega una medida:";
            // 
            // txtMedida
            // 
            this.txtMedida.Enabled = false;
            this.txtMedida.Location = new System.Drawing.Point(346, 12);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(100, 20);
            this.txtMedida.TabIndex = 3;
            // 
            // lblMedida2
            // 
            this.lblMedida2.AutoSize = true;
            this.lblMedida2.Enabled = false;
            this.lblMedida2.Location = new System.Drawing.Point(229, 64);
            this.lblMedida2.Name = "lblMedida2";
            this.lblMedida2.Size = new System.Drawing.Size(111, 13);
            this.lblMedida2.TabIndex = 4;
            this.lblMedida2.Text = "Agrega una medida 2:";
            // 
            // txtMedida2
            // 
            this.txtMedida2.Enabled = false;
            this.txtMedida2.Location = new System.Drawing.Point(346, 61);
            this.txtMedida2.Name = "txtMedida2";
            this.txtMedida2.Size = new System.Drawing.Size(100, 20);
            this.txtMedida2.TabIndex = 5;
            this.txtMedida2.TextChanged += new System.EventHandler(this.txtMedida2_TextChanged);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(457, 98);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(285, 125);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(373, 125);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(54, 13);
            this.lblPerimetro.TabIndex = 8;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblArea2
            // 
            this.lblArea2.AutoSize = true;
            this.lblArea2.Location = new System.Drawing.Point(323, 125);
            this.lblArea2.Name = "lblArea2";
            this.lblArea2.Size = new System.Drawing.Size(13, 13);
            this.lblArea2.TabIndex = 9;
            this.lblArea2.Text = "0";
            // 
            // lblPerimetro2
            // 
            this.lblPerimetro2.AutoSize = true;
            this.lblPerimetro2.Location = new System.Drawing.Point(433, 125);
            this.lblPerimetro2.Name = "lblPerimetro2";
            this.lblPerimetro2.Size = new System.Drawing.Size(13, 13);
            this.lblPerimetro2.TabIndex = 10;
            this.lblPerimetro2.Text = "0";
            // 
            // lblMedida3
            // 
            this.lblMedida3.AutoSize = true;
            this.lblMedida3.Enabled = false;
            this.lblMedida3.Location = new System.Drawing.Point(473, 15);
            this.lblMedida3.Name = "lblMedida3";
            this.lblMedida3.Size = new System.Drawing.Size(111, 13);
            this.lblMedida3.TabIndex = 11;
            this.lblMedida3.Text = "Agrega una medida 3:";
            // 
            // lblMedida4
            // 
            this.lblMedida4.AutoSize = true;
            this.lblMedida4.Enabled = false;
            this.lblMedida4.Location = new System.Drawing.Point(473, 64);
            this.lblMedida4.Name = "lblMedida4";
            this.lblMedida4.Size = new System.Drawing.Size(111, 13);
            this.lblMedida4.TabIndex = 12;
            this.lblMedida4.Text = "Agrega una medida 4:";
            // 
            // txtMedida3
            // 
            this.txtMedida3.Enabled = false;
            this.txtMedida3.Location = new System.Drawing.Point(590, 12);
            this.txtMedida3.Name = "txtMedida3";
            this.txtMedida3.Size = new System.Drawing.Size(100, 20);
            this.txtMedida3.TabIndex = 13;
            // 
            // txtMedida4
            // 
            this.txtMedida4.Enabled = false;
            this.txtMedida4.Location = new System.Drawing.Point(590, 61);
            this.txtMedida4.Name = "txtMedida4";
            this.txtMedida4.Size = new System.Drawing.Size(100, 20);
            this.txtMedida4.TabIndex = 14;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 49);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(89, 13);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "Tipo de triangulo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Escaleno",
            "Isosceles",
            "Equilatero"});
            this.cmbTipo.Location = new System.Drawing.Point(107, 46);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 16;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // frmFigGeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 170);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtMedida4);
            this.Controls.Add(this.txtMedida3);
            this.Controls.Add(this.lblMedida4);
            this.Controls.Add(this.lblMedida3);
            this.Controls.Add(this.lblPerimetro2);
            this.Controls.Add(this.lblArea2);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtMedida2);
            this.Controls.Add(this.lblMedida2);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.cmbFigura);
            this.Name = "frmFigGeo";
            this.Text = "Figuras geometricas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label lblMedida2;
        private System.Windows.Forms.TextBox txtMedida2;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea2;
        private System.Windows.Forms.Label lblPerimetro2;
        private System.Windows.Forms.Label lblMedida3;
        private System.Windows.Forms.Label lblMedida4;
        private System.Windows.Forms.TextBox txtMedida3;
        private System.Windows.Forms.TextBox txtMedida4;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

