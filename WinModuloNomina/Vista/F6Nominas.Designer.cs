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
            nominasIngeManuLb = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            nominaLb = new Label();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            textBox10 = new TextBox();
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            textBox4 = new TextBox();
            anioLb = new Label();
            mesLb = new Label();
            bonificacionesLb = new Label();
            descuentosLb = new Label();
            textBox5 = new TextBox();
            fecEmisionLb = new Label();
            textBox2 = new TextBox();
            salarioLb = new Label();
            idEmpleadoLb = new Label();
            panel2 = new Panel();
            nominaIngAutoLb = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            anioAutoNumUpDown = new NumericUpDown();
            empleLb2 = new Label();
            anioL2 = new Label();
            mesLb2 = new Label();
            empleAutoCb = new ComboBox();
            mesAutoCb = new ComboBox();
            ingAutoBtn = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
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
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anioAutoNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nominasActivasDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(nominasIngeManuLb);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(iconButton3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 161);
            panel1.TabIndex = 2;
            // 
            // nominasIngeManuLb
            // 
            nominasIngeManuLb.AutoSize = true;
            nominasIngeManuLb.Location = new Point(12, 6);
            nominasIngeManuLb.Name = "nominasIngeManuLb";
            nominasIngeManuLb.Size = new Size(149, 15);
            nominasIngeManuLb.TabIndex = 11;
            nominasIngeManuLb.Text = "Ingreso manual de nómina";
            nominasIngeManuLb.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(315, 135);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(82, 22);
            iconButton4.TabIndex = 12;
            iconButton4.Text = "Borrar";
            iconButton4.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.Controls.Add(textBox6, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox10, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox7, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox9, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 3);
            tableLayoutPanel1.Controls.Add(anioLb, 0, 1);
            tableLayoutPanel1.Controls.Add(mesLb, 2, 1);
            tableLayoutPanel1.Controls.Add(bonificacionesLb, 0, 2);
            tableLayoutPanel1.Controls.Add(descuentosLb, 2, 2);
            tableLayoutPanel1.Controls.Add(textBox5, 3, 2);
            tableLayoutPanel1.Controls.Add(fecEmisionLb, 2, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 3);
            tableLayoutPanel1.Controls.Add(salarioLb, 0, 3);
            tableLayoutPanel1.Controls.Add(idEmpleadoLb, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 23);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(473, 108);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // nominaLb
            // 
            nominaLb.AutoSize = true;
            nominaLb.Location = new Point(3, 0);
            nominaLb.Name = "nominaLb";
            nominaLb.Size = new Size(64, 15);
            nominaLb.TabIndex = 7;
            nominaLb.Text = "ID Nomina";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(93, 29);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(123, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(93, 2);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox10.Location = new Point(327, 2);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(143, 23);
            textBox10.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(327, 29);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 23);
            textBox7.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox9.Location = new Point(93, 56);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(123, 23);
            textBox9.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(327, 83);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 23);
            textBox4.TabIndex = 10;
            // 
            // anioLb
            // 
            anioLb.AutoSize = true;
            anioLb.Location = new Point(3, 27);
            anioLb.Name = "anioLb";
            anioLb.Size = new Size(29, 15);
            anioLb.TabIndex = 22;
            anioLb.Text = "Año";
            // 
            // mesLb
            // 
            mesLb.AutoSize = true;
            mesLb.Location = new Point(222, 27);
            mesLb.Name = "mesLb";
            mesLb.Size = new Size(29, 15);
            mesLb.TabIndex = 20;
            mesLb.Text = "Mes";
            // 
            // bonificacionesLb
            // 
            bonificacionesLb.AutoSize = true;
            bonificacionesLb.Location = new Point(3, 54);
            bonificacionesLb.Name = "bonificacionesLb";
            bonificacionesLb.Size = new Size(84, 15);
            bonificacionesLb.TabIndex = 17;
            bonificacionesLb.Text = "Bonificaciones";
            // 
            // descuentosLb
            // 
            descuentosLb.AutoSize = true;
            descuentosLb.Location = new Point(222, 54);
            descuentosLb.Name = "descuentosLb";
            descuentosLb.Size = new Size(68, 15);
            descuentosLb.TabIndex = 19;
            descuentosLb.Text = "Descuentos";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(327, 56);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 23);
            textBox5.TabIndex = 11;
            // 
            // fecEmisionLb
            // 
            fecEmisionLb.AutoSize = true;
            fecEmisionLb.Location = new Point(222, 81);
            fecEmisionLb.Name = "fecEmisionLb";
            fecEmisionLb.Size = new Size(99, 15);
            fecEmisionLb.TabIndex = 25;
            fecEmisionLb.Text = "Fecha de emisión";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(93, 83);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 23);
            textBox2.TabIndex = 26;
            // 
            // salarioLb
            // 
            salarioLb.AutoSize = true;
            salarioLb.Location = new Point(3, 81);
            salarioLb.Name = "salarioLb";
            salarioLb.Size = new Size(74, 15);
            salarioLb.TabIndex = 24;
            salarioLb.Text = "Salario Bruto";
            // 
            // idEmpleadoLb
            // 
            idEmpleadoLb.AutoSize = true;
            idEmpleadoLb.Location = new Point(222, 0);
            idEmpleadoLb.Name = "idEmpleadoLb";
            idEmpleadoLb.Size = new Size(60, 15);
            idEmpleadoLb.TabIndex = 18;
            idEmpleadoLb.Text = "Empleado";
            // 
            // panel2
            // 
            panel2.Controls.Add(nominaIngAutoLb);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(ingAutoBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(491, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 161);
            panel2.TabIndex = 4;
            // 
            // nominaIngAutoLb
            // 
            nominaIngAutoLb.AutoSize = true;
            nominaIngAutoLb.Location = new Point(6, 6);
            nominaIngAutoLb.Name = "nominaIngAutoLb";
            nominaIngAutoLb.Size = new Size(170, 15);
            nominaIngAutoLb.TabIndex = 13;
            nominaIngAutoLb.Text = "Ingreso automático de nómina";
            nominaIngAutoLb.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(9, 135);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(85, 22);
            iconButton2.TabIndex = 10;
            iconButton2.Text = "Buscar";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.42365F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.576355F));
            tableLayoutPanel2.Controls.Add(empleLb2, 0, 0);
            tableLayoutPanel2.Controls.Add(anioL2, 0, 1);
            tableLayoutPanel2.Controls.Add(mesLb2, 0, 2);
            tableLayoutPanel2.Controls.Add(empleAutoCb, 1, 0);
            tableLayoutPanel2.Controls.Add(mesAutoCb, 1, 2);
            tableLayoutPanel2.Controls.Add(anioAutoNumUpDown, 1, 1);
            tableLayoutPanel2.Location = new Point(6, 25);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(203, 94);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // anioAutoNumUpDown
            // 
            anioAutoNumUpDown.Location = new Point(81, 32);
            anioAutoNumUpDown.Name = "anioAutoNumUpDown";
            anioAutoNumUpDown.Size = new Size(119, 23);
            anioAutoNumUpDown.TabIndex = 11;
            // 
            // empleLb2
            // 
            empleLb2.AutoSize = true;
            empleLb2.Location = new Point(3, 0);
            empleLb2.Name = "empleLb2";
            empleLb2.Size = new Size(60, 15);
            empleLb2.TabIndex = 7;
            empleLb2.Text = "Empleado";
            // 
            // anioL2
            // 
            anioL2.AutoSize = true;
            anioL2.Location = new Point(3, 29);
            anioL2.Name = "anioL2";
            anioL2.Size = new Size(29, 15);
            anioL2.TabIndex = 22;
            anioL2.Text = "Año";
            // 
            // mesLb2
            // 
            mesLb2.AutoSize = true;
            mesLb2.Location = new Point(3, 61);
            mesLb2.Name = "mesLb2";
            mesLb2.Size = new Size(29, 15);
            mesLb2.TabIndex = 17;
            mesLb2.Text = "Mes";
            // 
            // empleAutoCb
            // 
            empleAutoCb.FormattingEnabled = true;
            empleAutoCb.Location = new Point(81, 3);
            empleAutoCb.Name = "empleAutoCb";
            empleAutoCb.Size = new Size(119, 23);
            empleAutoCb.TabIndex = 23;
            // 
            // mesAutoCb
            // 
            mesAutoCb.FormattingEnabled = true;
            mesAutoCb.Location = new Point(81, 64);
            mesAutoCb.Name = "mesAutoCb";
            mesAutoCb.Size = new Size(119, 23);
            mesAutoCb.TabIndex = 24;
            // 
            // ingAutoBtn
            // 
            ingAutoBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            ingAutoBtn.IconColor = Color.Black;
            ingAutoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ingAutoBtn.Location = new Point(124, 135);
            ingAutoBtn.Margin = new Padding(3, 2, 3, 2);
            ingAutoBtn.Name = "ingAutoBtn";
            ingAutoBtn.Size = new Size(82, 22);
            ingAutoBtn.TabIndex = 9;
            ingAutoBtn.Text = "Insertar";
            ingAutoBtn.UseVisualStyleBackColor = true;
            ingAutoBtn.Click += ingAutoBtn_Click;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(403, 135);
            iconButton3.Margin = new Padding(3, 2, 3, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(82, 22);
            iconButton3.TabIndex = 11;
            iconButton3.Text = "Editar";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // nominasActivasDgv
            // 
            nominasActivasDgv.AutoGenerateColumns = false;
            nominasActivasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nominasActivasDgv.Columns.AddRange(new DataGridViewColumn[] { idNominaDataGridViewTextBoxColumn, idEmpleadoDataGridViewTextBoxColumn, nombresApellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, horasJornadaDataGridViewTextBoxColumn, bonificacionesDataGridViewTextBoxColumn, descuentosDataGridViewTextBoxColumn, mesDataGridViewTextBoxColumn, anioDataGridViewTextBoxColumn, salarioNetoDataGridViewTextBoxColumn });
            nominasActivasDgv.DataSource = nominasDTOBindingSource;
            nominasActivasDgv.Dock = DockStyle.Top;
            nominasActivasDgv.Location = new Point(0, 197);
            nominasActivasDgv.Margin = new Padding(3, 2, 3, 2);
            nominasActivasDgv.Name = "nominasActivasDgv";
            nominasActivasDgv.RowHeadersWidth = 51;
            nominasActivasDgv.Size = new Size(700, 147);
            nominasActivasDgv.TabIndex = 8;
            nominasActivasDgv.CellClick += nominasActivasDgv_CellClick;
            // 
            // idNominaDataGridViewTextBoxColumn
            // 
            idNominaDataGridViewTextBoxColumn.DataPropertyName = "IdNomina";
            idNominaDataGridViewTextBoxColumn.HeaderText = "ID Nomina";
            idNominaDataGridViewTextBoxColumn.Name = "idNominaDataGridViewTextBoxColumn";
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID Empleado";
            idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
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
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // horasJornadaDataGridViewTextBoxColumn
            // 
            horasJornadaDataGridViewTextBoxColumn.DataPropertyName = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.HeaderText = "Horas Jornada";
            horasJornadaDataGridViewTextBoxColumn.Name = "horasJornadaDataGridViewTextBoxColumn";
            // 
            // bonificacionesDataGridViewTextBoxColumn
            // 
            bonificacionesDataGridViewTextBoxColumn.DataPropertyName = "Bonificaciones";
            bonificacionesDataGridViewTextBoxColumn.HeaderText = "Bonificaciones";
            bonificacionesDataGridViewTextBoxColumn.Name = "bonificacionesDataGridViewTextBoxColumn";
            // 
            // descuentosDataGridViewTextBoxColumn
            // 
            descuentosDataGridViewTextBoxColumn.DataPropertyName = "Descuentos";
            descuentosDataGridViewTextBoxColumn.HeaderText = "Descuentos";
            descuentosDataGridViewTextBoxColumn.Name = "descuentosDataGridViewTextBoxColumn";
            // 
            // mesDataGridViewTextBoxColumn
            // 
            mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            // 
            // anioDataGridViewTextBoxColumn
            // 
            anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            anioDataGridViewTextBoxColumn.HeaderText = "Año";
            anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            // 
            // salarioNetoDataGridViewTextBoxColumn
            // 
            salarioNetoDataGridViewTextBoxColumn.DataPropertyName = "SalarioNeto";
            salarioNetoDataGridViewTextBoxColumn.HeaderText = "Salario Neto";
            salarioNetoDataGridViewTextBoxColumn.Name = "salarioNetoDataGridViewTextBoxColumn";
            // 
            // nominasDTOBindingSource
            // 
            nominasDTOBindingSource.DataSource = typeof(Modelo.NominasDTO);
            // 
            // panel3
            // 
            panel3.Controls.Add(presentLb);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 161);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 36);
            panel3.TabIndex = 10;
            // 
            // presentLb
            // 
            presentLb.AutoSize = true;
            presentLb.Location = new Point(3, 19);
            presentLb.Name = "presentLb";
            presentLb.Size = new Size(96, 15);
            presentLb.TabIndex = 10;
            presentLb.Text = "Nominas Activas";
            presentLb.TextAlign = ContentAlignment.TopCenter;
            // 
            // F6Nominas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(nominasActivasDgv);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "F6Nominas";
            Text = "F6Nominas";
            Load += F6Nominas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anioAutoNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)nominasActivasDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)nominasDTOBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private TextBox textBox10;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox9;
        private TextBox textBox5;
        private TextBox textBox7;
        private Panel panel2;
        private DataGridView nominasActivasDgv;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton ingAutoBtn;
        private Panel panel3;
        private Label fecEmisionLb;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label empleLb2;
        private Label anioL2;
        private Label mesLb2;
        private BindingSource nominasDTOBindingSource;
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
        private Label nominasIngeManuLb;
        private Label presentLb;
        private Label nominaIngAutoLb;
        private ComboBox empleAutoCb;
        private ComboBox mesAutoCb;
        private NumericUpDown anioAutoNumUpDown;
    }
}