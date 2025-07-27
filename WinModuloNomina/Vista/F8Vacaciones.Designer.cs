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
            panel5 = new Panel();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            txtBuscar2 = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            dataRevisionV = new DataGridView();
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
            tableLayoutPanel4 = new TableLayoutPanel();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(-23, 0);
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
            panel1.Size = new Size(1078, 52);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Location = new Point(438, 159);
            panel5.Name = "panel5";
            panel5.Size = new Size(551, 50);
            panel5.TabIndex = 12;
            // 
            // btnEliminarA
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
            panel5.Size = new Size(640, 0);
            panel5.TabIndex = 12;
            // 
            // txtBuscar2
            // 
            txtBuscar2.Anchor = AnchorStyles.Right;
            txtBuscar2.Location = new Point(703, 12);
            txtBuscar2.Name = "txtBuscar2";
            txtBuscar2.Size = new Size(177, 27);
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
            btnBuscar.Location = new Point(886, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 45);
            btnBuscar.TabIndex = 10;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 35;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(481, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(233, 39);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Actualizar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Dock = DockStyle.Fill;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(6, 48);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(120, 41);
            btnCrear.IconSize = 35;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(242, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(233, 39);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Ingresar";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;

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
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(286, 191);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // cbxEmpleado
            // 
            cbxEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEmpleado.FormattingEnabled = true;
            cbxEmpleado.Location = new Point(117, 5);
            cbxEmpleado.Name = "cbxEmpleado";
            cbxEmpleado.Size = new Size(166, 28);
            cbxEmpleado.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 38);
            label5.Name = "label5";
            label5.Size = new Size(72, 38);
            label5.TabIndex = 20;
            label5.Text = "Fecha de Inicio:";
            // 
            // dateInicio
            // 
            dateInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateInicio.Cursor = Cursors.SizeAll;
            dateInicio.CustomFormat = "";
            dateInicio.Format = DateTimePickerFormat.Short;
            dateInicio.Location = new Point(117, 43);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(166, 27);
            dateInicio.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 85);
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
            dateFin.Location = new Point(117, 81);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(166, 27);
            dateFin.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(85, 38);
            label4.TabIndex = 19;
            label4.Text = "Dias Solicitados:";
            // 
            // txtDiasSolicitados
            // 
            txtDiasSolicitados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiasSolicitados.Location = new Point(117, 119);
            txtDiasSolicitados.Name = "txtDiasSolicitados";
            txtDiasSolicitados.Size = new Size(166, 27);
            txtDiasSolicitados.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 152);
            label6.Name = "label6";
            label6.Size = new Size(70, 39);
            label6.TabIndex = 21;
            label6.Text = "Estado Solicitud:";
            // 
            // cbxEstado
            // 
            cbxEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(117, 157);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(166, 28);
            cbxEstado.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 38);
            label3.TabIndex = 18;
            label3.Text = "Seleccione Empleado:";
            // 
            // txtIdSVacacion
            // 
            txtIdSVacacion.Dock = DockStyle.Fill;
            txtIdSVacacion.Location = new Point(3, 3);
            txtIdSVacacion.Name = "txtIdSVacacion";
            txtIdSVacacion.Size = new Size(233, 27);
            txtIdSVacacion.TabIndex = 7;
            // 
            // txtidAprovacion
            // 
            txtidAprovacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtidAprovacion.Location = new Point(429, 115);
            txtidAprovacion.Name = "txtidAprovacion";
            txtidAprovacion.Size = new Size(367, 27);
            txtidAprovacion.TabIndex = 28;
            // 
            // dataRevisionV
            // 
            dataRevisionV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataRevisionV.AutoGenerateColumns = false;
            dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRevisionV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRevisionV.Location = new Point(378, 152);
            dataRevisionV.Name = "dataRevisionV";
            dataRevisionV.RowHeadersWidth = 51;
            dataRevisionV.Size = new Size(624, 163);
            dataRevisionV.TabIndex = 14;
            dataRevisionV.CellContentClick += dataRevisionV_CellContentClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.Controls.Add(btnBorrar, 3, 0);
            tableLayoutPanel4.Controls.Add(btnEditar, 2, 0);
            tableLayoutPanel4.Controls.Add(txtIdSVacacion, 0, 0);
            tableLayoutPanel4.Controls.Add(btnCrear, 1, 0);
            tableLayoutPanel4.Location = new Point(46, 389);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(959, 45);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnBorrar
            // 
            dataRevisionV.AutoGenerateColumns = false;
            dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRevisionV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRevisionV.Dock = DockStyle.Fill;
            dataRevisionV.Location = new Point(3, 3);
            dataRevisionV.Name = "dataRevisionV";
            dataRevisionV.RowHeadersWidth = 51;
            dataRevisionV.Size = new Size(983, 89);
            dataRevisionV.TabIndex = 14;
            dataRevisionV.CellContentClick += dataRevisionV_CellContentClick;
            btnBorrar.Dock = DockStyle.Fill;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.IconSize = 30;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(720, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(236, 39);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // dataGridViewTextBoxColumn1
            // 
            // 
            // F8Vacaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 577);
            ClientSize = new Size(1055, 588);
            Controls.Add(txtidAprovacion);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(dataRevisionV);
            Controls.Add(panel1);
            Name = "F8Vacaciones";
            Text = "F8Vacaciones";
            Load += F8Vacaciones_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private TextBox txtBuscar2;
        private Panel panel5;
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
        private DateTimePicker dateFin;
        private TextBox txtidAprovacion;
        private FontAwesome.Sharp.IconButton btnEliminarA;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private BindingSource aprobacionVacacionesBindingSource;
        private BindingSource solicitudVacacionDTOBindingSource;
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
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}