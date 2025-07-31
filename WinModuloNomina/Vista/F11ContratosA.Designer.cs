namespace WinModuloNomina.Vista
{
    partial class F11ContratosA
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
            panel3 = new Panel();
            btnBuscarContrato = new FontAwesome.Sharp.IconButton();
            txtBuscarContrato = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label10 = new Label();
            label12 = new Label();
            label14 = new Label();
            cbTipoContrato = new ComboBox();
            txtIdContrato = new TextBox();
            cbEmpleado = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            txtSalario = new TextBox();
            cbEstadoContrato = new ComboBox();
            txtHorasJornada = new NumericUpDown();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCrearContrato = new FontAwesome.Sharp.IconButton();
            btnEditarContrato = new FontAwesome.Sharp.IconButton();
            btnBorrarContrato = new FontAwesome.Sharp.IconButton();
            dgvHistorialContratos = new Zuby.ADGV.AdvancedDataGridView();
            btnHistorico = new FontAwesome.Sharp.IconButton();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtHorasJornada).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialContratos).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnHistorico);
            panel3.Controls.Add(btnBuscarContrato);
            panel3.Controls.Add(txtBuscarContrato);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(879, 255);
            panel3.TabIndex = 16;
            // 
            // btnBuscarContrato
            // 
            btnBuscarContrato.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarContrato.FlatAppearance.BorderSize = 0;
            btnBuscarContrato.FlatStyle = FlatStyle.Flat;
            btnBuscarContrato.ForeColor = Color.Transparent;
            btnBuscarContrato.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarContrato.IconColor = Color.Black;
            btnBuscarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarContrato.IconSize = 35;
            btnBuscarContrato.Location = new Point(818, 220);
            btnBuscarContrato.Margin = new Padding(3, 4, 3, 4);
            btnBuscarContrato.Name = "btnBuscarContrato";
            btnBuscarContrato.Size = new Size(35, 27);
            btnBuscarContrato.TabIndex = 26;
            btnBuscarContrato.UseVisualStyleBackColor = true;
            // 
            // txtBuscarContrato
            // 
            txtBuscarContrato.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarContrato.Location = new Point(646, 220);
            txtBuscarContrato.Margin = new Padding(3, 4, 3, 4);
            txtBuscarContrato.Name = "txtBuscarContrato";
            txtBuscarContrato.Size = new Size(166, 27);
            txtBuscarContrato.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label10, 0, 3);
            tableLayoutPanel3.Controls.Add(label12, 0, 2);
            tableLayoutPanel3.Controls.Add(label14, 0, 1);
            tableLayoutPanel3.Controls.Add(cbTipoContrato, 1, 1);
            tableLayoutPanel3.Controls.Add(txtIdContrato, 1, 0);
            tableLayoutPanel3.Controls.Add(cbEmpleado, 1, 2);
            tableLayoutPanel3.Controls.Add(dtpFechaInicio, 1, 3);
            tableLayoutPanel3.Controls.Add(dtpFechaFin, 4, 0);
            tableLayoutPanel3.Controls.Add(txtSalario, 4, 1);
            tableLayoutPanel3.Controls.Add(cbEstadoContrato, 4, 2);
            tableLayoutPanel3.Controls.Add(txtHorasJornada, 4, 3);
            tableLayoutPanel3.Controls.Add(label15, 3, 0);
            tableLayoutPanel3.Controls.Add(label13, 3, 1);
            tableLayoutPanel3.Controls.Add(label11, 3, 2);
            tableLayoutPanel3.Controls.Add(label9, 3, 3);
            tableLayoutPanel3.Location = new Point(12, 21);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(646, 180);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 30;
            label1.Text = "ID:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 147);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 22;
            label10.Text = "F.Inicio:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(3, 102);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 20;
            label12.Text = "Empleado:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(3, 57);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 18;
            label14.Text = "Tipo:";
            // 
            // cbTipoContrato
            // 
            cbTipoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbTipoContrato.FormattingEnabled = true;
            cbTipoContrato.Location = new Point(116, 53);
            cbTipoContrato.Margin = new Padding(3, 4, 3, 4);
            cbTipoContrato.Name = "cbTipoContrato";
            cbTipoContrato.Size = new Size(171, 28);
            cbTipoContrato.TabIndex = 24;
            // 
            // txtIdContrato
            // 
            txtIdContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdContrato.Location = new Point(116, 9);
            txtIdContrato.Margin = new Padding(3, 4, 3, 4);
            txtIdContrato.Name = "txtIdContrato";
            txtIdContrato.Size = new Size(171, 27);
            txtIdContrato.TabIndex = 7;
            // 
            // cbEmpleado
            // 
            cbEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(116, 98);
            cbEmpleado.Margin = new Padding(3, 4, 3, 4);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(171, 28);
            cbEmpleado.TabIndex = 26;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaInicio.Location = new Point(116, 144);
            dtpFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(171, 27);
            dtpFechaInicio.TabIndex = 28;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaFin.Location = new Point(470, 9);
            dtpFechaFin.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(173, 27);
            dtpFechaFin.TabIndex = 29;
            // 
            // txtSalario
            // 
            txtSalario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSalario.Location = new Point(470, 54);
            txtSalario.Margin = new Padding(3, 4, 3, 4);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(173, 27);
            txtSalario.TabIndex = 13;
            // 
            // cbEstadoContrato
            // 
            cbEstadoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbEstadoContrato.FormattingEnabled = true;
            cbEstadoContrato.Location = new Point(470, 98);
            cbEstadoContrato.Margin = new Padding(3, 4, 3, 4);
            cbEstadoContrato.Name = "cbEstadoContrato";
            cbEstadoContrato.Size = new Size(173, 28);
            cbEstadoContrato.TabIndex = 25;
            // 
            // txtHorasJornada
            // 
            txtHorasJornada.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHorasJornada.Location = new Point(470, 144);
            txtHorasJornada.Margin = new Padding(3, 4, 3, 4);
            txtHorasJornada.Name = "txtHorasJornada";
            txtHorasJornada.Size = new Size(173, 27);
            txtHorasJornada.TabIndex = 30;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(357, 12);
            label15.Name = "label15";
            label15.Size = new Size(45, 20);
            label15.TabIndex = 17;
            label15.Text = "F. Fin:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(357, 57);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 19;
            label13.Text = "Salario:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(357, 102);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 21;
            label11.Text = "Estado:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(357, 147);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 23;
            label9.Text = "Horas ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Controls.Add(btnCrearContrato, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEditarContrato, 0, 1);
            tableLayoutPanel2.Controls.Add(btnBorrarContrato, 0, 2);
            tableLayoutPanel2.Location = new Point(701, 17);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(166, 180);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.BackColor = Color.RoyalBlue;
            btnCrearContrato.Dock = DockStyle.Fill;
            btnCrearContrato.FlatAppearance.BorderSize = 0;
            btnCrearContrato.FlatStyle = FlatStyle.Flat;
            btnCrearContrato.ForeColor = Color.WhiteSmoke;
            btnCrearContrato.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCrearContrato.IconColor = Color.WhiteSmoke;
            btnCrearContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearContrato.IconSize = 40;
            btnCrearContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearContrato.Location = new Point(3, 4);
            btnCrearContrato.Margin = new Padding(3, 4, 3, 4);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(160, 52);
            btnCrearContrato.TabIndex = 9;
            btnCrearContrato.Text = "Crear";
            btnCrearContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearContrato.UseVisualStyleBackColor = false;
            btnCrearContrato.Click += btnCrearContrato_Click;
            // 
            // btnEditarContrato
            // 
            btnEditarContrato.BackColor = Color.SteelBlue;
            btnEditarContrato.Dock = DockStyle.Fill;
            btnEditarContrato.FlatAppearance.BorderSize = 0;
            btnEditarContrato.FlatStyle = FlatStyle.Flat;
            btnEditarContrato.ForeColor = Color.WhiteSmoke;
            btnEditarContrato.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditarContrato.IconColor = Color.WhiteSmoke;
            btnEditarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarContrato.IconSize = 40;
            btnEditarContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarContrato.Location = new Point(3, 64);
            btnEditarContrato.Margin = new Padding(3, 4, 3, 4);
            btnEditarContrato.Name = "btnEditarContrato";
            btnEditarContrato.Size = new Size(160, 52);
            btnEditarContrato.TabIndex = 11;
            btnEditarContrato.Text = "Actualizar";
            btnEditarContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarContrato.UseVisualStyleBackColor = false;
            btnEditarContrato.Click += btnEditarContrato_Click;
            // 
            // btnBorrarContrato
            // 
            btnBorrarContrato.BackColor = Color.IndianRed;
            btnBorrarContrato.Dock = DockStyle.Fill;
            btnBorrarContrato.FlatAppearance.BorderSize = 0;
            btnBorrarContrato.FlatStyle = FlatStyle.Flat;
            btnBorrarContrato.ForeColor = Color.WhiteSmoke;
            btnBorrarContrato.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrarContrato.IconColor = Color.WhiteSmoke;
            btnBorrarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarContrato.IconSize = 35;
            btnBorrarContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrarContrato.Location = new Point(3, 124);
            btnBorrarContrato.Margin = new Padding(3, 4, 3, 4);
            btnBorrarContrato.Name = "btnBorrarContrato";
            btnBorrarContrato.Size = new Size(160, 52);
            btnBorrarContrato.TabIndex = 12;
            btnBorrarContrato.Text = "Eliminar";
            btnBorrarContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrarContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarContrato.UseVisualStyleBackColor = false;
            btnBorrarContrato.Click += btnBorrarContrato_Click;
            // 
            // dgvHistorialContratos
            // 
            dgvHistorialContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialContratos.Dock = DockStyle.Fill;
            dgvHistorialContratos.FilterAndSortEnabled = true;
            dgvHistorialContratos.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistorialContratos.Location = new Point(0, 255);
            dgvHistorialContratos.Margin = new Padding(3, 4, 3, 4);
            dgvHistorialContratos.MaxFilterButtonImageHeight = 23;
            dgvHistorialContratos.Name = "dgvHistorialContratos";
            dgvHistorialContratos.RightToLeft = RightToLeft.No;
            dgvHistorialContratos.RowHeadersWidth = 51;
            dgvHistorialContratos.Size = new Size(879, 260);
            dgvHistorialContratos.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistorialContratos.TabIndex = 22;
            dgvHistorialContratos.CellClick += dgvHistorialContratos_CellClick;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.SandyBrown;
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorico.ForeColor = Color.WhiteSmoke;
            btnHistorico.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            btnHistorico.IconColor = Color.WhiteSmoke;
            btnHistorico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHistorico.IconSize = 30;
            btnHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorico.Location = new Point(12, 208);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Padding = new Padding(12, 0, 0, 0);
            btnHistorico.Size = new Size(207, 40);
            btnHistorico.TabIndex = 27;
            btnHistorico.Text = "Guardar Historico";
            btnHistorico.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorico.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // F11ContratosA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 515);
            Controls.Add(dgvHistorialContratos);
            Controls.Add(panel3);
            Name = "F11ContratosA";
            Text = "F11ContratosA";
            Load += F11ContratosA_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtHorasJornada).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialContratos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Zuby.ADGV.AdvancedDataGridView dgvHistorialContratos;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnCrearContrato;
        private FontAwesome.Sharp.IconButton btnEditarContrato;
        private FontAwesome.Sharp.IconButton btnBorrarContrato;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label15;
        private DateTimePicker dtpFechaFin;
        private Label label10;
        private NumericUpDown txtHorasJornada;
        private Label label9;
        private DateTimePicker dtpFechaInicio;
        private Label label12;
        private Label label14;
        private ComboBox cbTipoContrato;
        private TextBox txtIdContrato;
        private Label label13;
        private Label label11;
        private ComboBox cbEmpleado;
        private ComboBox cbEstadoContrato;
        private TextBox txtSalario;
        private TextBox txtBuscarContrato;
        private FontAwesome.Sharp.IconButton btnBuscarContrato;
        private FontAwesome.Sharp.IconButton btnHistorico;
    }
}