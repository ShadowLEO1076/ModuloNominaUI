namespace WinModuloNomina.Vista
{
    partial class F1Puestos
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
            panel3 = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            txtBuscar = new TextBox();
            puestosBindingSource = new BindingSource(components);
            panel1 = new Panel();
            panel2 = new Panel();
            btnCrear = new FontAwesome.Sharp.IconButton();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            txtSalarioPuesto = new TextBox();
            txtNombrePuesto = new TextBox();
            txtIdPuesto = new TextBox();
            dgvPuestos = new DataGridView();
            idPuestoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioBaseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            puestosBindingSource2 = new BindingSource(components);
            puestosBindingSource1 = new BindingSource(components);
<<<<<<< HEAD
            btnBuscar = new FontAwesome.Sharp.IconButton();
=======
>>>>>>> origin
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtBuscar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 177);
            panel3.Name = "panel3";
<<<<<<< HEAD
            panel3.Size = new Size(742, 45);
=======
            panel3.Size = new Size(748, 45);
>>>>>>> origin
            panel3.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 35;
            btnBuscar.Location = new Point(187, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 32);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
<<<<<<< HEAD
            label11.Location = new Point(312, 13);
=======
            label11.Location = new Point(315, 16);
>>>>>>> origin
            label11.Name = "label11";
            label11.Size = new Size(140, 20);
            label11.TabIndex = 9;
            label11.Text = "PUESTOS - CARGOS";
<<<<<<< HEAD
=======
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.Location = new Point(24, 22);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(168, 27);
            txtBuscar.TabIndex = 8;
>>>>>>> origin
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
<<<<<<< HEAD
            panel1.Size = new Size(742, 177);
=======
            panel1.Size = new Size(748, 177);
>>>>>>> origin
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
<<<<<<< HEAD
            panel2.Controls.Add(btnCrear);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(btnEditar);
            panel2.Location = new Point(519, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 174);
            panel2.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.Location = new Point(91, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(162, 27);
            txtBuscar.TabIndex = 8;
            // 
=======
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(btnCrear);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(btnEditar);
            panel2.Location = new Point(481, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 174);
            panel2.TabIndex = 2;
            // 
>>>>>>> origin
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Right;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
<<<<<<< HEAD
            btnCrear.Location = new Point(117, 29);
=======
            btnCrear.Location = new Point(24, 71);
>>>>>>> origin
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(107, 38);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Right;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
<<<<<<< HEAD
            btnBorrar.Location = new Point(117, 121);
=======
            btnBorrar.Location = new Point(148, 119);
>>>>>>> origin
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(107, 38);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Right;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
<<<<<<< HEAD
            btnEditar.Location = new Point(117, 75);
=======
            btnEditar.Location = new Point(148, 72);
>>>>>>> origin
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 41);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
<<<<<<< HEAD
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
=======
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
>>>>>>> origin
            tableLayoutPanel1.Controls.Add(lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl3, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSalarioPuesto, 1, 2);
            tableLayoutPanel1.Controls.Add(txtNombrePuesto, 1, 1);
            tableLayoutPanel1.Controls.Add(txtIdPuesto, 1, 0);
<<<<<<< HEAD
            tableLayoutPanel1.Location = new Point(53, 16);
=======
            tableLayoutPanel1.Location = new Point(29, 16);
>>>>>>> origin
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
<<<<<<< HEAD
            tableLayoutPanel1.Size = new Size(432, 138);
=======
            tableLayoutPanel1.Size = new Size(446, 138);
>>>>>>> origin
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Right;
            lbl.AutoSize = true;
<<<<<<< HEAD
            lbl.Location = new Point(12, 105);
            lbl.Name = "lbl";
            lbl.Size = new Size(93, 20);
=======
            lbl.Location = new Point(12, 95);
            lbl.Name = "lbl";
            lbl.Size = new Size(59, 40);
>>>>>>> origin
            lbl.TabIndex = 20;
            lbl.Text = "Salario Base:";
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.Right;
            lbl2.AutoSize = true;
<<<<<<< HEAD
            lbl2.Location = new Point(38, 59);
=======
            lbl2.Location = new Point(4, 59);
>>>>>>> origin
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(67, 20);
            lbl2.TabIndex = 18;
            lbl2.Text = "Nombre:";
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.Right;
            lbl3.AutoSize = true;
<<<<<<< HEAD
            lbl3.Location = new Point(78, 13);
=======
            lbl3.Location = new Point(44, 13);
