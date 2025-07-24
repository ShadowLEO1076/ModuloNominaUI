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
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            dgvDescuentos = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label10 = new Label();
            fechaLb = new Label();
            idDescuentosTxt = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            descripcionTxt = new TextBox();
            tipoTxt = new TextBox();
            montoTxt = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            montoLb = new Label();
            tipoLb = new Label();
            descripcionLb = new Label();
            fechaDTP = new DateTimePicker();
            textBox4 = new TextBox();
            idEmpleadoLb = new Label();
            idEmpleadoCb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.Location = new Point(6, 87);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(82, 22);
            btnBorrar.TabIndex = 20;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(6, 61);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(6, 34);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(6, 8);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(82, 22);
            btnCrear.TabIndex = 17;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Location = new Point(12, 198);
            dgvDescuentos.Margin = new Padding(3, 2, 3, 2);
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.RowHeadersWidth = 51;
            dgvDescuentos.Size = new Size(408, 172);
            dgvDescuentos.TabIndex = 16;
            dgvDescuentos.CellContentClick += dgvDescuentos_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnCrear);
            panel2.Controls.Add(btnBuscar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(560, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 146);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 146);
            panel1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label10, 2, 4);
            tableLayoutPanel1.Controls.Add(fechaLb, 0, 4);
            tableLayoutPanel1.Controls.Add(idDescuentosTxt, 0, 0);
            tableLayoutPanel1.Controls.Add(label8, 2, 3);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(descripcionTxt, 1, 2);
            tableLayoutPanel1.Controls.Add(tipoTxt, 1, 1);
            tableLayoutPanel1.Controls.Add(montoTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox8, 3, 2);
            tableLayoutPanel1.Controls.Add(textBox7, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 3, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 3, 4);
            tableLayoutPanel1.Controls.Add(montoLb, 0, 3);
            tableLayoutPanel1.Controls.Add(tipoLb, 0, 1);
            tableLayoutPanel1.Controls.Add(descripcionLb, 0, 2);
            tableLayoutPanel1.Controls.Add(fechaDTP, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(idEmpleadoLb, 2, 0);
            tableLayoutPanel1.Controls.Add(idEmpleadoCb, 3, 0);
            tableLayoutPanel1.Location = new Point(24, 8);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(530, 138);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(267, 108);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 25;
            label10.Text = "label10";
            // 
            // fechaLb
            // 
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(3, 108);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(38, 15);
            fechaLb.TabIndex = 24;
            fechaLb.Text = "Fecha";
            // 
            // idDescuentosTxt
            // 
            idDescuentosTxt.AutoSize = true;
            idDescuentosTxt.Location = new Point(3, 0);
            idDescuentosTxt.Name = "idDescuentosTxt";
            idDescuentosTxt.Size = new Size(81, 15);
            idDescuentosTxt.TabIndex = 17;
            idDescuentosTxt.Text = "Id Descuentos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(267, 81);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 23;
            label8.Text = "label8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 54);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 21;
            label6.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 27);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 19;
            label4.Text = "label4";
            // 
            // descripcionTxt
            // 
            descripcionTxt.Location = new Point(135, 56);
            descripcionTxt.Margin = new Padding(3, 2, 3, 2);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(126, 23);
            descripcionTxt.TabIndex = 16;
            // 
            // tipoTxt
            // 
            tipoTxt.Location = new Point(135, 29);
            tipoTxt.Margin = new Padding(3, 2, 3, 2);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(126, 23);
            tipoTxt.TabIndex = 12;
            // 
            // montoTxt
            // 
            montoTxt.Location = new Point(135, 83);
            montoTxt.Margin = new Padding(3, 2, 3, 2);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(126, 23);
            montoTxt.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(399, 56);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(62, 23);
            textBox8.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(399, 29);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(62, 23);
            textBox7.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(399, 83);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 110);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 8;
            // 
            // montoLb
            // 
            montoLb.AutoSize = true;
            montoLb.Location = new Point(3, 81);
            montoLb.Name = "montoLb";
            montoLb.Size = new Size(43, 15);
            montoLb.TabIndex = 20;
            montoLb.Text = "Monto";
            // 
            // tipoLb
            // 
            tipoLb.AutoSize = true;
            tipoLb.Location = new Point(3, 27);
            tipoLb.Name = "tipoLb";
            tipoLb.Size = new Size(30, 15);
            tipoLb.TabIndex = 18;
            tipoLb.Text = "Tipo";
            // 
            // descripcionLb
            // 
            descripcionLb.AutoSize = true;
            descripcionLb.Location = new Point(3, 54);
            descripcionLb.Name = "descripcionLb";
            descripcionLb.Size = new Size(69, 15);
            descripcionLb.TabIndex = 22;
            descripcionLb.Text = "Descripcion";
            // 
            // fechaDTP
            // 
            fechaDTP.Format = DateTimePickerFormat.Short;
            fechaDTP.Location = new Point(135, 111);
            fechaDTP.Name = "fechaDTP";
            fechaDTP.Size = new Size(126, 23);
            fechaDTP.TabIndex = 26;
            fechaDTP.Value = new DateTime(2025, 7, 21, 20, 56, 31, 0);
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 2);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(126, 23);
            textBox4.TabIndex = 10;
            // 
            // idEmpleadoLb
            // 
            idEmpleadoLb.AutoSize = true;
            idEmpleadoLb.Location = new Point(267, 0);
            idEmpleadoLb.Name = "idEmpleadoLb";
            idEmpleadoLb.Size = new Size(74, 15);
            idEmpleadoLb.TabIndex = 7;
            idEmpleadoLb.Text = "ID Empleado";
            // 
            // idEmpleadoCb
            // 
            idEmpleadoCb.FormattingEnabled = true;
            idEmpleadoCb.Location = new Point(399, 3);
            idEmpleadoCb.Name = "idEmpleadoCb";
            idEmpleadoCb.Size = new Size(121, 23);
            idEmpleadoCb.TabIndex = 27;
            // 
            // F5Descuentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(dgvDescuentos);
            Controls.Add(panel1);
            Name = "F5Descuentos";
            Text = "F5Descuentos";
            Load += F5Descuentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private DataGridView dgvDescuentos;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private Label fechaLb;
        private Label label8;
        private Label descripcionLb;
        private Label label6;
        private Label montoLb;
        private Label label4;
        private Label tipoLb;
        private Label idDescuentosTxt;
        private Label idEmpleadoLb;
        private TextBox descripcionTxt;
        private TextBox tipoTxt;
        private TextBox textBox4;
        private TextBox montoTxt;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker fechaDTP;
        private ComboBox idEmpleadoCb;
    }
}