namespace WinModuloNomina.Vista
{
    partial class F4Asistencias
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
            salidaAlmBtn = new Button();
            entradaAlmBtn = new Button();
            salidaBtn = new Button();
            inasistenciaBtn = new Button();
            ingresoAsisBtn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            fechaPreLb = new Label();
            relojLb = new Label();
            relojPreLb = new Label();
            fechaLb = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            registroLb = new Label();
            registroCb = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            licenciaLb = new Label();
            licenciaCb = new ComboBox();
            licenciasLb = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            idEmpl = new Label();
            empleCedCb = new ComboBox();
            nomApeEmplLb = new Label();
            empleNomApeCb = new ComboBox();
            cedEmpleLb = new Label();
            idEmplLb = new Label();
            limpiarBtn = new FontAwesome.Sharp.IconButton();
            infoLb = new Label();
            label11 = new Label();
            idAsisTxt = new TextBox();
            asistenciasFormDTOBindingSource = new BindingSource(components);
            empleadosDgv = new DataGridView();
            idEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            puestoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            generoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaIngresoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            fechaCreacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaModificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadosBindingSource = new BindingSource(components);
            relojTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)asistenciasFormDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadosDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(salidaAlmBtn);
            panel1.Controls.Add(entradaAlmBtn);
            panel1.Controls.Add(salidaBtn);
            panel1.Controls.Add(inasistenciaBtn);
            panel1.Controls.Add(ingresoAsisBtn);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(limpiarBtn);
            panel1.Controls.Add(infoLb);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 166);
            panel1.TabIndex = 2;
            // 
            // salidaAlmBtn
            // 
            salidaAlmBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            salidaAlmBtn.Location = new Point(873, 102);
            salidaAlmBtn.Name = "salidaAlmBtn";
            salidaAlmBtn.Size = new Size(120, 23);
            salidaAlmBtn.TabIndex = 22;
            salidaAlmBtn.TabStop = false;
            salidaAlmBtn.Text = "Salida Almuerzo";
            salidaAlmBtn.UseVisualStyleBackColor = true;
            salidaAlmBtn.Click += salidaAlmBtn_Click;
            // 
            // entradaAlmBtn
            // 
            entradaAlmBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            entradaAlmBtn.Location = new Point(873, 69);
            entradaAlmBtn.Name = "entradaAlmBtn";
            entradaAlmBtn.Size = new Size(120, 23);
            entradaAlmBtn.TabIndex = 21;
            entradaAlmBtn.TabStop = false;
            entradaAlmBtn.Text = "Entrada Almuerzo";
            entradaAlmBtn.UseVisualStyleBackColor = true;
            entradaAlmBtn.Click += entradaAlmBtn_Click;
            // 
            // salidaBtn
            // 
            salidaBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            salidaBtn.Location = new Point(873, 131);
            salidaBtn.Name = "salidaBtn";
            salidaBtn.Size = new Size(120, 23);
            salidaBtn.TabIndex = 20;
            salidaBtn.TabStop = false;
            salidaBtn.Text = "Salida dia";
            salidaBtn.UseVisualStyleBackColor = true;
            salidaBtn.Click += salidaBtn_Click;
            // 
            // inasistenciaBtn
            // 
            inasistenciaBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inasistenciaBtn.Location = new Point(1029, 36);
            inasistenciaBtn.Name = "inasistenciaBtn";
            inasistenciaBtn.Size = new Size(118, 23);
            inasistenciaBtn.TabIndex = 19;
            inasistenciaBtn.TabStop = false;
            inasistenciaBtn.Text = "Ingreso inasistencia";
            inasistenciaBtn.UseVisualStyleBackColor = true;
            inasistenciaBtn.Click += inasistenciaBtn_Click;
            // 
            // ingresoAsisBtn
            // 
            ingresoAsisBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ingresoAsisBtn.Location = new Point(873, 36);
            ingresoAsisBtn.Name = "ingresoAsisBtn";
            ingresoAsisBtn.Size = new Size(120, 23);
            ingresoAsisBtn.TabIndex = 18;
            ingresoAsisBtn.TabStop = false;
            ingresoAsisBtn.Text = "Entrada dia";
            ingresoAsisBtn.UseVisualStyleBackColor = true;
            ingresoAsisBtn.Click += ingresoAsisBtn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(fechaPreLb, 0, 1);
            tableLayoutPanel3.Controls.Add(relojLb, 1, 0);
            tableLayoutPanel3.Controls.Add(relojPreLb, 0, 0);
            tableLayoutPanel3.Controls.Add(fechaLb, 1, 1);
            tableLayoutPanel3.Location = new Point(634, 36);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(196, 47);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // fechaPreLb
            // 
            fechaPreLb.AutoSize = true;
            fechaPreLb.Location = new Point(3, 23);
            fechaPreLb.Name = "fechaPreLb";
            fechaPreLb.Size = new Size(41, 15);
            fechaPreLb.TabIndex = 18;
            fechaPreLb.Text = "Fecha:";
            // 
            // relojLb
            // 
            relojLb.AutoSize = true;
            relojLb.BackColor = SystemColors.Control;
            relojLb.ForeColor = SystemColors.ControlText;
            relojLb.Location = new Point(101, 0);
            relojLb.Name = "relojLb";
            relojLb.Size = new Size(0, 15);
            relojLb.TabIndex = 16;
            // 
            // relojPreLb
            // 
            relojPreLb.AutoSize = true;
            relojPreLb.Location = new Point(3, 0);
            relojPreLb.Name = "relojPreLb";
            relojPreLb.Size = new Size(36, 15);
            relojPreLb.TabIndex = 17;
            relojPreLb.Text = "Hora:";
            // 
            // fechaLb
            // 
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(101, 23);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(0, 15);
            fechaLb.TabIndex = 19;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(registroLb, 0, 0);
            tableLayoutPanel4.Controls.Add(registroCb, 0, 1);
            tableLayoutPanel4.Location = new Point(16, 36);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 46.42857F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 53.57143F));
            tableLayoutPanel4.Size = new Size(170, 56);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // registroLb
            // 
            registroLb.AutoSize = true;
            registroLb.Location = new Point(3, 0);
            registroLb.Name = "registroLb";
            registroLb.Size = new Size(69, 15);
            registroLb.TabIndex = 0;
            registroLb.Text = "Registro de:";
            // 
            // registroCb
            // 
            registroCb.FormattingEnabled = true;
            registroCb.Location = new Point(3, 29);
            registroCb.Name = "registroCb";
            registroCb.Size = new Size(164, 23);
            registroCb.TabIndex = 1;
            registroCb.SelectedIndexChanged += registroCb_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.61702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.38298F));
            tableLayoutPanel2.Controls.Add(licenciaLb, 0, 0);
            tableLayoutPanel2.Controls.Add(licenciaCb, 1, 0);
            tableLayoutPanel2.Controls.Add(licenciasLb, 0, 1);
            tableLayoutPanel2.Location = new Point(16, 126);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(211, 31);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // licenciaLb
            // 
            licenciaLb.AutoSize = true;
            licenciaLb.Location = new Point(3, 0);
            licenciaLb.Name = "licenciaLb";
            licenciaLb.Size = new Size(64, 1);
            licenciaLb.TabIndex = 29;
            licenciaLb.Text = "ID Licencia";
            // 
            // licenciaCb
            // 
            licenciaCb.FormattingEnabled = true;
            licenciaCb.Location = new Point(95, 2);
            licenciaCb.Margin = new Padding(3, 2, 3, 2);
            licenciaCb.Name = "licenciaCb";
            licenciaCb.Size = new Size(113, 23);
            licenciaCb.TabIndex = 29;
            // 
            // licenciasLb
            // 
            licenciasLb.AutoSize = true;
            licenciasLb.Location = new Point(3, 0);
            licenciasLb.Name = "licenciasLb";
            licenciasLb.Size = new Size(58, 15);
            licenciasLb.TabIndex = 16;
            licenciasLb.Text = "Licencias:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.7288132F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.2711868F));
            tableLayoutPanel1.Controls.Add(idEmpl, 0, 0);
            tableLayoutPanel1.Controls.Add(empleCedCb, 1, 1);
            tableLayoutPanel1.Controls.Add(nomApeEmplLb, 0, 2);
            tableLayoutPanel1.Controls.Add(empleNomApeCb, 1, 2);
            tableLayoutPanel1.Controls.Add(cedEmpleLb, 0, 1);
            tableLayoutPanel1.Controls.Add(idEmplLb, 1, 0);
            tableLayoutPanel1.Location = new Point(277, 36);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.8333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.1666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(295, 77);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // idEmpl
            // 
            idEmpl.AutoSize = true;
            idEmpl.Location = new Point(3, 0);
            idEmpl.Name = "idEmpl";
            idEmpl.Size = new Size(74, 15);
            idEmpl.TabIndex = 7;
            idEmpl.Text = "ID Empleado";
            // 
            // empleCedCb
            // 
            empleCedCb.FormattingEnabled = true;
            empleCedCb.Location = new Point(132, 24);
            empleCedCb.Margin = new Padding(3, 2, 3, 2);
            empleCedCb.Name = "empleCedCb";
            empleCedCb.Size = new Size(160, 23);
            empleCedCb.TabIndex = 25;
            empleCedCb.SelectedIndexChanged += empleCedCb_SelectedIndexChanged;
            // 
            // nomApeEmplLb
            // 
            nomApeEmplLb.AutoSize = true;
            nomApeEmplLb.Location = new Point(3, 48);
            nomApeEmplLb.Name = "nomApeEmplLb";
            nomApeEmplLb.Size = new Size(117, 15);
            nomApeEmplLb.TabIndex = 26;
            nomApeEmplLb.Text = "Nombres y Apellidos";
            // 
            // empleNomApeCb
            // 
            empleNomApeCb.FormattingEnabled = true;
            empleNomApeCb.Location = new Point(132, 50);
            empleNomApeCb.Margin = new Padding(3, 2, 3, 2);
            empleNomApeCb.Name = "empleNomApeCb";
            empleNomApeCb.Size = new Size(160, 23);
            empleNomApeCb.TabIndex = 27;
            // 
            // cedEmpleLb
            // 
            cedEmpleLb.AutoSize = true;
            cedEmpleLb.Location = new Point(3, 22);
            cedEmpleLb.Name = "cedEmpleLb";
            cedEmpleLb.Size = new Size(100, 15);
            cedEmpleLb.TabIndex = 28;
            cedEmpleLb.Text = "Cedula Empleado";
            // 
            // idEmplLb
            // 
            idEmplLb.AutoSize = true;
            idEmplLb.Location = new Point(132, 0);
            idEmplLb.Name = "idEmplLb";
            idEmplLb.Size = new Size(0, 15);
            idEmplLb.TabIndex = 29;
            // 
            // limpiarBtn
            // 
            limpiarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            limpiarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            limpiarBtn.IconColor = Color.Black;
            limpiarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiarBtn.Location = new Point(470, 128);
            limpiarBtn.Margin = new Padding(3, 2, 3, 2);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(102, 29);
            limpiarBtn.TabIndex = 13;
            limpiarBtn.Text = "Limpiar datos";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // infoLb
            // 
            infoLb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            infoLb.Location = new Point(16, 9);
            infoLb.Name = "infoLb";
            infoLb.Size = new Size(144, 15);
            infoLb.TabIndex = 6;
            infoLb.Text = "CONTROL DE ASISTENCIA";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.Location = new Point(10, 7);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 5;
            // 
            // idAsisTxt
            // 
            idAsisTxt.Location = new Point(260, 3);
            idAsisTxt.Margin = new Padding(3, 2, 3, 2);
            idAsisTxt.Name = "idAsisTxt";
            idAsisTxt.ReadOnly = true;
            idAsisTxt.Size = new Size(246, 23);
            idAsisTxt.TabIndex = 7;
            // 
            // empleadosDgv
            // 
            empleadosDgv.AutoGenerateColumns = false;
            empleadosDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empleadosDgv.Columns.AddRange(new DataGridViewColumn[] { idEmpleadoDataGridViewTextBoxColumn, puestoIdDataGridViewTextBoxColumn, nombresDataGridViewTextBoxColumn, apellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, generoDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, fechaIngresoDataGridViewTextBoxColumn, estadoDataGridViewCheckBoxColumn, fechaCreacionDataGridViewTextBoxColumn, fechaModificacionDataGridViewTextBoxColumn });
            empleadosDgv.DataSource = empleadosBindingSource;
            empleadosDgv.Dock = DockStyle.Fill;
            empleadosDgv.Location = new Point(0, 166);
            empleadosDgv.Name = "empleadosDgv";
            empleadosDgv.RowHeadersWidth = 51;
            empleadosDgv.Size = new Size(1159, 172);
            empleadosDgv.TabIndex = 10;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            // 
            // puestoIdDataGridViewTextBoxColumn
            // 
            puestoIdDataGridViewTextBoxColumn.DataPropertyName = "PuestoId";
            puestoIdDataGridViewTextBoxColumn.HeaderText = "PuestoId";
            puestoIdDataGridViewTextBoxColumn.Name = "puestoIdDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            // 
            // empleadosBindingSource
            // 
            empleadosBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.Empleados);
            // 
            // relojTimer
            // 
            relojTimer.Enabled = true;
            relojTimer.Interval = 1000;
            relojTimer.Tick += relojTimer_Tick;
            // 
            // F4Asistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 338);
            Controls.Add(empleadosDgv);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "F4Asistencias";
            Text = "F4Asistencias";
            Load += F4Asistencias_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)asistenciasFormDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadosDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private DataGridViewTextBoxColumn idAsistenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresApellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaSalidaDataGridViewTextBoxColumn;
        private BindingSource asistenciasFormDTOBindingSource;
        private Label infoLb;
        private TableLayoutPanel tableLayoutPanel1;
        private Label idEmpl;
        private TextBox idAsisTxt;

        private ComboBox empleCedCb;
        private FontAwesome.Sharp.IconButton limpiarBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView empleadosDgv;
        private TableLayoutPanel tableLayoutPanel4;
        private Label registroLb;
        private ComboBox registroCb;
        private DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puestoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private BindingSource empleadosBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private Label licenciasLb;
        private Label licenciaLb;
        private ComboBox licenciaCb;
        private Label nomApeEmplLb;
        private ComboBox empleNomApeCb;
        private Label cedEmpleLb;
        private Label relojLb;
        private System.Windows.Forms.Timer relojTimer;
        private Label fechaPreLb;
        private Label relojPreLb;
        private Label fechaLb;
        private Button ingresoAsisBtn;
        private Label idEmplLb;
        private Button inasistenciaBtn;
        private Button salidaBtn;
        private Button salidaAlmBtn;
        private Button entradaAlmBtn;
    }
}