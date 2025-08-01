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
            label1 = new Label();
            limpiarBtn = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            descripcionLb = new Label();
            tipoLb = new Label();
            idBoniLb = new Label();
            descripcionTxt = new TextBox();
            idBoniTxt = new TextBox();
            fechaLb = new Label();
            montoLb = new Label();
            idEmpleadoLb = new Label();
            fechaIngresoDtp = new DateTimePicker();
            montoTxt = new TextBox();
            empleCb = new ComboBox();
            nombreEmpleadoLb = new Label();
            empleLb = new Label();
            tipoCb = new ComboBox();
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
            bonificacionesDgv.Dock = DockStyle.Fill;
            bonificacionesDgv.Location = new Point(0, 237);
            bonificacionesDgv.Margin = new Padding(3, 2, 3, 2);
            bonificacionesDgv.Name = "bonificacionesDgv";
            bonificacionesDgv.RowHeadersWidth = 51;
            bonificacionesDgv.Size = new Size(1283, 248);
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(limpiarBtn);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1283, 237);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 22;
            label1.Text = "REGISTRO DE BONIFICACIONES";
            // 
            // limpiarBtn
            // 
            limpiarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            limpiarBtn.IconColor = Color.Black;
            limpiarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiarBtn.Location = new Point(388, 173);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(descripcionLb, 0, 3);
            tableLayoutPanel1.Controls.Add(tipoLb, 0, 2);
            tableLayoutPanel1.Controls.Add(idBoniLb, 0, 1);
            tableLayoutPanel1.Controls.Add(descripcionTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(idBoniTxt, 1, 1);
            tableLayoutPanel1.Controls.Add(fechaLb, 2, 3);
            tableLayoutPanel1.Controls.Add(montoLb, 2, 2);
            tableLayoutPanel1.Controls.Add(idEmpleadoLb, 2, 1);
            tableLayoutPanel1.Controls.Add(fechaIngresoDtp, 3, 3);
            tableLayoutPanel1.Controls.Add(montoTxt, 3, 2);
            tableLayoutPanel1.Controls.Add(empleCb, 3, 1);
            tableLayoutPanel1.Controls.Add(nombreEmpleadoLb, 2, 0);
            tableLayoutPanel1.Controls.Add(empleLb, 3, 0);
            tableLayoutPanel1.Controls.Add(tipoCb, 1, 2);
            tableLayoutPanel1.Location = new Point(21, 37);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(464, 118);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // descripcionLb
            // 
            descripcionLb.AutoSize = true;
            descripcionLb.Location = new Point(3, 87);
            descripcionLb.Name = "descripcionLb";
            descripcionLb.Size = new Size(69, 15);
            descripcionLb.TabIndex = 22;
            descripcionLb.Text = "Descripcion";
            // 
            // tipoLb
            // 
            tipoLb.AutoSize = true;
            tipoLb.Location = new Point(3, 58);
            tipoLb.Name = "tipoLb";
            tipoLb.Size = new Size(30, 15);
            tipoLb.TabIndex = 18;
            tipoLb.Text = "Tipo";
            // 
            // idBoniLb
            // 
            idBoniLb.AutoSize = true;
            idBoniLb.Location = new Point(3, 29);
            idBoniLb.Name = "idBoniLb";
            idBoniLb.Size = new Size(98, 15);
            idBoniLb.TabIndex = 17;
            idBoniLb.Text = "ID Bonificaciones";
            // 
            // descripcionTxt
            // 
            descripcionTxt.Location = new Point(119, 89);
            descripcionTxt.Margin = new Padding(3, 2, 3, 2);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(110, 23);
            descripcionTxt.TabIndex = 16;
            // 
            // idBoniTxt
            // 
            idBoniTxt.Location = new Point(119, 31);
            idBoniTxt.Margin = new Padding(3, 2, 3, 2);
            idBoniTxt.Name = "idBoniTxt";
            idBoniTxt.ReadOnly = true;
            idBoniTxt.Size = new Size(110, 23);
            idBoniTxt.TabIndex = 10;
            // 
            // fechaLb
            // 
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(235, 87);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(96, 15);
            fechaLb.TabIndex = 24;
            fechaLb.Text = "Fecha de ingreso";
            // 
            // montoLb
            // 
            montoLb.AutoSize = true;
            montoLb.Location = new Point(235, 58);
            montoLb.Name = "montoLb";
            montoLb.Size = new Size(43, 15);
            montoLb.TabIndex = 20;
            montoLb.Text = "Monto";
            // 
            // idEmpleadoLb
            // 
            idEmpleadoLb.AutoSize = true;
            idEmpleadoLb.Dock = DockStyle.Left;
            idEmpleadoLb.Location = new Point(235, 29);
            idEmpleadoLb.Name = "idEmpleadoLb";
            idEmpleadoLb.Size = new Size(74, 29);
            idEmpleadoLb.TabIndex = 7;
            idEmpleadoLb.Text = "ID Empleado";
            // 
            // fechaIngresoDtp
            // 
            fechaIngresoDtp.Format = DateTimePickerFormat.Short;
            fechaIngresoDtp.Location = new Point(351, 90);
            fechaIngresoDtp.Name = "fechaIngresoDtp";
            fechaIngresoDtp.Size = new Size(110, 23);
            fechaIngresoDtp.TabIndex = 26;
            fechaIngresoDtp.Value = new DateTime(2025, 7, 21, 20, 56, 31, 0);
            // 
            // montoTxt
            // 
            montoTxt.Location = new Point(351, 60);
            montoTxt.Margin = new Padding(3, 2, 3, 2);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(110, 23);
            montoTxt.TabIndex = 15;
            // 
            // empleCb
            // 
            empleCb.FormattingEnabled = true;
            empleCb.Location = new Point(351, 32);
            empleCb.Name = "empleCb";
            empleCb.Size = new Size(110, 23);
            empleCb.TabIndex = 27;
            empleCb.SelectedIndexChanged += empleCb_SelectedIndexChanged;
            // 
            // nombreEmpleadoLb
            // 
            nombreEmpleadoLb.AutoSize = true;
            nombreEmpleadoLb.Location = new Point(235, 0);
            nombreEmpleadoLb.Name = "nombreEmpleadoLb";
            nombreEmpleadoLb.Size = new Size(107, 15);
            nombreEmpleadoLb.TabIndex = 28;
            nombreEmpleadoLb.Text = "Nombre Empleado";
            // 
            // empleLb
            // 
            empleLb.AutoSize = true;
            empleLb.Location = new Point(351, 0);
            empleLb.Name = "empleLb";
            empleLb.Size = new Size(101, 15);
            empleLb.TabIndex = 29;
            empleLb.Text = "Elija un empleado";
            // 
            // tipoCb
            // 
            tipoCb.FormattingEnabled = true;
            tipoCb.Location = new Point(119, 61);
            tipoCb.Name = "tipoCb";
            tipoCb.Size = new Size(110, 23);
            tipoCb.TabIndex = 30;
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
            actualizarBtn.Location = new Point(21, 133);
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
            insertarBtn.Location = new Point(21, 107);
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
            btnBuscar.Location = new Point(21, 81);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            // 
            // F5Bonificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 485);
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
        private Label nombreEmpleadoLb;
        private Label empleLb;
        private Label label1;
        private ComboBox tipoCb;
    }
}