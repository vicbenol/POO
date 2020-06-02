namespace EmpleadosRestaurante
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
            this.grpMesero = new System.Windows.Forms.GroupBox();
            this.lblPagaMese = new System.Windows.Forms.Label();
            this.lblSemaMese = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcuMese = new System.Windows.Forms.Button();
            this.txtSueldoMese = new System.Windows.Forms.TextBox();
            this.lblSueldoMese = new System.Windows.Forms.Label();
            this.txtPropinaMese = new System.Windows.Forms.TextBox();
            this.lblPropinaMese = new System.Windows.Forms.Label();
            this.lblTrabaMese = new System.Windows.Forms.Label();
            this.dtpNacimese = new System.Windows.Forms.DateTimePicker();
            this.txtNombreMese = new System.Windows.Forms.TextBox();
            this.lblNombreMese = new System.Windows.Forms.Label();
            this.grpRepartidor = new System.Windows.Forms.GroupBox();
            this.txtSueldoRepaDia = new System.Windows.Forms.TextBox();
            this.lblSueldoRepaDia = new System.Windows.Forms.Label();
            this.cmbDiasRepa = new System.Windows.Forms.ComboBox();
            this.cmbZonaRepa = new System.Windows.Forms.ComboBox();
            this.txtPediRepa = new System.Windows.Forms.TextBox();
            this.txtPropiRepa = new System.Windows.Forms.TextBox();
            this.dtpFechaRepa = new System.Windows.Forms.DateTimePicker();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnCalcuRepa = new System.Windows.Forms.Button();
            this.lblPagaRepa = new System.Windows.Forms.Label();
            this.lblSemaRepa = new System.Windows.Forms.Label();
            this.lblPediRepa = new System.Windows.Forms.Label();
            this.lblZonaRepa = new System.Windows.Forms.Label();
            this.lblPropiRepa = new System.Windows.Forms.Label();
            this.lblDiasRepa = new System.Windows.Forms.Label();
            this.lblNaciRepa = new System.Windows.Forms.Label();
            this.lblNombreRepa = new System.Windows.Forms.Label();
            this.grpCajera = new System.Windows.Forms.GroupBox();
            this.cmbDiasCaja = new System.Windows.Forms.ComboBox();
            this.cmbNumCaja = new System.Windows.Forms.ComboBox();
            this.txtSueldoCajaDia = new System.Windows.Forms.TextBox();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCaja = new System.Windows.Forms.TextBox();
            this.btnCalcuCaja = new System.Windows.Forms.Button();
            this.lblTotalCaja = new System.Windows.Forms.Label();
            this.lblSemaCaja = new System.Windows.Forms.Label();
            this.lblSueldoCajaDia = new System.Windows.Forms.Label();
            this.lblNumCaja = new System.Windows.Forms.Label();
            this.lblDiasCaja = new System.Windows.Forms.Label();
            this.lblFechaCaja = new System.Windows.Forms.Label();
            this.lblNombreCaja = new System.Windows.Forms.Label();
            this.cmbDiaMese = new System.Windows.Forms.ComboBox();
            this.grpMesero.SuspendLayout();
            this.grpRepartidor.SuspendLayout();
            this.grpCajera.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMesero
            // 
            this.grpMesero.Controls.Add(this.cmbDiaMese);
            this.grpMesero.Controls.Add(this.lblPagaMese);
            this.grpMesero.Controls.Add(this.lblSemaMese);
            this.grpMesero.Controls.Add(this.label1);
            this.grpMesero.Controls.Add(this.btnCalcuMese);
            this.grpMesero.Controls.Add(this.txtSueldoMese);
            this.grpMesero.Controls.Add(this.lblSueldoMese);
            this.grpMesero.Controls.Add(this.txtPropinaMese);
            this.grpMesero.Controls.Add(this.lblPropinaMese);
            this.grpMesero.Controls.Add(this.lblTrabaMese);
            this.grpMesero.Controls.Add(this.dtpNacimese);
            this.grpMesero.Controls.Add(this.txtNombreMese);
            this.grpMesero.Controls.Add(this.lblNombreMese);
            this.grpMesero.Location = new System.Drawing.Point(12, 13);
            this.grpMesero.Name = "grpMesero";
            this.grpMesero.Size = new System.Drawing.Size(224, 213);
            this.grpMesero.TabIndex = 0;
            this.grpMesero.TabStop = false;
            this.grpMesero.Text = "Mesero";
            // 
            // lblPagaMese
            // 
            this.lblPagaMese.AutoSize = true;
            this.lblPagaMese.Location = new System.Drawing.Point(105, 168);
            this.lblPagaMese.Name = "lblPagaMese";
            this.lblPagaMese.Size = new System.Drawing.Size(13, 13);
            this.lblPagaMese.TabIndex = 13;
            this.lblPagaMese.Text = "0";
            // 
            // lblSemaMese
            // 
            this.lblSemaMese.AutoSize = true;
            this.lblSemaMese.Location = new System.Drawing.Point(14, 168);
            this.lblSemaMese.Name = "lblSemaMese";
            this.lblSemaMese.Size = new System.Drawing.Size(85, 13);
            this.lblSemaMese.TabIndex = 12;
            this.lblSemaMese.Text = "Sueldo semanal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha de nacimiento:";
            // 
            // btnCalcuMese
            // 
            this.btnCalcuMese.Location = new System.Drawing.Point(70, 184);
            this.btnCalcuMese.Name = "btnCalcuMese";
            this.btnCalcuMese.Size = new System.Drawing.Size(75, 23);
            this.btnCalcuMese.TabIndex = 10;
            this.btnCalcuMese.Text = "Calcular";
            this.btnCalcuMese.UseVisualStyleBackColor = true;
            this.btnCalcuMese.Click += new System.EventHandler(this.btnCalcuMese_Click);
            // 
            // txtSueldoMese
            // 
            this.txtSueldoMese.Location = new System.Drawing.Point(83, 131);
            this.txtSueldoMese.Name = "txtSueldoMese";
            this.txtSueldoMese.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoMese.TabIndex = 9;
            // 
            // lblSueldoMese
            // 
            this.lblSueldoMese.AutoSize = true;
            this.lblSueldoMese.Location = new System.Drawing.Point(6, 134);
            this.lblSueldoMese.Name = "lblSueldoMese";
            this.lblSueldoMese.Size = new System.Drawing.Size(71, 13);
            this.lblSueldoMese.TabIndex = 8;
            this.lblSueldoMese.Text = "Sueldo diario:";
            // 
            // txtPropinaMese
            // 
            this.txtPropinaMese.Location = new System.Drawing.Point(99, 101);
            this.txtPropinaMese.Name = "txtPropinaMese";
            this.txtPropinaMese.Size = new System.Drawing.Size(100, 20);
            this.txtPropinaMese.TabIndex = 6;
            // 
            // lblPropinaMese
            // 
            this.lblPropinaMese.AutoSize = true;
            this.lblPropinaMese.Location = new System.Drawing.Point(6, 104);
            this.lblPropinaMese.Name = "lblPropinaMese";
            this.lblPropinaMese.Size = new System.Drawing.Size(93, 13);
            this.lblPropinaMese.TabIndex = 5;
            this.lblPropinaMese.Text = "Propinas semanal:";
            // 
            // lblTrabaMese
            // 
            this.lblTrabaMese.AutoSize = true;
            this.lblTrabaMese.Location = new System.Drawing.Point(6, 74);
            this.lblTrabaMese.Name = "lblTrabaMese";
            this.lblTrabaMese.Size = new System.Drawing.Size(83, 13);
            this.lblTrabaMese.TabIndex = 3;
            this.lblTrabaMese.Text = "Dias trabajados:";
            // 
            // dtpNacimese
            // 
            this.dtpNacimese.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNacimese.Location = new System.Drawing.Point(121, 39);
            this.dtpNacimese.Name = "dtpNacimese";
            this.dtpNacimese.Size = new System.Drawing.Size(88, 20);
            this.dtpNacimese.TabIndex = 2;
            // 
            // txtNombreMese
            // 
            this.txtNombreMese.Location = new System.Drawing.Point(59, 13);
            this.txtNombreMese.Name = "txtNombreMese";
            this.txtNombreMese.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMese.TabIndex = 1;
            // 
            // lblNombreMese
            // 
            this.lblNombreMese.AutoSize = true;
            this.lblNombreMese.Location = new System.Drawing.Point(6, 16);
            this.lblNombreMese.Name = "lblNombreMese";
            this.lblNombreMese.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMese.TabIndex = 0;
            this.lblNombreMese.Text = "Nombre:";
            // 
            // grpRepartidor
            // 
            this.grpRepartidor.Controls.Add(this.txtSueldoRepaDia);
            this.grpRepartidor.Controls.Add(this.lblSueldoRepaDia);
            this.grpRepartidor.Controls.Add(this.cmbDiasRepa);
            this.grpRepartidor.Controls.Add(this.cmbZonaRepa);
            this.grpRepartidor.Controls.Add(this.txtPediRepa);
            this.grpRepartidor.Controls.Add(this.txtPropiRepa);
            this.grpRepartidor.Controls.Add(this.dtpFechaRepa);
            this.grpRepartidor.Controls.Add(this.txt);
            this.grpRepartidor.Controls.Add(this.btnCalcuRepa);
            this.grpRepartidor.Controls.Add(this.lblPagaRepa);
            this.grpRepartidor.Controls.Add(this.lblSemaRepa);
            this.grpRepartidor.Controls.Add(this.lblPediRepa);
            this.grpRepartidor.Controls.Add(this.lblZonaRepa);
            this.grpRepartidor.Controls.Add(this.lblPropiRepa);
            this.grpRepartidor.Controls.Add(this.lblDiasRepa);
            this.grpRepartidor.Controls.Add(this.lblNaciRepa);
            this.grpRepartidor.Controls.Add(this.lblNombreRepa);
            this.grpRepartidor.Location = new System.Drawing.Point(265, 1);
            this.grpRepartidor.Name = "grpRepartidor";
            this.grpRepartidor.Size = new System.Drawing.Size(232, 251);
            this.grpRepartidor.TabIndex = 1;
            this.grpRepartidor.TabStop = false;
            this.grpRepartidor.Text = "Repartidor ";
            // 
            // txtSueldoRepaDia
            // 
            this.txtSueldoRepaDia.Location = new System.Drawing.Point(83, 180);
            this.txtSueldoRepaDia.Name = "txtSueldoRepaDia";
            this.txtSueldoRepaDia.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoRepaDia.TabIndex = 17;
            // 
            // lblSueldoRepaDia
            // 
            this.lblSueldoRepaDia.AutoSize = true;
            this.lblSueldoRepaDia.Location = new System.Drawing.Point(6, 180);
            this.lblSueldoRepaDia.Name = "lblSueldoRepaDia";
            this.lblSueldoRepaDia.Size = new System.Drawing.Size(71, 13);
            this.lblSueldoRepaDia.TabIndex = 16;
            this.lblSueldoRepaDia.Text = "Sueldo diario:";
            // 
            // cmbDiasRepa
            // 
            this.cmbDiasRepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasRepa.FormattingEnabled = true;
            this.cmbDiasRepa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasRepa.Location = new System.Drawing.Point(91, 71);
            this.cmbDiasRepa.Name = "cmbDiasRepa";
            this.cmbDiasRepa.Size = new System.Drawing.Size(121, 21);
            this.cmbDiasRepa.TabIndex = 15;
            // 
            // cmbZonaRepa
            // 
            this.cmbZonaRepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZonaRepa.FormattingEnabled = true;
            this.cmbZonaRepa.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbZonaRepa.Location = new System.Drawing.Point(91, 127);
            this.cmbZonaRepa.Name = "cmbZonaRepa";
            this.cmbZonaRepa.Size = new System.Drawing.Size(121, 21);
            this.cmbZonaRepa.TabIndex = 14;
            // 
            // txtPediRepa
            // 
            this.txtPediRepa.Location = new System.Drawing.Point(114, 154);
            this.txtPediRepa.Name = "txtPediRepa";
            this.txtPediRepa.Size = new System.Drawing.Size(100, 20);
            this.txtPediRepa.TabIndex = 13;
            // 
            // txtPropiRepa
            // 
            this.txtPropiRepa.Location = new System.Drawing.Point(116, 101);
            this.txtPropiRepa.Name = "txtPropiRepa";
            this.txtPropiRepa.Size = new System.Drawing.Size(100, 20);
            this.txtPropiRepa.TabIndex = 12;
            // 
            // dtpFechaRepa
            // 
            this.dtpFechaRepa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRepa.Location = new System.Drawing.Point(114, 39);
            this.dtpFechaRepa.Name = "dtpFechaRepa";
            this.dtpFechaRepa.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaRepa.TabIndex = 10;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(59, 13);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 9;
            // 
            // btnCalcuRepa
            // 
            this.btnCalcuRepa.Location = new System.Drawing.Point(84, 222);
            this.btnCalcuRepa.Name = "btnCalcuRepa";
            this.btnCalcuRepa.Size = new System.Drawing.Size(75, 23);
            this.btnCalcuRepa.TabIndex = 8;
            this.btnCalcuRepa.Text = "Calcular";
            this.btnCalcuRepa.UseVisualStyleBackColor = true;
            this.btnCalcuRepa.Click += new System.EventHandler(this.btnCalcuRepa_Click);
            // 
            // lblPagaRepa
            // 
            this.lblPagaRepa.AutoSize = true;
            this.lblPagaRepa.Location = new System.Drawing.Point(97, 201);
            this.lblPagaRepa.Name = "lblPagaRepa";
            this.lblPagaRepa.Size = new System.Drawing.Size(13, 13);
            this.lblPagaRepa.TabIndex = 7;
            this.lblPagaRepa.Text = "0";
            // 
            // lblSemaRepa
            // 
            this.lblSemaRepa.AutoSize = true;
            this.lblSemaRepa.Location = new System.Drawing.Point(6, 201);
            this.lblSemaRepa.Name = "lblSemaRepa";
            this.lblSemaRepa.Size = new System.Drawing.Size(85, 13);
            this.lblSemaRepa.TabIndex = 6;
            this.lblSemaRepa.Text = "Sueldo semanal:";
            // 
            // lblPediRepa
            // 
            this.lblPediRepa.AutoSize = true;
            this.lblPediRepa.Location = new System.Drawing.Point(6, 157);
            this.lblPediRepa.Name = "lblPediRepa";
            this.lblPediRepa.Size = new System.Drawing.Size(104, 13);
            this.lblPediRepa.TabIndex = 5;
            this.lblPediRepa.Text = "Pedidos entregados:";
            // 
            // lblZonaRepa
            // 
            this.lblZonaRepa.AutoSize = true;
            this.lblZonaRepa.Location = new System.Drawing.Point(6, 134);
            this.lblZonaRepa.Name = "lblZonaRepa";
            this.lblZonaRepa.Size = new System.Drawing.Size(79, 13);
            this.lblZonaRepa.TabIndex = 4;
            this.lblZonaRepa.Text = "Zona repartida:";
            // 
            // lblPropiRepa
            // 
            this.lblPropiRepa.AutoSize = true;
            this.lblPropiRepa.Location = new System.Drawing.Point(6, 104);
            this.lblPropiRepa.Name = "lblPropiRepa";
            this.lblPropiRepa.Size = new System.Drawing.Size(104, 13);
            this.lblPropiRepa.TabIndex = 3;
            this.lblPropiRepa.Text = "Propinas semanales:";
            // 
            // lblDiasRepa
            // 
            this.lblDiasRepa.AutoSize = true;
            this.lblDiasRepa.Location = new System.Drawing.Point(6, 74);
            this.lblDiasRepa.Name = "lblDiasRepa";
            this.lblDiasRepa.Size = new System.Drawing.Size(83, 13);
            this.lblDiasRepa.TabIndex = 2;
            this.lblDiasRepa.Text = "Dias trabajados:";
            // 
            // lblNaciRepa
            // 
            this.lblNaciRepa.AutoSize = true;
            this.lblNaciRepa.Location = new System.Drawing.Point(6, 45);
            this.lblNaciRepa.Name = "lblNaciRepa";
            this.lblNaciRepa.Size = new System.Drawing.Size(109, 13);
            this.lblNaciRepa.TabIndex = 1;
            this.lblNaciRepa.Text = "Fecha de nacimiento:";
            // 
            // lblNombreRepa
            // 
            this.lblNombreRepa.AutoSize = true;
            this.lblNombreRepa.Location = new System.Drawing.Point(6, 16);
            this.lblNombreRepa.Name = "lblNombreRepa";
            this.lblNombreRepa.Size = new System.Drawing.Size(47, 13);
            this.lblNombreRepa.TabIndex = 0;
            this.lblNombreRepa.Text = "Nombre:";
            // 
            // grpCajera
            // 
            this.grpCajera.Controls.Add(this.cmbDiasCaja);
            this.grpCajera.Controls.Add(this.cmbNumCaja);
            this.grpCajera.Controls.Add(this.txtSueldoCajaDia);
            this.grpCajera.Controls.Add(this.dtpFechaCaja);
            this.grpCajera.Controls.Add(this.txtNombreCaja);
            this.grpCajera.Controls.Add(this.btnCalcuCaja);
            this.grpCajera.Controls.Add(this.lblTotalCaja);
            this.grpCajera.Controls.Add(this.lblSemaCaja);
            this.grpCajera.Controls.Add(this.lblSueldoCajaDia);
            this.grpCajera.Controls.Add(this.lblNumCaja);
            this.grpCajera.Controls.Add(this.lblDiasCaja);
            this.grpCajera.Controls.Add(this.lblFechaCaja);
            this.grpCajera.Controls.Add(this.lblNombreCaja);
            this.grpCajera.Location = new System.Drawing.Point(503, 7);
            this.grpCajera.Name = "grpCajera";
            this.grpCajera.Size = new System.Drawing.Size(224, 239);
            this.grpCajera.TabIndex = 2;
            this.grpCajera.TabStop = false;
            this.grpCajera.Text = "Cajera";
            // 
            // cmbDiasCaja
            // 
            this.cmbDiasCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasCaja.FormattingEnabled = true;
            this.cmbDiasCaja.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasCaja.Location = new System.Drawing.Point(94, 74);
            this.cmbDiasCaja.Name = "cmbDiasCaja";
            this.cmbDiasCaja.Size = new System.Drawing.Size(121, 21);
            this.cmbDiasCaja.TabIndex = 30;
            // 
            // cmbNumCaja
            // 
            this.cmbNumCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumCaja.FormattingEnabled = true;
            this.cmbNumCaja.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbNumCaja.Location = new System.Drawing.Point(94, 105);
            this.cmbNumCaja.Name = "cmbNumCaja";
            this.cmbNumCaja.Size = new System.Drawing.Size(121, 21);
            this.cmbNumCaja.TabIndex = 29;
            // 
            // txtSueldoCajaDia
            // 
            this.txtSueldoCajaDia.Location = new System.Drawing.Point(86, 134);
            this.txtSueldoCajaDia.Name = "txtSueldoCajaDia";
            this.txtSueldoCajaDia.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoCajaDia.TabIndex = 28;
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaja.Location = new System.Drawing.Point(117, 42);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaCaja.TabIndex = 26;
            // 
            // txtNombreCaja
            // 
            this.txtNombreCaja.Location = new System.Drawing.Point(62, 16);
            this.txtNombreCaja.Name = "txtNombreCaja";
            this.txtNombreCaja.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCaja.TabIndex = 25;
            // 
            // btnCalcuCaja
            // 
            this.btnCalcuCaja.Location = new System.Drawing.Point(94, 184);
            this.btnCalcuCaja.Name = "btnCalcuCaja";
            this.btnCalcuCaja.Size = new System.Drawing.Size(75, 23);
            this.btnCalcuCaja.TabIndex = 24;
            this.btnCalcuCaja.Text = "Calcular";
            this.btnCalcuCaja.UseVisualStyleBackColor = true;
            this.btnCalcuCaja.Click += new System.EventHandler(this.btnCalcuCaja_Click);
            // 
            // lblTotalCaja
            // 
            this.lblTotalCaja.AutoSize = true;
            this.lblTotalCaja.Location = new System.Drawing.Point(100, 168);
            this.lblTotalCaja.Name = "lblTotalCaja";
            this.lblTotalCaja.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCaja.TabIndex = 23;
            this.lblTotalCaja.Text = "0";
            // 
            // lblSemaCaja
            // 
            this.lblSemaCaja.AutoSize = true;
            this.lblSemaCaja.Location = new System.Drawing.Point(9, 168);
            this.lblSemaCaja.Name = "lblSemaCaja";
            this.lblSemaCaja.Size = new System.Drawing.Size(85, 13);
            this.lblSemaCaja.TabIndex = 22;
            this.lblSemaCaja.Text = "Sueldo semanal:";
            // 
            // lblSueldoCajaDia
            // 
            this.lblSueldoCajaDia.AutoSize = true;
            this.lblSueldoCajaDia.Location = new System.Drawing.Point(9, 135);
            this.lblSueldoCajaDia.Name = "lblSueldoCajaDia";
            this.lblSueldoCajaDia.Size = new System.Drawing.Size(71, 13);
            this.lblSueldoCajaDia.TabIndex = 21;
            this.lblSueldoCajaDia.Text = "Sueldo diario:";
            // 
            // lblNumCaja
            // 
            this.lblNumCaja.AutoSize = true;
            this.lblNumCaja.Location = new System.Drawing.Point(9, 108);
            this.lblNumCaja.Name = "lblNumCaja";
            this.lblNumCaja.Size = new System.Drawing.Size(85, 13);
            this.lblNumCaja.TabIndex = 20;
            this.lblNumCaja.Text = "Numero de caja:";
            // 
            // lblDiasCaja
            // 
            this.lblDiasCaja.AutoSize = true;
            this.lblDiasCaja.Location = new System.Drawing.Point(9, 77);
            this.lblDiasCaja.Name = "lblDiasCaja";
            this.lblDiasCaja.Size = new System.Drawing.Size(83, 13);
            this.lblDiasCaja.TabIndex = 18;
            this.lblDiasCaja.Text = "Dias trabajados:";
            // 
            // lblFechaCaja
            // 
            this.lblFechaCaja.AutoSize = true;
            this.lblFechaCaja.Location = new System.Drawing.Point(9, 48);
            this.lblFechaCaja.Name = "lblFechaCaja";
            this.lblFechaCaja.Size = new System.Drawing.Size(109, 13);
            this.lblFechaCaja.TabIndex = 17;
            this.lblFechaCaja.Text = "Fecha de nacimiento:";
            // 
            // lblNombreCaja
            // 
            this.lblNombreCaja.AutoSize = true;
            this.lblNombreCaja.Location = new System.Drawing.Point(9, 19);
            this.lblNombreCaja.Name = "lblNombreCaja";
            this.lblNombreCaja.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCaja.TabIndex = 16;
            this.lblNombreCaja.Text = "Nombre:";
            // 
            // cmbDiaMese
            // 
            this.cmbDiaMese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaMese.FormattingEnabled = true;
            this.cmbDiaMese.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiaMese.Location = new System.Drawing.Point(95, 71);
            this.cmbDiaMese.Name = "cmbDiaMese";
            this.cmbDiaMese.Size = new System.Drawing.Size(121, 21);
            this.cmbDiaMese.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 254);
            this.Controls.Add(this.grpCajera);
            this.Controls.Add(this.grpRepartidor);
            this.Controls.Add(this.grpMesero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMesero.ResumeLayout(false);
            this.grpMesero.PerformLayout();
            this.grpRepartidor.ResumeLayout(false);
            this.grpRepartidor.PerformLayout();
            this.grpCajera.ResumeLayout(false);
            this.grpCajera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMesero;
        private System.Windows.Forms.Label lblPagaMese;
        private System.Windows.Forms.Label lblSemaMese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcuMese;
        private System.Windows.Forms.TextBox txtSueldoMese;
        private System.Windows.Forms.Label lblSueldoMese;
        private System.Windows.Forms.TextBox txtPropinaMese;
        private System.Windows.Forms.Label lblPropinaMese;
        private System.Windows.Forms.Label lblTrabaMese;
        private System.Windows.Forms.DateTimePicker dtpNacimese;
        private System.Windows.Forms.TextBox txtNombreMese;
        private System.Windows.Forms.Label lblNombreMese;
        private System.Windows.Forms.GroupBox grpRepartidor;
        private System.Windows.Forms.Label lblPagaRepa;
        private System.Windows.Forms.Label lblSemaRepa;
        private System.Windows.Forms.Label lblPediRepa;
        private System.Windows.Forms.Label lblZonaRepa;
        private System.Windows.Forms.Label lblPropiRepa;
        private System.Windows.Forms.Label lblDiasRepa;
        private System.Windows.Forms.Label lblNaciRepa;
        private System.Windows.Forms.Label lblNombreRepa;
        private System.Windows.Forms.Button btnCalcuRepa;
        private System.Windows.Forms.TextBox txtSueldoRepaDia;
        private System.Windows.Forms.Label lblSueldoRepaDia;
        private System.Windows.Forms.ComboBox cmbDiasRepa;
        private System.Windows.Forms.ComboBox cmbZonaRepa;
        private System.Windows.Forms.TextBox txtPediRepa;
        private System.Windows.Forms.TextBox txtPropiRepa;
        private System.Windows.Forms.DateTimePicker dtpFechaRepa;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.GroupBox grpCajera;
        private System.Windows.Forms.ComboBox cmbDiasCaja;
        private System.Windows.Forms.ComboBox cmbNumCaja;
        private System.Windows.Forms.TextBox txtSueldoCajaDia;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;
        private System.Windows.Forms.TextBox txtNombreCaja;
        private System.Windows.Forms.Button btnCalcuCaja;
        private System.Windows.Forms.Label lblTotalCaja;
        private System.Windows.Forms.Label lblSemaCaja;
        private System.Windows.Forms.Label lblSueldoCajaDia;
        private System.Windows.Forms.Label lblNumCaja;
        private System.Windows.Forms.Label lblDiasCaja;
        private System.Windows.Forms.Label lblFechaCaja;
        private System.Windows.Forms.Label lblNombreCaja;
        private System.Windows.Forms.ComboBox cmbDiaMese;
    }
}

