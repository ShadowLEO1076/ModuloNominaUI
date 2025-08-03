namespace WinModuloNomina.Vista
{
    partial class FormInasistencias
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
            panel4 = new Panel();
            dgvInasistencias = new Zuby.ADGV.AdvancedDataGridView();
            panel3 = new Panel();
            label2 = new Label();
            inasistenciasBindingSource = new BindingSource(components);
            idInasistenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            licenciaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInasistencias).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inasistenciasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvInasistencias);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 450);
            panel4.TabIndex = 27;
            // 
            // dgvInasistencias
            // 
            dgvInasistencias.AutoGenerateColumns = false;
            dgvInasistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInasistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInasistencias.Columns.AddRange(new DataGridViewColumn[] { idInasistenciaDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, licenciaIdDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn });
            dgvInasistencias.DataSource = inasistenciasBindingSource;
            dgvInasistencias.Dock = DockStyle.Fill;
            dgvInasistencias.FilterAndSortEnabled = true;
            dgvInasistencias.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvInasistencias.Location = new Point(0, 45);
            dgvInasistencias.MaxFilterButtonImageHeight = 23;
            dgvInasistencias.Name = "dgvInasistencias";
            dgvInasistencias.RightToLeft = RightToLeft.No;
            dgvInasistencias.RowHeadersWidth = 51;
            dgvInasistencias.Size = new Size(800, 405);
            dgvInasistencias.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvInasistencias.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 45);
            panel3.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(399, -16);
            label2.Name = "label2";
            label2.Size = new Size(195, 18);
            label2.TabIndex = 1;
            label2.Text = "Inasistencias sin licencia";
            // 
            // inasistenciasBindingSource
            // 
            inasistenciasBindingSource.DataSource = typeof(Infraestructura.AccesoDatos.Inasistencias);
            // 
            // idInasistenciaDataGridViewTextBoxColumn
            // 
            idInasistenciaDataGridViewTextBoxColumn.DataPropertyName = "IdInasistencia";
            idInasistenciaDataGridViewTextBoxColumn.HeaderText = "IdInasistencia";
            idInasistenciaDataGridViewTextBoxColumn.MinimumWidth = 24;
            idInasistenciaDataGridViewTextBoxColumn.Name = "idInasistenciaDataGridViewTextBoxColumn";
            idInasistenciaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // licenciaIdDataGridViewTextBoxColumn
            // 
            licenciaIdDataGridViewTextBoxColumn.DataPropertyName = "LicenciaId";
            licenciaIdDataGridViewTextBoxColumn.HeaderText = "LicenciaId";
            licenciaIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            licenciaIdDataGridViewTextBoxColumn.Name = "licenciaIdDataGridViewTextBoxColumn";
            licenciaIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 18);
            label1.Name = "label1";
            label1.Size = new Size(337, 18);
            label1.TabIndex = 2;
            label1.Text = "Inacistencias sin licencia o no remuneradas";
            // 
            // Inasistencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inasistencias";
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInasistencias).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inasistenciasBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Zuby.ADGV.AdvancedDataGridView dgvInasistencias;
        private DataGridViewTextBoxColumn idInasistenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licenciaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private BindingSource inasistenciasBindingSource;
        private Panel panel3;
        private Label label1;
        private Label label2;
    }
}