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
            btnBorrar.Location = new Point(7, 116);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 20;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(7, 81);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(7, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(7, 11);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 17;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Location = new Point(370, 230);
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.RowHeadersWidth = 51;
            dgvDescuentos.Size = new Size(339, 229);
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
            panel2.Location = new Point(640, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(114, 195);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 195);
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
            tableLayoutPanel1.Location = new Point(27, 11);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(606, 184);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(305, 144);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 25;
            label10.Text = "label10";
            // 
            // fechaLb
            // 
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(3, 144);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(47, 20);
            fechaLb.TabIndex = 24;
            fechaLb.Text = "Fecha";
            // 
            // idDescuentosTxt
            // 
            idDescuentosTxt.AutoSize = true;
            idDescuentosTxt.Location = new Point(3, 0);
            idDescuentosTxt.Name = "idDescuentosTxt";
            idDescuentosTxt.Size = new Size(102, 20);
            idDescuentosTxt.TabIndex = 17;
            idDescuentosTxt.Text = "Id Descuentos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(305, 108);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 23;
            label8.Text = "label8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 72);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 21;
            label6.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 36);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 19;
            label4.Text = "label4";
            // 
            // descripcionTxt
            // 
            descripcionTxt.Location = new Point(154, 75);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(143, 27);
            descripcionTxt.TabIndex = 16;
            // 
            // tipoTxt
            // 
            tipoTxt.Location = new Point(154, 39);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(143, 27);
            tipoTxt.TabIndex = 12;
            // 
            // montoTxt
            // 
            montoTxt.Location = new Point(154, 111);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(143, 27);
            montoTxt.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(456, 75);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(70, 27);
            textBox8.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(456, 39);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(70, 27);
            textBox7.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(456, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(70, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(456, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(70, 27);
            textBox2.TabIndex = 8;
            // 
            // montoLb
            // 
            montoLb.AutoSize = true;
            montoLb.Location = new Point(3, 108);
            montoLb.Name = "montoLb";
            montoLb.Size = new Size(53, 20);
            montoLb.TabIndex = 20;
            montoLb.Text = "Monto";
            // 
            // tipoLb
            // 
            tipoLb.AutoSize = true;
            tipoLb.Location = new Point(3, 36);
            tipoLb.Name = "tipoLb";
            tipoLb.Size = new Size(39, 20);
            tipoLb.TabIndex = 18;
            tipoLb.Text = "Tipo";
            // 
            // descripcionLb
            // 
            descripcionLb.AutoSize = true;
            descripcionLb.Location = new Point(3, 72);
            descripcionLb.Name = "descripcionLb";
            descripcionLb.Size = new Size(87, 20);
            descripcionLb.TabIndex = 22;
            descripcionLb.Text = "Descripcion";
            // 
            // fechaDTP
            // 
            fechaDTP.Format = DateTimePickerFormat.Short;
            fechaDTP.Location = new Point(154, 148);
            fechaDTP.Margin = new Padding(3, 4, 3, 4);
            fechaDTP.Name = "fechaDTP";
            fechaDTP.Size = new Size(143, 27);
            fechaDTP.TabIndex = 26;
            fechaDTP.Value = new DateTime(2025, 7, 21, 20, 56, 31, 0);
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 3);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(143, 27);
            textBox4.TabIndex = 10;
            // 
            // idEmpleadoLb
            // 
            idEmpleadoLb.AutoSize = true;
            idEmpleadoLb.Location = new Point(305, 0);
            idEmpleadoLb.Name = "idEmpleadoLb";
            idEmpleadoLb.Size = new Size(96, 20);
            idEmpleadoLb.TabIndex = 7;
            idEmpleadoLb.Text = "ID Empleado";
            // 
            // idEmpleadoCb
            // 
            idEmpleadoCb.FormattingEnabled = true;
            idEmpleadoCb.Location = new Point(456, 4);
            idEmpleadoCb.Margin = new Padding(3, 4, 3, 4);
            idEmpleadoCb.Name = "idEmpleadoCb";
            idEmpleadoCb.Size = new Size(138, 28);
            idEmpleadoCb.TabIndex = 27;
            // 
            // F5Descuentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 600);
            Controls.Add(dgvDescuentos);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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