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
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel9 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel7 = new Panel();
            cbdiasfaltados = new ComboBox();
            panel4 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            idEmpleadoCb = new ComboBox();
            label4 = new Label();
            idDescuentosTxt = new Label();
            textBox4 = new TextBox();
            descripcionLb = new Label();
            descripcionTxt = new TextBox();
            tipoLb = new Label();
            tipoTxt = new ComboBox();
            fechaLb = new Label();
            fechaDTP = new DateTimePicker();
            cbSalario = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            montoLb = new Label();
            montoTxt = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            btnAsistencias = new FontAwesome.Sharp.IconButton();
            btnInacistencias = new FontAwesome.Sharp.IconButton();
            panelAuxiliar = new Panel();
            inasistenciasBindingSource = new BindingSource(components);
            panel5 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            dgvDescuentos = new Zuby.ADGV.AdvancedDataGridView();
            descuentosBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inasistenciasBindingSource).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descuentosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Silver;
            btnBorrar.Dock = DockStyle.Fill;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.IconSize = 34;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(293, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Padding = new Padding(12, 0, 0, 0);
            btnBorrar.Size = new Size(141, 40);
            btnBorrar.TabIndex = 20;
            btnBorrar.Text = "Eliminar";
            btnBorrar.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 35;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(148, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(12, 0, 0, 0);
            btnEditar.Size = new Size(139, 51);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Actualizar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
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
            btnBuscar.Location = new Point(871, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 29);
            btnBuscar.TabIndex = 18;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Silver;
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
            btnCrear.Padding = new Padding(12, 0, 0, 0);
            btnCrear.Size = new Size(139, 40);
            btnCrear.TabIndex = 17;
            btnCrear.Text = "Crear";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(panel9, 1, 8);
            tableLayoutPanel1.Controls.Add(panel7, 0, 8);
            tableLayoutPanel1.Controls.Add(cbdiasfaltados, 1, 6);
            tableLayoutPanel1.Controls.Add(panel4, 1, 5);
            tableLayoutPanel1.Controls.Add(panel6, 0, 5);
            tableLayoutPanel1.Controls.Add(idEmpleadoCb, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(idDescuentosTxt, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(descripcionLb, 0, 3);
            tableLayoutPanel1.Controls.Add(descripcionTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(tipoLb, 0, 2);
            tableLayoutPanel1.Controls.Add(tipoTxt, 1, 2);
            tableLayoutPanel1.Controls.Add(fechaLb, 0, 4);
            tableLayoutPanel1.Controls.Add(fechaDTP, 1, 4);
            tableLayoutPanel1.Controls.Add(cbSalario, 1, 7);
            tableLayoutPanel1.Controls.Add(label2, 0, 6);
            tableLayoutPanel1.Controls.Add(label5, 0, 7);
            tableLayoutPanel1.Controls.Add(montoLb, 0, 9);
            tableLayoutPanel1.Controls.Add(montoTxt, 1, 9);
            tableLayoutPanel1.Location = new Point(3, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.Size = new Size(440, 324);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Highlight;
            panel9.Controls.Add(iconButton1);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(135, 259);
            panel9.Name = "panel9";
            panel9.Size = new Size(302, 26);
            panel9.TabIndex = 41;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Fill;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusMinus;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(302, 26);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Calcular click";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Highlight;
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 259);
            panel7.Name = "panel7";
            panel7.Size = new Size(126, 26);
            panel7.TabIndex = 40;
            // 
            // cbdiasfaltados
            // 
            cbdiasfaltados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbdiasfaltados.FormattingEnabled = true;
            cbdiasfaltados.Location = new Point(135, 195);
            cbdiasfaltados.Name = "cbdiasfaltados";
            cbdiasfaltados.Size = new Size(302, 28);
            cbdiasfaltados.TabIndex = 39;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(135, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 26);
            panel4.TabIndex = 38;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(62, 5);
            label6.Name = "label6";
            label6.Size = new Size(158, 18);
            label6.TabIndex = 1;
            label6.Text = "Parametros Calculo";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Highlight;
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 163);
            panel6.Name = "panel6";
            panel6.Size = new Size(126, 26);
            panel6.TabIndex = 37;
            // 
            // idEmpleadoCb
            // 
            idEmpleadoCb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idEmpleadoCb.FormattingEnabled = true;
            idEmpleadoCb.Location = new Point(135, 35);
            idEmpleadoCb.Name = "idEmpleadoCb";
            idEmpleadoCb.Size = new Size(302, 28);
            idEmpleadoCb.TabIndex = 29;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 38);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 28;
            label4.Text = "Empleado";
            // 
            // idDescuentosTxt
            // 
            idDescuentosTxt.Anchor = AnchorStyles.Left;
            idDescuentosTxt.AutoSize = true;
            idDescuentosTxt.Location = new Point(3, 5);
            idDescuentosTxt.Name = "idDescuentosTxt";
            idDescuentosTxt.Size = new Size(81, 15);
            idDescuentosTxt.TabIndex = 17;
            idDescuentosTxt.Text = "Id Descuentos";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(135, 3);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(302, 27);
            textBox4.TabIndex = 10;
            // 
            // descripcionLb
            // 
            descripcionLb.Anchor = AnchorStyles.Left;
            descripcionLb.AutoSize = true;
            descripcionLb.Location = new Point(3, 102);
            descripcionLb.Name = "descripcionLb";
            descripcionLb.Size = new Size(87, 20);
            descripcionLb.TabIndex = 22;
            descripcionLb.Text = "Descripcion";
            // 
            // descripcionTxt
            // 
            descripcionTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descripcionTxt.Location = new Point(135, 99);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(302, 27);
            descripcionTxt.TabIndex = 16;
            // 
            // tipoLb
            // 
            tipoLb.Anchor = AnchorStyles.Left;
            tipoLb.AutoSize = true;
            tipoLb.Location = new Point(3, 70);
            tipoLb.Name = "tipoLb";
            tipoLb.Size = new Size(79, 20);
            tipoLb.TabIndex = 18;
            tipoLb.Text = "Descuento";
            // 
            // tipoTxt
            // 
            tipoTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tipoTxt.FormattingEnabled = true;
            tipoTxt.Location = new Point(135, 67);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(302, 28);
            tipoTxt.TabIndex = 27;
            tipoTxt.SelectedIndexChanged += tipoTxt_SelectedIndexChanged;
            // 
            // fechaLb
            // 
            fechaLb.Anchor = AnchorStyles.Left;
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(3, 134);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(83, 15);
            fechaLb.TabIndex = 24;
            fechaLb.Text = "Fecha Emision";
            // 
            // fechaDTP
            // 
            fechaDTP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fechaDTP.Format = DateTimePickerFormat.Short;
            fechaDTP.Location = new Point(135, 132);
            fechaDTP.Margin = new Padding(3, 4, 3, 4);
            fechaDTP.Name = "fechaDTP";
            fechaDTP.Size = new Size(302, 27);
            fechaDTP.TabIndex = 26;
            fechaDTP.Value = new DateTime(2025, 7, 21, 20, 56, 31, 0);
            // 
            // cbSalario
            // 
            cbSalario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbSalario.FormattingEnabled = true;
            cbSalario.Location = new Point(135, 227);
            cbSalario.Name = "cbSalario";
            cbSalario.Size = new Size(302, 28);
            cbSalario.TabIndex = 34;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 198);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 31;
            label2.Text = "Cantidad faltas";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 230);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 33;
            label5.Text = "Salario Emp..";
            // 
            // montoLb
            // 
            montoLb.Anchor = AnchorStyles.Left;
            montoLb.AutoSize = true;
            montoLb.Location = new Point(3, 296);
            montoLb.Name = "montoLb";
            montoLb.Size = new Size(43, 15);
            montoLb.TabIndex = 20;
            montoLb.Text = "Monto";
            // 
            // montoTxt
            // 
            montoTxt.Dock = DockStyle.Fill;
            montoTxt.Location = new Point(135, 291);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(302, 27);
            montoTxt.TabIndex = 42;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.4382F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.5618F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(910, 434);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 428);
            panel2.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnCrear, 0, 0);
            tableLayoutPanel3.Controls.Add(btnEditar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnBorrar, 2, 0);
            tableLayoutPanel3.Location = new Point(3, 379);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(437, 46);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 45);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 12);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Registro Descuentos";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Controls.Add(panelAuxiliar, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(452, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel4.Size = new Size(455, 428);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(btnAsistencias);
            panel3.Controls.Add(btnInacistencias);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 47);
            panel3.TabIndex = 23;
            // 
            // btnAsistencias
            // 
            btnAsistencias.Anchor = AnchorStyles.Right;
            btnAsistencias.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnAsistencias.IconColor = Color.Black;
            btnAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsistencias.IconSize = 40;
            btnAsistencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.Location = new Point(297, 3);
            btnAsistencias.Name = "btnAsistencias";
            btnAsistencias.Padding = new Padding(12, 0, 0, 0);
            btnAsistencias.Size = new Size(149, 41);
            btnAsistencias.TabIndex = 1;
            btnAsistencias.Text = "Licencias";
            btnAsistencias.TextAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsistencias.UseVisualStyleBackColor = true;
            // 
            // btnInacistencias
            // 
            btnInacistencias.Anchor = AnchorStyles.Right;
            btnInacistencias.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnInacistencias.IconColor = Color.Black;
            btnInacistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInacistencias.IconSize = 40;
            btnInacistencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnInacistencias.Location = new Point(143, 3);
            btnInacistencias.Name = "btnInacistencias";
            btnInacistencias.Padding = new Padding(8, 0, 0, 0);
            btnInacistencias.Size = new Size(148, 41);
            btnInacistencias.TabIndex = 0;
            btnInacistencias.Text = "Inacistencias";
            btnInacistencias.TextAlign = ContentAlignment.MiddleLeft;
            btnInacistencias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInacistencias.UseVisualStyleBackColor = true;
            btnInacistencias.Click += btnInacistencias_Click;
            // 
            // panelAuxiliar
            // 
            panelAuxiliar.Dock = DockStyle.Fill;
            panelAuxiliar.Location = new Point(3, 74);
            panelAuxiliar.Name = "panelAuxiliar";
            panelAuxiliar.Size = new Size(449, 351);
            panelAuxiliar.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(-1, 452);
            panel5.Name = "panel5";
            panel5.Size = new Size(934, 39);
            panel5.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Location = new Point(749, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(368, 6);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 19;
            label3.Text = "Descuentos Registrados";
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDescuentos.AutoGenerateColumns = false;
            dgvDescuentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.DataSource = descuentosBindingSource;
            dgvDescuentos.FilterAndSortEnabled = true;
            dgvDescuentos.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvDescuentos.Location = new Point(-1, 487);
            dgvDescuentos.MaxFilterButtonImageHeight = 23;
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.RightToLeft = RightToLeft.No;
            dgvDescuentos.RowHeadersWidth = 51;
            dgvDescuentos.Size = new Size(931, 151);
            dgvDescuentos.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvDescuentos.TabIndex = 25;
            // 
            // F5Descuentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 640);
            Controls.Add(dgvDescuentos);
            Controls.Add(panel5);
            Controls.Add(tableLayoutPanel2);
            Name = "F5Descuentos";
            Text = "F5Descuentos";
            Load += F5Descuentos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inasistenciasBindingSource).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)descuentosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private TableLayoutPanel tableLayoutPanel1;
        private Label fechaLb;
        private Label descripcionLb;
        private Label montoLb;
        private Label tipoLb;
        private Label idDescuentosTxt;
        private TextBox descripcionTxt;
        private TextBox textBox4;
        private DateTimePicker fechaDTP;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Zuby.ADGV.AdvancedDataGridView dgvDescuentos;
        private BindingSource inasistenciasBindingSource;
        private DataGridViewTextBoxColumn idDescuentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private BindingSource descuentosBindingSource;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private ComboBox tipoTxt;
        private ComboBox idEmpleadoCb;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnAsistencias;
        private FontAwesome.Sharp.IconButton btnInacistencias;
        private Panel panelAuxiliar;
        private Label label5;
        private Label label2;
        private Panel panel4;
        private Label label6;
        private Panel panel6;
        private ComboBox cbSalario;
        private ComboBox cbdiasfaltados;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel7;
        private TextBox montoTxt;
    }
}