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
            tableLayoutPanel1 = new TableLayoutPanel();
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
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aprobacionVacacionesBindingSource).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionDTOBindingSource1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar2
            // 
            txtBuscar2.Anchor = AnchorStyles.Right;
            txtBuscar2.Location = new Point(877, 8);
            txtBuscar2.Name = "txtBuscar2";
            txtBuscar2.Size = new Size(177, 27);
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
            btnBuscar.Location = new Point(1060, -1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 45);
            btnBuscar.TabIndex = 10;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Black;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 35;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(3, 99);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(12, 0, 0, 0);
            btnEditar.Size = new Size(248, 42);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Actualizar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Silver;
            btnCrear.Dock = DockStyle.Fill;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = Color.Black;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.IconSize = 35;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(3, 51);
            btnCrear.Name = "btnCrear";
            btnCrear.Padding = new Padding(12, 0, 0, 0);
            btnCrear.Size = new Size(248, 42);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Ingresar";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
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
            tableLayoutPanel1.Location = new Point(46, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(370, 219);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // cbxEmpleado
            // 
            cbxEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEmpleado.FormattingEnabled = true;
            cbxEmpleado.Location = new Point(151, 7);
            cbxEmpleado.Name = "cbxEmpleado";
            cbxEmpleado.Size = new Size(216, 28);
            cbxEmpleado.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 54);
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
            dateInicio.Location = new Point(151, 51);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(216, 27);
            dateInicio.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 97);
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
            dateFin.Location = new Point(151, 94);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(216, 27);
            dateFin.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 140);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 19;
            label4.Text = "Dias Solicitados:";
            // 
            // txtDiasSolicitados
            // 
            txtDiasSolicitados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiasSolicitados.Location = new Point(151, 137);
            txtDiasSolicitados.Name = "txtDiasSolicitados";
            txtDiasSolicitados.Size = new Size(216, 27);
            txtDiasSolicitados.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 185);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 21;
            label6.Text = "Estado Solicitud:";
            // 
            // cbxEstado
            // 
            cbxEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(151, 181);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(216, 28);
            cbxEstado.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 1);
            label3.Name = "label3";
            label3.Size = new Size(84, 40);
            label3.TabIndex = 18;
            label3.Text = "Seleccione Empleado:";
            // 
            // txtIdSVacacion
            // 
            txtIdSVacacion.Anchor = AnchorStyles.None;
            txtIdSVacacion.Location = new Point(3, 10);
            txtIdSVacacion.Name = "txtIdSVacacion";
            txtIdSVacacion.Size = new Size(248, 27);
            txtIdSVacacion.TabIndex = 7;
            // 
            // txtidAprovacion
            // 
            txtidAprovacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtidAprovacion.Location = new Point(457, 96);
            txtidAprovacion.Name = "txtidAprovacion";
            txtidAprovacion.Size = new Size(625, 27);
            txtidAprovacion.TabIndex = 28;
            // 
            // dataRevisionV
            // 
            dataRevisionV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataRevisionV.AutoGenerateColumns = false;
            dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRevisionV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRevisionV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn24, dataGridViewTextBoxColumn25, dataGridViewTextBoxColumn26, dataGridViewTextBoxColumn27 });
            dataRevisionV.DataSource = aprobacionVacacionesBindingSource;
            dataRevisionV.Location = new Point(457, 143);
            dataRevisionV.Name = "dataRevisionV";
            dataRevisionV.RowHeadersWidth = 51;
            dataRevisionV.Size = new Size(624, 161);
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
            tableLayoutPanel4.Controls.Add(txtIdSVacacion, 0, 0);
            tableLayoutPanel4.Controls.Add(btnCrear, 0, 1);
            tableLayoutPanel4.Controls.Add(btnEditar, 0, 2);
            tableLayoutPanel4.Controls.Add(btnBorrar, 0, 3);
            tableLayoutPanel4.Location = new Point(876, 409);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(254, 192);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Silver;
            btnBorrar.Dock = DockStyle.Fill;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Black;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.IconSize = 30;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(3, 147);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Padding = new Padding(12, 0, 0, 0);
            btnBorrar.Size = new Size(248, 42);
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
            dgvSolicitudes.Location = new Point(-1, 379);
            dgvSolicitudes.MaxFilterButtonImageHeight = 23;
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RightToLeft = RightToLeft.No;
            dgvSolicitudes.RowHeadersWidth = 51;
            dgvSolicitudes.Size = new Size(876, 261);
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(457, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 45);
            panel2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 14);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 16;
            label1.Text = "RESUMEN APROVADAS";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(txtBuscar2);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(-1, 328);
            panel3.Name = "panel3";
            panel3.Size = new Size(1131, 45);
            panel3.TabIndex = 30;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(464, 13);
            label7.Name = "label7";
            label7.Size = new Size(227, 20);
            label7.TabIndex = 17;
            label7.Text = "RESUMEN SOLICITUDES";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(99, 13);
            label9.Name = "label9";
            label9.Size = new Size(176, 20);
            label9.TabIndex = 33;
            label9.Text = "DATOS SOLICITUD";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.Highlight;
            panel4.Controls.Add(label9);
            panel4.Location = new Point(46, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 45);
            panel4.TabIndex = 31;
            // 
            // F8Vacaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1132, 638);
            Controls.Add(panel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(txtidAprovacion);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(dgvSolicitudes);
            Controls.Add(dataRevisionV);
            Name = "F8Vacaciones";
            Text = "F8Vacaciones";
            Load += F8Vacaciones_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).EndInit();
            ((System.ComponentModel.ISupportInitialize)aprobacionVacacionesBindingSource).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionDTOBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private TextBox txtBuscar2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtIdSVacacion;
        private ComboBox cbxEmpleado;
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
        private Label label5;
        private DateTimePicker dateInicio;
        private TextBox txtDiasSolicitados;
        private DateTimePicker dateFin;
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
        private ComboBox cbxEstado;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label7;
        private Label label9;
        private Panel panel4;
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
    }
}