>>>>>>> origin
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(27, 20);
            lbl3.TabIndex = 7;
            lbl3.Text = "ID:";
            // 
            // txtSalarioPuesto
            // 
            txtSalarioPuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
<<<<<<< HEAD
            txtSalarioPuesto.Location = new Point(111, 101);
            txtSalarioPuesto.Name = "txtSalarioPuesto";
            txtSalarioPuesto.Size = new Size(318, 27);
=======
            txtSalarioPuesto.Location = new Point(77, 101);
            txtSalarioPuesto.Name = "txtSalarioPuesto";
            txtSalarioPuesto.Size = new Size(217, 27);
>>>>>>> origin
            txtSalarioPuesto.TabIndex = 16;
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
<<<<<<< HEAD
            txtNombrePuesto.Location = new Point(111, 55);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(318, 27);
=======
            txtNombrePuesto.Location = new Point(77, 55);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(217, 27);
>>>>>>> origin
            txtNombrePuesto.TabIndex = 12;
            // 
            // txtIdPuesto
            // 
            txtIdPuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
<<<<<<< HEAD
            txtIdPuesto.Location = new Point(111, 9);
            txtIdPuesto.Name = "txtIdPuesto";
            txtIdPuesto.Size = new Size(318, 27);
=======
            txtIdPuesto.Location = new Point(77, 9);
            txtIdPuesto.Name = "txtIdPuesto";
            txtIdPuesto.Size = new Size(217, 27);
>>>>>>> origin
            txtIdPuesto.TabIndex = 7;
            // 
            // dgvPuestos
            // 
            dgvPuestos.AutoGenerateColumns = false;
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Columns.AddRange(new DataGridViewColumn[] { idPuestoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, salarioBaseDataGridViewTextBoxColumn });
            dgvPuestos.DataSource = puestosBindingSource2;
            dgvPuestos.Dock = DockStyle.Fill;
            dgvPuestos.Location = new Point(0, 222);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowHeadersWidth = 51;
<<<<<<< HEAD
            dgvPuestos.Size = new Size(742, 193);
=======
            dgvPuestos.Size = new Size(748, 160);
>>>>>>> origin
            dgvPuestos.TabIndex = 9;
            dgvPuestos.CellContentClick += dgvPuestos_CellContentClick_1;
            // 
            // idPuestoDataGridViewTextBoxColumn
            // 
            idPuestoDataGridViewTextBoxColumn.DataPropertyName = "IdPuesto";
            idPuestoDataGridViewTextBoxColumn.HeaderText = "IdPuesto";
            idPuestoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idPuestoDataGridViewTextBoxColumn.Name = "idPuestoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // salarioBaseDataGridViewTextBoxColumn
            // 
            salarioBaseDataGridViewTextBoxColumn.DataPropertyName = "SalarioBase";
            salarioBaseDataGridViewTextBoxColumn.HeaderText = "SalarioBase";
            salarioBaseDataGridViewTextBoxColumn.MinimumWidth = 6;
            salarioBaseDataGridViewTextBoxColumn.Name = "salarioBaseDataGridViewTextBoxColumn";
            // 
            // puestosBindingSource2
            // 
            puestosBindingSource2.DataSource = typeof(Infraestructura.AccesoDatos.Puestos);
            // 
            // puestosBindingSource1
            // 
            puestosBindingSource1.DataSource = typeof(Infraestructura.AccesoDatos.Puestos);
<<<<<<< HEAD
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 35;
            btnBuscar.Location = new Point(29, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 32);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = true;
=======
>>>>>>> origin
            // 
            // F1Puestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
<<<<<<< HEAD
            ClientSize = new Size(742, 415);
=======
            ClientSize = new Size(748, 382);
>>>>>>> origin
            Controls.Add(dgvPuestos);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "F1Puestos";
            Text = "F1Puestos";
            Load += F1Puestos_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label9;
        private Label label7;
        private TextBox textBox9;
        private TextBox textBox5;
        private Panel panel3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource puestosBindingSource;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl;
        private Label lbl2;
        private Label lbl3;
        private TextBox txtSalarioPuesto;
        private TextBox txtNombrePuesto;
        private TextBox txtIdPuesto;
        private Label label11;
        private DataGridView dgvPuestos;
        private BindingSource puestosBindingSource1;
        private DataGridViewTextBoxColumn idPuestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioBaseDataGridViewTextBoxColumn;
        private BindingSource puestosBindingSource2;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}