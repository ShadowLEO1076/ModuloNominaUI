namespace WinModuloNomina.Vista
{
    partial class F4AsistenciasHistorial
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
            panelSuperior = new Panel();
            limpiar = new Button();
            eliminarBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cedulaTxt = new TextBox();
            fechaTxt = new TextBox();
            idAsisLb = new Label();
            empleNomApeLb = new Label();
            fechaLb = new Label();
            cedulaLb = new Label();
            idAsisTxt = new TextBox();
            empleNomApeTxt = new TextBox();
            filtroLb = new Label();
            filtroTxt = new TextBox();
            AsistenciasDgv = new DataGridView();
            panelSuperior.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AsistenciasDgv).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(limpiar);
            panelSuperior.Controls.Add(eliminarBtn);
            panelSuperior.Controls.Add(tableLayoutPanel1);
            panelSuperior.Controls.Add(filtroLb);
            panelSuperior.Controls.Add(filtroTxt);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(800, 84);
            panelSuperior.TabIndex = 0;
            // 
            // limpiar
            // 
            limpiar.Location = new Point(465, 26);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(75, 23);
            limpiar.TabIndex = 4;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Location = new Point(465, 55);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(75, 23);
            eliminarBtn.TabIndex = 3;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2380943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7619057F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(cedulaTxt, 3, 1);
            tableLayoutPanel1.Controls.Add(fechaTxt, 3, 0);
            tableLayoutPanel1.Controls.Add(idAsisLb, 0, 0);
            tableLayoutPanel1.Controls.Add(empleNomApeLb, 0, 1);
            tableLayoutPanel1.Controls.Add(fechaLb, 2, 0);
            tableLayoutPanel1.Controls.Add(cedulaLb, 2, 1);
            tableLayoutPanel1.Controls.Add(idAsisTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(empleNomApeTxt, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(420, 66);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // cedulaTxt
            // 
            cedulaTxt.Location = new Point(318, 36);
            cedulaTxt.Name = "cedulaTxt";
            cedulaTxt.ReadOnly = true;
            cedulaTxt.Size = new Size(99, 23);
            cedulaTxt.TabIndex = 7;
            // 
            // fechaTxt
            // 
            fechaTxt.Location = new Point(318, 3);
            fechaTxt.Name = "fechaTxt";
            fechaTxt.ReadOnly = true;
            fechaTxt.Size = new Size(99, 23);
            fechaTxt.TabIndex = 6;
            // 
            // idAsisLb
            // 
            idAsisLb.AutoSize = true;
            idAsisLb.Location = new Point(3, 0);
            idAsisLb.Name = "idAsisLb";
            idAsisLb.Size = new Size(77, 15);
            idAsisLb.TabIndex = 0;
            idAsisLb.Text = "ID Asistencia:";
            // 
            // empleNomApeLb
            // 
            empleNomApeLb.AutoSize = true;
            empleNomApeLb.Location = new Point(3, 33);
            empleNomApeLb.Name = "empleNomApeLb";
            empleNomApeLb.Size = new Size(63, 15);
            empleNomApeLb.TabIndex = 1;
            empleNomApeLb.Text = "Empleado:";
            // 
            // fechaLb
            // 
            fechaLb.AutoSize = true;
            fechaLb.Location = new Point(214, 0);
            fechaLb.Name = "fechaLb";
            fechaLb.Size = new Size(41, 15);
            fechaLb.TabIndex = 2;
            fechaLb.Text = "Fecha:";
            // 
            // cedulaLb
            // 
            cedulaLb.AutoSize = true;
            cedulaLb.Location = new Point(214, 33);
            cedulaLb.Name = "cedulaLb";
            cedulaLb.Size = new Size(47, 15);
            cedulaLb.TabIndex = 3;
            cedulaLb.Text = "Cédula:";
            // 
            // idAsisTxt
            // 
            idAsisTxt.Location = new Point(108, 3);
            idAsisTxt.Name = "idAsisTxt";
            idAsisTxt.ReadOnly = true;
            idAsisTxt.Size = new Size(100, 23);
            idAsisTxt.TabIndex = 4;
            // 
            // empleNomApeTxt
            // 
            empleNomApeTxt.Location = new Point(108, 36);
            empleNomApeTxt.Name = "empleNomApeTxt";
            empleNomApeTxt.ReadOnly = true;
            empleNomApeTxt.Size = new Size(100, 23);
            empleNomApeTxt.TabIndex = 5;
            // 
            // filtroLb
            // 
            filtroLb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            filtroLb.AutoSize = true;
            filtroLb.Location = new Point(566, 12);
            filtroLb.Name = "filtroLb";
            filtroLb.Size = new Size(37, 15);
            filtroLb.TabIndex = 1;
            filtroLb.Text = "Filtro:";
            // 
            // filtroTxt
            // 
            filtroTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            filtroTxt.Location = new Point(609, 9);
            filtroTxt.Name = "filtroTxt";
            filtroTxt.Size = new Size(134, 23);
            filtroTxt.TabIndex = 0;
            filtroTxt.TextChanged += txtFiltro_TextChanged;
            // 
            // AsistenciasDgv
            // 
            AsistenciasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AsistenciasDgv.Dock = DockStyle.Fill;
            AsistenciasDgv.Location = new Point(0, 84);
            AsistenciasDgv.Name = "AsistenciasDgv";
            AsistenciasDgv.Size = new Size(800, 366);
            AsistenciasDgv.TabIndex = 1;
            AsistenciasDgv.CellClick += AsistenciasDgv_CellClick;
            // 
            // F4AsistenciasHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AsistenciasDgv);
            Controls.Add(panelSuperior);
            Name = "F4AsistenciasHistorial";
            Text = "Historial Asistencias";
            Load += F4AsistenciasHistorial_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AsistenciasDgv).EndInit();
            ResumeLayout(false);
        }

        private void FiltroTxt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelSuperior;
        private DataGridView AsistenciasDgv;
        private TextBox filtroTxt;
        private Label filtroLb;
        private TableLayoutPanel tableLayoutPanel1;
        private Label idAsisLb;
        private Label empleNomApeLb;
        private Label fechaLb;
        private Label cedulaLb;
        private TextBox cedulaTxt;
        private TextBox fechaTxt;
        private TextBox idAsisTxt;
        private TextBox empleNomApeTxt;
        private Button eliminarBtn;
        private Button limpiar;
    }
}