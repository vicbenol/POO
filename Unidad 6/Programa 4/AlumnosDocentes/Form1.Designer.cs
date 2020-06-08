namespace AlumnosDocentes
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
            this.btnAgregsrMas = new System.Windows.Forms.Button();
            this.btnAgregarAlu = new System.Windows.Forms.Button();
            this.dtgAlumno = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgMaestro = new System.Windows.Forms.DataGridView();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantAlu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgrMas = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimir2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaestro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregsrMas
            // 
            this.btnAgregsrMas.Location = new System.Drawing.Point(235, 365);
            this.btnAgregsrMas.Name = "btnAgregsrMas";
            this.btnAgregsrMas.Size = new System.Drawing.Size(75, 23);
            this.btnAgregsrMas.TabIndex = 35;
            this.btnAgregsrMas.Text = "Agregar";
            this.btnAgregsrMas.UseVisualStyleBackColor = true;
            this.btnAgregsrMas.Click += new System.EventHandler(this.btnAgregsrMas_Click);
            // 
            // btnAgregarAlu
            // 
            this.btnAgregarAlu.Location = new System.Drawing.Point(202, 23);
            this.btnAgregarAlu.Name = "btnAgregarAlu";
            this.btnAgregarAlu.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAlu.TabIndex = 22;
            this.btnAgregarAlu.Text = "Agregar";
            this.btnAgregarAlu.UseVisualStyleBackColor = true;
            this.btnAgregarAlu.Click += new System.EventHandler(this.btnAgregarAlu_Click);
            // 
            // dtgAlumno
            // 
            this.dtgAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha,
            this.Curp,
            this.Telefono,
            this.Email,
            this.Control,
            this.Carrera,
            this.Materias,
            this.Promedio});
            this.dtgAlumno.Location = new System.Drawing.Point(12, 57);
            this.dtgAlumno.Name = "dtgAlumno";
            this.dtgAlumno.Size = new System.Drawing.Size(623, 226);
            this.dtgAlumno.TabIndex = 2;
            this.dtgAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlumno_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.Name = "Nombre";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Curp
            // 
            this.Curp.HeaderText = "Curp";
            this.Curp.Name = "Curp";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Control
            // 
            this.Control.HeaderText = "No. de control";
            this.Control.Name = "Control";
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            // 
            // Materias
            // 
            this.Materias.HeaderText = "Materias";
            this.Materias.Name = "Materias";
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            // 
            // dtgMaestro
            // 
            this.dtgMaestro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMaestro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre2,
            this.Fecha2,
            this.Curp2,
            this.Telefono2,
            this.Email2,
            this.Numero2,
            this.Sueldo,
            this.MatImp});
            this.dtgMaestro.Location = new System.Drawing.Point(12, 401);
            this.dtgMaestro.Name = "dtgMaestro";
            this.dtgMaestro.Size = new System.Drawing.Size(618, 226);
            this.dtgMaestro.TabIndex = 3;
            // 
            // Nombre2
            // 
            this.Nombre2.HeaderText = "Nombre";
            this.Nombre2.Name = "Nombre2";
            // 
            // Fecha2
            // 
            this.Fecha2.HeaderText = "Fecha";
            this.Fecha2.Name = "Fecha2";
            // 
            // Curp2
            // 
            this.Curp2.HeaderText = "Curp";
            this.Curp2.Name = "Curp2";
            // 
            // Telefono2
            // 
            this.Telefono2.HeaderText = "Telefono";
            this.Telefono2.Name = "Telefono2";
            // 
            // Email2
            // 
            this.Email2.HeaderText = "Email";
            this.Email2.Name = "Email2";
            // 
            // Numero2
            // 
            this.Numero2.HeaderText = "No. de control";
            this.Numero2.Name = "Numero2";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // MatImp
            // 
            this.MatImp.HeaderText = "Materias impartidas";
            this.MatImp.Name = "MatImp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuantos alumnos son:";
            // 
            // txtCantAlu
            // 
            this.txtCantAlu.Location = new System.Drawing.Point(129, 25);
            this.txtCantAlu.Name = "txtCantAlu";
            this.txtCantAlu.Size = new System.Drawing.Size(67, 20);
            this.txtCantAlu.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cuantos maestros son:";
            // 
            // txtAgrMas
            // 
            this.txtAgrMas.Location = new System.Drawing.Point(129, 367);
            this.txtAgrMas.Name = "txtAgrMas";
            this.txtAgrMas.Size = new System.Drawing.Size(100, 20);
            this.txtAgrMas.TabIndex = 25;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(12, 289);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimir2
            // 
            this.btnImprimir2.Location = new System.Drawing.Point(12, 633);
            this.btnImprimir2.Name = "btnImprimir2";
            this.btnImprimir2.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir2.TabIndex = 36;
            this.btnImprimir2.Text = "Imprimir";
            this.btnImprimir2.UseVisualStyleBackColor = true;
            this.btnImprimir2.Click += new System.EventHandler(this.btnImprimir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 659);
            this.Controls.Add(this.txtAgrMas);
            this.Controls.Add(this.btnImprimir2);
            this.Controls.Add(this.btnAgregsrMas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtCantAlu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgMaestro);
            this.Controls.Add(this.dtgAlumno);
            this.Controls.Add(this.btnAgregarAlu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaestro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarAlu;
        private System.Windows.Forms.Button btnAgregsrMas;
        private System.Windows.Forms.DataGridView dtgAlumno;
        private System.Windows.Forms.DataGridView dtgMaestro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Control;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgrMas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatImp;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimir2;
    }
}

