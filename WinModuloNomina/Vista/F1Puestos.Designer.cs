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
            panel3 = new Panel();
            label2 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            btnCrear = new FontAwesome.Sharp.IconButton();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl = new Label();
            txtIdPuesto = new TextBox();
            txtNombrePuesto = new TextBox();
            txtSalarioPuesto = new TextBox();
            dgvPuestos = new DataGridView();

            btnBuscar = new FontAwesome.Sharp.IconButton();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(txtBuscar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(742, 45);
            panel3.Size = new Size(748, 45);
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(txtBuscar);
            panel3.Location = new Point(147, 264);
            panel3.Name = "panel3";
            panel3.Size = new Size(627, 45);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(274, 14);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 11;
            label2.Text = "PUESTOS ";
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
            btnBuscar.Location = new Point(568, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 32);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Right;
            txtBuscar.Location = new Point(446, 10);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(118, 27);
            txtBuscar.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(147, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 177);
            panel1.Size = new Size(748, 177);
            panel1.Size = new Size(627, 45);
            panel1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.Location = new Point(91, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(162, 27);
            txtBuscar.TabIndex = 8;
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(264, 11);
            label1.Name = "label1";
            label1.Size = new Size(111, 18);
            label1.TabIndex = 10;
            label1.Text = "CONTROLES";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(192, 255, 192);
            btnCrear.Dock = DockStyle.Fill;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(117, 29);
            btnCrear.Location = new Point(24, 71);
            btnCrear.IconSize = 40;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(471, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Padding = new Padding(12, 0, 0, 0);
            btnCrear.Size = new Size(153, 48);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Crear";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(255, 192, 192);
            btnBorrar.Dock = DockStyle.Fill;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.Location = new Point(117, 121);
            btnBorrar.Location = new Point(148, 119);
            btnBorrar.IconSize = 40;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(471, 111);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Padding = new Padding(12, 0, 0, 0);
            btnBorrar.Size = new Size(153, 49);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Eliminar";
            btnBorrar.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(192, 255, 255);
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(117, 75);
            btnEditar.Location = new Point(148, 72);
            btnEditar.IconSize = 40;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(471, 57);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(12, 0, 0, 0);
            btnEditar.Size = new Size(153, 48);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Actualizar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnBorrar, 3, 2);
            tableLayoutPanel1.Controls.Add(btnEditar, 3, 1);
            tableLayoutPanel1.Controls.Add(btnCrear, 3, 0);
            tableLayoutPanel1.Controls.Add(lbl3, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(txtIdPuesto, 1, 0);
            tableLayoutPanel1.Location = new Point(53, 16);
            tableLayoutPanel1.Location = new Point(29, 16);
            tableLayoutPanel1.Controls.Add(txtNombrePuesto, 1, 1);
            tableLayoutPanel1.Controls.Add(txtSalarioPuesto, 1, 2);
            tableLayoutPanel1.Location = new Point(147, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(432, 138);
            tableLayoutPanel1.Size = new Size(446, 138);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Right;
            lbl.AutoSize = true;
            lbl.Location = new Point(12, 105);
            lbl.Name = "lbl";
            lbl.Size = new Size(93, 20);
            lbl.Location = new Point(12, 95);
            lbl.Name = "lbl";
            lbl.Size = new Size(59, 40);
            lbl.TabIndex = 20;
            lbl.Text = "Salario Base:";
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.Right;
            lbl2.AutoSize = true;
            lbl2.Location = new Point(38, 59);
            lbl2.Location = new Point(4, 59);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(67, 20);
            lbl2.TabIndex = 18;
            lbl2.Text = "Nombre:";
            // 
            tableLayoutPanel1.Size = new Size(627, 163);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.Left;
            lbl3.AutoSize = true;
            lbl3.Location = new Point(78, 13);
            lbl3.Location = new Point(44, 13);
            lbl3.Location = new Point(3, 17);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(100, 20);
            lbl3.TabIndex = 7;
            lbl3.Text = "ID del Puesto:";
            // 
            // lbl2
            // 
            txtSalarioPuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSalarioPuesto.Location = new Point(111, 101);
            txtSalarioPuesto.Name = "txtSalarioPuesto";
            txtSalarioPuesto.Size = new Size(318, 27);
            txtSalarioPuesto.Location = new Point(77, 101);
            txtSalarioPuesto.Name = "txtSalarioPuesto";
            txtSalarioPuesto.Size = new Size(217, 27);
            txtSalarioPuesto.TabIndex = 16;
            lbl2.Anchor = AnchorStyles.Left;
            lbl2.AutoSize = true;
            lbl2.Location = new Point(3, 71);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(140, 20);
            lbl2.TabIndex = 18;
            lbl2.Text = "Nombre del Puesto:";
            // 
            // lbl
            // 
            txtNombrePuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombrePuesto.Location = new Point(111, 55);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(318, 27);
            txtNombrePuesto.Location = new Point(77, 55);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(217, 27);
            txtNombrePuesto.TabIndex = 12;
            lbl.Anchor = AnchorStyles.Left;
            lbl.AutoSize = true;
            lbl.Location = new Point(3, 125);
            lbl.Name = "lbl";
            lbl.Size = new Size(93, 20);
            lbl.TabIndex = 20;
            lbl.Text = "Salario Base:";
            // 
            // txtIdPuesto
            // 
            txtIdPuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdPuesto.Location = new Point(111, 9);
            txtIdPuesto.Name = "txtIdPuesto";
            txtIdPuesto.Size = new Size(318, 27);
            txtIdPuesto.Location = new Point(77, 9);
            txtIdPuesto.Location = new Point(159, 13);
            txtIdPuesto.Name = "txtIdPuesto";
            txtIdPuesto.Size = new Size(150, 27);
            txtIdPuesto.TabIndex = 7;
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombrePuesto.Location = new Point(159, 67);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(150, 27);
            txtNombrePuesto.TabIndex = 12;
            // 
            // txtSalarioPuesto
            // 
            txtSalarioPuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSalarioPuesto.Location = new Point(159, 122);
            txtSalarioPuesto.Name = "txtSalarioPuesto";
            txtSalarioPuesto.Size = new Size(150, 27);
            txtSalarioPuesto.TabIndex = 16;
            // 
            // dgvPuestos
            // 
            dgvPuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Location = new Point(147, 315);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.Size = new Size(742, 193);
            dgvPuestos.Size = new Size(748, 160);
            dgvPuestos.TabIndex = 9;
            dgvPuestos.CellContentClick += dgvPuestos_CellContentClick_1;
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
            // 
            dgvPuestos.Size = new Size(627, 361);
            dgvPuestos.TabIndex = 9;
            dgvPuestos.CellContentClick += dgvPuestos_CellContentClick_1;
            // 
            // F1Puestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(742, 415);
            ClientSize = new Size(748, 382);
            ClientSize = new Size(915, 679);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvPuestos);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "F1Puestos";
            Text = "F1Puestos";
            Load += F1Puestos_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label9;
        private Label label7;
        private TextBox textBox9;
        private TextBox textBox5;
        private Panel panel3;
        private Panel panel1;
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
        private DataGridView dgvPuestos;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscar;
    }
}