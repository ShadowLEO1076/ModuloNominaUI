namespace WinModuloNomina.Vista
{
    partial class F5Descuentos
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
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            idEmpleadoCb = new ComboBox();
            label4 = new Label();
            idDescuentosTxt = new Label();
            textBox4 = new TextBox();
            fechaLb = new Label();
            fechaDTP = new DateTimePicker();
            montoLb = new Label();
            descripcionLb = new Label();
            descripcionTxt = new TextBox();
            tipoLb = new Label();
            montoTxt = new NumericUpDown();
            tipoTxt = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            dgvInasistencias = new Zuby.ADGV.AdvancedDataGridView();
            idInasistenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            licenciaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            diasContadosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inasistenciasBindingSource = new BindingSource(components);
            panel3 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            dgvDescuentos = new Zuby.ADGV.AdvancedDataGridView();
            idDescuentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descuentosBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)montoTxt).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInasistencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inasistenciasBindingSource).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descuentosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Dock = DockStyle.Fill;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.Location = new Point(229, 2);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(107, 39);
            btnBorrar.TabIndex = 20;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(116, 2);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 39);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 40;
            btnBuscar.Location = new Point(640, 2);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 29);
            btnBuscar.TabIndex = 18;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Dock = DockStyle.Fill;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(3, 2);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(107, 39);
            btnCrear.TabIndex = 17;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(idEmpleadoCb, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(idDescuentosTxt, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(fechaLb, 0, 5);
            tableLayoutPanel1.Controls.Add(fechaDTP, 1, 5);
            tableLayoutPanel1.Controls.Add(montoLb, 0, 4);
            tableLayoutPanel1.Controls.Add(descripcionLb, 0, 3);
            tableLayoutPanel1.Controls.Add(descripcionTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(tipoLb, 0, 2);
            tableLayoutPanel1.Controls.Add(montoTxt, 1, 4);
            tableLayoutPanel1.Controls.Add(tipoTxt, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 39);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(341, 152);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // idEmpleadoCb
            // 
            idEmpleadoCb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idEmpleadoCb.FormattingEnabled = true;
            idEmpleadoCb.Location = new Point(105, 27);
            idEmpleadoCb.Margin = new Padding(3, 2, 3, 2);
            idEmpleadoCb.Name = "idEmpleadoCb";
            idEmpleadoCb.Size = new Size(233, 23);
            idEmpleadoCb.TabIndex = 29;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 30);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 28;
            label4.Text = "Empleado";
            // 
            // idDescuentosTxt
            // 
            idDescuentosTxt.Anchor = AnchorStyles.Left;
            idDescuentosTxt.AutoSize = true;
            idDescuentosTxt.Location = new Point(3, 5);
            idDescuentosTxt.Name = "idDescuentosTxt";
            idDescuentosTxt.Size = new Size(81, 15);
            idDescuentosTxt.TabIndex = 17;
            idDescuentosTxt.Text = "Id Descuentos";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(105, 2);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(233, 23);
            textBox4.TabIndex = 10;
            // 
            // fechaLb
            // 
            fechaLb.Anchor = AnchorStyles.Left;
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(3, 131);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(83, 15);
            fechaLb.TabIndex = 24;
            fechaLb.Text = "Fecha Emision";
            // 
            // fechaDTP
            // 
            fechaDTP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fechaDTP.Format = DateTimePickerFormat.Short;
            fechaDTP.Location = new Point(105, 128);
            fechaDTP.Name = "fechaDTP";
            fechaDTP.Size = new Size(233, 23);
            fechaDTP.TabIndex = 26;
            fechaDTP.Value = new DateTime(2025, 7, 21, 20, 56, 31, 0);
            // 
            // montoLb
            // 
            montoLb.Anchor = AnchorStyles.Left;
            montoLb.AutoSize = true;
            montoLb.Location = new Point(3, 105);
            montoLb.Name = "montoLb";
            montoLb.Size = new Size(43, 15);
            montoLb.TabIndex = 20;
            montoLb.Text = "Monto";
            // 
            // descripcionLb
            // 
            descripcionLb.Anchor = AnchorStyles.Left;
            descripcionLb.AutoSize = true;
            descripcionLb.Location = new Point(3, 80);
            descripcionLb.Name = "descripcionLb";
            descripcionLb.Size = new Size(69, 15);
            descripcionLb.TabIndex = 22;
            descripcionLb.Text = "Descripcion";
            // 
            // descripcionTxt
            // 
            descripcionTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descripcionTxt.Location = new Point(105, 77);
            descripcionTxt.Margin = new Padding(3, 2, 3, 2);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(233, 23);
            descripcionTxt.TabIndex = 16;
            // 
            // tipoLb
            // 
            tipoLb.Anchor = AnchorStyles.Left;
            tipoLb.AutoSize = true;
            tipoLb.Location = new Point(3, 55);
            tipoLb.Name = "tipoLb";
            tipoLb.Size = new Size(63, 15);
            tipoLb.TabIndex = 18;
            tipoLb.Text = "Descuento";
            // 
            // montoTxt
            // 
            montoTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            montoTxt.Location = new Point(105, 102);
            montoTxt.Margin = new Padding(3, 2, 3, 2);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(233, 23);
            montoTxt.TabIndex = 30;
            // 
            // tipoTxt
            // 
            tipoTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tipoTxt.FormattingEnabled = true;
            tipoTxt.Location = new Point(105, 52);
            tipoTxt.Margin = new Padding(3, 2, 3, 2);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(233, 23);
            tipoTxt.TabIndex = 27;
            tipoTxt.SelectedIndexChanged += tipoTxt_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Location = new Point(10, 9);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 247F));
            tableLayoutPanel2.Size = new Size(701, 247);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 243);
            panel2.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnCrear, 0, 0);
            tableLayoutPanel3.Controls.Add(btnEditar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnBorrar, 2, 0);
            tableLayoutPanel3.Location = new Point(5, 196);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(339, 43);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 34);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Registro Descuentos";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvInasistencias);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(353, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(345, 243);
            panel4.TabIndex = 26;
            // 
            // dgvInasistencias
            // 
            dgvInasistencias.AutoGenerateColumns = false;
            dgvInasistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInasistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInasistencias.Columns.AddRange(new DataGridViewColumn[] { idInasistenciaDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn1, licenciaIdDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn1, diasContadosDataGridViewTextBoxColumn });
            dgvInasistencias.DataSource = inasistenciasBindingSource;
            dgvInasistencias.Dock = DockStyle.Fill;
            dgvInasistencias.FilterAndSortEnabled = true;
            dgvInasistencias.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvInasistencias.Location = new Point(0, 34);
            dgvInasistencias.Margin = new Padding(3, 2, 3, 2);
            dgvInasistencias.MaxFilterButtonImageHeight = 23;
            dgvInasistencias.Name = "dgvInasistencias";
            dgvInasistencias.RightToLeft = RightToLeft.No;
            dgvInasistencias.RowHeadersWidth = 51;
            dgvInasistencias.Size = new Size(345, 209);
            dgvInasistencias.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvInasistencias.TabIndex = 26;
            // 
            // idInasistenciaDataGridViewTextBoxColumn
            // 
            idInasistenciaDataGridViewTextBoxColumn.DataPropertyName = "IdInasistencia";
            idInasistenciaDataGridViewTextBoxColumn.HeaderText = "IdInasistencia";
            idInasistenciaDataGridViewTextBoxColumn.MinimumWidth = 24;
            idInasistenciaDataGridViewTextBoxColumn.Name = "idInasistenciaDataGridViewTextBoxColumn";
            idInasistenciaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // empleadoIdDataGridViewTextBoxColumn1
            // 
            empleadoIdDataGridViewTextBoxColumn1.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn1.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn1.MinimumWidth = 24;
            empleadoIdDataGridViewTextBoxColumn1.Name = "empleadoIdDataGridViewTextBoxColumn1";
            empleadoIdDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // licenciaIdDataGridViewTextBoxColumn
            // 
            licenciaIdDataGridViewTextBoxColumn.DataPropertyName = "LicenciaId";
            licenciaIdDataGridViewTextBoxColumn.HeaderText = "LicenciaId";
            licenciaIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            licenciaIdDataGridViewTextBoxColumn.Name = "licenciaIdDataGridViewTextBoxColumn";
            licenciaIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn1.MinimumWidth = 24;
            fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            fechaDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // diasContadosDataGridViewTextBoxColumn
            // 
            diasContadosDataGridViewTextBoxColumn.DataPropertyName = "DiasContados";
            diasContadosDataGridViewTextBoxColumn.HeaderText = "DiasContados";
            diasContadosDataGridViewTextBoxColumn.MinimumWidth = 24;
            diasContadosDataGridViewTextBoxColumn.Name = "diasContadosDataGridViewTextBoxColumn";
            diasContadosDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // inasistenciasBindingSource
            // 
            inasistenciasBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.Inasistencias);
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 34);
            panel3.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 9);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 1;
            label2.Text = "Inasistencias sin licencia";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(10, 270);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(696, 34);
            panel5.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Location = new Point(534, 7);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(278, 11);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 19;
            label3.Text = "Descuentos Registrados";
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDescuentos.AutoGenerateColumns = false;
            dgvDescuentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Columns.AddRange(new DataGridViewColumn[] { idDescuentoDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, montoDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn });
            dgvDescuentos.DataSource = descuentosBindingSource;
            dgvDescuentos.FilterAndSortEnabled = true;
            dgvDescuentos.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvDescuentos.Location = new Point(10, 308);
            dgvDescuentos.Margin = new Padding(3, 2, 3, 2);
            dgvDescuentos.MaxFilterButtonImageHeight = 23;
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.RightToLeft = RightToLeft.No;
            dgvDescuentos.RowHeadersWidth = 51;
            dgvDescuentos.Size = new Size(696, 178);
            dgvDescuentos.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvDescuentos.TabIndex = 25;
            // 
            // idDescuentoDataGridViewTextBoxColumn
            // 
            idDescuentoDataGridViewTextBoxColumn.DataPropertyName = "IdDescuento";
            idDescuentoDataGridViewTextBoxColumn.HeaderText = "IdDescuento";
            idDescuentoDataGridViewTextBoxColumn.MinimumWidth = 24;
            idDescuentoDataGridViewTextBoxColumn.Name = "idDescuentoDataGridViewTextBoxColumn";
            idDescuentoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.MinimumWidth = 24;
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 24;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            montoDataGridViewTextBoxColumn.MinimumWidth = 24;
            montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            montoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // descuentosBindingSource
            // 
            descuentosBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.Descuentos);
            // 
            // F5Descuentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 480);
            Controls.Add(dgvDescuentos);
            Controls.Add(panel5);
            Controls.Add(tableLayoutPanel2);
            Name = "F5Descuentos";
            Text = "F5Descuentos";
            Load += F5Descuentos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)montoTxt).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInasistencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)inasistenciasBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)descuentosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private TableLayoutPanel tableLayoutPanel1;
        private Label fechaLb;
        private Label descripcionLb;
        private Label montoLb;
        private Label tipoLb;
        private Label idDescuentosTxt;
        private TextBox descripcionTxt;
        private TextBox textBox4;
        private DateTimePicker fechaDTP;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Zuby.ADGV.AdvancedDataGridView dgvDescuentos;
        private BindingSource inasistenciasBindingSource;
        private DataGridViewTextBoxColumn idDescuentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private BindingSource descuentosBindingSource;
        private Label label1;
        private Label label2;
        private Zuby.ADGV.AdvancedDataGridView dgvInasistencias;
        private DataGridViewTextBoxColumn idInasistenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn licenciaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn diasContadosDataGridViewTextBoxColumn;
        private Label label3;
        private TextBox textBox1;
        private ComboBox tipoTxt;
        private ComboBox idEmpleadoCb;
        private Label label4;
        private NumericUpDown montoTxt;
    }
}