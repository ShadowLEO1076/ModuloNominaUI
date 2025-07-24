namespace WinModuloNomina.Vista
{
    partial class F3Contratos
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
            tableLayoutPanel3 = new TableLayoutPanel();
            cbEmpleado = new ComboBox();
            cbEstadoContrato = new ComboBox();
            cbTipoContrato = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            label14 = new Label();
            label16 = new Label();
            txtIdContrato = new TextBox();
            label15 = new Label();
            label13 = new Label();
            txtSalario = new TextBox();
            label11 = new Label();
            label9 = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            txtHorasJornada = new NumericUpDown();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtNombreTipo = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtIdTipoContrato = new TextBox();
            cbJornadaTipo = new ComboBox();
            dgvTipoContrato = new DataGridView();
            idTipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contratosTipoBindingSource = new BindingSource(components);
            panel4 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            txtBuscarContrato = new TextBox();
            btnBuscarContrato = new FontAwesome.Sharp.IconButton();
            btnBorrarTipoContrato = new FontAwesome.Sharp.IconButton();
            btnCrearContrato = new FontAwesome.Sharp.IconButton();
            btnEditarContrato = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvHistorialContratos = new Zuby.ADGV.AdvancedDataGridView();
            idContratoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaInicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaCreacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaModificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasJornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contratosBindingSource = new BindingSource(components);
            panel3 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtHorasJornada).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoContrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialContratos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosBindingSource).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 296);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Controls.Add(cbEmpleado, 1, 2);
            tableLayoutPanel3.Controls.Add(cbEstadoContrato, 3, 1);
            tableLayoutPanel3.Controls.Add(cbTipoContrato, 1, 1);
            tableLayoutPanel3.Controls.Add(label10, 0, 3);
            tableLayoutPanel3.Controls.Add(label12, 0, 2);
            tableLayoutPanel3.Controls.Add(label14, 0, 1);
            tableLayoutPanel3.Controls.Add(label16, 0, 0);
            tableLayoutPanel3.Controls.Add(txtIdContrato, 1, 0);
            tableLayoutPanel3.Controls.Add(label15, 0, 4);
            tableLayoutPanel3.Controls.Add(label13, 2, 0);
            tableLayoutPanel3.Controls.Add(txtSalario, 3, 0);
            tableLayoutPanel3.Controls.Add(label11, 2, 1);
            tableLayoutPanel3.Controls.Add(label9, 2, 2);
            tableLayoutPanel3.Controls.Add(dtpFechaInicio, 1, 3);
            tableLayoutPanel3.Controls.Add(dtpFechaFin, 1, 4);
            tableLayoutPanel3.Controls.Add(txtHorasJornada, 3, 2);
            tableLayoutPanel3.Location = new Point(353, 50);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(521, 246);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // cbEmpleado
            // 
            cbEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(81, 108);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(176, 28);
            cbEmpleado.TabIndex = 26;
            // 
            // cbEstadoContrato
            // 
            cbEstadoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbEstadoContrato.FormattingEnabled = true;
            cbEstadoContrato.Location = new Point(341, 59);
            cbEstadoContrato.Name = "cbEstadoContrato";
            cbEstadoContrato.Size = new Size(177, 28);
            cbEstadoContrato.TabIndex = 25;
            // 
            // cbTipoContrato
            // 
            cbTipoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbTipoContrato.FormattingEnabled = true;
            cbTipoContrato.Location = new Point(81, 59);
            cbTipoContrato.Name = "cbTipoContrato";
            cbTipoContrato.Size = new Size(176, 28);
            cbTipoContrato.TabIndex = 24;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(17, 161);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 22;
            label10.Text = "F.Inicio:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(7, 102);
            label12.Name = "label12";
            label12.Size = new Size(68, 40);
            label12.TabIndex = 20;
            label12.Text = "Empleado:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(33, 63);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 18;
            label14.Text = "Tipo:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(48, 14);
            label16.Name = "label16";
            label16.Size = new Size(27, 20);
            label16.TabIndex = 7;
            label16.Text = "ID:";
            // 
            // txtIdContrato
            // 
            txtIdContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdContrato.Location = new Point(81, 11);
            txtIdContrato.Name = "txtIdContrato";
            txtIdContrato.Size = new Size(176, 27);
            txtIdContrato.TabIndex = 7;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(30, 211);
            label15.Name = "label15";
            label15.Size = new Size(45, 20);
            label15.TabIndex = 17;
            label15.Text = "F. Fin:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(277, 14);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 19;
            label13.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSalario.Location = new Point(341, 11);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(177, 27);
            txtSalario.TabIndex = 13;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(278, 63);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 21;
            label11.Text = "Estado:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(274, 102);
            label9.Name = "label9";
            label9.Size = new Size(61, 40);
            label9.TabIndex = 23;
            label9.Text = "Horas Jornada";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaInicio.Location = new Point(81, 158);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(176, 27);
            dtpFechaInicio.TabIndex = 28;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaFin.Location = new Point(81, 207);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(176, 27);
            dtpFechaFin.TabIndex = 29;
            // 
            // txtHorasJornada
            // 
            txtHorasJornada.Location = new Point(341, 101);
            txtHorasJornada.Name = "txtHorasJornada";
            txtHorasJornada.Size = new Size(177, 27);
            txtHorasJornada.TabIndex = 30;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel4.Controls.Add(dgvTipoContrato, 0, 1);
            tableLayoutPanel4.Location = new Point(0, 50);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 41.17647F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 58.82353F));
            tableLayoutPanel4.Size = new Size(347, 246);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(txtNombreTipo, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdTipoContrato, 1, 0);
            tableLayoutPanel1.Controls.Add(cbJornadaTipo, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(341, 95);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txtNombreTipo
            // 
            txtNombreTipo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreTipo.Location = new Point(105, 65);
            txtNombreTipo.Name = "txtNombreTipo";
            txtNombreTipo.Size = new Size(233, 27);
            txtNombreTipo.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(35, 68);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 19;
            label6.Text = "Nombre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(38, 36);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 18;
            label3.Text = "Jornada";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(75, 5);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // txtIdTipoContrato
            // 
            txtIdTipoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdTipoContrato.Location = new Point(105, 3);
            txtIdTipoContrato.Name = "txtIdTipoContrato";
            txtIdTipoContrato.Size = new Size(233, 27);
            txtIdTipoContrato.TabIndex = 7;
            // 
            // cbJornadaTipo
            // 
            cbJornadaTipo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbJornadaTipo.FormattingEnabled = true;
            cbJornadaTipo.Location = new Point(105, 34);
            cbJornadaTipo.Name = "cbJornadaTipo";
            cbJornadaTipo.Size = new Size(233, 28);
            cbJornadaTipo.TabIndex = 22;
            // 
            // dgvTipoContrato
            // 
            dgvTipoContrato.AutoGenerateColumns = false;
            dgvTipoContrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoContrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoContrato.Columns.AddRange(new DataGridViewColumn[] { idTipoDataGridViewTextBoxColumn, jornadaDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn });
            dgvTipoContrato.DataSource = contratosTipoBindingSource;
            dgvTipoContrato.Dock = DockStyle.Fill;
            dgvTipoContrato.Location = new Point(3, 104);
            dgvTipoContrato.Name = "dgvTipoContrato";
            dgvTipoContrato.RowHeadersWidth = 51;
            dgvTipoContrato.Size = new Size(341, 139);
            dgvTipoContrato.TabIndex = 4;
            dgvTipoContrato.CellContentClick += dgvTipoContrato_CellContentClick;
            // 
            // idTipoDataGridViewTextBoxColumn
            // 
            idTipoDataGridViewTextBoxColumn.DataPropertyName = "IdTipo";
            idTipoDataGridViewTextBoxColumn.HeaderText = "IdTipo";
            idTipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idTipoDataGridViewTextBoxColumn.Name = "idTipoDataGridViewTextBoxColumn";
            // 
            // jornadaDataGridViewTextBoxColumn
            // 
            jornadaDataGridViewTextBoxColumn.DataPropertyName = "Jornada";
            jornadaDataGridViewTextBoxColumn.HeaderText = "Jornada";
            jornadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            jornadaDataGridViewTextBoxColumn.Name = "jornadaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // contratosTipoBindingSource
            // 
            contratosTipoBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.ContratosTipo);
            // 
            // panel4
            // 
            panel4.Controls.Add(checkBox2);
            panel4.Controls.Add(checkBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1056, 50);
            panel4.TabIndex = 7;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Left;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(399, 12);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(114, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "CONTRATOS";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(55, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "TIPO CONTRATO";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(txtBuscarContrato);
            panel2.Controls.Add(btnBuscarContrato);
            panel2.Controls.Add(btnBorrarTipoContrato);
            panel2.Controls.Add(btnCrearContrato);
            panel2.Controls.Add(btnEditarContrato);
            panel2.Location = new Point(872, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 246);
            panel2.TabIndex = 6;
            // 
            // txtBuscarContrato
            // 
            txtBuscarContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarContrato.Location = new Point(17, 8);
            txtBuscarContrato.Name = "txtBuscarContrato";
            txtBuscarContrato.Size = new Size(111, 27);
            txtBuscarContrato.TabIndex = 11;
            // 
            // btnBuscarContrato
            // 
            btnBuscarContrato.Anchor = AnchorStyles.Right;
            btnBuscarContrato.FlatAppearance.BorderSize = 0;
            btnBuscarContrato.FlatStyle = FlatStyle.Flat;
            btnBuscarContrato.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarContrato.IconColor = Color.Black;
            btnBuscarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarContrato.IconSize = 35;
            btnBuscarContrato.Location = new Point(120, 10);
            btnBuscarContrato.Name = "btnBuscarContrato";
            btnBuscarContrato.Size = new Size(59, 29);
            btnBuscarContrato.TabIndex = 11;
            btnBuscarContrato.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTipoContrato
            // 
            btnBorrarTipoContrato.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrarTipoContrato.IconColor = Color.Black;
            btnBorrarTipoContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarTipoContrato.Location = new Point(76, 166);
            btnBorrarTipoContrato.Name = "btnBorrarTipoContrato";
            btnBorrarTipoContrato.Size = new Size(94, 29);
            btnBorrarTipoContrato.TabIndex = 12;
            btnBorrarTipoContrato.Text = "Borrar";
            btnBorrarTipoContrato.UseVisualStyleBackColor = true;
            btnBorrarTipoContrato.Click += btnBorrarTipoContrato_Click;
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrearContrato.IconColor = Color.Black;
            btnCrearContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearContrato.Location = new Point(76, 95);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(94, 29);
            btnCrearContrato.TabIndex = 9;
            btnCrearContrato.Text = "Crear";
            btnCrearContrato.UseVisualStyleBackColor = true;
            btnCrearContrato.Click += btnCrearContrato_Click;
            // 
            // btnEditarContrato
            // 
            btnEditarContrato.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditarContrato.IconColor = Color.Black;
            btnEditarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarContrato.Location = new Point(76, 131);
            btnEditarContrato.Name = "btnEditarContrato";
            btnEditarContrato.Size = new Size(94, 29);
            btnEditarContrato.TabIndex = 11;
            btnEditarContrato.Text = "Editar";
            btnEditarContrato.UseVisualStyleBackColor = true;
            btnEditarContrato.Click += btnEditarContrato_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(dgvHistorialContratos, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 296);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8888855F));
            tableLayoutPanel2.Size = new Size(1056, 355);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // dgvHistorialContratos
            // 
            dgvHistorialContratos.AutoGenerateColumns = false;
            dgvHistorialContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialContratos.Columns.AddRange(new DataGridViewColumn[] { idContratoDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, tipoIdDataGridViewTextBoxColumn, fechaInicioDataGridViewTextBoxColumn, fechaFinDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, fechaCreacionDataGridViewTextBoxColumn, fechaModificacionDataGridViewTextBoxColumn, horasJornadaDataGridViewTextBoxColumn });
            dgvHistorialContratos.DataSource = contratosBindingSource;
            dgvHistorialContratos.Dock = DockStyle.Fill;
            dgvHistorialContratos.FilterAndSortEnabled = true;
            dgvHistorialContratos.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistorialContratos.Location = new Point(3, 42);
            dgvHistorialContratos.MaxFilterButtonImageHeight = 23;
            dgvHistorialContratos.Name = "dgvHistorialContratos";
            dgvHistorialContratos.RightToLeft = RightToLeft.No;
            dgvHistorialContratos.RowHeadersWidth = 51;
            dgvHistorialContratos.Size = new Size(1050, 310);
            dgvHistorialContratos.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistorialContratos.TabIndex = 14;
            dgvHistorialContratos.CellContentClick += dgvHistorialContratos_CellContentClick;
            // 
            // idContratoDataGridViewTextBoxColumn
            // 
            idContratoDataGridViewTextBoxColumn.DataPropertyName = "IdContrato";
            idContratoDataGridViewTextBoxColumn.HeaderText = "IdContrato";
            idContratoDataGridViewTextBoxColumn.MinimumWidth = 24;
            idContratoDataGridViewTextBoxColumn.Name = "idContratoDataGridViewTextBoxColumn";
            idContratoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // tipoIdDataGridViewTextBoxColumn
            // 
            tipoIdDataGridViewTextBoxColumn.DataPropertyName = "TipoId";
            tipoIdDataGridViewTextBoxColumn.HeaderText = "TipoId";
            tipoIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            tipoIdDataGridViewTextBoxColumn.Name = "tipoIdDataGridViewTextBoxColumn";
            tipoIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            fechaInicioDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            fechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin";
            fechaFinDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            fechaFinDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.MinimumWidth = 24;
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            salarioDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 24;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            fechaCreacionDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            fechaModificacionDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // horasJornadaDataGridViewTextBoxColumn
            // 
            horasJornadaDataGridViewTextBoxColumn.DataPropertyName = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.HeaderText = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.MinimumWidth = 24;
            horasJornadaDataGridViewTextBoxColumn.Name = "horasJornadaDataGridViewTextBoxColumn";
            horasJornadaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // contratosBindingSource
            // 
            contratosBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.Contratos);
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1050, 33);
            panel3.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(419, 6);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 2;
            label5.Text = "HISTORICOS CONTRATOS";
            // 
            // F3Contratos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 651);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Name = "F3Contratos";
            Text = "F3Contratos";
            Load += F3Contratos_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtHorasJornada).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoContrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialContratos).EndInit();
            ((System.ComponentModel.ISupportInitialize)contratosBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnBorrarTipoContrato;
        private FontAwesome.Sharp.IconButton btnEditarContrato;
        private FontAwesome.Sharp.IconButton btnCrearContrato;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Zuby.ADGV.AdvancedDataGridView dgvHistorialContratos;
        private DataGridViewTextBoxColumn idContratoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasJornadaDataGridViewTextBoxColumn;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtIdContrato;
        private TextBox txtSalario;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label1;
        private TextBox txtIdTipoContrato;
        private DataGridView dgvTipoContrato;
        private Panel panel4;
        private Label label5;
        private TextBox txtNombreTipo;
        private Label label6;
        private TextBox txtBuscarContrato;
        private FontAwesome.Sharp.IconButton btnBuscarContrato;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn idTipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jornadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private ComboBox cbEmpleado;
        private ComboBox cbEstadoContrato;
        private ComboBox cbTipoContrato;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private ComboBox cbJornadaTipo;
        private NumericUpDown txtHorasJornada;
        private BindingSource contratosTipoBindingSource;
        private BindingSource contratosBindingSource;
    }
}