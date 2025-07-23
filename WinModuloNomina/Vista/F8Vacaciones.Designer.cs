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
            txtFInincio = new TextBox();
            txtFFin = new TextBox();
            cbxEstado = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIdSVacacion = new TextBox();
            txtDiasSolicitados = new TextBox();
            cbxEmpleado = new ComboBox();
            panel5 = new Panel();
            panel2 = new Panel();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            txtBuscar2 = new TextBox();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            solicitudVacacionesBindingSource = new BindingSource(components);
            solicitudVacacionDTOBindingSource = new BindingSource(components);
            dgvAprovados = new DataGridView();
            aprobacionVacacionesBindingSource = new BindingSource(components);
            empleadosVacacionesTotalesBindingSource = new BindingSource(components);
            dgvRevisionV = new Panel();
            label9 = new Label();
            dataRevisionV = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            label8 = new Label();
            dgvSolicitudes = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAprovados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aprobacionVacacionesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadosVacacionesTotalesBindingSource).BeginInit();
            dgvRevisionV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
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
            panel1.Size = new Size(821, 159);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(txtFInincio, 1, 2);
            tableLayoutPanel1.Controls.Add(txtFFin, 3, 0);
            tableLayoutPanel1.Controls.Add(cbxEstado, 3, 2);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdSVacacion, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDiasSolicitados, 3, 1);
            tableLayoutPanel1.Controls.Add(cbxEmpleado, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(589, 159);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // txtFInincio
            // 
            txtFInincio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFInincio.Location = new Point(91, 119);
            txtFInincio.Name = "txtFInincio";
            txtFInincio.Size = new Size(200, 27);
            txtFInincio.TabIndex = 27;
            txtFInincio.TextChanged += txtFInincio_TextChanged;
            txtFInincio.Enter += txtFInincio_Enter;
            txtFInincio.Leave += txtFInincio_Leave;
            // 
            // txtFFin
            // 
            txtFFin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFFin.Location = new Point(385, 13);
            txtFFin.Name = "txtFFin";
            txtFFin.Size = new Size(201, 27);
            txtFFin.TabIndex = 26;
            // 
            // cbxEstado
            // 
            cbxEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(385, 118);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(201, 28);
            cbxEstado.TabIndex = 25;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(325, 122);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 21;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(29, 122);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 20;
            label5.Text = "fecha I.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(337, 69);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 19;
            label4.Text = "Dias ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(8, 69);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 18;
            label3.Text = "Empleado";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(318, 16);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 17;
            label2.Text = "Fecha F.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(18, 6);
            label1.Name = "label1";
            label1.Size = new Size(67, 40);
            label1.TabIndex = 7;
            label1.Text = "id Solicitud";
            // 
            // txtIdSVacacion
            // 
            txtIdSVacacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdSVacacion.Location = new Point(91, 13);
            txtIdSVacacion.Name = "txtIdSVacacion";
            txtIdSVacacion.Size = new Size(200, 27);
            txtIdSVacacion.TabIndex = 7;
            // 
            // txtDiasSolicitados
            // 
            txtDiasSolicitados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiasSolicitados.Location = new Point(385, 66);
            txtDiasSolicitados.Name = "txtDiasSolicitados";
            txtDiasSolicitados.Size = new Size(201, 27);
            txtDiasSolicitados.TabIndex = 13;
            // 
            // cbxEmpleado
            // 
            cbxEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxEmpleado.FormattingEnabled = true;
            cbxEmpleado.Location = new Point(91, 65);
            cbxEmpleado.Name = "cbxEmpleado";
            cbxEmpleado.Size = new Size(200, 28);
            cbxEmpleado.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Location = new Point(438, 159);
            panel5.Name = "panel5";
            panel5.Size = new Size(383, 50);
            panel5.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(txtBuscar2);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(btnCrear);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(589, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 159);
            panel2.TabIndex = 4;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Right;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.Location = new Point(122, 110);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtBuscar2
            // 
            txtBuscar2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar2.Location = new Point(3, 3);
            txtBuscar2.Name = "txtBuscar2";
            txtBuscar2.Size = new Size(147, 27);
            txtBuscar2.TabIndex = 15;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Right;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(122, 75);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(157, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(59, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Right;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(122, 45);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(132, 15);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 10;
            label7.Text = "APROVADOS";
            // 
            // solicitudVacacionesBindingSource
            // 
            solicitudVacacionesBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.SolicitudVacaciones);
            // 
            // solicitudVacacionDTOBindingSource
            // 
            solicitudVacacionDTOBindingSource.DataSource = typeof(Aplicacion.DTO.DTOs.SolicitudVacacionDTO);
            // 
            // dgvAprovados
            // 
            dgvAprovados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAprovados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAprovados.Dock = DockStyle.Fill;
            dgvAprovados.Location = new Point(3, 3);
            dgvAprovados.Name = "dgvAprovados";
            dgvAprovados.RowHeadersWidth = 51;
            dgvAprovados.Size = new Size(404, 89);
            dgvAprovados.TabIndex = 11;
            // 
            // aprobacionVacacionesBindingSource
            // 
            aprobacionVacacionesBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.AprobacionVacaciones);
            // 
            // empleadosVacacionesTotalesBindingSource
            // 
            empleadosVacacionesTotalesBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.EmpleadosVacacionesTotales);
            // 
            // dgvRevisionV
            // 
            dgvRevisionV.BackColor = SystemColors.ActiveCaption;
            dgvRevisionV.Controls.Add(label7);
            dgvRevisionV.Controls.Add(label9);
            dgvRevisionV.Dock = DockStyle.Top;
            dgvRevisionV.Location = new Point(0, 159);
            dgvRevisionV.Name = "dgvRevisionV";
            dgvRevisionV.Size = new Size(821, 45);
            dgvRevisionV.TabIndex = 13;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(626, 15);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 10;
            label9.Text = "DETALLE";
            // 
            // dataRevisionV
            // 
            dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRevisionV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRevisionV.Dock = DockStyle.Fill;
            dataRevisionV.Location = new Point(413, 3);
            dataRevisionV.Name = "dataRevisionV";
            dataRevisionV.RowHeadersWidth = 51;
            dataRevisionV.Size = new Size(405, 89);
            dataRevisionV.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvAprovados, 0, 0);
            tableLayoutPanel2.Controls.Add(dataRevisionV, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 204);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(821, 95);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(821, 47);
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
            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvSolicitudes.DataSource = solicitudVacacionesBindingSource;
            dgvSolicitudes.Dock = DockStyle.Fill;
            dgvSolicitudes.Location = new Point(0, 346);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 51;
            dgvSolicitudes.Size = new Size(821, 88);
            dgvSolicitudes.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdSolicitud";
            dataGridViewTextBoxColumn1.HeaderText = "IdSolicitud";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FechaInicio";
            dataGridViewTextBoxColumn2.HeaderText = "FechaInicio";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "FechaFin";
            dataGridViewTextBoxColumn3.HeaderText = "FechaFin";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn4.HeaderText = "Estado";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // F8Vacaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 434);
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
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)solicitudVacacionDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAprovados).EndInit();
            ((System.ComponentModel.ISupportInitialize)aprobacionVacacionesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadosVacacionesTotalesBindingSource).EndInit();
            dgvRevisionV.ResumeLayout(false);
            dgvRevisionV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataRevisionV).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
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
        private DataGridView dgvAprovados;
        private Panel dgvRevisionV;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIdSVacacion;
        private TextBox txtDiasSolicitados;
        private ComboBox cbxEmpleado;
        private ComboBox cbxEstado;
        private BindingSource aprobacionVacacionesBindingSource;
        private BindingSource empleadosVacacionesTotalesBindingSource;
        private DataGridViewTextBoxColumn idSolicitudDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diasSolicitadosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private BindingSource solicitudVacacionesBindingSource;
        private BindingSource solicitudVacacionDTOBindingSource;
        private DataGridView dataRevisionV;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private Label label8;
        private DataGridView dgvSolicitudes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextBox txtFInincio;
        private TextBox txtFFin;
    }
}