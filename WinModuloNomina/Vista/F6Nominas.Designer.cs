using WinModuloNomina.Modelo;

namespace WinModuloNomina.Vista
{
    partial class F6Nominas
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            empleNomLb1 = new Label();
            empleNombrePresen = new Label();
            nominasIngeManuLb = new Label();
            limpiarBtn = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            nominaLb = new Label();
            idNomTxt = new TextBox();
            anioLb = new Label();
            mesLb = new Label();
            idEmpleadoLb = new Label();
            salManTxt = new TextBox();
            boniManTxt = new TextBox();
            salarioLb = new Label();
            bonificacionesLb = new Label();
            fecEmisionLb = new Label();
            descuentosLb = new Label();
            descManTxt = new TextBox();
            empleAutoCb = new ComboBox();
            mesAutoCb = new ComboBox();
            anioNud = new NumericUpDown();
            fecEmiDtp = new DateTimePicker();
            panel2 = new Panel();
            eliminarBtn = new FontAwesome.Sharp.IconButton();
            insertarBtn = new FontAwesome.Sharp.IconButton();
            actualizarBtn = new FontAwesome.Sharp.IconButton();
            nominasActivasDgv = new DataGridView();
            idNominaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaEmisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresApellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasJornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasLaboradasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasLaboradasFormateadasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioHorasLaboradasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonificacionesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descuentosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioNetoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nominasDTOBindingSource2 = new BindingSource(components);
            nominasDTOBindingSource = new BindingSource(components);
            panel3 = new Panel();
            presentLb = new Label();
            nominasDTOBindingSource1 = new BindingSource(components);
            nominasMenBtn = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anioNud).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nominasActivasDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(nominasMenBtn);
            panel1.Controls.Add(empleNomLb1);
            panel1.Controls.Add(empleNombrePresen);
            panel1.Controls.Add(nominasIngeManuLb);
            panel1.Controls.Add(limpiarBtn);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 178);
            panel1.TabIndex = 2;
            // 
            // empleNomLb1
            // 
            empleNomLb1.AutoSize = true;
            empleNomLb1.Location = new Point(444, 9);
            empleNomLb1.Name = "empleNomLb1";
            empleNomLb1.Size = new Size(0, 15);
            empleNomLb1.TabIndex = 14;
            // 
            // empleNombrePresen
            // 
            empleNombrePresen.AutoSize = true;
            empleNombrePresen.Location = new Point(288, 9);
            empleNombrePresen.Name = "empleNombrePresen";
            empleNombrePresen.Size = new Size(107, 15);
            empleNombrePresen.TabIndex = 13;
            empleNombrePresen.Text = "Nombre Empleado";
            // 
            // nominasIngeManuLb
            // 
            nominasIngeManuLb.AutoSize = true;
            nominasIngeManuLb.Location = new Point(12, 9);
            nominasIngeManuLb.Name = "nominasIngeManuLb";
            nominasIngeManuLb.Size = new Size(111, 15);
            nominasIngeManuLb.TabIndex = 11;
            nominasIngeManuLb.Text = "DATOS DE NOMINA";
            nominasIngeManuLb.TextAlign = ContentAlignment.TopCenter;
            // 
            // limpiarBtn
            // 
            limpiarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            limpiarBtn.IconColor = Color.Black;
            limpiarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiarBtn.Location = new Point(742, 126);
            limpiarBtn.Margin = new Padding(3, 2, 3, 2);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(163, 26);
            limpiarBtn.TabIndex = 12;
            limpiarBtn.Text = "Limpiar datos";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(nominaLb, 0, 0);
            tableLayoutPanel1.Controls.Add(idNomTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(anioLb, 0, 1);
            tableLayoutPanel1.Controls.Add(mesLb, 2, 1);
            tableLayoutPanel1.Controls.Add(idEmpleadoLb, 2, 0);
            tableLayoutPanel1.Controls.Add(salManTxt, 1, 2);
            tableLayoutPanel1.Controls.Add(boniManTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(salarioLb, 0, 2);
            tableLayoutPanel1.Controls.Add(bonificacionesLb, 0, 3);
            tableLayoutPanel1.Controls.Add(fecEmisionLb, 2, 2);
            tableLayoutPanel1.Controls.Add(descuentosLb, 2, 3);
            tableLayoutPanel1.Controls.Add(descManTxt, 3, 3);
            tableLayoutPanel1.Controls.Add(empleAutoCb, 3, 0);
            tableLayoutPanel1.Controls.Add(mesAutoCb, 3, 1);
            tableLayoutPanel1.Controls.Add(anioNud, 1, 1);
            tableLayoutPanel1.Controls.Add(fecEmiDtp, 3, 2);
            tableLayoutPanel1.Location = new Point(66, 38);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(592, 114);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // nominaLb
            // 
            nominaLb.AutoSize = true;
            nominaLb.Location = new Point(3, 0);
            nominaLb.Name = "nominaLb";
            nominaLb.Size = new Size(64, 15);
            nominaLb.TabIndex = 7;
            nominaLb.Text = "ID Nomina";
            // 
            // idNomTxt
            // 
            idNomTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idNomTxt.Location = new Point(93, 3);
            idNomTxt.Margin = new Padding(3, 2, 3, 2);
            idNomTxt.Name = "idNomTxt";
            idNomTxt.ReadOnly = true;
            idNomTxt.Size = new Size(123, 23);
            idNomTxt.TabIndex = 7;
            // 
            // anioLb
            // 
            anioLb.AutoSize = true;
            anioLb.Location = new Point(3, 29);
            anioLb.Name = "anioLb";
            anioLb.Size = new Size(29, 15);
            anioLb.TabIndex = 22;
            anioLb.Text = "Año";
            // 
            // mesLb
            // 
            mesLb.AutoSize = true;
            mesLb.Location = new Point(222, 29);
            mesLb.Name = "mesLb";
            mesLb.Size = new Size(29, 15);
            mesLb.TabIndex = 20;
            mesLb.Text = "Mes";
            // 
            // idEmpleadoLb
            // 
            idEmpleadoLb.AutoSize = true;
            idEmpleadoLb.Location = new Point(222, 0);
            idEmpleadoLb.Name = "idEmpleadoLb";
            idEmpleadoLb.Size = new Size(122, 15);
            idEmpleadoLb.TabIndex = 18;
            idEmpleadoLb.Text = "Cédula  del Empleado";
            // 
            // salManTxt
            // 
            salManTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            salManTxt.Location = new Point(93, 61);
            salManTxt.Margin = new Padding(3, 2, 3, 2);
            salManTxt.Name = "salManTxt";
            salManTxt.Size = new Size(123, 23);
            salManTxt.TabIndex = 26;
            // 
            // boniManTxt
            // 
            boniManTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boniManTxt.Location = new Point(93, 89);
            boniManTxt.Margin = new Padding(3, 2, 3, 2);
            boniManTxt.Name = "boniManTxt";
            boniManTxt.Size = new Size(123, 23);
            boniManTxt.TabIndex = 15;
            // 
            // salarioLb
            // 
            salarioLb.AutoSize = true;
            salarioLb.Location = new Point(3, 58);
            salarioLb.Name = "salarioLb";
            salarioLb.Size = new Size(74, 15);
            salarioLb.TabIndex = 24;
            salarioLb.Text = "Salario Bruto";
            // 
            // bonificacionesLb
            // 
            bonificacionesLb.AutoSize = true;
            bonificacionesLb.Location = new Point(3, 87);
            bonificacionesLb.Name = "bonificacionesLb";
            bonificacionesLb.Size = new Size(84, 15);
            bonificacionesLb.TabIndex = 17;
            bonificacionesLb.Text = "Bonificaciones";
            // 
            // fecEmisionLb
            // 
            fecEmisionLb.AutoSize = true;
            fecEmisionLb.Location = new Point(222, 58);
            fecEmisionLb.Name = "fecEmisionLb";
            fecEmisionLb.Size = new Size(99, 15);
            fecEmisionLb.TabIndex = 25;
            fecEmisionLb.Text = "Fecha de emisión";
            // 
            // descuentosLb
            // 
            descuentosLb.AutoSize = true;
            descuentosLb.Location = new Point(222, 87);
            descuentosLb.Name = "descuentosLb";
            descuentosLb.Size = new Size(68, 15);
            descuentosLb.TabIndex = 19;
            descuentosLb.Text = "Descuentos";
            // 
            // descManTxt
            // 
            descManTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descManTxt.Location = new Point(350, 89);
            descManTxt.Margin = new Padding(3, 2, 3, 2);
            descManTxt.Name = "descManTxt";
            descManTxt.Size = new Size(239, 23);
            descManTxt.TabIndex = 11;
            // 
            // empleAutoCb
            // 
            empleAutoCb.FormattingEnabled = true;
            empleAutoCb.Location = new Point(350, 3);
            empleAutoCb.Name = "empleAutoCb";
            empleAutoCb.Size = new Size(239, 23);
            empleAutoCb.TabIndex = 27;
            empleAutoCb.SelectedIndexChanged += empleAutoCb_SelectedIndexChanged;
            // 
            // mesAutoCb
            // 
            mesAutoCb.FormattingEnabled = true;
            mesAutoCb.Location = new Point(350, 32);
            mesAutoCb.Name = "mesAutoCb";
            mesAutoCb.Size = new Size(239, 23);
            mesAutoCb.TabIndex = 28;
            // 
            // anioNud
            // 
            anioNud.Location = new Point(93, 32);
            anioNud.Name = "anioNud";
            anioNud.Size = new Size(120, 23);
            anioNud.TabIndex = 29;
            // 
            // fecEmiDtp
            // 
            fecEmiDtp.Format = DateTimePickerFormat.Short;
            fecEmiDtp.Location = new Point(350, 61);
            fecEmiDtp.Name = "fecEmiDtp";
            fecEmiDtp.Size = new Size(239, 23);
            fecEmiDtp.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Controls.Add(eliminarBtn);
            panel2.Controls.Add(insertarBtn);
            panel2.Controls.Add(actualizarBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(976, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(138, 178);
            panel2.TabIndex = 4;
            // 
            // eliminarBtn
            // 
            eliminarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            eliminarBtn.IconColor = Color.Black;
            eliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarBtn.Location = new Point(33, 131);
            eliminarBtn.Margin = new Padding(3, 2, 3, 2);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(82, 22);
            eliminarBtn.TabIndex = 12;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // insertarBtn
            // 
            insertarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            insertarBtn.IconColor = Color.Black;
            insertarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            insertarBtn.Location = new Point(33, 70);
            insertarBtn.Margin = new Padding(3, 2, 3, 2);
            insertarBtn.Name = "insertarBtn";
            insertarBtn.Size = new Size(82, 22);
            insertarBtn.TabIndex = 9;
            insertarBtn.Text = "Insertar";
            insertarBtn.UseVisualStyleBackColor = true;
            insertarBtn.Click += ingAutoBtn_Click;
            // 
            // actualizarBtn
            // 
            actualizarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            actualizarBtn.IconColor = Color.Black;
            actualizarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            actualizarBtn.Location = new Point(33, 102);
            actualizarBtn.Margin = new Padding(3, 2, 3, 2);
            actualizarBtn.Name = "actualizarBtn";
            actualizarBtn.Size = new Size(82, 22);
            actualizarBtn.TabIndex = 11;
            actualizarBtn.Text = "Actualizar";
            actualizarBtn.UseVisualStyleBackColor = true;
            actualizarBtn.Click += actualizarBtn_Click;
            // 
            // nominasActivasDgv
            // 
            nominasActivasDgv.AutoGenerateColumns = false;
            nominasActivasDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            nominasActivasDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            nominasActivasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nominasActivasDgv.Columns.AddRange(new DataGridViewColumn[] { idNominaDataGridViewTextBoxColumn, idEmpleadoDataGridViewTextBoxColumn, fechaEmisionDataGridViewTextBoxColumn, mesDataGridViewTextBoxColumn, anioDataGridViewTextBoxColumn, nombresApellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, horasJornadaDataGridViewTextBoxColumn, horasLaboradasDataGridViewTextBoxColumn, horasLaboradasFormateadasDataGridViewTextBoxColumn, salarioHorasLaboradasDataGridViewTextBoxColumn, bonificacionesDataGridViewTextBoxColumn, descuentosDataGridViewTextBoxColumn, salarioNetoDataGridViewTextBoxColumn });
            nominasActivasDgv.DataSource = nominasDTOBindingSource2;
            nominasActivasDgv.Dock = DockStyle.Fill;
            nominasActivasDgv.Location = new Point(0, 212);
            nominasActivasDgv.Margin = new Padding(3, 2, 3, 2);
            nominasActivasDgv.Name = "nominasActivasDgv";
            nominasActivasDgv.RowHeadersWidth = 51;
            nominasActivasDgv.Size = new Size(1114, 99);
            nominasActivasDgv.TabIndex = 8;
            nominasActivasDgv.CellClick += nominasActivasDgv_CellClick;
            nominasActivasDgv.DataBindingComplete += nominasActivasDgv_DataBindingComplete;
            // 
            // idNominaDataGridViewTextBoxColumn
            // 
            idNominaDataGridViewTextBoxColumn.DataPropertyName = "IdNomina";
            idNominaDataGridViewTextBoxColumn.HeaderText = "IdNomina";
            idNominaDataGridViewTextBoxColumn.Name = "idNominaDataGridViewTextBoxColumn";
            idNominaDataGridViewTextBoxColumn.Visible = false;
            idNominaDataGridViewTextBoxColumn.Width = 85;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            idEmpleadoDataGridViewTextBoxColumn.Visible = false;
            idEmpleadoDataGridViewTextBoxColumn.Width = 95;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            fechaEmisionDataGridViewTextBoxColumn.HeaderText = "FechaEmision";
            fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            fechaEmisionDataGridViewTextBoxColumn.Width = 105;
            // 
            // mesDataGridViewTextBoxColumn
            // 
            mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            mesDataGridViewTextBoxColumn.Width = 54;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            anioDataGridViewTextBoxColumn.HeaderText = "Anio";
            anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            anioDataGridViewTextBoxColumn.Width = 57;
            // 
            // nombresApellidosDataGridViewTextBoxColumn
            // 
            nombresApellidosDataGridViewTextBoxColumn.DataPropertyName = "NombresApellidos";
            nombresApellidosDataGridViewTextBoxColumn.HeaderText = "NombresApellidos";
            nombresApellidosDataGridViewTextBoxColumn.Name = "nombresApellidosDataGridViewTextBoxColumn";
            nombresApellidosDataGridViewTextBoxColumn.Width = 130;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            cedulaDataGridViewTextBoxColumn.Width = 69;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            salarioDataGridViewTextBoxColumn.Width = 67;
            // 
            // horasJornadaDataGridViewTextBoxColumn
            // 
            horasJornadaDataGridViewTextBoxColumn.DataPropertyName = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.HeaderText = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.Name = "horasJornadaDataGridViewTextBoxColumn";
            horasJornadaDataGridViewTextBoxColumn.Width = 104;
            // 
            // horasLaboradasDataGridViewTextBoxColumn
            // 
            horasLaboradasDataGridViewTextBoxColumn.DataPropertyName = "HorasLaboradas";
            horasLaboradasDataGridViewTextBoxColumn.HeaderText = "HorasLaboradas";
            horasLaboradasDataGridViewTextBoxColumn.Name = "horasLaboradasDataGridViewTextBoxColumn";
            horasLaboradasDataGridViewTextBoxColumn.Visible = false;
            horasLaboradasDataGridViewTextBoxColumn.Width = 117;
            // 
            // horasLaboradasFormateadasDataGridViewTextBoxColumn
            // 
            horasLaboradasFormateadasDataGridViewTextBoxColumn.DataPropertyName = "HorasLaboradasFormateadas";
            horasLaboradasFormateadasDataGridViewTextBoxColumn.HeaderText = "HorasLaboradasFormateadas";
            horasLaboradasFormateadasDataGridViewTextBoxColumn.Name = "horasLaboradasFormateadasDataGridViewTextBoxColumn";
            horasLaboradasFormateadasDataGridViewTextBoxColumn.ReadOnly = true;
            horasLaboradasFormateadasDataGridViewTextBoxColumn.Width = 185;
            // 
            // salarioHorasLaboradasDataGridViewTextBoxColumn
            // 
            salarioHorasLaboradasDataGridViewTextBoxColumn.DataPropertyName = "SalarioHorasLaboradas";
            salarioHorasLaboradasDataGridViewTextBoxColumn.HeaderText = "SalarioHorasLaboradas";
            salarioHorasLaboradasDataGridViewTextBoxColumn.Name = "salarioHorasLaboradasDataGridViewTextBoxColumn";
            salarioHorasLaboradasDataGridViewTextBoxColumn.Width = 152;
            // 
            // bonificacionesDataGridViewTextBoxColumn
            // 
            bonificacionesDataGridViewTextBoxColumn.DataPropertyName = "Bonificaciones";
            bonificacionesDataGridViewTextBoxColumn.HeaderText = "Bonificaciones";
            bonificacionesDataGridViewTextBoxColumn.Name = "bonificacionesDataGridViewTextBoxColumn";
            bonificacionesDataGridViewTextBoxColumn.Width = 109;
            // 
            // descuentosDataGridViewTextBoxColumn
            // 
            descuentosDataGridViewTextBoxColumn.DataPropertyName = "Descuentos";
            descuentosDataGridViewTextBoxColumn.HeaderText = "Descuentos";
            descuentosDataGridViewTextBoxColumn.Name = "descuentosDataGridViewTextBoxColumn";
            descuentosDataGridViewTextBoxColumn.Width = 93;
            // 
            // salarioNetoDataGridViewTextBoxColumn
            // 
            salarioNetoDataGridViewTextBoxColumn.DataPropertyName = "SalarioNeto";
            salarioNetoDataGridViewTextBoxColumn.HeaderText = "SalarioNeto";
            salarioNetoDataGridViewTextBoxColumn.Name = "salarioNetoDataGridViewTextBoxColumn";
            salarioNetoDataGridViewTextBoxColumn.Width = 93;
            // 
            // nominasDTOBindingSource2
            // 
            nominasDTOBindingSource2.DataSource = typeof(NominasDTO);
            // 
            // nominasDTOBindingSource
            // 
            nominasDTOBindingSource.DataSource = typeof(NominasDTO);
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(presentLb);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 178);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1114, 34);
            panel3.TabIndex = 10;
            // 
            // presentLb
            // 
            presentLb.AutoSize = true;
            presentLb.Location = new Point(3, 19);
            presentLb.Name = "presentLb";
            presentLb.Size = new Size(96, 15);
            presentLb.TabIndex = 10;
            presentLb.Text = "Nominas Activas";
            presentLb.TextAlign = ContentAlignment.TopCenter;
            // 
            // nominasDTOBindingSource1
            // 
            nominasDTOBindingSource1.DataSource = typeof(NominasDTO);
            // 
            // nominasMenBtn
            // 
            nominasMenBtn.Location = new Point(742, 59);
            nominasMenBtn.Name = "nominasMenBtn";
            nominasMenBtn.Size = new Size(163, 23);
            nominasMenBtn.TabIndex = 15;
            nominasMenBtn.Text = "Insertar nóminas mensuales";
            nominasMenBtn.UseVisualStyleBackColor = true;
            nominasMenBtn.Click += nominasMenBtn_Click;
            // 
            // F6Nominas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 311);
            Controls.Add(nominasActivasDgv);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "F6Nominas";
            Text = "F6Nominas";
            Load += F6Nominas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anioNud).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nominasActivasDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label salarioLb;
        private Label anioLb;
        private Label mesLb;
        private Label descuentosLb;
        private Label idEmpleadoLb;
        private Label bonificacionesLb;
        private Label nominaLb;
        private TextBox idNomTxt;
        private TextBox boniManTxt;
        private TextBox descManTxt;
        private DataGridView nominasActivasDgv;
        private FontAwesome.Sharp.IconButton limpiarBtn;
        private FontAwesome.Sharp.IconButton actualizarBtn;
        private Panel panel3;
        private Label fecEmisionLb;
        private TextBox salManTxt;
        private BindingSource nominasDTOBindingSource;
        private Label nominasIngeManuLb;
        private Label presentLb;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton insertarBtn;
        private ComboBox empleAutoCb;
        private ComboBox mesAutoCb;
        private NumericUpDown anioNud;
        private DateTimePicker fecEmiDtp;
        private FontAwesome.Sharp.IconButton eliminarBtn;
        private Label empleNomLb1;
        private Label empleNombrePresen;
        private TableLayoutPanel tableLayoutPanel2;
        private BindingSource nominasDTOBindingSource1;
        private DataGridViewTextBoxColumn idNominaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresApellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasJornadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasLaboradasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasLaboradasFormateadasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioHorasLaboradasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bonificacionesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descuentosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioNetoDataGridViewTextBoxColumn;
        private BindingSource nominasDTOBindingSource2;
        private Button nominasMenBtn;
    }
}