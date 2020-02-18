namespace RegistroDePersonas
{
    partial class Concierto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concierto));
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.lblAsistente = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.btnContabilizar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblNiños = new System.Windows.Forms.Label();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblTercera = new System.Windows.Forms.Label();
            this.lblBebes2 = new System.Windows.Forms.Label();
            this.lblNiños2 = new System.Windows.Forms.Label();
            this.lblAdultos2 = new System.Windows.Forms.Label();
            this.lblTercera2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Items.AddRange(new object[] {
            "Bebes",
            "Niños",
            "Adultos",
            "Tercera Edad"});
            this.cmbPersonas.Location = new System.Drawing.Point(184, 32);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(101, 21);
            this.cmbPersonas.TabIndex = 0;
            this.cmbPersonas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblAsistente
            // 
            this.lblAsistente.AutoSize = true;
            this.lblAsistente.Location = new System.Drawing.Point(125, 35);
            this.lblAsistente.Name = "lblAsistente";
            this.lblAsistente.Size = new System.Drawing.Size(53, 13);
            this.lblAsistente.TabIndex = 1;
            this.lblAsistente.Text = "Asistente:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(300, 35);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCantidad.Location = new System.Drawing.Point(358, 32);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(80, 21);
            this.cmbCantidad.TabIndex = 3;
            this.cmbCantidad.SelectedIndexChanged += new System.EventHandler(this.cmbCantidad_SelectedIndexChanged);
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContabilizar.Location = new System.Drawing.Point(444, 30);
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(75, 23);
            this.btnContabilizar.TabIndex = 4;
            this.btnContabilizar.Text = "Contabilizar ";
            this.btnContabilizar.UseVisualStyleBackColor = true;
            this.btnContabilizar.Click += new System.EventHandler(this.btnContabilizar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReporte.Location = new System.Drawing.Point(308, 93);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(178, 218);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Bebes:";
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.Location = new System.Drawing.Point(248, 218);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(37, 13);
            this.lblNiños.TabIndex = 7;
            this.lblNiños.Text = "Niños:";
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(319, 218);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(45, 13);
            this.lblAdultos.TabIndex = 8;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblTercera
            // 
            this.lblTercera.AutoSize = true;
            this.lblTercera.Location = new System.Drawing.Point(396, 218);
            this.lblTercera.Name = "lblTercera";
            this.lblTercera.Size = new System.Drawing.Size(74, 13);
            this.lblTercera.TabIndex = 9;
            this.lblTercera.Text = "Tercera edad:";
            // 
            // lblBebes2
            // 
            this.lblBebes2.AutoSize = true;
            this.lblBebes2.Location = new System.Drawing.Point(224, 218);
            this.lblBebes2.Name = "lblBebes2";
            this.lblBebes2.Size = new System.Drawing.Size(13, 13);
            this.lblBebes2.TabIndex = 10;
            this.lblBebes2.Text = "0";
            // 
            // lblNiños2
            // 
            this.lblNiños2.AutoSize = true;
            this.lblNiños2.Location = new System.Drawing.Point(291, 218);
            this.lblNiños2.Name = "lblNiños2";
            this.lblNiños2.Size = new System.Drawing.Size(13, 13);
            this.lblNiños2.TabIndex = 11;
            this.lblNiños2.Text = "0";
            // 
            // lblAdultos2
            // 
            this.lblAdultos2.AutoSize = true;
            this.lblAdultos2.Location = new System.Drawing.Point(370, 218);
            this.lblAdultos2.Name = "lblAdultos2";
            this.lblAdultos2.Size = new System.Drawing.Size(13, 13);
            this.lblAdultos2.TabIndex = 12;
            this.lblAdultos2.Text = "0";
            // 
            // lblTercera2
            // 
            this.lblTercera2.AutoSize = true;
            this.lblTercera2.Location = new System.Drawing.Point(476, 218);
            this.lblTercera2.Name = "lblTercera2";
            this.lblTercera2.Size = new System.Drawing.Size(13, 13);
            this.lblTercera2.TabIndex = 13;
            this.lblTercera2.Text = "0";
            // 
            // Concierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RegistroDePersonas.Properties.Resources.logo_tecnm;
            this.ClientSize = new System.Drawing.Size(531, 290);
            this.Controls.Add(this.lblTercera2);
            this.Controls.Add(this.lblAdultos2);
            this.Controls.Add(this.lblNiños2);
            this.Controls.Add(this.lblBebes2);
            this.Controls.Add(this.lblTercera);
            this.Controls.Add(this.lblAdultos);
            this.Controls.Add(this.lblNiños);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnContabilizar);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblAsistente);
            this.Controls.Add(this.cmbPersonas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Concierto";
            this.Text = "Concierto";
            this.Load += new System.EventHandler(this.Concierto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.Label lblAsistente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Button btnContabilizar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNiños;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Label lblTercera;
        private System.Windows.Forms.Label lblBebes2;
        private System.Windows.Forms.Label lblNiños2;
        private System.Windows.Forms.Label lblAdultos2;
        private System.Windows.Forms.Label lblTercera2;
    }
}

