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
            btnBuscar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tipoLb = new Label();
            tipoTxt = new ComboBox();
            label2 = new Label();
            montoTxt = new TextBox();
            label4 = new Label();
            idEmpleadoCb = new ComboBox();
            fechaLb = new Label();
            fechaDTP = new DateTimePicker();
            idDescuentosTxt = new Label();
            textBox4 = new TextBox();
            descripcionLb = new Label();
            descripcionTxt = new TextBox();
            panel5 = new Panel();
            txtBuscarD = new TextBox();
            label3 = new Label();
            dgvDescuentos = new Zuby.ADGV.AdvancedDataGridView();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            txtEstado = new TextBox();
            label1 = new Label();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnBuscar.Location = new Point(891, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(59, 39);
            btnBuscar.TabIndex = 18;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Location = new Point(27, 56);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(615, 253);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 247);
            panel2.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(tipoLb, 0, 3);
            tableLayoutPanel1.Controls.Add(tipoTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 2, 3);
            tableLayoutPanel1.Controls.Add(montoTxt, 3, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(idEmpleadoCb, 1, 2);
            tableLayoutPanel1.Controls.Add(fechaLb, 2, 2);
            tableLayoutPanel1.Controls.Add(fechaDTP, 3, 2);
            tableLayoutPanel1.Controls.Add(idDescuentosTxt, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(descripcionLb, 2, 1);
            tableLayoutPanel1.Controls.Add(descripcionTxt, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.Size = new Size(609, 247);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // tipoLb
            // 
            tipoLb.Anchor = AnchorStyles.Left;
            tipoLb.AutoSize = true;
            tipoLb.Location = new Point(3, 200);
            tipoLb.Name = "tipoLb";
            tipoLb.Size = new Size(79, 20);
            tipoLb.TabIndex = 18;
            tipoLb.Text = "Descuento";
            // 
            // tipoTxt
            // 
            tipoTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tipoTxt.FormattingEnabled = true;
            tipoTxt.Location = new Point(124, 196);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(176, 28);
            tipoTxt.TabIndex = 27;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(306, 200);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 44;
            label2.Text = "Monto";
            // 
            // montoTxt
            // 
            montoTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            montoTxt.Location = new Point(427, 196);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(179, 27);
            montoTxt.TabIndex = 43;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 127);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 28;
            label4.Text = "Empleado";
            // 
            // idEmpleadoCb
            // 
            idEmpleadoCb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idEmpleadoCb.FormattingEnabled = true;
            idEmpleadoCb.Location = new Point(124, 123);
            idEmpleadoCb.Name = "idEmpleadoCb";
            idEmpleadoCb.Size = new Size(176, 28);
            idEmpleadoCb.TabIndex = 29;
            // 
            // fechaLb
            // 
            fechaLb.Anchor = AnchorStyles.Left;
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(306, 127);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(103, 20);
            fechaLb.TabIndex = 24;
            fechaLb.Text = "Fecha Emision";
            // 
            // fechaDTP
            // 
            fechaDTP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fechaDTP.Format = DateTimePickerFormat.Short;
            fechaDTP.Location = new Point(427, 123);
            fechaDTP.Margin = new Padding(3, 4, 3, 4);
            fechaDTP.Name = "fechaDTP";
            fechaDTP.Size = new Size(179, 27);
            fechaDTP.TabIndex = 26;
            fechaDTP.Value = new DateTime(2025, 7, 21, 20, 56, 31, 0);
            // 
            // idDescuentosTxt
            // 
            idDescuentosTxt.Anchor = AnchorStyles.Left;
            idDescuentosTxt.AutoSize = true;
            idDescuentosTxt.Location = new Point(3, 55);
            idDescuentosTxt.Name = "idDescuentosTxt";
            idDescuentosTxt.Size = new Size(102, 20);
            idDescuentosTxt.TabIndex = 17;
            idDescuentosTxt.Text = "Id Descuentos";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(124, 51);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(176, 27);
            textBox4.TabIndex = 10;
            // 
            // descripcionLb
            // 
            descripcionLb.Anchor = AnchorStyles.Left;
            descripcionLb.AutoSize = true;
            descripcionLb.Location = new Point(306, 55);
            descripcionLb.Name = "descripcionLb";
            descripcionLb.Size = new Size(87, 20);
            descripcionLb.TabIndex = 22;
            descripcionLb.Text = "Descripcion";
            // 
            // descripcionTxt
            // 
            descripcionTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descripcionTxt.Location = new Point(427, 51);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(179, 27);
            descripcionTxt.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Controls.Add(txtBuscarD);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(0, 322);
            panel5.Name = "panel5";
            panel5.Size = new Size(954, 39);
            panel5.TabIndex = 23;
            // 
            // txtBuscarD
            // 
            txtBuscarD.Anchor = AnchorStyles.Right;
            txtBuscarD.Location = new Point(769, 5);
            txtBuscarD.Name = "txtBuscarD";
            txtBuscarD.Size = new Size(127, 27);
            txtBuscarD.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(390, 9);
            label3.Name = "label3";
            label3.Size = new Size(194, 18);
            label3.TabIndex = 19;
            label3.Text = "Descuentos Registrados";
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDescuentos.AutoGenerateColumns = false;
            dgvDescuentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20 });
            dgvDescuentos.DataSource = bindingSource1;
            dgvDescuentos.FilterAndSortEnabled = true;
            dgvDescuentos.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvDescuentos.Location = new Point(-1, 358);
            dgvDescuentos.MaxFilterButtonImageHeight = 23;
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.RightToLeft = RightToLeft.No;
            dgvDescuentos.RowHeadersWidth = 51;
            dgvDescuentos.Size = new Size(951, 248);
            dgvDescuentos.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvDescuentos.TabIndex = 25;
            dgvDescuentos.CellClick += dgvDescuentos_CellClick;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "IdDescuento";
            dataGridViewTextBoxColumn14.HeaderText = "IdDescuento";
            dataGridViewTextBoxColumn14.MinimumWidth = 24;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "EmpleadoId";
            dataGridViewTextBoxColumn15.HeaderText = "EmpleadoId";
            dataGridViewTextBoxColumn15.MinimumWidth = 24;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "Tipo";
            dataGridViewTextBoxColumn16.HeaderText = "Tipo";
            dataGridViewTextBoxColumn16.MinimumWidth = 24;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "Descripcion";
            dataGridViewTextBoxColumn17.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn17.MinimumWidth = 24;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "Monto";
            dataGridViewTextBoxColumn18.HeaderText = "Monto";
            dataGridViewTextBoxColumn18.MinimumWidth = 24;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "Fecha";
            dataGridViewTextBoxColumn19.HeaderText = "Fecha";
            dataGridViewTextBoxColumn19.MinimumWidth = 24;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn20.HeaderText = "Estado";
            dataGridViewTextBoxColumn20.MinimumWidth = 24;
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Infraestructura.AccesoDatos.Descuentos);
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.Dock = DockStyle.Fill;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.IconSize = 34;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(3, 103);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Padding = new Padding(11, 0, 0, 0);
            btnBorrar.Size = new Size(213, 46);
            btnBorrar.TabIndex = 20;
            btnBorrar.Text = "Eliminar";
            btnBorrar.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 35;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(3, 53);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(11, 0, 0, 0);
            btnEditar.Size = new Size(213, 44);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Actualizar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.RoyalBlue;
            btnCrear.Dock = DockStyle.Fill;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.IconSize = 35;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(3, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Padding = new Padding(11, 0, 0, 0);
            btnCrear.Size = new Size(213, 44);
            btnCrear.TabIndex = 17;
            btnCrear.Text = "Crear";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnCrear, 0, 0);
            tableLayoutPanel3.Controls.Add(btnEditar, 0, 1);
            tableLayoutPanel3.Controls.Add(btnBorrar, 0, 2);
            tableLayoutPanel3.Location = new Point(720, 59);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(219, 152);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(txtEstado);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 45);
            panel1.TabIndex = 26;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Right;
            txtEstado.Location = new Point(1298, -16);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(56, 27);
            txtEstado.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(381, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 18);
            label1.TabIndex = 0;
            label1.Text = "Registro Descuentos Individual";
            // 
            // F5Descuentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 608);
            Controls.Add(panel1);
            Controls.Add(dgvDescuentos);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel5);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F5Descuentos";
            Text = " ";
            Load += F5Descuentos_Load;
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Zuby.ADGV.AdvancedDataGridView dgvDescuentos;
        private DataGridViewTextBoxColumn idDescuentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private Label label1;
        private Label label3;
        private TextBox txtBuscarD;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panelAuxiliar;
        private TextBox txtEstado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private BindingSource descuentosBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private BindingSource bindingSource1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox idEmpleadoCb;
        private Label label4;
        private Label idDescuentosTxt;
        private TextBox textBox4;
        private Label tipoLb;
        private ComboBox tipoTxt;
        private Label descripcionLb;
        private Label fechaLb;
        private Label label2;
        private TextBox descripcionTxt;
        private DateTimePicker fechaDTP;
        private TextBox montoTxt;
    }
}