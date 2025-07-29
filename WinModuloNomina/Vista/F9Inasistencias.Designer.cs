namespace WinModuloNomina.Vista
{
    partial class F9Inasistencias
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
            dgvInasistenciasL = new Zuby.ADGV.AdvancedDataGridView();
            inasistenciasFormDTOBindingSource = new BindingSource(components);
            idInasistenciasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresApellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            licenciaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreLicenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remunerableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInasistenciasL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inasistenciasFormDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvInasistenciasL
            // 
            dgvInasistenciasL.AutoGenerateColumns = false;
            dgvInasistenciasL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInasistenciasL.Columns.AddRange(new DataGridViewColumn[] { idInasistenciasDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, nombresApellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, licenciaIdDataGridViewTextBoxColumn, nombreLicenciaDataGridViewTextBoxColumn, remunerableDataGridViewCheckBoxColumn });
            dgvInasistenciasL.DataSource = inasistenciasFormDTOBindingSource;
            dgvInasistenciasL.Dock = DockStyle.Fill;
            dgvInasistenciasL.FilterAndSortEnabled = true;
            dgvInasistenciasL.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvInasistenciasL.Location = new Point(0, 0);
            dgvInasistenciasL.MaxFilterButtonImageHeight = 23;
            dgvInasistenciasL.Name = "dgvInasistenciasL";
            dgvInasistenciasL.RightToLeft = RightToLeft.No;
            dgvInasistenciasL.RowHeadersWidth = 51;
            dgvInasistenciasL.Size = new Size(800, 450);
            dgvInasistenciasL.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvInasistenciasL.TabIndex = 1;
            // 
            // inasistenciasFormDTOBindingSource
            // 
            inasistenciasFormDTOBindingSource.DataSource = typeof(Aplicacion.DTO.DTOs.InasistenciasFormDTO);
            // 
            // idInasistenciasDataGridViewTextBoxColumn
            // 
            idInasistenciasDataGridViewTextBoxColumn.DataPropertyName = "IdInasistencias";
            idInasistenciasDataGridViewTextBoxColumn.HeaderText = "IdInasistencias";
            idInasistenciasDataGridViewTextBoxColumn.MinimumWidth = 24;
            idInasistenciasDataGridViewTextBoxColumn.Name = "idInasistenciasDataGridViewTextBoxColumn";
            idInasistenciasDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            idInasistenciasDataGridViewTextBoxColumn.Width = 125;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            empleadoIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombresApellidosDataGridViewTextBoxColumn
            // 
            nombresApellidosDataGridViewTextBoxColumn.DataPropertyName = "NombresApellidos";
            nombresApellidosDataGridViewTextBoxColumn.HeaderText = "NombresApellidos";
            nombresApellidosDataGridViewTextBoxColumn.MinimumWidth = 24;
            nombresApellidosDataGridViewTextBoxColumn.Name = "nombresApellidosDataGridViewTextBoxColumn";
            nombresApellidosDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            nombresApellidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.MinimumWidth = 24;
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            cedulaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            cedulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 24;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenciaIdDataGridViewTextBoxColumn
            // 
            licenciaIdDataGridViewTextBoxColumn.DataPropertyName = "LicenciaId";
            licenciaIdDataGridViewTextBoxColumn.HeaderText = "LicenciaId";
            licenciaIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            licenciaIdDataGridViewTextBoxColumn.Name = "licenciaIdDataGridViewTextBoxColumn";
            licenciaIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            licenciaIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreLicenciaDataGridViewTextBoxColumn
            // 
            nombreLicenciaDataGridViewTextBoxColumn.DataPropertyName = "NombreLicencia";
            nombreLicenciaDataGridViewTextBoxColumn.HeaderText = "NombreLicencia";
            nombreLicenciaDataGridViewTextBoxColumn.MinimumWidth = 24;
            nombreLicenciaDataGridViewTextBoxColumn.Name = "nombreLicenciaDataGridViewTextBoxColumn";
            nombreLicenciaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            nombreLicenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // remunerableDataGridViewCheckBoxColumn
            // 
            remunerableDataGridViewCheckBoxColumn.DataPropertyName = "Remunerable";
            remunerableDataGridViewCheckBoxColumn.HeaderText = "Remunerable";
            remunerableDataGridViewCheckBoxColumn.MinimumWidth = 24;
            remunerableDataGridViewCheckBoxColumn.Name = "remunerableDataGridViewCheckBoxColumn";
            remunerableDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            remunerableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // F9Inasistencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dgvInasistenciasL);
            Name = "F9Inasistencias";
            ShowIcon = false;
            Load += F9Inasistencias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInasistenciasL).EndInit();
            ((System.ComponentModel.ISupportInitialize)inasistenciasFormDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView dgvInasistenciasL;
        private DataGridViewTextBoxColumn idInasistenciasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresApellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licenciaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreLicenciaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn remunerableDataGridViewCheckBoxColumn;
        private BindingSource inasistenciasFormDTOBindingSource;
    }
}