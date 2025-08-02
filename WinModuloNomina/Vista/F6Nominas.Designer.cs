using WinModuloNomina.Modelo;

namespace WinModuloNomina.Vista
{
    partial class F6Nominas
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
            empleNomLb1 = new Label();
            empleNombrePresen = new Label();
            nominasIngeManuLb = new Label();
            limpiarBtn = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            nominaLb = new Label();
            idNomTxt = new TextBox();
            anioLb = new Label();
            mesLb = new Label();
            idEmpleadoLb = new Label();
            salManTxt = new TextBox();
            boniManTxt = new TextBox();
            salarioLb = new Label();
            bonificacionesLb = new Label();
            fecEmisionLb = new Label();
            descuentosLb = new Label();
            descManTxt = new TextBox();
            empleAutoCb = new ComboBox();
            mesAutoCb = new ComboBox();
            anioNud = new NumericUpDown();
            fecEmiDtp = new DateTimePicker();
            panel2 = new Panel();
            eliminarBtn = new FontAwesome.Sharp.IconButton();
            insertarBtn = new FontAwesome.Sharp.IconButton();
            actualizarBtn = new FontAwesome.Sharp.IconButton();
            nominasActivasDgv = new DataGridView();
            idNominaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresApellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasJornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonificacionesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descuentosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioNetoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nominasDTOBindingSource = new BindingSource(components);
            panel3 = new Panel();
            presentLb = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anioNud).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nominasActivasDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(nominasIngeManuLb);
            panel1.Controls.Add(limpiarBtn);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 237);
            panel1.TabIndex = 2;
            // 
            // empleNomLb1
            // 
            empleNomLb1.AutoSize = true;
            empleNomLb1.Location = new Point(182, 0);
            empleNomLb1.Name = "empleNomLb1";
            empleNomLb1.Size = new Size(0, 20);
            empleNomLb1.TabIndex = 14;
            // 
            // empleNombrePresen
            // 
            empleNombrePresen.AutoSize = true;
            empleNombrePresen.Location = new Point(3, 0);
            empleNombrePresen.Name = "empleNombrePresen";
            empleNombrePresen.Size = new Size(136, 20);
            empleNombrePresen.TabIndex = 13;
            empleNombrePresen.Text = "Nombre Empleado";
            // 
            // nominasIngeManuLb
            // 
            nominasIngeManuLb.AutoSize = true;
            nominasIngeManuLb.Location = new Point(14, 8);
            nominasIngeManuLb.Name = "nominasIngeManuLb";
            nominasIngeManuLb.Size = new Size(142, 20);
            nominasIngeManuLb.TabIndex = 11;
            nominasIngeManuLb.Text = "DATOS DE NOMINA";
            nominasIngeManuLb.TextAlign = ContentAlignment.TopCenter;
            // 
            // limpiarBtn
            // 
            limpiarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            limpiarBtn.IconColor = Color.Black;
            limpiarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiarBtn.Location = new Point(848, 168);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(186, 35);
            limpiarBtn.TabIndex = 12;
            limpiarBtn.Text = "Limpiar datos";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(nominaLb, 0, 0);
            tableLayoutPanel1.Controls.Add(idNomTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(anioLb, 0, 1);
            tableLayoutPanel1.Controls.Add(mesLb, 2, 1);
            tableLayoutPanel1.Controls.Add(idEmpleadoLb, 2, 0);
            tableLayoutPanel1.Controls.Add(salManTxt, 1, 2);
            tableLayoutPanel1.Controls.Add(boniManTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(salarioLb, 0, 2);
            tableLayoutPanel1.Controls.Add(bonificacionesLb, 0, 3);
            tableLayoutPanel1.Controls.Add(fecEmisionLb, 2, 2);
            tableLayoutPanel1.Controls.Add(descuentosLb, 2, 3);
            tableLayoutPanel1.Controls.Add(descManTxt, 3, 3);
            tableLayoutPanel1.Controls.Add(empleAutoCb, 3, 0);
            tableLayoutPanel1.Controls.Add(mesAutoCb, 3, 1);
            tableLayoutPanel1.Controls.Add(anioNud, 1, 1);
            tableLayoutPanel1.Controls.Add(fecEmiDtp, 3, 2);
            tableLayoutPanel1.Location = new Point(75, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(698, 140);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // nominaLb
            // 
            nominaLb.AutoSize = true;
            nominaLb.Location = new Point(3, 0);
            nominaLb.Name = "nominaLb";
            nominaLb.Size = new Size(81, 20);
            nominaLb.TabIndex = 7;
            nominaLb.Text = "ID Nomina";
            // 
            // idNomTxt
            // 
            idNomTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idNomTxt.Location = new Point(114, 4);
            idNomTxt.Name = "idNomTxt";
            idNomTxt.ReadOnly = true;
            idNomTxt.Size = new Size(140, 27);
            idNomTxt.TabIndex = 7;
            // 
            // anioLb
            // 
            anioLb.AutoSize = true;
            anioLb.Location = new Point(3, 36);
            anioLb.Name = "anioLb";
            anioLb.Size = new Size(36, 20);
            anioLb.TabIndex = 22;
            anioLb.Text = "Año";
            // 
            // mesLb
            // 
            mesLb.AutoSize = true;
            mesLb.Location = new Point(260, 36);
            mesLb.Name = "mesLb";
            mesLb.Size = new Size(36, 20);
            mesLb.TabIndex = 20;
            mesLb.Text = "Mes";
            // 
            // idEmpleadoLb
            // 
            idEmpleadoLb.AutoSize = true;
            idEmpleadoLb.Location = new Point(260, 0);
            idEmpleadoLb.Name = "idEmpleadoLb";
            idEmpleadoLb.Size = new Size(156, 20);
            idEmpleadoLb.TabIndex = 18;
            idEmpleadoLb.Text = "Cédula  del Empleado";
            // 
            // salManTxt
            // 
            salManTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            salManTxt.Location = new Point(114, 76);
            salManTxt.Name = "salManTxt";
            salManTxt.Size = new Size(140, 27);
            salManTxt.TabIndex = 26;
            // 
            // boniManTxt
            // 
            boniManTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boniManTxt.Location = new Point(114, 110);
            boniManTxt.Name = "boniManTxt";
            boniManTxt.Size = new Size(140, 27);
            boniManTxt.TabIndex = 15;
            // 
            // salarioLb
            // 
            salarioLb.AutoSize = true;
            salarioLb.Location = new Point(3, 72);
            salarioLb.Name = "salarioLb";
            salarioLb.Size = new Size(95, 20);
            salarioLb.TabIndex = 24;
            salarioLb.Text = "Salario Bruto";
            // 
            // bonificacionesLb
            // 
            bonificacionesLb.AutoSize = true;
            bonificacionesLb.Location = new Point(3, 107);
            bonificacionesLb.Name = "bonificacionesLb";
            bonificacionesLb.Size = new Size(105, 20);
            bonificacionesLb.TabIndex = 17;
            bonificacionesLb.Text = "Bonificaciones";
            // 
            // fecEmisionLb
            // 
            fecEmisionLb.AutoSize = true;
            fecEmisionLb.Location = new Point(260, 72);
            fecEmisionLb.Name = "fecEmisionLb";
            fecEmisionLb.Size = new Size(124, 20);
            fecEmisionLb.TabIndex = 25;
            fecEmisionLb.Text = "Fecha de emisión";
            // 
            // descuentosLb
            // 
            descuentosLb.AutoSize = true;
            descuentosLb.Location = new Point(260, 107);
            descuentosLb.Name = "descuentosLb";
            descuentosLb.Size = new Size(85, 20);
            descuentosLb.TabIndex = 19;
            descuentosLb.Text = "Descuentos";
            // 
            // descManTxt
            // 
            descManTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descManTxt.Location = new Point(422, 110);
            descManTxt.Name = "descManTxt";
            descManTxt.Size = new Size(273, 27);
            descManTxt.TabIndex = 11;
            // 
            // empleAutoCb
            // 
            empleAutoCb.FormattingEnabled = true;
            empleAutoCb.Location = new Point(422, 4);
            empleAutoCb.Margin = new Padding(3, 4, 3, 4);
            empleAutoCb.Name = "empleAutoCb";
            empleAutoCb.Size = new Size(273, 28);
            empleAutoCb.TabIndex = 27;
            empleAutoCb.SelectedIndexChanged += empleAutoCb_SelectedIndexChanged;
            // 
            // mesAutoCb
            // 
            mesAutoCb.FormattingEnabled = true;
            mesAutoCb.Location = new Point(422, 40);
            mesAutoCb.Margin = new Padding(3, 4, 3, 4);
            mesAutoCb.Name = "mesAutoCb";
            mesAutoCb.Size = new Size(273, 28);
            mesAutoCb.TabIndex = 28;
            // 
            // anioNud
            // 
            anioNud.Location = new Point(114, 40);
            anioNud.Margin = new Padding(3, 4, 3, 4);
            anioNud.Name = "anioNud";
            anioNud.Size = new Size(137, 27);
            anioNud.TabIndex = 29;
            // 
            // fecEmiDtp
            // 
            fecEmiDtp.Format = DateTimePickerFormat.Short;
            fecEmiDtp.Location = new Point(422, 76);
            fecEmiDtp.Margin = new Padding(3, 4, 3, 4);
            fecEmiDtp.Name = "fecEmiDtp";
            fecEmiDtp.Size = new Size(273, 27);
            fecEmiDtp.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Controls.Add(eliminarBtn);
            panel2.Controls.Add(insertarBtn);
            panel2.Controls.Add(actualizarBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1115, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 237);
            panel2.TabIndex = 4;
            // 
            // eliminarBtn
            // 
            eliminarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            eliminarBtn.IconColor = Color.Black;
            eliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarBtn.Location = new Point(38, 175);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(94, 29);
            eliminarBtn.TabIndex = 12;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // insertarBtn
            // 
            insertarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            insertarBtn.IconColor = Color.Black;
            insertarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            insertarBtn.Location = new Point(38, 93);
            insertarBtn.Name = "insertarBtn";
            insertarBtn.Size = new Size(94, 29);
            insertarBtn.TabIndex = 9;
            insertarBtn.Text = "Insertar";
            insertarBtn.UseVisualStyleBackColor = true;
            insertarBtn.Click += ingAutoBtn_Click;
            // 
            // actualizarBtn
            // 
            actualizarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            actualizarBtn.IconColor = Color.Black;
            actualizarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            actualizarBtn.Location = new Point(38, 136);
            actualizarBtn.Name = "actualizarBtn";
            actualizarBtn.Size = new Size(94, 29);
            actualizarBtn.TabIndex = 11;
            actualizarBtn.Text = "Actualizar";
            actualizarBtn.UseVisualStyleBackColor = true;
            actualizarBtn.Click += actualizarBtn_Click;
            // 
            // nominasActivasDgv
            // 
            nominasActivasDgv.AutoGenerateColumns = false;
            nominasActivasDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            nominasActivasDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            nominasActivasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nominasActivasDgv.Columns.AddRange(new DataGridViewColumn[] { idNominaDataGridViewTextBoxColumn, idEmpleadoDataGridViewTextBoxColumn, nombresApellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, horasJornadaDataGridViewTextBoxColumn, bonificacionesDataGridViewTextBoxColumn, descuentosDataGridViewTextBoxColumn, mesDataGridViewTextBoxColumn, anioDataGridViewTextBoxColumn, salarioNetoDataGridViewTextBoxColumn });
            nominasActivasDgv.DataSource = nominasDTOBindingSource;
            nominasActivasDgv.Dock = DockStyle.Fill;
            nominasActivasDgv.Location = new Point(0, 282);
            nominasActivasDgv.Name = "nominasActivasDgv";
            nominasActivasDgv.RowHeadersWidth = 51;
            nominasActivasDgv.Size = new Size(1273, 133);
            nominasActivasDgv.TabIndex = 8;
            nominasActivasDgv.CellClick += nominasActivasDgv_CellClick;
            nominasActivasDgv.DataBindingComplete += nominasActivasDgv_DataBindingComplete;
            // 
            // idNominaDataGridViewTextBoxColumn
            // 
            idNominaDataGridViewTextBoxColumn.DataPropertyName = "IdNomina";
            idNominaDataGridViewTextBoxColumn.HeaderText = "ID Nomina";
            idNominaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idNominaDataGridViewTextBoxColumn.Name = "idNominaDataGridViewTextBoxColumn";
            idNominaDataGridViewTextBoxColumn.Width = 101;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID Empleado";
            idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            idEmpleadoDataGridViewTextBoxColumn.Width = 115;
            // 
            // nombresApellidosDataGridViewTextBoxColumn
            // 
            nombresApellidosDataGridViewTextBoxColumn.DataPropertyName = "NombresApellidos";
            nombresApellidosDataGridViewTextBoxColumn.HeaderText = "Nombres y Apellidos";
            nombresApellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombresApellidosDataGridViewTextBoxColumn.Name = "nombresApellidosDataGridViewTextBoxColumn";
            nombresApellidosDataGridViewTextBoxColumn.Width = 162;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            cedulaDataGridViewTextBoxColumn.Width = 84;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            salarioDataGridViewTextBoxColumn.Width = 84;
            // 
            // horasJornadaDataGridViewTextBoxColumn
            // 
            horasJornadaDataGridViewTextBoxColumn.DataPropertyName = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.HeaderText = "Horas Jornada";
            horasJornadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            horasJornadaDataGridViewTextBoxColumn.Name = "horasJornadaDataGridViewTextBoxColumn";
            horasJornadaDataGridViewTextBoxColumn.Width = 122;
            // 
            // bonificacionesDataGridViewTextBoxColumn
            // 
            bonificacionesDataGridViewTextBoxColumn.DataPropertyName = "Bonificaciones";
            bonificacionesDataGridViewTextBoxColumn.HeaderText = "Bonificaciones";
            bonificacionesDataGridViewTextBoxColumn.MinimumWidth = 6;
            bonificacionesDataGridViewTextBoxColumn.Name = "bonificacionesDataGridViewTextBoxColumn";
            bonificacionesDataGridViewTextBoxColumn.Width = 134;
            // 
            // descuentosDataGridViewTextBoxColumn
            // 
            descuentosDataGridViewTextBoxColumn.DataPropertyName = "Descuentos";
            descuentosDataGridViewTextBoxColumn.HeaderText = "Descuentos";
            descuentosDataGridViewTextBoxColumn.MinimumWidth = 6;
            descuentosDataGridViewTextBoxColumn.Name = "descuentosDataGridViewTextBoxColumn";
            descuentosDataGridViewTextBoxColumn.Width = 114;
            // 
            // mesDataGridViewTextBoxColumn
            // 
            mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            mesDataGridViewTextBoxColumn.MinimumWidth = 6;
            mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            mesDataGridViewTextBoxColumn.Width = 65;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            anioDataGridViewTextBoxColumn.HeaderText = "Año";
            anioDataGridViewTextBoxColumn.MinimumWidth = 6;
            anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            anioDataGridViewTextBoxColumn.Width = 65;
            // 
            // salarioNetoDataGridViewTextBoxColumn
            // 
            salarioNetoDataGridViewTextBoxColumn.DataPropertyName = "SalarioNeto";
            salarioNetoDataGridViewTextBoxColumn.HeaderText = "SalarioNeto";
            salarioNetoDataGridViewTextBoxColumn.MinimumWidth = 6;
            salarioNetoDataGridViewTextBoxColumn.Name = "salarioNetoDataGridViewTextBoxColumn";
            salarioNetoDataGridViewTextBoxColumn.Width = 117;
            // 
            // nominasDTOBindingSource
            // 
            nominasDTOBindingSource.DataSource = typeof(NominasDTO);
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(presentLb);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 237);
            panel3.Name = "panel3";
            panel3.Size = new Size(1273, 45);
            panel3.TabIndex = 10;
            // 
            // presentLb
            // 
            presentLb.AutoSize = true;
            presentLb.Location = new Point(3, 25);
            presentLb.Name = "presentLb";
            presentLb.Size = new Size(119, 20);
            presentLb.TabIndex = 10;
            presentLb.Text = "Nominas Activas";
            presentLb.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.59375F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.40625F));
            tableLayoutPanel2.Controls.Add(empleNombrePresen, 0, 0);
            tableLayoutPanel2.Controls.Add(empleNomLb1, 1, 0);
            tableLayoutPanel2.Location = new Point(803, 51);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(306, 45);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // F6Nominas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 415);
            Controls.Add(nominasActivasDgv);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "F6Nominas";
            Text = "F6Nominas";
            Load += F6Nominas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anioNud).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nominasActivasDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label salarioLb;
        private Label anioLb;
        private Label mesLb;
        private Label descuentosLb;
        private Label idEmpleadoLb;
        private Label bonificacionesLb;
        private Label nominaLb;
        private TextBox idNomTxt;
        private TextBox boniManTxt;
        private TextBox descManTxt;
        private DataGridView nominasActivasDgv;
        private FontAwesome.Sharp.IconButton limpiarBtn;
        private FontAwesome.Sharp.IconButton actualizarBtn;
        private Panel panel3;
        private Label fecEmisionLb;
        private TextBox salManTxt;
        private BindingSource nominasDTOBindingSource;
        private Label nominasIngeManuLb;
        private Label presentLb;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton insertarBtn;
        private ComboBox empleAutoCb;
        private ComboBox mesAutoCb;
        private NumericUpDown anioNud;
        private DateTimePicker fecEmiDtp;
        private DataGridViewTextBoxColumn idNominaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresApellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasJornadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bonificacionesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descuentosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioNetoDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton eliminarBtn;
        private Label empleNomLb1;
        private Label empleNombrePresen;
        private TableLayoutPanel tableLayoutPanel2;
    }
}