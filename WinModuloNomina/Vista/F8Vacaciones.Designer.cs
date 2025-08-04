using WinModuloNomina.Modelo.DTOS;

namespace WinModuloNomina.Vista
{
    partial class F8Vacaciones
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
            txtBuscar2 = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            txtIdSVacacion = new TextBox();
            txtidAprovacion = new TextBox();
            dataRevisionV = new DataGridView();
            dataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn26 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn27 = new DataGridViewTextBoxColumn();
            aprobacionVacacionesBindingSource = new BindingSource(components);
            tableLayoutPanel4 = new TableLayoutPanel();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            dgvSolicitudes = new Zuby.ADGV.AdvancedDataGridView();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
            solicitudVacacionDTOBindingSource1 = new BindingSource(components);
            label1 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label9 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            label12 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDiasAcumulados = new TextBox();
            label8 = new Label();
            cbxEmpleado = new ComboBox();
            label5 = new Label();
            dateInicio = new DateTimePicker();
            label2 = new Label();
            dateFin = new DateTimePicker();
            label4 = new Label();
            txtDiasSolicitados = new TextBox();
            label6 = new Label();
            cbxEstado = new ComboBox();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            txtAnio = new TextBox();
            txtSaldoid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aprobacionVacacionesBindingSource).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionDTOBindingSource1).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar2
            // 
            txtBuscar2.Anchor = AnchorStyles.Right;
            txtBuscar2.Location = new Point(723, 10);
            txtBuscar2.Margin = new Padding(3, 4, 3, 4);
            txtBuscar2.Name = "txtBuscar2";
            txtBuscar2.Size = new Size(126, 27);
            txtBuscar2.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 35;
            btnBuscar.Location = new Point(873, 10);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(35, 27);
            btnBuscar.TabIndex = 10;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.WhiteSmoke;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.WhiteSmoke;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 35;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(3, 62);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(14, 0, 0, 0);
            btnEditar.Size = new Size(186, 50);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Actualizar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.RoyalBlue;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.WhiteSmoke;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCrear.IconColor = Color.WhiteSmoke;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.IconSize = 35;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(3, 4);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Padding = new Padding(14, 0, 0, 0);
            btnCrear.Size = new Size(186, 50);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Ingresar";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtIdSVacacion
            // 
            txtIdSVacacion.Anchor = AnchorStyles.Left;
            txtIdSVacacion.Location = new Point(153, 8);
            txtIdSVacacion.Margin = new Padding(3, 4, 3, 4);
            txtIdSVacacion.Name = "txtIdSVacacion";
            txtIdSVacacion.Size = new Size(219, 27);
            txtIdSVacacion.TabIndex = 7;
            // 
            // txtidAprovacion
            // 
            txtidAprovacion.Anchor = AnchorStyles.Right;
            txtidAprovacion.Location = new Point(3, 8);
            txtidAprovacion.Margin = new Padding(3, 4, 3, 4);
            txtidAprovacion.Name = "txtidAprovacion";
            txtidAprovacion.Size = new Size(220, 27);
            txtidAprovacion.TabIndex = 28;
            // 
            // dataRevisionV
            // 
            dataRevisionV.AutoGenerateColumns = false;
            dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRevisionV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRevisionV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn24, dataGridViewTextBoxColumn25, dataGridViewTextBoxColumn26, dataGridViewTextBoxColumn27 });
            dataRevisionV.DataSource = aprobacionVacacionesBindingSource;
            dataRevisionV.Dock = DockStyle.Fill;
            dataRevisionV.Location = new Point(3, 102);
            dataRevisionV.Margin = new Padding(3, 4, 3, 4);
            dataRevisionV.Name = "dataRevisionV";
            dataRevisionV.RowHeadersWidth = 51;
            dataRevisionV.Size = new Size(377, 222);
            dataRevisionV.TabIndex = 14;
            dataRevisionV.CellClick += dataRevisionV_CellClick;
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.DataPropertyName = "IdAprobacion";
            dataGridViewTextBoxColumn24.HeaderText = "IdAprobacion";
            dataGridViewTextBoxColumn24.MinimumWidth = 6;
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewTextBoxColumn25.DataPropertyName = "SolicitudId";
            dataGridViewTextBoxColumn25.HeaderText = "SolicitudId";
            dataGridViewTextBoxColumn25.MinimumWidth = 6;
            dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            dataGridViewTextBoxColumn26.DataPropertyName = "FechaAprobacion";
            dataGridViewTextBoxColumn26.HeaderText = "FechaAprobacion";
            dataGridViewTextBoxColumn26.MinimumWidth = 6;
            dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            dataGridViewTextBoxColumn27.DataPropertyName = "UsuarioAprobador";
            dataGridViewTextBoxColumn27.HeaderText = "UsuarioAprobador";
            dataGridViewTextBoxColumn27.MinimumWidth = 6;
            dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // aprobacionVacacionesBindingSource
            // 
            aprobacionVacacionesBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.AprobacionVacaciones);
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000076F));
            tableLayoutPanel4.Controls.Add(btnCrear, 0, 0);
            tableLayoutPanel4.Controls.Add(btnEditar, 0, 1);
            tableLayoutPanel4.Controls.Add(btnBorrar, 0, 2);
            tableLayoutPanel4.Location = new Point(787, 473);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(192, 176);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.WhiteSmoke;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrar.IconColor = Color.WhiteSmoke;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.IconSize = 30;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(3, 120);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Padding = new Padding(14, 0, 0, 0);
            btnBorrar.Size = new Size(186, 52);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Eliminar";
            btnBorrar.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToOrderColumns = true;
            dgvSolicitudes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvSolicitudes.BackgroundColor = Color.Gainsboro;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21, dataGridViewTextBoxColumn22, dataGridViewTextBoxColumn23 });
            dgvSolicitudes.DataSource = solicitudVacacionDTOBindingSource1;
            dgvSolicitudes.FilterAndSortEnabled = true;
            dgvSolicitudes.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvSolicitudes.Location = new Point(46, 473);
            dgvSolicitudes.Margin = new Padding(3, 4, 3, 4);
            dgvSolicitudes.MaxFilterButtonImageHeight = 23;
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RightToLeft = RightToLeft.No;
            dgvSolicitudes.RowHeadersWidth = 51;
            dgvSolicitudes.Size = new Size(722, 183);
            dgvSolicitudes.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvSolicitudes.TabIndex = 20;
            dgvSolicitudes.CellContentClick += dgvSolicitudes_CellContentClick;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "IdSolicitud";
            dataGridViewTextBoxColumn15.HeaderText = "IdSolicitud";
            dataGridViewTextBoxColumn15.MinimumWidth = 24;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "IdEmpleado";
            dataGridViewTextBoxColumn16.HeaderText = "IdEmpleado";
            dataGridViewTextBoxColumn16.MinimumWidth = 24;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "NombreCompleto";
            dataGridViewTextBoxColumn17.HeaderText = "NombreCompleto";
            dataGridViewTextBoxColumn17.MinimumWidth = 24;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "Cedula";
            dataGridViewTextBoxColumn18.HeaderText = "Cedula";
            dataGridViewTextBoxColumn18.MinimumWidth = 24;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "FechaInicio";
            dataGridViewTextBoxColumn19.HeaderText = "FechaInicio";
            dataGridViewTextBoxColumn19.MinimumWidth = 24;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "FechaFin";
            dataGridViewTextBoxColumn20.HeaderText = "FechaFin";
            dataGridViewTextBoxColumn20.MinimumWidth = 24;
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "DiasSolicitados";
            dataGridViewTextBoxColumn21.HeaderText = "DiasSolicitados";
            dataGridViewTextBoxColumn21.MinimumWidth = 24;
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn22.HeaderText = "Estado";
            dataGridViewTextBoxColumn22.MinimumWidth = 24;
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.DataPropertyName = "FechaCreacion";
            dataGridViewTextBoxColumn23.HeaderText = "FechaCreacion";
            dataGridViewTextBoxColumn23.MinimumWidth = 24;
            dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            dataGridViewTextBoxColumn23.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // solicitudVacacionDTOBindingSource1
            // 
            solicitudVacacionDTOBindingSource1.DataSource = typeof(SolicitudVacacionDTO);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(82, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 16;
            label1.Text = "RESUMEN APROBADAS";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtBuscar2);
            panel3.Controls.Add(btnBuscar);
            panel3.Location = new Point(49, 419);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(927, 46);
            panel3.TabIndex = 30;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(347, 10);
            label7.Name = "label7";
            label7.Size = new Size(227, 20);
            label7.TabIndex = 17;
            label7.Text = "RESUMEN SOLICITUDES";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(102, 0);
            label9.Name = "label9";
            label9.Size = new Size(176, 20);
            label9.TabIndex = 33;
            label9.Text = "DATOS SOLICITUD";
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top;
            iconButton1.BackColor = Color.SandyBrown;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            iconButton1.ForeColor = Color.WhiteSmoke;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(396, 13);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(14, 0, 0, 0);
            iconButton1.Size = new Size(241, 45);
            iconButton1.TabIndex = 32;
            iconButton1.Text = "Refrescar disponibles";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(229, 11);
            label11.Name = "label11";
            label11.Size = new Size(145, 20);
            label11.TabIndex = 34;
            label11.Text = "ID Aprovacion:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(3, 11);
            label12.Name = "label12";
            label12.Size = new Size(144, 20);
            label12.TabIndex = 35;
            label12.Text = "ID Solicitud:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Size = new Size(381, 328);
            tableLayoutPanel2.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Controls.Add(label12, 0, 0);
            tableLayoutPanel3.Controls.Add(txtIdSVacacion, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 52);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(375, 43);
            tableLayoutPanel3.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(txtDiasAcumulados, 1, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(cbxEmpleado, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(dateInicio, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dateFin, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtDiasSolicitados, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(cbxEstado, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(375, 224);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // txtDiasAcumulados
            // 
            txtDiasAcumulados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiasAcumulados.Location = new Point(153, 191);
            txtDiasAcumulados.Margin = new Padding(3, 4, 3, 4);
            txtDiasAcumulados.Name = "txtDiasAcumulados";
            txtDiasAcumulados.Size = new Size(219, 27);
            txtDiasAcumulados.TabIndex = 30;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 194);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 28;
            label8.Text = "Dias disponibles:";
            // 
            // cbxEmpleado
            // 
            cbxEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEmpleado.FormattingEnabled = true;
            cbxEmpleado.Location = new Point(153, 4);
            cbxEmpleado.Margin = new Padding(3, 4, 3, 4);
            cbxEmpleado.Name = "cbxEmpleado";
            cbxEmpleado.Size = new Size(219, 28);
            cbxEmpleado.TabIndex = 22;
            cbxEmpleado.SelectedIndexChanged += cbxEmpleado_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 45);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 20;
            label5.Text = "Fecha de Inicio:";
            // 
            // dateInicio
            // 
            dateInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateInicio.Cursor = Cursors.SizeAll;
            dateInicio.CustomFormat = "";
            dateInicio.Format = DateTimePickerFormat.Short;
            dateInicio.Location = new Point(153, 42);
            dateInicio.Margin = new Padding(3, 4, 3, 4);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(219, 27);
            dateInicio.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 17;
            label2.Text = "Fecha de Fin:";
            // 
            // dateFin
            // 
            dateFin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateFin.Cursor = Cursors.SizeAll;
            dateFin.CustomFormat = "";
            dateFin.Format = DateTimePickerFormat.Short;
            dateFin.Location = new Point(153, 79);
            dateFin.Margin = new Padding(3, 4, 3, 4);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(219, 27);
            dateFin.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 119);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 19;
            label4.Text = "Dias Solicitados:";
            // 
            // txtDiasSolicitados
            // 
            txtDiasSolicitados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiasSolicitados.Location = new Point(153, 116);
            txtDiasSolicitados.Margin = new Padding(3, 4, 3, 4);
            txtDiasSolicitados.Name = "txtDiasSolicitados";
            txtDiasSolicitados.Size = new Size(219, 27);
            txtDiasSolicitados.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 156);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 21;
            label6.Text = "Estado Solicitud:";
            // 
            // cbxEstado
            // 
            cbxEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(153, 152);
            cbxEstado.Margin = new Padding(3, 4, 3, 4);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(219, 28);
            cbxEstado.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 37);
            label3.TabIndex = 18;
            label3.Text = "Seleccione Empleado:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(dataRevisionV, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(544, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel5.Size = new Size(383, 328);
            tableLayoutPanel5.TabIndex = 37;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.Controls.Add(txtidAprovacion, 0, 0);
            tableLayoutPanel6.Controls.Add(label11, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 52);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(377, 43);
            tableLayoutPanel6.TabIndex = 38;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.BackColor = Color.WhiteSmoke;
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel7.Location = new Point(46, 65);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(930, 334);
            tableLayoutPanel7.TabIndex = 38;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.None;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(txtAnio, 0, 1);
            tableLayoutPanel8.Controls.Add(txtSaldoid, 0, 0);
            tableLayoutPanel8.Location = new Point(390, 104);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Size = new Size(148, 125);
            tableLayoutPanel8.TabIndex = 39;
            // 
            // txtAnio
            // 
            txtAnio.Anchor = AnchorStyles.None;
            txtAnio.Location = new Point(11, 80);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(125, 27);
            txtAnio.TabIndex = 39;
            // 
            // txtSaldoid
            // 
            txtSaldoid.Anchor = AnchorStyles.None;
            txtSaldoid.Location = new Point(11, 17);
            txtSaldoid.Name = "txtSaldoid";
            txtSaldoid.Size = new Size(125, 27);
            txtSaldoid.TabIndex = 38;
            // 
            // F8Vacaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1015, 686);
            Controls.Add(tableLayoutPanel7);
            Controls.Add(iconButton1);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(dgvSolicitudes);
            Name = "F8Vacaciones";
            Text = "F8Vacaciones";
            Load += F8Vacaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).EndInit();
            ((System.ComponentModel.ISupportInitialize)aprobacionVacacionesBindingSource).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionDTOBindingSource1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private TextBox txtBuscar2;
        private TextBox txtIdSVacacion;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn1;
        private DataGridView dataRevisionV;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoNombreCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn idSolicitudDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diasSolicitadosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAprobacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn solicitudIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaAprobacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioAprobadorDataGridViewTextBoxColumn;
        private TextBox txtidAprovacion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private Zuby.ADGV.AdvancedDataGridView dgvSolicitudes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private Label label1;
        private Panel panel3;
        private Label label7;
        private Label label9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private BindingSource aprobacionVacacionesBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private BindingSource solicitudVacacionDTOBindingSource1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label11;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDiasAcumulados;
        private Label label8;
        private ComboBox cbxEmpleado;
        private Label label5;
        private DateTimePicker dateInicio;
        private Label label2;
        private DateTimePicker dateFin;
        private Label label4;
        private TextBox txtDiasSolicitados;
        private Label label6;
        private ComboBox cbxEstado;
        private Label label3;
        private TextBox txtSaldoid;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox txtDiasUsados;
        private TextBox txtAnio;
    }
}