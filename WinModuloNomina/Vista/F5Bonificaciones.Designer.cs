namespace WinModuloNomina.Vista
{
    partial class F5Bonificaciones
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
            bonificacionesDgv = new DataGridView();
            idBonificacionesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresApellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonificacionesFormDTOBindingSource = new BindingSource(components);
            panel1 = new Panel();
            limpiarBtn = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            idBoniLb = new Label();
            idBoniTxt = new TextBox();
            tipoLb = new Label();
            tipoCb = new ComboBox();
            descripcionTxt = new TextBox();
            descripcionLb = new Label();
            idEmpleadoLb = new Label();
            empleCb = new ComboBox();
            montoLb = new Label();
            montoTxt = new TextBox();
            fechaLb = new Label();
            fechaIngresoDtp = new DateTimePicker();
            panel2 = new Panel();
            eliminarBtn = new FontAwesome.Sharp.IconButton();
            actualizarBtn = new FontAwesome.Sharp.IconButton();
            insertarBtn = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            empleLb = new Label();
            nombreEmpleadoLb = new Label();
            ((System.ComponentModel.ISupportInitialize)bonificacionesDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bonificacionesFormDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bonificacionesDgv
            // 
            bonificacionesDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bonificacionesDgv.AutoGenerateColumns = false;
            bonificacionesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bonificacionesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bonificacionesDgv.Columns.AddRange(new DataGridViewColumn[] { idBonificacionesDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, nombresApellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, montoDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn });
            bonificacionesDgv.DataSource = bonificacionesFormDTOBindingSource;
            bonificacionesDgv.Location = new Point(26, 322);
            bonificacionesDgv.Name = "bonificacionesDgv";
            bonificacionesDgv.RowHeadersWidth = 51;
            bonificacionesDgv.Size = new Size(907, 199);
            bonificacionesDgv.TabIndex = 18;
            bonificacionesDgv.CellClick += descuentosDgv_CellClick;
            // 
            // idBonificacionesDataGridViewTextBoxColumn
            // 
            idBonificacionesDataGridViewTextBoxColumn.DataPropertyName = "IdBonificaciones";
            idBonificacionesDataGridViewTextBoxColumn.HeaderText = "ID Bonificaciones";
            idBonificacionesDataGridViewTextBoxColumn.MinimumWidth = 6;
            idBonificacionesDataGridViewTextBoxColumn.Name = "idBonificacionesDataGridViewTextBoxColumn";
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "ID Empleado";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            // 
            // nombresApellidosDataGridViewTextBoxColumn
            // 
            nombresApellidosDataGridViewTextBoxColumn.DataPropertyName = "NombresApellidos";
            nombresApellidosDataGridViewTextBoxColumn.HeaderText = "Nombres y Apellidos";
            nombresApellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombresApellidosDataGridViewTextBoxColumn.Name = "nombresApellidosDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Bonificación";
            tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // bonificacionesFormDTOBindingSource
            // 
            bonificacionesFormDTOBindingSource.DataSource = typeof(Aplicacion.DTO.DTOs.BonificacionesFormDTO);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(limpiarBtn);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(empleLb);
            panel1.Controls.Add(nombreEmpleadoLb);
            panel1.Location = new Point(26, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 316);
            panel1.TabIndex = 17;
            // 
            // limpiarBtn
            // 
            limpiarBtn.Anchor = AnchorStyles.None;
            limpiarBtn.BackColor = Color.SandyBrown;
            limpiarBtn.FlatAppearance.BorderSize = 0;
            limpiarBtn.FlatStyle = FlatStyle.Flat;
            limpiarBtn.IconChar = FontAwesome.Sharp.IconChar.Broom;
            limpiarBtn.IconColor = Color.Black;
            limpiarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiarBtn.IconSize = 40;
            limpiarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarBtn.Location = new Point(291, 241);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Padding = new Padding(12, 0, 0, 0);
            limpiarBtn.Size = new Size(181, 51);
            limpiarBtn.TabIndex = 21;
            limpiarBtn.Text = "Limpiar datos";
            limpiarBtn.TextAlign = ContentAlignment.MiddleLeft;
            limpiarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            limpiarBtn.UseVisualStyleBackColor = false;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(idBoniLb, 0, 0);
            tableLayoutPanel1.Controls.Add(idBoniTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(tipoLb, 0, 1);
            tableLayoutPanel1.Controls.Add(tipoCb, 1, 1);
            tableLayoutPanel1.Controls.Add(descripcionTxt, 1, 2);
            tableLayoutPanel1.Controls.Add(descripcionLb, 0, 2);
            tableLayoutPanel1.Controls.Add(idEmpleadoLb, 2, 0);
            tableLayoutPanel1.Controls.Add(empleCb, 3, 0);
            tableLayoutPanel1.Controls.Add(montoLb, 2, 1);
            tableLayoutPanel1.Controls.Add(montoTxt, 3, 1);
            tableLayoutPanel1.Controls.Add(fechaLb, 2, 2);
            tableLayoutPanel1.Controls.Add(fechaIngresoDtp, 3, 2);
            tableLayoutPanel1.Location = new Point(60, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(610, 171);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // idBoniLb
            // 
            idBoniLb.Anchor = AnchorStyles.Left;
            idBoniLb.AutoSize = true;
            idBoniLb.Location = new Point(3, 18);
            idBoniLb.Name = "idBoniLb";
            idBoniLb.Size = new Size(124, 20);
            idBoniLb.TabIndex = 17;
            idBoniLb.Text = "ID Bonificaciones";
            // 
            // idBoniTxt
            // 
            idBoniTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idBoniTxt.Location = new Point(155, 15);
            idBoniTxt.Name = "idBoniTxt";
            idBoniTxt.ReadOnly = true;
            idBoniTxt.Size = new Size(146, 27);
            idBoniTxt.TabIndex = 10;
            // 
            // tipoLb
            // 
            tipoLb.Anchor = AnchorStyles.Left;
            tipoLb.AutoSize = true;
            tipoLb.Location = new Point(3, 75);
            tipoLb.Name = "tipoLb";
            tipoLb.Size = new Size(39, 20);
            tipoLb.TabIndex = 18;
            tipoLb.Text = "Tipo";
            // 
            // tipoCb
            // 
            tipoCb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tipoCb.FormattingEnabled = true;
            tipoCb.Location = new Point(155, 71);
            tipoCb.Margin = new Padding(3, 4, 3, 4);
            tipoCb.Name = "tipoCb";
            tipoCb.Size = new Size(146, 28);
            tipoCb.TabIndex = 30;
            // 
            // descripcionTxt
            // 
            descripcionTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descripcionTxt.Location = new Point(155, 129);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(146, 27);
            descripcionTxt.TabIndex = 16;
            // 
            // descripcionLb
            // 
            descripcionLb.Anchor = AnchorStyles.Left;
            descripcionLb.AutoSize = true;
            descripcionLb.Location = new Point(3, 132);
            descripcionLb.Name = "descripcionLb";
            descripcionLb.Size = new Size(87, 20);
            descripcionLb.TabIndex = 22;
            descripcionLb.Text = "Descripcion";
            // 
            // idEmpleadoLb
            // 
            idEmpleadoLb.Anchor = AnchorStyles.Left;
            idEmpleadoLb.AutoSize = true;
            idEmpleadoLb.Location = new Point(307, 18);
            idEmpleadoLb.Name = "idEmpleadoLb";
            idEmpleadoLb.Size = new Size(96, 20);
            idEmpleadoLb.TabIndex = 7;
            idEmpleadoLb.Text = "ID Empleado";
            // 
            // empleCb
            // 
            empleCb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            empleCb.FormattingEnabled = true;
            empleCb.Location = new Point(459, 14);
            empleCb.Margin = new Padding(3, 4, 3, 4);
            empleCb.Name = "empleCb";
            empleCb.Size = new Size(148, 28);
            empleCb.TabIndex = 27;
            empleCb.SelectedIndexChanged += empleCb_SelectedIndexChanged;
            // 
            // montoLb
            // 
            montoLb.Anchor = AnchorStyles.Left;
            montoLb.AutoSize = true;
            montoLb.Location = new Point(307, 75);
            montoLb.Name = "montoLb";
            montoLb.Size = new Size(53, 20);
            montoLb.TabIndex = 20;
            montoLb.Text = "Monto";
            // 
            // montoTxt
            // 
            montoTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            montoTxt.Location = new Point(459, 72);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(148, 27);
            montoTxt.TabIndex = 15;
            // 
            // fechaLb
            // 
            fechaLb.Anchor = AnchorStyles.Left;
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(307, 132);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(121, 20);
            fechaLb.TabIndex = 24;
            fechaLb.Text = "Fecha de ingreso";
            // 
            // fechaIngresoDtp
            // 
            fechaIngresoDtp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fechaIngresoDtp.Format = DateTimePickerFormat.Short;
            fechaIngresoDtp.Location = new Point(459, 129);
            fechaIngresoDtp.Margin = new Padding(3, 4, 3, 4);
            fechaIngresoDtp.Name = "fechaIngresoDtp";
            fechaIngresoDtp.Size = new Size(148, 27);
            fechaIngresoDtp.TabIndex = 26;
            fechaIngresoDtp.Value = new DateTime(2025, 7, 21, 20, 56, 31, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(eliminarBtn);
            panel2.Controls.Add(actualizarBtn);
            panel2.Controls.Add(insertarBtn);
            panel2.Controls.Add(btnBuscar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(736, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 316);
            panel2.TabIndex = 15;
            // 
            // eliminarBtn
            // 
            eliminarBtn.BackColor = Color.IndianRed;
            eliminarBtn.FlatAppearance.BorderSize = 0;
            eliminarBtn.FlatStyle = FlatStyle.Flat;
            eliminarBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            eliminarBtn.IconColor = Color.Black;
            eliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarBtn.IconSize = 40;
            eliminarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarBtn.Location = new Point(12, 229);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Padding = new Padding(12, 0, 0, 0);
            eliminarBtn.Size = new Size(147, 51);
            eliminarBtn.TabIndex = 20;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.TextAlign = ContentAlignment.MiddleLeft;
            eliminarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarBtn.UseVisualStyleBackColor = false;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // actualizarBtn
            // 
            actualizarBtn.BackColor = Color.SteelBlue;
            actualizarBtn.FlatAppearance.BorderSize = 0;
            actualizarBtn.FlatStyle = FlatStyle.Flat;
            actualizarBtn.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            actualizarBtn.IconColor = Color.Black;
            actualizarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            actualizarBtn.IconSize = 40;
            actualizarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            actualizarBtn.Location = new Point(12, 169);
            actualizarBtn.Name = "actualizarBtn";
            actualizarBtn.Padding = new Padding(12, 0, 0, 0);
            actualizarBtn.Size = new Size(147, 51);
            actualizarBtn.TabIndex = 19;
            actualizarBtn.Text = "Actualizar";
            actualizarBtn.TextAlign = ContentAlignment.MiddleLeft;
            actualizarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            actualizarBtn.UseVisualStyleBackColor = false;
            actualizarBtn.Click += actualizarBtn_Click;
            // 
            // insertarBtn
            // 
            insertarBtn.BackColor = Color.RoyalBlue;
            insertarBtn.FlatAppearance.BorderSize = 0;
            insertarBtn.FlatStyle = FlatStyle.Flat;
            insertarBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            insertarBtn.IconColor = Color.Black;
            insertarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            insertarBtn.IconSize = 40;
            insertarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            insertarBtn.Location = new Point(12, 112);
            insertarBtn.Name = "insertarBtn";
            insertarBtn.Padding = new Padding(12, 0, 0, 0);
            insertarBtn.Size = new Size(147, 51);
            insertarBtn.TabIndex = 17;
            insertarBtn.Text = "Insertar";
            insertarBtn.TextAlign = ContentAlignment.MiddleLeft;
            insertarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            insertarBtn.UseVisualStyleBackColor = false;
            insertarBtn.Click += insertarBtn_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Gainsboro;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 40;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(12, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(12, 0, 0, 0);
            btnBuscar.Size = new Size(147, 51);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Visible = false;
            // 
            // empleLb
            // 
            empleLb.Anchor = AnchorStyles.None;
            empleLb.AutoSize = true;
            empleLb.ForeColor = Color.Lime;
            empleLb.Location = new Point(404, 19);
            empleLb.Name = "empleLb";
            empleLb.Size = new Size(129, 20);
            empleLb.TabIndex = 29;
            empleLb.Text = "Elija un empleado";
            // 
            // nombreEmpleadoLb
            // 
            nombreEmpleadoLb.Anchor = AnchorStyles.None;
            nombreEmpleadoLb.AutoSize = true;
            nombreEmpleadoLb.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreEmpleadoLb.Location = new Point(252, 19);
            nombreEmpleadoLb.Name = "nombreEmpleadoLb";
            nombreEmpleadoLb.Size = new Size(148, 18);
            nombreEmpleadoLb.TabIndex = 28;
            nombreEmpleadoLb.Text = "Cedula empleado: ";
            // 
            // F5Bonificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(962, 551);
            Controls.Add(bonificacionesDgv);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F5Bonificaciones";
            Text = "F5Bonificaciones";
            Load += F5Bonificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)bonificacionesDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)bonificacionesFormDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void EmpleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView bonificacionesDgv;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton eliminarBtn;
        private FontAwesome.Sharp.IconButton actualizarBtn;
        private FontAwesome.Sharp.IconButton insertarBtn;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label idBoniLb;
        private TextBox descripcionTxt;
        private Label tipoLb;
        private Label descripcionLb;
        private TextBox idBoniTxt;
        private Label idEmpleadoLb;
        private ComboBox empleCb;
        private Label montoLb;
        private TextBox montoTxt;
        private Label fechaLb;
        private DateTimePicker fechaIngresoDtp;
        private BindingSource bonificacionesFormDTOBindingSource;
        private DataGridViewTextBoxColumn idBonificacionesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresApellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton limpiarBtn;
        private Label nombreEmpleadoLb;
        private Label empleLb;
        private ComboBox tipoCb;
    }
}