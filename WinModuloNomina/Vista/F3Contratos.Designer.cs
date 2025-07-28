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
            btnCrearContrato = new FontAwesome.Sharp.IconButton();
            btnEditarContrato = new FontAwesome.Sharp.IconButton();
            btnBorrarContrato = new FontAwesome.Sharp.IconButton();
            txtIdTipoContrato = new TextBox();
            label5 = new Label();
            txtBuscarContrato = new TextBox();
            btnBuscarContrato = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            txtAuxE = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label15 = new Label();
            dtpFechaFin = new DateTimePicker();
            label10 = new Label();
            txtHorasJornada = new NumericUpDown();
            label9 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label12 = new Label();
            label14 = new Label();
            cbTipoContrato = new ComboBox();
            txtIdContrato = new TextBox();
            label13 = new Label();
            label11 = new Label();
            txtSalario = new TextBox();
            cbEmpleado = new ComboBox();
            cbEstadoContrato = new ComboBox();
            panel2 = new Panel();
            dgvTipoContrato = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            contratosTipoBindingSource = new BindingSource(components);
            tableLayoutPanel5 = new TableLayoutPanel();
            btnEliminarCT = new FontAwesome.Sharp.IconButton();
            btnCrearTipoC = new FontAwesome.Sharp.IconButton();
            btnEditarTipoC = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            cbJornadaTipo = new ComboBox();
            label6 = new Label();
            txtNombreTipo = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvHistorialContratos = new Zuby.ADGV.AdvancedDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            cedulaEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCompletoEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoContratoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionTipoContratoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            fechaModificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            contratosDTOBindingSource = new BindingSource(components);
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtHorasJornada).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoContrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialContratos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.BackColor = SystemColors.ButtonShadow;
            btnCrearContrato.Dock = DockStyle.Fill;
            btnCrearContrato.FlatAppearance.BorderSize = 0;
            btnCrearContrato.FlatStyle = FlatStyle.Flat;
            btnCrearContrato.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCrearContrato.IconColor = Color.Black;
            btnCrearContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearContrato.IconSize = 40;
            btnCrearContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearContrato.Location = new Point(3, 3);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(119, 34);
            btnCrearContrato.TabIndex = 9;
            btnCrearContrato.Text = "Crear";
            btnCrearContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearContrato.UseVisualStyleBackColor = false;
            btnCrearContrato.Click += btnCrearContrato_Click;
            // 
            // btnEditarContrato
            // 
            btnEditarContrato.BackColor = SystemColors.ButtonShadow;
            btnEditarContrato.Dock = DockStyle.Fill;
            btnEditarContrato.FlatAppearance.BorderSize = 0;
            btnEditarContrato.FlatStyle = FlatStyle.Flat;
            btnEditarContrato.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditarContrato.IconColor = Color.Black;
            btnEditarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarContrato.IconSize = 40;
            btnEditarContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarContrato.Location = new Point(128, 3);
            btnEditarContrato.Name = "btnEditarContrato";
            btnEditarContrato.Size = new Size(119, 34);
            btnEditarContrato.TabIndex = 11;
            btnEditarContrato.Text = "Actualizar";
            btnEditarContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarContrato.UseVisualStyleBackColor = false;
            btnEditarContrato.Click += btnEditarContrato_Click;
            // 
            // btnBorrarContrato
            // 
            btnBorrarContrato.BackColor = SystemColors.ButtonShadow;
            btnBorrarContrato.Dock = DockStyle.Fill;
            btnBorrarContrato.FlatAppearance.BorderSize = 0;
            btnBorrarContrato.FlatStyle = FlatStyle.Flat;
            btnBorrarContrato.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrarContrato.IconColor = Color.Black;
            btnBorrarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarContrato.IconSize = 35;
            btnBorrarContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrarContrato.Location = new Point(253, 3);
            btnBorrarContrato.Name = "btnBorrarContrato";
            btnBorrarContrato.Size = new Size(120, 34);
            btnBorrarContrato.TabIndex = 12;
            btnBorrarContrato.Text = "Eliminar";
            btnBorrarContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrarContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarContrato.UseVisualStyleBackColor = false;
            btnBorrarContrato.Click += btnBorrarContrato_Click;
            // 
            // txtIdTipoContrato
            // 
            txtIdTipoContrato.Anchor = AnchorStyles.Right;
            txtIdTipoContrato.Location = new Point(285, 6);
            txtIdTipoContrato.Name = "txtIdTipoContrato";
            txtIdTipoContrato.Size = new Size(62, 23);
            txtIdTipoContrato.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(134, 9);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 2;
            label5.Text = "CONTRATO";
            // 
            // txtBuscarContrato
            // 
            txtBuscarContrato.Anchor = AnchorStyles.Right;
            txtBuscarContrato.Location = new Point(550, 9);
            txtBuscarContrato.Name = "txtBuscarContrato";
            txtBuscarContrato.Size = new Size(141, 23);
            txtBuscarContrato.TabIndex = 11;
            txtBuscarContrato.TextChanged += txtBuscarContrato_TextChanged;
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
            btnBuscarContrato.Location = new Point(707, 6);
            btnBuscarContrato.Name = "btnBuscarContrato";
            btnBuscarContrato.Size = new Size(38, 26);
            btnBuscarContrato.TabIndex = 11;
            btnBuscarContrato.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(txtAuxE);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(376, 34);
            panel5.TabIndex = 10;
            // 
            // txtAuxE
            // 
            txtAuxE.Location = new Point(300, 6);
            txtAuxE.Margin = new Padding(3, 2, 3, 2);
            txtAuxE.Name = "txtAuxE";
            txtAuxE.Size = new Size(62, 23);
            txtAuxE.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.Highlight;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtIdTipoContrato);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 34);
            panel4.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(121, 9);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 16;
            label4.Text = "TIPO CONTRATO";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtBuscarContrato);
            panel3.Controls.Add(btnBuscarContrato);
            panel3.Location = new Point(44, 302);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(763, 38);
            panel3.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(298, 12);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 16;
            label2.Text = "RESUMEN CONTRATOS";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnCrearContrato, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEditarContrato, 1, 0);
            tableLayoutPanel2.Controls.Add(btnBorrarContrato, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 245);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(376, 40);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(384, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 285);
            panel1.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.9985F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.0014954F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label15, 0, 4);
            tableLayoutPanel3.Controls.Add(dtpFechaFin, 1, 4);
            tableLayoutPanel3.Controls.Add(label10, 0, 3);
            tableLayoutPanel3.Controls.Add(txtHorasJornada, 1, 7);
            tableLayoutPanel3.Controls.Add(label9, 0, 7);
            tableLayoutPanel3.Controls.Add(dtpFechaInicio, 1, 3);
            tableLayoutPanel3.Controls.Add(label12, 0, 2);
            tableLayoutPanel3.Controls.Add(label14, 0, 1);
            tableLayoutPanel3.Controls.Add(cbTipoContrato, 1, 1);
            tableLayoutPanel3.Controls.Add(txtIdContrato, 1, 0);
            tableLayoutPanel3.Controls.Add(label13, 0, 5);
            tableLayoutPanel3.Controls.Add(label11, 0, 6);
            tableLayoutPanel3.Controls.Add(txtSalario, 1, 5);
            tableLayoutPanel3.Controls.Add(cbEmpleado, 1, 2);
            tableLayoutPanel3.Controls.Add(cbEstadoContrato, 1, 6);
            tableLayoutPanel3.Location = new Point(0, 34);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.Size = new Size(376, 208);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 30;
            label1.Text = "ID:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(3, 109);
            label15.Name = "label15";
            label15.Size = new Size(38, 15);
            label15.TabIndex = 17;
            label15.Text = "F. Fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaFin.Location = new Point(134, 107);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(239, 23);
            dtpFechaFin.TabIndex = 29;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 83);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 22;
            label10.Text = "F.Inicio:";
            // 
            // txtHorasJornada
            // 
            txtHorasJornada.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHorasJornada.Location = new Point(134, 185);
            txtHorasJornada.Name = "txtHorasJornada";
            txtHorasJornada.Size = new Size(239, 23);
            txtHorasJornada.TabIndex = 30;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 187);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 23;
            label9.Text = "Horas ";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaInicio.Location = new Point(134, 81);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(239, 23);
            dtpFechaInicio.TabIndex = 28;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(3, 57);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 20;
            label12.Text = "Empleado:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(3, 31);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 18;
            label14.Text = "Tipo:";
            // 
            // cbTipoContrato
            // 
            cbTipoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbTipoContrato.FormattingEnabled = true;
            cbTipoContrato.Location = new Point(134, 29);
            cbTipoContrato.Name = "cbTipoContrato";
            cbTipoContrato.Size = new Size(239, 23);
            cbTipoContrato.TabIndex = 24;
            // 
            // txtIdContrato
            // 
            txtIdContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdContrato.Location = new Point(134, 3);
            txtIdContrato.Name = "txtIdContrato";
            txtIdContrato.Size = new Size(239, 23);
            txtIdContrato.TabIndex = 7;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(3, 135);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 19;
            label13.Text = "Salario:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(3, 161);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 21;
            label11.Text = "Estado:";
            // 
            // txtSalario
            // 
            txtSalario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSalario.Location = new Point(134, 133);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(239, 23);
            txtSalario.TabIndex = 13;
            // 
            // cbEmpleado
            // 
            cbEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(134, 55);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(239, 23);
            cbEmpleado.TabIndex = 26;
            cbEmpleado.SelectedIndexChanged += cbJornadaTipo_SelectedIndexChanged;
            // 
            // cbEstadoContrato
            // 
            cbEstadoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbEstadoContrato.FormattingEnabled = true;
            cbEstadoContrato.Location = new Point(134, 159);
            cbEstadoContrato.Name = "cbEstadoContrato";
            cbEstadoContrato.Size = new Size(239, 23);
            cbEstadoContrato.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTipoContrato);
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 285);
            panel2.TabIndex = 18;
            // 
            // dgvTipoContrato
            // 
            dgvTipoContrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTipoContrato.AutoGenerateColumns = false;
            dgvTipoContrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoContrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoContrato.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgvTipoContrato.DataSource = contratosTipoBindingSource;
            dgvTipoContrato.Location = new Point(10, 145);
            dgvTipoContrato.Name = "dgvTipoContrato";
            dgvTipoContrato.RowHeadersWidth = 51;
            dgvTipoContrato.Size = new Size(360, 137);
            dgvTipoContrato.TabIndex = 13;
            dgvTipoContrato.CellClick += dgvTipoContrato_CellClick;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "IdTipo";
            dataGridViewTextBoxColumn7.HeaderText = "IdTipo";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Jornada";
            dataGridViewTextBoxColumn8.HeaderText = "Jornada";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn9.HeaderText = "Nombre";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // contratosTipoBindingSource
            // 
            contratosTipoBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.ContratosTipo);
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(btnEliminarCT, 2, 0);
            tableLayoutPanel5.Controls.Add(btnCrearTipoC, 0, 0);
            tableLayoutPanel5.Controls.Add(btnEditarTipoC, 1, 0);
            tableLayoutPanel5.Location = new Point(7, 104);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(366, 38);
            tableLayoutPanel5.TabIndex = 20;
            // 
            // btnEliminarCT
            // 
            btnEliminarCT.BackColor = SystemColors.ButtonShadow;
            btnEliminarCT.Dock = DockStyle.Fill;
            btnEliminarCT.FlatAppearance.BorderSize = 0;
            btnEliminarCT.FlatStyle = FlatStyle.Flat;
            btnEliminarCT.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarCT.IconColor = Color.Black;
            btnEliminarCT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarCT.IconSize = 35;
            btnEliminarCT.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarCT.Location = new Point(247, 3);
            btnEliminarCT.Name = "btnEliminarCT";
            btnEliminarCT.Size = new Size(116, 32);
            btnEliminarCT.TabIndex = 33;
            btnEliminarCT.Text = "Eliminar";
            btnEliminarCT.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarCT.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarCT.UseVisualStyleBackColor = false;
            btnEliminarCT.Click += btnEliminarCT_Click;
            // 
            // btnCrearTipoC
            // 
            btnCrearTipoC.BackColor = SystemColors.ButtonShadow;
            btnCrearTipoC.Dock = DockStyle.Fill;
            btnCrearTipoC.FlatAppearance.BorderSize = 0;
            btnCrearTipoC.FlatStyle = FlatStyle.Flat;
            btnCrearTipoC.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCrearTipoC.IconColor = Color.Black;
            btnCrearTipoC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearTipoC.IconSize = 40;
            btnCrearTipoC.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearTipoC.Location = new Point(3, 3);
            btnCrearTipoC.Name = "btnCrearTipoC";
            btnCrearTipoC.Size = new Size(116, 32);
            btnCrearTipoC.TabIndex = 30;
            btnCrearTipoC.Text = "Crear";
            btnCrearTipoC.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearTipoC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearTipoC.UseVisualStyleBackColor = false;
            btnCrearTipoC.Click += btnCrearTipoC_Click;
            // 
            // btnEditarTipoC
            // 
            btnEditarTipoC.BackColor = SystemColors.ButtonShadow;
            btnEditarTipoC.Dock = DockStyle.Fill;
            btnEditarTipoC.FlatAppearance.BorderSize = 0;
            btnEditarTipoC.FlatStyle = FlatStyle.Flat;
            btnEditarTipoC.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditarTipoC.IconColor = Color.Black;
            btnEditarTipoC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarTipoC.IconSize = 40;
            btnEditarTipoC.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarTipoC.Location = new Point(125, 3);
            btnEditarTipoC.Name = "btnEditarTipoC";
            btnEditarTipoC.Size = new Size(116, 32);
            btnEditarTipoC.TabIndex = 32;
            btnEditarTipoC.Text = "Editar";
            btnEditarTipoC.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarTipoC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarTipoC.UseVisualStyleBackColor = false;
            btnEditarTipoC.Click += btnEditarTipoC_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(cbJornadaTipo, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNombreTipo, 1, 1);
            tableLayoutPanel1.Location = new Point(26, 34);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(349, 65);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 18;
            label3.Text = "Jornada";
            // 
            // cbJornadaTipo
            // 
            cbJornadaTipo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbJornadaTipo.FormattingEnabled = true;
            cbJornadaTipo.Location = new Point(119, 4);
            cbJornadaTipo.Name = "cbJornadaTipo";
            cbJornadaTipo.Size = new Size(227, 23);
            cbJornadaTipo.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 41);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 19;
            label6.Text = "Descripcion";
            // 
            // txtNombreTipo
            // 
            txtNombreTipo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreTipo.Location = new Point(119, 37);
            txtNombreTipo.Name = "txtNombreTipo";
            txtNombreTipo.Size = new Size(227, 23);
            txtNombreTipo.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel1, 1, 0);
            tableLayoutPanel4.Controls.Add(panel2, 0, 0);
            tableLayoutPanel4.Location = new Point(44, 9);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(763, 289);
            tableLayoutPanel4.TabIndex = 19;
            // 
            // dgvHistorialContratos
            // 
            dgvHistorialContratos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistorialContratos.AutoGenerateColumns = false;
            dgvHistorialContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialContratos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, cedulaEmpleadoDataGridViewTextBoxColumn, nombreCompletoEmpleadoDataGridViewTextBoxColumn, tipoContratoDataGridViewTextBoxColumn, descripcionTipoContratoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, fechaModificacionDataGridViewTextBoxColumn, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvHistorialContratos.DataSource = contratosDTOBindingSource;
            dgvHistorialContratos.FilterAndSortEnabled = true;
            dgvHistorialContratos.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistorialContratos.Location = new Point(44, 345);
            dgvHistorialContratos.MaxFilterButtonImageHeight = 23;
            dgvHistorialContratos.Name = "dgvHistorialContratos";
            dgvHistorialContratos.RightToLeft = RightToLeft.No;
            dgvHistorialContratos.RowHeadersWidth = 51;
            dgvHistorialContratos.Size = new Size(763, 128);
            dgvHistorialContratos.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistorialContratos.TabIndex = 20;
            dgvHistorialContratos.CellClick += dgvHistorialContratos_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdContrato";
            dataGridViewTextBoxColumn1.HeaderText = "IdContrato";
            dataGridViewTextBoxColumn1.MinimumWidth = 24;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "EmpleadoId";
            dataGridViewTextBoxColumn2.HeaderText = "EmpleadoId";
            dataGridViewTextBoxColumn2.MinimumWidth = 24;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // cedulaEmpleadoDataGridViewTextBoxColumn
            // 
            cedulaEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CedulaEmpleado";
            cedulaEmpleadoDataGridViewTextBoxColumn.HeaderText = "CedulaEmpleado";
            cedulaEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 24;
            cedulaEmpleadoDataGridViewTextBoxColumn.Name = "cedulaEmpleadoDataGridViewTextBoxColumn";
            cedulaEmpleadoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // nombreCompletoEmpleadoDataGridViewTextBoxColumn
            // 
            nombreCompletoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompletoEmpleado";
            nombreCompletoEmpleadoDataGridViewTextBoxColumn.HeaderText = "NombreCompletoEmpleado";
            nombreCompletoEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 24;
            nombreCompletoEmpleadoDataGridViewTextBoxColumn.Name = "nombreCompletoEmpleadoDataGridViewTextBoxColumn";
            nombreCompletoEmpleadoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // tipoContratoDataGridViewTextBoxColumn
            // 
            tipoContratoDataGridViewTextBoxColumn.DataPropertyName = "TipoContrato";
            tipoContratoDataGridViewTextBoxColumn.HeaderText = "TipoContrato";
            tipoContratoDataGridViewTextBoxColumn.MinimumWidth = 24;
            tipoContratoDataGridViewTextBoxColumn.Name = "tipoContratoDataGridViewTextBoxColumn";
            tipoContratoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // descripcionTipoContratoDataGridViewTextBoxColumn
            // 
            descripcionTipoContratoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTipoContrato";
            descripcionTipoContratoDataGridViewTextBoxColumn.HeaderText = "DescripcionTipoContrato";
            descripcionTipoContratoDataGridViewTextBoxColumn.MinimumWidth = 24;
            descripcionTipoContratoDataGridViewTextBoxColumn.Name = "descripcionTipoContratoDataGridViewTextBoxColumn";
            descripcionTipoContratoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Salario";
            dataGridViewTextBoxColumn3.HeaderText = "Salario";
            dataGridViewTextBoxColumn3.MinimumWidth = 24;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "FechaCreacion";
            dataGridViewTextBoxColumn4.HeaderText = "FechaCreacion";
            dataGridViewTextBoxColumn4.MinimumWidth = 24;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            fechaModificacionDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "HorasJornada";
            dataGridViewTextBoxColumn5.HeaderText = "HorasJornada";
            dataGridViewTextBoxColumn5.MinimumWidth = 24;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn6.HeaderText = "Estado";
            dataGridViewTextBoxColumn6.MinimumWidth = 24;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // contratosDTOBindingSource
            // 
            contratosDTOBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.ContratosDTO);
            // 
            // F3Contratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 469);
            Controls.Add(dgvHistorialContratos);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "F3Contratos";
            Text = "F3Contratos";
            Load += F3Contratos_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtHorasJornada).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTipoContrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialContratos).EndInit();
            ((System.ComponentModel.ISupportInitialize)contratosDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBorrarContrato;
        private FontAwesome.Sharp.IconButton btnEditarContrato;
        private FontAwesome.Sharp.IconButton btnCrearContrato;
        private TextBox txtIdTipoContrato;
        private Label label5;
        private TextBox txtBuscarContrato;
        private FontAwesome.Sharp.IconButton btnBuscarContrato;
        private DataGridViewTextBoxColumn idContratoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasJornadaDataGridViewTextBoxColumn;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Label label4;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvTipoContrato;
        private DataGridViewTextBoxColumn idTipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jornadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnEliminarCT;
        private Label label3;
        private ComboBox cbJornadaTipo;
        private FontAwesome.Sharp.IconButton btnCrearTipoC;
        private Label label6;
        private TextBox txtNombreTipo;
        private FontAwesome.Sharp.IconButton btnEditarTipoC;
        private Label label9;
        private NumericUpDown txtHorasJornada;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label15;
        private DateTimePicker dtpFechaFin;
        private Label label10;
        private DateTimePicker dtpFechaInicio;
        private Label label12;
        private Label label14;
        private ComboBox cbTipoContrato;
        private TextBox txtIdContrato;
        private Label label13;
        private Label label11;
        private TextBox txtSalario;
        private ComboBox cbEstadoContrato;
        private ComboBox cbEmpleado;
        private TableLayoutPanel tableLayoutPanel5;
        private Zuby.ADGV.AdvancedDataGridView dgvHistorialContratos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private BindingSource contratosTipoBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn cedulaEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCompletoEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoContratoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionTipoContratoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIniciocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFincDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource contratosDTOBindingSource;
        private TextBox txtAuxE;
    }
}