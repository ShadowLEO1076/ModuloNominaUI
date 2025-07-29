namespace WinModuloNomina.Vista
{
    partial class F2Empleados
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
            TableLayoutPanel tablaEmpleados;
            fecIngresoDtp = new DateTimePicker();
            telfTxt = new TextBox();
            apellidosLb = new Label();
            fechaNacLb = new Label();
            nombresLb = new Label();
            correoLb = new Label();
            idPuestosLb = new Label();
            IdEmpleadoLb = new Label();
            idEmplTxt = new TextBox();
            correoTxt = new TextBox();
            nombresTxt = new TextBox();
            apellidosTxt = new TextBox();
            cedulaLb = new Label();
            cedulaTxt = new TextBox();
            telefonoLb = new Label();
            generoLb = new Label();
            fechaIngresoLb = new Label();
            estadoLb = new Label();
            puestosCb = new ComboBox();
            fechaNacDtp = new DateTimePicker();
            estadoCheckbox = new CheckBox();
            generoCb = new ComboBox();
            limpiarBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            txtBuscar = new TextBox();
            borrarBtn = new FontAwesome.Sharp.IconButton();
            buscarBtn = new FontAwesome.Sharp.IconButton();
            editarBtn = new FontAwesome.Sharp.IconButton();
            crearBtn = new FontAwesome.Sharp.IconButton();
            empleadosDgv = new DataGridView();
            empleadosBindingSource = new BindingSource(components);
            panel3 = new Panel();
            presentLb = new Label();
            tablaEmpleados = new TableLayoutPanel();
            tablaEmpleados.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empleadosDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadosBindingSource).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tablaEmpleados
            // 
            tablaEmpleados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tablaEmpleados.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tablaEmpleados.ColumnCount = 6;
            tablaEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2203388F));
            tablaEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5526733F));
            tablaEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.7730961F));
            tablaEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.52188F));
            tablaEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tablaEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tablaEmpleados.Controls.Add(fecIngresoDtp, 5, 1);
            tablaEmpleados.Controls.Add(telfTxt, 5, 0);
            tablaEmpleados.Controls.Add(apellidosLb, 0, 3);
            tablaEmpleados.Controls.Add(fechaNacLb, 2, 2);
            tablaEmpleados.Controls.Add(nombresLb, 0, 2);
            tablaEmpleados.Controls.Add(correoLb, 2, 1);
            tablaEmpleados.Controls.Add(idPuestosLb, 0, 1);
            tablaEmpleados.Controls.Add(IdEmpleadoLb, 0, 0);
            tablaEmpleados.Controls.Add(idEmplTxt, 1, 0);
            tablaEmpleados.Controls.Add(correoTxt, 3, 1);
            tablaEmpleados.Controls.Add(nombresTxt, 1, 2);
            tablaEmpleados.Controls.Add(apellidosTxt, 1, 3);
            tablaEmpleados.Controls.Add(cedulaLb, 2, 0);
            tablaEmpleados.Controls.Add(cedulaTxt, 3, 0);
            tablaEmpleados.Controls.Add(telefonoLb, 4, 0);
            tablaEmpleados.Controls.Add(generoLb, 2, 3);
            tablaEmpleados.Controls.Add(fechaIngresoLb, 4, 1);
            tablaEmpleados.Controls.Add(estadoLb, 4, 2);
            tablaEmpleados.Controls.Add(puestosCb, 1, 1);
            tablaEmpleados.Controls.Add(fechaNacDtp, 3, 2);
            tablaEmpleados.Controls.Add(estadoCheckbox, 5, 2);
            tablaEmpleados.Controls.Add(generoCb, 3, 3);
            tablaEmpleados.Controls.Add(limpiarBtn, 5, 3);
            tablaEmpleados.Location = new Point(14, 33);
            tablaEmpleados.Name = "tablaEmpleados";
            tablaEmpleados.RowCount = 4;
            tablaEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tablaEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tablaEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tablaEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tablaEmpleados.Size = new Size(910, 188);
            tablaEmpleados.TabIndex = 3;
            // 
            // fecIngresoDtp
            // 
            fecIngresoDtp.Format = DateTimePickerFormat.Short;
            fecIngresoDtp.Location = new Point(780, 51);
            fecIngresoDtp.Margin = new Padding(3, 4, 3, 4);
            fecIngresoDtp.Name = "fecIngresoDtp";
            fecIngresoDtp.Size = new Size(109, 27);
            fecIngresoDtp.TabIndex = 31;
            // 
            // telfTxt
            // 
            telfTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            telfTxt.Location = new Point(780, 10);
            telfTxt.Name = "telfTxt";
            telfTxt.Size = new Size(127, 27);
            telfTxt.TabIndex = 29;
            // 
            // apellidosLb
            // 
            apellidosLb.Anchor = AnchorStyles.Left;
            apellidosLb.AutoSize = true;
            apellidosLb.Location = new Point(3, 154);
            apellidosLb.Name = "apellidosLb";
            apellidosLb.Size = new Size(72, 20);
            apellidosLb.TabIndex = 22;
            apellidosLb.Text = "Apellidos";
            // 
            // fechaNacLb
            // 
            fechaNacLb.Anchor = AnchorStyles.Left;
            fechaNacLb.AutoSize = true;
            fechaNacLb.Location = new Point(303, 97);
            fechaNacLb.Name = "fechaNacLb";
            fechaNacLb.Size = new Size(86, 40);
            fechaNacLb.TabIndex = 21;
            fechaNacLb.Text = "Fecha Nacimiento";
            // 
            // nombresLb
            // 
            nombresLb.Anchor = AnchorStyles.Left;
            nombresLb.AutoSize = true;
            nombresLb.Location = new Point(3, 107);
            nombresLb.Name = "nombresLb";
            nombresLb.Size = new Size(70, 20);
            nombresLb.TabIndex = 20;
            nombresLb.Text = "Nombres";
            // 
            // correoLb
            // 
            correoLb.Anchor = AnchorStyles.Left;
            correoLb.AutoSize = true;
            correoLb.Location = new Point(303, 60);
            correoLb.Name = "correoLb";
            correoLb.Size = new Size(54, 20);
            correoLb.TabIndex = 19;
            correoLb.Text = "Correo";
            // 
            // idPuestosLb
            // 
            idPuestosLb.Anchor = AnchorStyles.Left;
            idPuestosLb.AutoSize = true;
            idPuestosLb.Location = new Point(3, 60);
            idPuestosLb.Name = "idPuestosLb";
            idPuestosLb.Size = new Size(59, 20);
            idPuestosLb.TabIndex = 18;
            idPuestosLb.Text = "Puestos";
            // 
            // IdEmpleadoLb
            // 
            IdEmpleadoLb.Anchor = AnchorStyles.Left;
            IdEmpleadoLb.AutoSize = true;
            IdEmpleadoLb.Location = new Point(3, 13);
            IdEmpleadoLb.Name = "IdEmpleadoLb";
            IdEmpleadoLb.Size = new Size(94, 20);
            IdEmpleadoLb.TabIndex = 7;
            IdEmpleadoLb.Text = "Id Empleado";
            // 
            // idEmplTxt
            // 
            idEmplTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idEmplTxt.Location = new Point(122, 10);
            idEmplTxt.Name = "idEmplTxt";
            idEmplTxt.ReadOnly = true;
            idEmplTxt.Size = new Size(175, 27);
            idEmplTxt.TabIndex = 7;
            // 
            // correoTxt
            // 
            correoTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            correoTxt.Location = new Point(433, 57);
            correoTxt.Name = "correoTxt";
            correoTxt.Size = new Size(221, 27);
            correoTxt.TabIndex = 13;
            // 
            // nombresTxt
            // 
            nombresTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nombresTxt.Location = new Point(122, 104);
            nombresTxt.Name = "nombresTxt";
            nombresTxt.Size = new Size(175, 27);
            nombresTxt.TabIndex = 15;
            // 
            // apellidosTxt
            // 
            apellidosTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            apellidosTxt.Location = new Point(122, 151);
            apellidosTxt.Name = "apellidosTxt";
            apellidosTxt.Size = new Size(175, 27);
            apellidosTxt.TabIndex = 16;
            // 
            // cedulaLb
            // 
            cedulaLb.Anchor = AnchorStyles.Left;
            cedulaLb.AutoSize = true;
            cedulaLb.Location = new Point(303, 13);
            cedulaLb.Name = "cedulaLb";
            cedulaLb.Size = new Size(55, 20);
            cedulaLb.TabIndex = 17;
            cedulaLb.Text = "Cedula";
            // 
            // cedulaTxt
            // 
            cedulaTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cedulaTxt.Location = new Point(433, 10);
            cedulaTxt.Name = "cedulaTxt";
            cedulaTxt.Size = new Size(221, 27);
            cedulaTxt.TabIndex = 10;
            // 
            // telefonoLb
            // 
            telefonoLb.Anchor = AnchorStyles.Left;
            telefonoLb.AutoSize = true;
            telefonoLb.Location = new Point(660, 13);
            telefonoLb.Name = "telefonoLb";
            telefonoLb.Size = new Size(67, 20);
            telefonoLb.TabIndex = 24;
            telefonoLb.Text = "Teléfono";
            // 
            // generoLb
            // 
            generoLb.Anchor = AnchorStyles.Left;
            generoLb.AutoSize = true;
            generoLb.Location = new Point(303, 154);
            generoLb.Name = "generoLb";
            generoLb.Size = new Size(57, 20);
            generoLb.TabIndex = 23;
            generoLb.Text = "Género";
            // 
            // fechaIngresoLb
            // 
            fechaIngresoLb.Anchor = AnchorStyles.Left;
            fechaIngresoLb.AutoSize = true;
            fechaIngresoLb.Location = new Point(660, 60);
            fechaIngresoLb.Name = "fechaIngresoLb";
            fechaIngresoLb.Size = new Size(100, 20);
            fechaIngresoLb.TabIndex = 25;
            fechaIngresoLb.Text = "Fecha Ingreso";
            // 
            // estadoLb
            // 
            estadoLb.Anchor = AnchorStyles.Left;
            estadoLb.AutoSize = true;
            estadoLb.Location = new Point(660, 107);
            estadoLb.Name = "estadoLb";
            estadoLb.Size = new Size(54, 20);
            estadoLb.TabIndex = 26;
            estadoLb.Text = "Estado";
            // 
            // puestosCb
            // 
            puestosCb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            puestosCb.FormattingEnabled = true;
            puestosCb.Location = new Point(122, 56);
            puestosCb.Margin = new Padding(3, 4, 3, 4);
            puestosCb.Name = "puestosCb";
            puestosCb.Size = new Size(175, 28);
            puestosCb.TabIndex = 27;
            // 
            // fechaNacDtp
            // 
            fechaNacDtp.Format = DateTimePickerFormat.Short;
            fechaNacDtp.Location = new Point(433, 98);
            fechaNacDtp.Margin = new Padding(3, 4, 3, 4);
            fechaNacDtp.Name = "fechaNacDtp";
            fechaNacDtp.Size = new Size(221, 27);
            fechaNacDtp.TabIndex = 28;
            // 
            // estadoCheckbox
            // 
            estadoCheckbox.AutoSize = true;
            estadoCheckbox.Location = new Point(780, 98);
            estadoCheckbox.Margin = new Padding(3, 4, 3, 4);
            estadoCheckbox.Name = "estadoCheckbox";
            estadoCheckbox.Size = new Size(18, 17);
            estadoCheckbox.TabIndex = 32;
            estadoCheckbox.UseVisualStyleBackColor = true;
            // 
            // generoCb
            // 
            generoCb.FormattingEnabled = true;
            generoCb.Location = new Point(433, 145);
            generoCb.Margin = new Padding(3, 4, 3, 4);
            generoCb.Name = "generoCb";
            generoCb.Size = new Size(221, 28);
            generoCb.TabIndex = 33;
            // 
            // limpiarBtn
            // 
            limpiarBtn.Location = new Point(780, 145);
            limpiarBtn.Margin = new Padding(3, 4, 3, 4);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(125, 31);
            limpiarBtn.TabIndex = 34;
            limpiarBtn.Text = "Limpiar datos";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tablaEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 234);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(borrarBtn);
            panel2.Controls.Add(editarBtn);
            panel2.Controls.Add(buscarBtn);
            panel2.Controls.Add(crearBtn);
            panel2.Location = new Point(933, 33);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 188);
            panel2.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(4, 2);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Cedula a buscar";
            txtBuscar.Size = new Size(130, 27);
            txtBuscar.TabIndex = 32;
            // 
            // borrarBtn
            // 
            borrarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            borrarBtn.IconColor = Color.Black;
            borrarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            borrarBtn.Location = new Point(14, 152);
            borrarBtn.Margin = new Padding(3, 2, 3, 2);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(111, 33);
            borrarBtn.TabIndex = 12;
            borrarBtn.Text = "Borrar";
            borrarBtn.UseVisualStyleBackColor = true;
            borrarBtn.Visible = false;
            // 
            // buscarBtn
            // 
            buscarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            buscarBtn.IconColor = Color.Black;
            buscarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buscarBtn.Location = new Point(13, 40);
            buscarBtn.Margin = new Padding(3, 2, 3, 2);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(112, 34);
            buscarBtn.TabIndex = 10;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // editarBtn
            // 
            editarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            editarBtn.IconColor = Color.Black;
            editarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarBtn.Location = new Point(14, 115);
            editarBtn.Margin = new Padding(3, 2, 3, 2);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(111, 33);
            editarBtn.TabIndex = 11;
            editarBtn.Text = "Editar";
            editarBtn.UseVisualStyleBackColor = true;
            editarBtn.Click += editarBtn_Click;
            // 
            // crearBtn
            // 
            crearBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            crearBtn.IconColor = Color.Black;
            crearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            crearBtn.Location = new Point(13, 77);
            crearBtn.Margin = new Padding(3, 2, 3, 2);
            crearBtn.Name = "crearBtn";
            crearBtn.Size = new Size(111, 34);
            crearBtn.TabIndex = 9;
            crearBtn.Text = "Insertar";
            crearBtn.UseVisualStyleBackColor = true;
            crearBtn.Click += crearBtn_Click;
            // 
            // empleadosDgv
            // 
            empleadosDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empleadosDgv.Dock = DockStyle.Fill;
            empleadosDgv.Location = new Point(0, 278);
            empleadosDgv.Margin = new Padding(3, 2, 3, 2);
            empleadosDgv.Name = "empleadosDgv";
            empleadosDgv.RowHeadersWidth = 51;
            empleadosDgv.Size = new Size(1081, 254);
            empleadosDgv.TabIndex = 8;
            empleadosDgv.CellClick += empleadosDgv_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(presentLb);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(1081, 44);
            panel3.TabIndex = 9;
            // 
            // presentLb
            // 
            presentLb.AutoSize = true;
            presentLb.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            presentLb.ForeColor = Color.White;
            presentLb.Location = new Point(486, 13);
            presentLb.Name = "presentLb";
            presentLb.Size = new Size(110, 18);
            presentLb.TabIndex = 10;
            presentLb.Text = "EMPLEADOS";
            presentLb.TextAlign = ContentAlignment.TopCenter;
            // 
            // F2Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 532);
            Controls.Add(empleadosDgv);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "F2Empleados";
            Text = "F2Empleados";
            Load += F2Empleados_Load;
            tablaEmpleados.ResumeLayout(false);
            tablaEmpleados.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)empleadosDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadosBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tablaEmpleados;
        private Label generoLb;
        private Label apellidosLb;
        private Label fechaNacLb;
        private Label nombresLb;
        private Label correoLb;
        private Label idPuestosLb;
        private Label cedulaLb;
        private Label IdEmpleadoLb;
        private TextBox apellidosTxt;
        private TextBox cedulaTxt;
        private TextBox idEmplTxt;
        private TextBox nombresTxt;
        private TextBox textBox8;
        private TextBox correoTxt;
        private Panel panel2;
        private DataGridView empleadosDgv;
        private FontAwesome.Sharp.IconButton borrarBtn;
        private FontAwesome.Sharp.IconButton editarBtn;
        private FontAwesome.Sharp.IconButton buscarBtn;
        private FontAwesome.Sharp.IconButton crearBtn;
        private Panel panel3;
        private Label presentLb;
        private Label telefonoLb;
        private Label fechaIngresoLb;
        private Label estadoLb;
        private ComboBox puestosCb;
        private DateTimePicker fechaNacDtp;
        private TextBox telfTxt;
        private DateTimePicker fecIngresoDtp;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puestoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private BindingSource empleadosBindingSource;
        private CheckBox estadoCheckbox;
        private ComboBox generoCb;
        private Button limpiarBtn;
    }
}