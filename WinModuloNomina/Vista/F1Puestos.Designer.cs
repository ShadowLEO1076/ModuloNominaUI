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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            txtSalarioPuesto = new TextBox();
            txtNombrePuesto = new TextBox();
            txtIdPuesto = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtBuscar = new TextBox();
            btnCrear = new FontAwesome.Sharp.IconButton();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label11 = new Label();
            dgvPuestos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            puestosBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl3, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSalarioPuesto, 1, 2);
            tableLayoutPanel1.Controls.Add(txtNombrePuesto, 1, 1);
            tableLayoutPanel1.Controls.Add(txtIdPuesto, 1, 0);
            tableLayoutPanel1.Location = new Point(21, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(518, 138);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Left;
            lbl.AutoSize = true;
            lbl.Location = new Point(3, 105);
            lbl.Name = "lbl";
            lbl.Size = new Size(50, 20);
            lbl.TabIndex = 20;
            lbl.Text = "label5";
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.Left;
            lbl2.AutoSize = true;
            lbl2.Location = new Point(3, 59);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(50, 20);
            lbl2.TabIndex = 18;
            lbl2.Text = "label3";
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.Left;
            lbl3.AutoSize = true;
            lbl3.Location = new Point(3, 13);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(50, 20);
            lbl3.TabIndex = 7;
            lbl3.Text = "label1";
            // 
            // txtSalarioPuesto
            // 
            txtSalarioPuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSalarioPuesto.Location = new Point(262, 101);
            txtSalarioPuesto.Name = "txtSalarioPuesto";
            txtSalarioPuesto.Size = new Size(253, 27);
            txtSalarioPuesto.TabIndex = 16;
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombrePuesto.Location = new Point(262, 55);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(253, 27);
            txtNombrePuesto.TabIndex = 12;
            // 
            // txtIdPuesto
            // 
            txtIdPuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdPuesto.Location = new Point(262, 9);
            txtIdPuesto.Name = "txtIdPuesto";
            txtIdPuesto.Size = new Size(253, 27);
            txtIdPuesto.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 177);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(btnCrear);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(btnEditar);
            panel2.Location = new Point(571, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 174);
            panel2.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.Location = new Point(3, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(106, 27);
            txtBuscar.TabIndex = 8;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Right;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.Location = new Point(119, 51);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
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
            btnBorrar.Location = new Point(119, 121);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(119, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
           
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Right;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(119, 86);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(796, 45);
            panel3.TabIndex = 8;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(367, 12);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 9;
            label11.Text = "label11";
            // 
            // dgvPuestos
            // 
            dgvPuestos.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvPuestos.DataSource = puestosBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPuestos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPuestos.Dock = DockStyle.Fill;
            dgvPuestos.Location = new Point(0, 222);
            dgvPuestos.Name = "dgvPuestos";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.Size = new Size(796, 132);
            dgvPuestos.TabIndex = 9;
            dgvPuestos.CellContentClick += dgvPuestos_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdPuesto";
            dataGridViewTextBoxColumn1.HeaderText = "IdPuesto";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SalarioBase";
            dataGridViewTextBoxColumn3.HeaderText = "SalarioBase";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // puestosBindingSource
            // 
            puestosBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.Puestos);
            // 
            // F1Puestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 354);
            Controls.Add(dgvPuestos);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "F1Puestos";
            Text = "F1Puestos";
            Load += F1Puestos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnCrear;
        private Label label9;
        private Label label7;
        private Label lbl;
        private Label lbl2;
        private Label lbl3;
        private TextBox txtSalarioPuesto;
        private TextBox txtNombrePuesto;
        private TextBox txtIdPuesto;
        private TextBox textBox9;
        private TextBox textBox5;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private Panel panel3;
        private Label label11;
        private DataGridView dgvPuestos;
        private DataGridViewTextBoxColumn idPuestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioBaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource puestosBindingSource;
        private TextBox txtBuscar;
    }
}