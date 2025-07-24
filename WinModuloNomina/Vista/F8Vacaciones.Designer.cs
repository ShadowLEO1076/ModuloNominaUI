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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtIdSVacacion = new TextBox();
            cbxEmpleado = new ComboBox();
            dateInicio = new DateTimePicker();
            txtDiasSolicitados = new TextBox();
            cbxEstado = new ComboBox();
            dateFin = new DateTimePicker();
            txtidAprovacion = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            btnEliminarA = new FontAwesome.Sharp.IconButton();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            txtBuscar2 = new TextBox();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            dgvRevisionV = new Panel();
            dataRevisionV = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            label8 = new Label();
            dgvSolicitudes = new Zuby.ADGV.AdvancedDataGridView();
            solicitudVacacionDTOBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            aprobacionVacacionesBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            dgvRevisionV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aprobacionVacacionesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 159);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3665142F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1885262F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.692934F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.36912F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.38291F));
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdSVacacion, 1, 0);
            tableLayoutPanel1.Controls.Add(cbxEmpleado, 1, 1);
            tableLayoutPanel1.Controls.Add(dateInicio, 1, 2);
            tableLayoutPanel1.Controls.Add(txtDiasSolicitados, 4, 1);
            tableLayoutPanel1.Controls.Add(cbxEstado, 4, 2);
            tableLayoutPanel1.Controls.Add(dateFin, 4, 0);
            tableLayoutPanel1.Controls.Add(txtidAprovacion, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 1);
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(721, 159);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(37, 122);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 20;
            label5.Text = "fecha I.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(16, 69);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 18;
            label3.Text = "Empleado";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 7;
            label1.Text = "id Solicitud";
            // 
            // txtIdSVacacion
            // 
            txtIdSVacacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdSVacacion.Location = new Point(99, 13);
            txtIdSVacacion.Name = "txtIdSVacacion";
            txtIdSVacacion.Size = new Size(218, 27);
            txtIdSVacacion.TabIndex = 7;
            // 
            // cbxEmpleado
            // 
            cbxEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEmpleado.FormattingEnabled = true;
            cbxEmpleado.Location = new Point(99, 65);
            cbxEmpleado.Name = "cbxEmpleado";
            cbxEmpleado.Size = new Size(218, 28);
            cbxEmpleado.TabIndex = 22;
            // 
            // dateInicio
            // 
            dateInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateInicio.Cursor = Cursors.SizeAll;
            dateInicio.CustomFormat = "";
            dateInicio.Format = DateTimePickerFormat.Short;
            dateInicio.Location = new Point(99, 119);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(218, 27);
            dateInicio.TabIndex = 26;
            // 
            // txtDiasSolicitados
            // 
            txtDiasSolicitados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiasSolicitados.Location = new Point(496, 66);
            txtDiasSolicitados.Name = "txtDiasSolicitados";
            txtDiasSolicitados.Size = new Size(222, 27);
            txtDiasSolicitados.TabIndex = 13;
            // 
            // cbxEstado
            // 
            cbxEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(496, 118);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(222, 28);
            cbxEstado.TabIndex = 25;
            // 
            // dateFin
            // 
            dateFin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateFin.Cursor = Cursors.SizeAll;
            dateFin.CustomFormat = "";
            dateFin.Format = DateTimePickerFormat.Short;
            dateFin.Location = new Point(496, 13);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(222, 27);
            dateFin.TabIndex = 27;
            // 
            // txtidAprovacion
            // 
            txtidAprovacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtidAprovacion.Location = new Point(323, 13);
            txtidAprovacion.Name = "txtidAprovacion";
            txtidAprovacion.Size = new Size(71, 27);
            txtidAprovacion.TabIndex = 28;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(448, 69);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 19;
            label4.Text = "Dias ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(429, 16);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 17;
            label2.Text = "Fecha F.";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(436, 122);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 21;
            label6.Text = "Estado";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Location = new Point(438, 159);
            panel5.Name = "panel5";
            panel5.Size = new Size(551, 50);
            panel5.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminarA);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(txtBuscar2);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(btnCrear);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(721, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 159);
            panel2.TabIndex = 4;
            // 
            // btnEliminarA
            // 
            btnEliminarA.Anchor = AnchorStyles.Right;
            btnEliminarA.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarA.IconColor = Color.Black;
            btnEliminarA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarA.IconSize = 22;
            btnEliminarA.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarA.Location = new Point(136, 95);
            btnEliminarA.Name = "btnEliminarA";
            btnEliminarA.Size = new Size(120, 41);
            btnEliminarA.TabIndex = 16;
            btnEliminarA.Text = "Aprovacion";
            btnEliminarA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarA.UseVisualStyleBackColor = true;
            btnEliminarA.Click += btnEliminarA_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Right;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.IconSize = 22;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(6, 95);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(120, 41);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Solicitud";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtBuscar2
            // 
            txtBuscar2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar2.Location = new Point(3, 3);
            txtBuscar2.Name = "txtBuscar2";
            txtBuscar2.Size = new Size(183, 27);
            txtBuscar2.TabIndex = 15;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Right;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(136, 48);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 41);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
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
            btnBuscar.Location = new Point(193, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(59, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Right;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(6, 48);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(120, 41);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(451, 13);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 10;
            label7.Text = "APROVADOS";
            // 
            // dgvRevisionV
            // 
            dgvRevisionV.BackColor = SystemColors.ActiveCaption;
            dgvRevisionV.Controls.Add(label7);
            dgvRevisionV.Dock = DockStyle.Top;
            dgvRevisionV.Location = new Point(0, 159);
            dgvRevisionV.Name = "dgvRevisionV";
            dgvRevisionV.Size = new Size(989, 45);
            dgvRevisionV.TabIndex = 13;
            // 
            // dataRevisionV
            // 
            dataRevisionV.AutoGenerateColumns = false;
            dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRevisionV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRevisionV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14 });
            dataRevisionV.DataSource = aprobacionVacacionesBindingSource;
            dataRevisionV.Dock = DockStyle.Fill;
            dataRevisionV.Location = new Point(3, 3);
            dataRevisionV.Name = "dataRevisionV";
            dataRevisionV.RowHeadersWidth = 51;
            dataRevisionV.Size = new Size(983, 89);
            dataRevisionV.TabIndex = 14;
            dataRevisionV.CellContentClick += dataRevisionV_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataRevisionV, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 204);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(989, 95);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(989, 47);
            panel4.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 14);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 0;
            label8.Text = "SOLICITUDES";
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToOrderColumns = true;
            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgvSolicitudes.DataSource = solicitudVacacionDTOBindingSource;
            dgvSolicitudes.Dock = DockStyle.Fill;
            dgvSolicitudes.FilterAndSortEnabled = true;
            dgvSolicitudes.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvSolicitudes.Location = new Point(0, 346);
            dgvSolicitudes.MaxFilterButtonImageHeight = 23;
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RightToLeft = RightToLeft.No;
            dgvSolicitudes.RowHeadersWidth = 51;
            dgvSolicitudes.Size = new Size(989, 231);
            dgvSolicitudes.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvSolicitudes.TabIndex = 17;
            // 
            // solicitudVacacionDTOBindingSource
            // 
            solicitudVacacionDTOBindingSource.DataSource = typeof(SolicitudVacacionDTO);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdSolicitud";
            dataGridViewTextBoxColumn1.HeaderText = "IdSolicitud";
            dataGridViewTextBoxColumn1.MinimumWidth = 24;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "IdEmpleado";
            dataGridViewTextBoxColumn2.HeaderText = "IdEmpleado";
            dataGridViewTextBoxColumn2.MinimumWidth = 24;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "NombreCompleto";
            dataGridViewTextBoxColumn3.HeaderText = "NombreCompleto";
            dataGridViewTextBoxColumn3.MinimumWidth = 24;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Cedula";
            dataGridViewTextBoxColumn5.HeaderText = "Cedula";
            dataGridViewTextBoxColumn5.MinimumWidth = 24;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "FechaInicio";
            dataGridViewTextBoxColumn6.HeaderText = "FechaInicio";
            dataGridViewTextBoxColumn6.MinimumWidth = 24;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "FechaFin";
            dataGridViewTextBoxColumn7.HeaderText = "FechaFin";
            dataGridViewTextBoxColumn7.MinimumWidth = 24;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "DiasSolicitados";
            dataGridViewTextBoxColumn8.HeaderText = "DiasSolicitados";
            dataGridViewTextBoxColumn8.MinimumWidth = 24;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn9.HeaderText = "Estado";
            dataGridViewTextBoxColumn9.MinimumWidth = 24;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "FechaCreacion";
            dataGridViewTextBoxColumn10.HeaderText = "FechaCreacion";
            dataGridViewTextBoxColumn10.MinimumWidth = 24;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // aprobacionVacacionesBindingSource
            // 
            aprobacionVacacionesBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.AprobacionVacaciones);
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "IdAprobacion";
            dataGridViewTextBoxColumn11.HeaderText = "IdAprobacion";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "SolicitudId";
            dataGridViewTextBoxColumn12.HeaderText = "SolicitudId";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "FechaAprobacion";
            dataGridViewTextBoxColumn13.HeaderText = "FechaAprobacion";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "UsuarioAprobador";
            dataGridViewTextBoxColumn14.HeaderText = "UsuarioAprobador";
            dataGridViewTextBoxColumn14.MinimumWidth = 6;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // F8Vacaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 577);
            Controls.Add(dgvSolicitudes);
            Controls.Add(panel4);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dgvRevisionV);
            Controls.Add(panel1);
            Name = "F8Vacaciones";
            Text = "F8Vacaciones";
            Load += F8Vacaciones_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            dgvRevisionV.ResumeLayout(false);
            dgvRevisionV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)aprobacionVacacionesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private TextBox txtBuscar2;
        private Panel panel5;
        private Label label7;
        private Panel dgvRevisionV;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIdSVacacion;
        private ComboBox cbxEmpleado;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn1;
        private DataGridView dataRevisionV;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private Label label8;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoNombreCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Zuby.ADGV.AdvancedDataGridView dgvSolicitudes;
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
        private ComboBox cbxEstado;
        private DateTimePicker dateFin;
        private TextBox txtidAprovacion;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnEliminarA;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private BindingSource aprobacionVacacionesBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private BindingSource solicitudVacacionDTOBindingSource;
    }
}