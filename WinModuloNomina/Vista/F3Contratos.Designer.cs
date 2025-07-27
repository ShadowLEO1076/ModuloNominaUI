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
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtNombreTipo = new TextBox();
            txtIdTipoContrato = new TextBox();
            cbJornadaTipo = new ComboBox();
            dgvTipoContrato = new DataGridView();
            idTipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contratosTipoBindingSource = new BindingSource(components);
            panel2 = new Panel();
            txtBuscarContrato = new TextBox();
            btnBuscarContrato = new FontAwesome.Sharp.IconButton();
            btnBorrarTipoContrato = new FontAwesome.Sharp.IconButton();
            btnCrearContrato = new FontAwesome.Sharp.IconButton();
            btnEditarContrato = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
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
            horasJornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contratosBindingSource = new BindingSource(components);
            panel3 = new Panel();
            fechaModificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtHorasJornada).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoContrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialContratos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosBindingSource).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 607);
            panel1.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.998497F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.0014954F));
            tableLayoutPanel3.Controls.Add(label16, 0, 0);
            tableLayoutPanel3.Controls.Add(label15, 0, 4);
            tableLayoutPanel3.Controls.Add(dtpFechaFin, 1, 4);
            tableLayoutPanel3.Controls.Add(dtpFechaInicio, 1, 3);
            tableLayoutPanel3.Controls.Add(label12, 0, 2);
            tableLayoutPanel3.Controls.Add(label14, 0, 1);
            tableLayoutPanel3.Controls.Add(cbTipoContrato, 1, 1);
            tableLayoutPanel3.Controls.Add(txtIdContrato, 1, 0);
            tableLayoutPanel3.Controls.Add(label13, 0, 5);
            tableLayoutPanel3.Controls.Add(label11, 0, 6);
            tableLayoutPanel3.Controls.Add(txtSalario, 1, 5);
            tableLayoutPanel3.Controls.Add(cbEstadoContrato, 1, 6);
            tableLayoutPanel3.Controls.Add(cbEmpleado, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2851F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8148146F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1687241F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2851028F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2851028F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2851F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2893887F));
            tableLayoutPanel3.Size = new Size(965, 607);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // cbEmpleado
            // 
            cbEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(292, 223);
            cbEmpleado.Margin = new Padding(3, 4, 3, 4);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(670, 23);
            cbEmpleado.TabIndex = 26;
            // 
            // cbEstadoContrato
            // 
            cbEstadoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbEstadoContrato.FormattingEnabled = true;
            cbEstadoContrato.Location = new Point(292, 560);
            cbEstadoContrato.Margin = new Padding(3, 4, 3, 4);
            cbEstadoContrato.Name = "cbEstadoContrato";
            cbEstadoContrato.Size = new Size(670, 23);
            cbEstadoContrato.TabIndex = 25;
            // 
            // cbTipoContrato
            // 
            cbTipoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbTipoContrato.FormattingEnabled = true;
            cbTipoContrato.Location = new Point(292, 129);
            cbTipoContrato.Margin = new Padding(3, 4, 3, 4);
            cbTipoContrato.Name = "cbTipoContrato";
            cbTipoContrato.Size = new Size(670, 23);
            cbTipoContrato.TabIndex = 24;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(319, 125);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 22;
            label10.Text = "F.Inicio:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(3, 227);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 20;
            label12.Text = "Empleado:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(3, 133);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 18;
            label14.Text = "Tipo:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(265, 39);
            label16.Name = "label16";
            label16.Size = new Size(21, 15);
            label16.TabIndex = 7;
            label16.Text = "ID:";
            // 
            // txtIdContrato
            // 
            txtIdContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdContrato.Location = new Point(292, 35);
            txtIdContrato.Margin = new Padding(3, 4, 3, 4);
            txtIdContrato.Name = "txtIdContrato";
            txtIdContrato.Size = new Size(670, 23);
            txtIdContrato.TabIndex = 7;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(3, 415);
            label15.Name = "label15";
            label15.Size = new Size(38, 15);
            label15.TabIndex = 17;
            label15.Text = "F. Fin:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(3, 496);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 19;
            label13.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSalario.Location = new Point(292, 492);
            txtSalario.Margin = new Padding(3, 4, 3, 4);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(670, 23);
            txtSalario.TabIndex = 13;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(3, 564);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 21;
            label11.Text = "Estado:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 65);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 23;
            label9.Text = "Horas ";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaInicio.Location = new Point(292, 317);
            dtpFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(670, 23);
            dtpFechaInicio.TabIndex = 28;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaFin.Location = new Point(292, 411);
            dtpFechaFin.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(670, 23);
            dtpFechaFin.TabIndex = 29;
            // 
            // txtHorasJornada
            // 
            txtHorasJornada.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHorasJornada.Location = new Point(161, 62);
            txtHorasJornada.Margin = new Padding(3, 4, 3, 4);
            txtHorasJornada.Name = "txtHorasJornada";
            txtHorasJornada.Size = new Size(152, 23);
            txtHorasJornada.TabIndex = 30;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 30;
            label1.Text = "ID:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.Location = new Point(50, 12);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 41.17647F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 58.82353F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(877, 357);
            tableLayoutPanel4.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label10, 2, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(cbJornadaTipo, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNombreTipo, 1, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 2);
            tableLayoutPanel1.Controls.Add(txtHorasJornada, 1, 2);
            tableLayoutPanel1.Location = new Point(46, 45);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(475, 149);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 36);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 19;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(-11, 345);
            label5.Name = "label5";
            label5.Size = new Size(176, 15);
            label5.TabIndex = 2;
            label5.Text = "HISTORICOS CONTRATOS";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(161, 7);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 18;
            label3.Text = "Jornada";
            // 
            // txtNombreTipo
            // 
            txtNombreTipo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreTipo.Location = new Point(161, 33);
            txtNombreTipo.Margin = new Padding(3, 4, 3, 4);
            txtNombreTipo.Name = "txtNombreTipo";
            txtNombreTipo.Size = new Size(152, 23);
            txtNombreTipo.TabIndex = 21;
            // 
            // txtIdTipoContrato
            // 
            txtIdTipoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdTipoContrato.Location = new Point(3, 33);
            txtIdTipoContrato.Margin = new Padding(3, 4, 3, 4);
            txtIdTipoContrato.Name = "txtIdTipoContrato";
            txtIdTipoContrato.Size = new Size(61, 23);
            txtIdTipoContrato.TabIndex = 7;
            // 
            // cbJornadaTipo
            // 
            cbJornadaTipo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbJornadaTipo.FormattingEnabled = true;
            cbJornadaTipo.Location = new Point(319, 4);
            cbJornadaTipo.Margin = new Padding(3, 4, 3, 4);
            cbJornadaTipo.Name = "cbJornadaTipo";
            cbJornadaTipo.Size = new Size(153, 23);
            cbJornadaTipo.TabIndex = 22;
            // 
            // dgvTipoContrato
            // 
            dgvTipoContrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTipoContrato.AutoGenerateColumns = false;
            dgvTipoContrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoContrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoContrato.Columns.AddRange(new DataGridViewColumn[] { idTipoDataGridViewTextBoxColumn, jornadaDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn });
            dgvTipoContrato.DataSource = contratosTipoBindingSource;
            dgvTipoContrato.Location = new Point(46, 189);
            dgvTipoContrato.Margin = new Padding(3, 4, 3, 4);
            dgvTipoContrato.Name = "dgvTipoContrato";
            dgvTipoContrato.RowHeadersWidth = 51;
            dgvTipoContrato.Size = new Size(919, 418);
            dgvTipoContrato.TabIndex = 13;
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
            // panel2
            // 
            panel2.Controls.Add(dgvTipoContrato);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 607);
            panel2.TabIndex = 18;
            // 
            // txtBuscarContrato
            // 
            txtBuscarContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarContrato.Location = new Point(17, 295);
            txtBuscarContrato.Margin = new Padding(3, 4, 3, 4);
            txtBuscarContrato.Name = "txtBuscarContrato";
            txtBuscarContrato.Size = new Size(26, 23);
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
            btnBuscarContrato.Location = new Point(35, 297);
            btnBuscarContrato.Margin = new Padding(3, 4, 3, 4);
            btnBuscarContrato.Name = "btnBuscarContrato";
            btnBuscarContrato.Size = new Size(59, 29);
            btnBuscarContrato.TabIndex = 11;
            btnBuscarContrato.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTipoContrato
            // 
            btnBorrarTipoContrato.BackColor = Color.FromArgb(255, 192, 192);
            btnBorrarTipoContrato.Dock = DockStyle.Fill;
            btnBorrarTipoContrato.FlatAppearance.BorderSize = 0;
            btnBorrarTipoContrato.FlatStyle = FlatStyle.Flat;
            btnBorrarTipoContrato.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrarTipoContrato.IconColor = Color.Black;
            btnBorrarTipoContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarTipoContrato.IconSize = 35;
            btnBorrarTipoContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrarTipoContrato.Location = new Point(3, 340);
            btnBorrarTipoContrato.Margin = new Padding(3, 4, 3, 4);
            btnBorrarTipoContrato.Name = "btnBorrarTipoContrato";
            btnBorrarTipoContrato.Size = new Size(959, 263);
            btnBorrarTipoContrato.TabIndex = 12;
            btnBorrarTipoContrato.Text = "Borrar";
            btnBorrarTipoContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrarTipoContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarTipoContrato.UseVisualStyleBackColor = true;
            btnBorrarTipoContrato.Click += btnBorrarTipoContrato_Click;
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.BackColor = Color.FromArgb(192, 255, 192);
            btnCrearContrato.Dock = DockStyle.Fill;
            btnCrearContrato.FlatAppearance.BorderSize = 0;
            btnCrearContrato.FlatStyle = FlatStyle.Flat;
            btnCrearContrato.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrearContrato.IconColor = Color.Black;
            btnCrearContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearContrato.IconSize = 40;
            btnCrearContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearContrato.Location = new Point(3, 4);
            btnCrearContrato.Margin = new Padding(3, 4, 3, 4);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(959, 295);
            btnCrearContrato.TabIndex = 9;
            btnCrearContrato.Text = "Crear";
            btnCrearContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearContrato.UseVisualStyleBackColor = true;
            btnCrearContrato.Click += btnCrearContrato_Click;
            // 
            // btnEditarContrato
            // 
            btnEditarContrato.BackColor = Color.FromArgb(192, 255, 255);
            btnEditarContrato.Dock = DockStyle.Fill;
            btnEditarContrato.FlatAppearance.BorderSize = 0;
            btnEditarContrato.FlatStyle = FlatStyle.Flat;
            btnEditarContrato.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditarContrato.IconColor = Color.Black;
            btnEditarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarContrato.IconSize = 40;
            btnEditarContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarContrato.Location = new Point(3, 307);
            btnEditarContrato.Margin = new Padding(3, 4, 3, 4);
            btnEditarContrato.Name = "btnEditarContrato";
            btnEditarContrato.Size = new Size(959, 25);
            btnEditarContrato.TabIndex = 11;
            btnEditarContrato.Text = "Editar";
            btnEditarContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarContrato.UseVisualStyleBackColor = true;
            btnEditarContrato.Click += btnEditarContrato_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Controls.Add(txtIdTipoContrato);
            panel4.Controls.Add(checkBox2);
            panel4.Controls.Add(checkBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(965, 50);
            panel4.TabIndex = 7;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Left;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(399, 12);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(92, 19);
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
            checkBox1.Size = new Size(114, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "TIPO CONTRATO";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(btnCrearContrato, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEditarContrato, 1, 0);
            tableLayoutPanel2.Controls.Add(btnBorrarTipoContrato, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8888855F));
            tableLayoutPanel2.Size = new Size(965, 607);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // dgvHistorialContratos
            // 
            dgvHistorialContratos.AutoGenerateColumns = false;
            dgvHistorialContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialContratos.Columns.AddRange(new DataGridViewColumn[] { idContratoDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, tipoIdDataGridViewTextBoxColumn, fechaInicioDataGridViewTextBoxColumn, fechaFinDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, fechaCreacionDataGridViewTextBoxColumn, horasJornadaDataGridViewTextBoxColumn });
            dgvHistorialContratos.DataSource = contratosBindingSource;
            dgvHistorialContratos.Dock = DockStyle.Fill;
            dgvHistorialContratos.FilterAndSortEnabled = true;
            dgvHistorialContratos.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistorialContratos.Location = new Point(0, 0);
            dgvHistorialContratos.Margin = new Padding(3, 4, 3, 4);
            dgvHistorialContratos.MaxFilterButtonImageHeight = 23;
            dgvHistorialContratos.Name = "dgvHistorialContratos";
            dgvHistorialContratos.RightToLeft = RightToLeft.No;
            dgvHistorialContratos.RowHeadersWidth = 51;
            dgvHistorialContratos.Size = new Size(965, 607);
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
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(txtBuscarContrato);
            panel3.Controls.Add(btnBuscarContrato);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(965, 607);
            panel3.TabIndex = 14;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            fechaModificacionDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // F3Contratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 607);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(panel3);
            Controls.Add(dgvHistorialContratos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "F3Contratos";
            Text = "F3Contratos";
            Load += F3Contratos_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtHorasJornada).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoContrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private TextBox txtIdTipoContrato;
        private Label label5;
        private TextBox txtBuscarContrato;
        private FontAwesome.Sharp.IconButton btnBuscarContrato;
        private BindingSource contratosTipoBindingSource;
        private BindingSource contratosBindingSource;
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
        private DataGridView dgvTipoContrato;
        private Panel panel4;
        private TextBox txtNombreTipo;
        private Label label6;
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
        private Panel panel5;
        private Label label4;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}