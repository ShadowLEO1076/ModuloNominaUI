namespace WinModuloNomina.Vista
{
    partial class F12TipoC
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
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCrearTipoC = new FontAwesome.Sharp.IconButton();
            btnEditarTipoC = new FontAwesome.Sharp.IconButton();
            btnEliminarCT = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtHorasLaborales = new TextBox();
            label1 = new Label();
            txtIdTipoContrato = new TextBox();
            txtNombreTipo = new TextBox();
            label6 = new Label();
            label3 = new Label();
            cbJornadaTipo = new ComboBox();
            label2 = new Label();
            dgvTipoContrato = new DataGridView();
            idTipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasJornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contratosTipoBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoContrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 193);
            panel2.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btnCrearTipoC);
            flowLayoutPanel1.Controls.Add(btnEditarTipoC);
            flowLayoutPanel1.Controls.Add(btnEliminarCT);
            flowLayoutPanel1.Location = new Point(635, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 182);
            flowLayoutPanel1.TabIndex = 34;
            // 
            // btnCrearTipoC
            // 
            btnCrearTipoC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCrearTipoC.BackColor = Color.RoyalBlue;
            btnCrearTipoC.FlatAppearance.BorderSize = 0;
            btnCrearTipoC.FlatStyle = FlatStyle.Flat;
            btnCrearTipoC.ForeColor = Color.WhiteSmoke;
            btnCrearTipoC.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCrearTipoC.IconColor = Color.WhiteSmoke;
            btnCrearTipoC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearTipoC.IconSize = 40;
            btnCrearTipoC.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearTipoC.Location = new Point(3, 4);
            btnCrearTipoC.Margin = new Padding(3, 4, 3, 4);
            btnCrearTipoC.Name = "btnCrearTipoC";
            btnCrearTipoC.Padding = new Padding(12, 0, 0, 0);
            btnCrearTipoC.Size = new Size(181, 52);
            btnCrearTipoC.TabIndex = 30;
            btnCrearTipoC.Text = "Crear";
            btnCrearTipoC.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearTipoC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearTipoC.UseVisualStyleBackColor = false;
            btnCrearTipoC.Click += btnCrearTipoC_Click;
            // 
            // btnEditarTipoC
            // 
            btnEditarTipoC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEditarTipoC.BackColor = Color.SteelBlue;
            btnEditarTipoC.FlatAppearance.BorderSize = 0;
            btnEditarTipoC.FlatStyle = FlatStyle.Flat;
            btnEditarTipoC.ForeColor = Color.WhiteSmoke;
            btnEditarTipoC.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditarTipoC.IconColor = Color.WhiteSmoke;
            btnEditarTipoC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarTipoC.IconSize = 40;
            btnEditarTipoC.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarTipoC.Location = new Point(3, 64);
            btnEditarTipoC.Margin = new Padding(3, 4, 3, 4);
            btnEditarTipoC.Name = "btnEditarTipoC";
            btnEditarTipoC.Padding = new Padding(12, 0, 0, 0);
            btnEditarTipoC.Size = new Size(181, 52);
            btnEditarTipoC.TabIndex = 32;
            btnEditarTipoC.Text = "Editar";
            btnEditarTipoC.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarTipoC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarTipoC.UseVisualStyleBackColor = false;
            btnEditarTipoC.Click += btnEditarTipoC_Click;
            // 
            // btnEliminarCT
            // 
            btnEliminarCT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarCT.BackColor = Color.IndianRed;
            btnEliminarCT.FlatAppearance.BorderSize = 0;
            btnEliminarCT.FlatStyle = FlatStyle.Flat;
            btnEliminarCT.ForeColor = Color.WhiteSmoke;
            btnEliminarCT.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarCT.IconColor = Color.WhiteSmoke;
            btnEliminarCT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarCT.IconSize = 35;
            btnEliminarCT.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarCT.Location = new Point(3, 124);
            btnEliminarCT.Margin = new Padding(3, 4, 3, 4);
            btnEliminarCT.Name = "btnEliminarCT";
            btnEliminarCT.Padding = new Padding(12, 0, 0, 0);
            btnEliminarCT.Size = new Size(181, 52);
            btnEliminarCT.TabIndex = 33;
            btnEliminarCT.Text = "Eliminar";
            btnEliminarCT.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarCT.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarCT.UseVisualStyleBackColor = false;
            btnEliminarCT.Click += btnEliminarCT_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(txtHorasLaborales, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdTipoContrato, 1, 0);
            tableLayoutPanel1.Controls.Add(txtNombreTipo, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(cbJornadaTipo, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(554, 160);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // txtHorasLaborales
            // 
            txtHorasLaborales.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHorasLaborales.Location = new Point(167, 126);
            txtHorasLaborales.Margin = new Padding(3, 4, 3, 4);
            txtHorasLaborales.Name = "txtHorasLaborales";
            txtHorasLaborales.Size = new Size(323, 27);
            txtHorasLaborales.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(134, 10);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 23;
            label1.Text = "ID:";
            // 
            // txtIdTipoContrato
            // 
            txtIdTipoContrato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdTipoContrato.Location = new Point(167, 6);
            txtIdTipoContrato.Margin = new Padding(3, 4, 3, 4);
            txtIdTipoContrato.Name = "txtIdTipoContrato";
            txtIdTipoContrato.Size = new Size(323, 27);
            txtIdTipoContrato.TabIndex = 19;
            // 
            // txtNombreTipo
            // 
            txtNombreTipo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreTipo.Location = new Point(167, 86);
            txtNombreTipo.Margin = new Padding(3, 4, 3, 4);
            txtNombreTipo.Name = "txtNombreTipo";
            txtNombreTipo.Size = new Size(323, 27);
            txtNombreTipo.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(71, 90);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 19;
            label6.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(97, 50);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 18;
            label3.Text = "Jornada:";
            // 
            // cbJornadaTipo
            // 
            cbJornadaTipo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbJornadaTipo.FormattingEnabled = true;
            cbJornadaTipo.Location = new Point(167, 46);
            cbJornadaTipo.Margin = new Padding(3, 4, 3, 4);
            cbJornadaTipo.Name = "cbJornadaTipo";
            cbJornadaTipo.Size = new Size(323, 28);
            cbJornadaTipo.TabIndex = 22;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(42, 130);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 24;
            label2.Text = "Horas Laborales:";
            // 
            // dgvTipoContrato
            // 
            dgvTipoContrato.AutoGenerateColumns = false;
            dgvTipoContrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoContrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoContrato.Columns.AddRange(new DataGridViewColumn[] { idTipoDataGridViewTextBoxColumn, jornadaDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, horasJornadaDataGridViewTextBoxColumn });
            dgvTipoContrato.DataSource = contratosTipoBindingSource;
            dgvTipoContrato.Dock = DockStyle.Fill;
            dgvTipoContrato.Location = new Point(0, 193);
            dgvTipoContrato.Margin = new Padding(3, 4, 3, 4);
            dgvTipoContrato.Name = "dgvTipoContrato";
            dgvTipoContrato.RowHeadersWidth = 51;
            dgvTipoContrato.Size = new Size(876, 257);
            dgvTipoContrato.TabIndex = 27;
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
            // horasJornadaDataGridViewTextBoxColumn
            // 
            horasJornadaDataGridViewTextBoxColumn.DataPropertyName = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.HeaderText = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            horasJornadaDataGridViewTextBoxColumn.Name = "horasJornadaDataGridViewTextBoxColumn";
            // 
            // contratosTipoBindingSource
            // 
            contratosTipoBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.ContratosTipo);
            // 
            // F12TipoC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(876, 450);
            Controls.Add(dgvTipoContrato);
            Controls.Add(panel2);
            Name = "F12TipoC";
            Text = "F12TipoC";
            Load += F12TipoC_Load;
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoContrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnEliminarCT;
        private FontAwesome.Sharp.IconButton btnCrearTipoC;
        private FontAwesome.Sharp.IconButton btnEditarTipoC;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private ComboBox cbJornadaTipo;
        private Label label6;
        private TextBox txtNombreTipo;
        private TextBox txtIdTipoContrato;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox txtHorasLaborales;
        private DataGridViewTextBoxColumn horasLaboralesDataGridViewTextBoxColumn;
        private DataGridView dgvTipoContrato;
        private DataGridViewTextBoxColumn idTipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jornadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasJornadaDataGridViewTextBoxColumn;
        private BindingSource contratosTipoBindingSource;
    }
}