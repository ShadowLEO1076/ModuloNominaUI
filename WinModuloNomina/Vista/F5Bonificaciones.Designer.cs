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
            descripcionTxt = new TextBox();
            tipoTxt = new TextBox();
            tipoLb = new Label();
            descripcionLb = new Label();
            idBoniTxt = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)bonificacionesDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bonificacionesFormDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bonificacionesDgv
            // 
            bonificacionesDgv.AutoGenerateColumns = false;
            bonificacionesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bonificacionesDgv.Columns.AddRange(new DataGridViewColumn[] { idBonificacionesDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, nombresApellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, montoDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn });
            bonificacionesDgv.DataSource = bonificacionesFormDTOBindingSource;
            bonificacionesDgv.Dock = DockStyle.Top;
            bonificacionesDgv.Location = new Point(0, 146);
            bonificacionesDgv.Margin = new Padding(3, 2, 3, 2);
            bonificacionesDgv.Name = "bonificacionesDgv";
            bonificacionesDgv.RowHeadersWidth = 51;
            bonificacionesDgv.Size = new Size(800, 172);
            bonificacionesDgv.TabIndex = 18;
            bonificacionesDgv.CellClick += descuentosDgv_CellClick;
            // 
            // idBonificacionesDataGridViewTextBoxColumn
            // 
            idBonificacionesDataGridViewTextBoxColumn.DataPropertyName = "IdBonificaciones";
            idBonificacionesDataGridViewTextBoxColumn.HeaderText = "ID Bonificaciones";
            idBonificacionesDataGridViewTextBoxColumn.Name = "idBonificacionesDataGridViewTextBoxColumn";
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "ID Empleado";
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            // 
            // nombresApellidosDataGridViewTextBoxColumn
            // 
            nombresApellidosDataGridViewTextBoxColumn.DataPropertyName = "NombresApellidos";
            nombresApellidosDataGridViewTextBoxColumn.HeaderText = "Nombres y Apellidos";
            nombresApellidosDataGridViewTextBoxColumn.Name = "nombresApellidosDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Bonificación";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // bonificacionesFormDTOBindingSource
            // 
            bonificacionesFormDTOBindingSource.DataSource = typeof(Aplicacion.DTO.DTOs.BonificacionesFormDTO);
            // 
            // panel1
            // 
            panel1.Controls.Add(limpiarBtn);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 146);
            panel1.TabIndex = 17;
            // 
            // limpiarBtn
            // 
            limpiarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            limpiarBtn.IconColor = Color.Black;
            limpiarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiarBtn.Location = new Point(447, 106);
            limpiarBtn.Margin = new Padding(3, 2, 3, 2);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(94, 22);
            limpiarBtn.TabIndex = 21;
            limpiarBtn.Text = "Limpiar datos";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6511631F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.11628F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(idBoniLb, 0, 0);
            tableLayoutPanel1.Controls.Add(descripcionTxt, 1, 2);
            tableLayoutPanel1.Controls.Add(tipoTxt, 1, 1);
            tableLayoutPanel1.Controls.Add(tipoLb, 0, 1);
            tableLayoutPanel1.Controls.Add(descripcionLb, 0, 2);
            tableLayoutPanel1.Controls.Add(idBoniTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(idEmpleadoLb, 2, 0);
            tableLayoutPanel1.Controls.Add(empleCb, 3, 0);
            tableLayoutPanel1.Controls.Add(montoLb, 2, 1);
            tableLayoutPanel1.Controls.Add(montoTxt, 3, 1);
            tableLayoutPanel1.Controls.Add(fechaLb, 2, 2);
            tableLayoutPanel1.Controls.Add(fechaIngresoDtp, 3, 2);
            tableLayoutPanel1.Location = new Point(100, 15);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(441, 87);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // idBoniLb
            // 
            idBoniLb.AutoSize = true;
            idBoniLb.Location = new Point(3, 0);
            idBoniLb.Name = "idBoniLb";
            idBoniLb.Size = new Size(98, 15);
            idBoniLb.TabIndex = 17;
            idBoniLb.Text = "ID Bonificaciones";
            // 
            // descripcionTxt
            // 
            descripcionTxt.Location = new Point(111, 60);
            descripcionTxt.Margin = new Padding(3, 2, 3, 2);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(102, 23);
            descripcionTxt.TabIndex = 16;
            // 
            // tipoTxt
            // 
            tipoTxt.Location = new Point(111, 31);
            tipoTxt.Margin = new Padding(3, 2, 3, 2);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(102, 23);
            tipoTxt.TabIndex = 12;
            // 
            // tipoLb
            // 
            tipoLb.AutoSize = true;
            tipoLb.Location = new Point(3, 29);
            tipoLb.Name = "tipoLb";
            tipoLb.Size = new Size(30, 15);
            tipoLb.TabIndex = 18;
            tipoLb.Text = "Tipo";
            // 
            // descripcionLb
            // 
            descripcionLb.AutoSize = true;
            descripcionLb.Location = new Point(3, 58);
            descripcionLb.Name = "descripcionLb";
            descripcionLb.Size = new Size(69, 15);
            descripcionLb.TabIndex = 22;
            descripcionLb.Text = "Descripcion";
            // 
            // idBoniTxt
            // 
            idBoniTxt.Location = new Point(111, 2);
            idBoniTxt.Margin = new Padding(3, 2, 3, 2);
            idBoniTxt.Name = "idBoniTxt";
            idBoniTxt.ReadOnly = true;
            idBoniTxt.Size = new Size(102, 23);
            idBoniTxt.TabIndex = 10;
            // 
            // idEmpleadoLb
            // 
            idEmpleadoLb.AutoSize = true;
            idEmpleadoLb.Location = new Point(222, 0);
            idEmpleadoLb.Name = "idEmpleadoLb";
            idEmpleadoLb.Size = new Size(74, 15);
            idEmpleadoLb.TabIndex = 7;
            idEmpleadoLb.Text = "ID Empleado";
            // 
            // empleCb
            // 
            empleCb.FormattingEnabled = true;
            empleCb.Location = new Point(332, 3);
            empleCb.Name = "empleCb";
            empleCb.Size = new Size(103, 23);
            empleCb.TabIndex = 27;
            // 
            // montoLb
            // 
            montoLb.AutoSize = true;
            montoLb.Location = new Point(222, 29);
            montoLb.Name = "montoLb";
            montoLb.Size = new Size(43, 15);
            montoLb.TabIndex = 20;
            montoLb.Text = "Monto";
            // 
            // montoTxt
            // 
            montoTxt.Location = new Point(332, 31);
            montoTxt.Margin = new Padding(3, 2, 3, 2);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(103, 23);
            montoTxt.TabIndex = 15;
            // 
            // fechaLb
            // 
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(222, 58);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(96, 15);
            fechaLb.TabIndex = 24;
            fechaLb.Text = "Fecha de ingreso";
            // 
            // fechaIngresoDtp
            // 
            fechaIngresoDtp.Format = DateTimePickerFormat.Short;
            fechaIngresoDtp.Location = new Point(332, 61);
            fechaIngresoDtp.Name = "fechaIngresoDtp";
            fechaIngresoDtp.Size = new Size(103, 23);
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
            panel2.Location = new Point(676, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 146);
            panel2.TabIndex = 15;
            // 
            // eliminarBtn
            // 
            eliminarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            eliminarBtn.IconColor = Color.Black;
            eliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarBtn.Location = new Point(30, 106);
            eliminarBtn.Margin = new Padding(3, 2, 3, 2);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(82, 22);
            eliminarBtn.TabIndex = 20;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // actualizarBtn
            // 
            actualizarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            actualizarBtn.IconColor = Color.Black;
            actualizarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            actualizarBtn.Location = new Point(30, 80);
            actualizarBtn.Margin = new Padding(3, 2, 3, 2);
            actualizarBtn.Name = "actualizarBtn";
            actualizarBtn.Size = new Size(82, 22);
            actualizarBtn.TabIndex = 19;
            actualizarBtn.Text = "Actualizar";
            actualizarBtn.UseVisualStyleBackColor = true;
            actualizarBtn.Click += actualizarBtn_Click;
            // 
            // insertarBtn
            // 
            insertarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            insertarBtn.IconColor = Color.Black;
            insertarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            insertarBtn.Location = new Point(30, 54);
            insertarBtn.Margin = new Padding(3, 2, 3, 2);
            insertarBtn.Name = "insertarBtn";
            insertarBtn.Size = new Size(82, 22);
            insertarBtn.TabIndex = 17;
            insertarBtn.Text = "Insertar";
            insertarBtn.UseVisualStyleBackColor = true;
            insertarBtn.Click += insertarBtn_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(30, 28);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // F5Bonificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bonificacionesDgv);
            Controls.Add(panel1);
            Name = "F5Bonificaciones";
            Text = "F5Bonificaciones";
            Load += F5Bonificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)bonificacionesDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)bonificacionesFormDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox tipoTxt;
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
    }
}