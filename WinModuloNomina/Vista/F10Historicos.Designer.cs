namespace WinModuloNomina.Vista
{
    partial class F10Historicos
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
            dgvHistoricos = new Zuby.ADGV.AdvancedDataGridView();
            contratosHistoricoDTOBindingSource = new BindingSource(components);
            idHistoricoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idContratoOriginalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaInicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaCreacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaModificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasJornadaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioCambioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaRegistroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosHistoricoDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricos
            // 
            dgvHistoricos.AutoGenerateColumns = false;
            dgvHistoricos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoricos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricos.Columns.AddRange(new DataGridViewColumn[] { idHistoricoDataGridViewTextBoxColumn, idContratoOriginalDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, tipoIdDataGridViewTextBoxColumn, fechaInicioDataGridViewTextBoxColumn, fechaFinDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, fechaCreacionDataGridViewTextBoxColumn, fechaModificacionDataGridViewTextBoxColumn, horasJornadaDataGridViewTextBoxColumn, usuarioCambioDataGridViewTextBoxColumn, fechaRegistroDataGridViewTextBoxColumn });
            dgvHistoricos.DataSource = contratosHistoricoDTOBindingSource;
            dgvHistoricos.Dock = DockStyle.Fill;
            dgvHistoricos.FilterAndSortEnabled = true;
            dgvHistoricos.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistoricos.Location = new Point(0, 0);
            dgvHistoricos.MaxFilterButtonImageHeight = 23;
            dgvHistoricos.Name = "dgvHistoricos";
            dgvHistoricos.RightToLeft = RightToLeft.No;
            dgvHistoricos.RowHeadersWidth = 51;
            dgvHistoricos.Size = new Size(800, 450);
            dgvHistoricos.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvHistoricos.TabIndex = 23;
            // 
            // contratosHistoricoDTOBindingSource
            // 
            contratosHistoricoDTOBindingSource.DataSource = typeof(Aplicacion.DTO.DTOs.ContratosHistoricoDTO);
            // 
            // idHistoricoDataGridViewTextBoxColumn
            // 
            idHistoricoDataGridViewTextBoxColumn.DataPropertyName = "IdHistorico";
            idHistoricoDataGridViewTextBoxColumn.HeaderText = "IdHistorico";
            idHistoricoDataGridViewTextBoxColumn.MinimumWidth = 24;
            idHistoricoDataGridViewTextBoxColumn.Name = "idHistoricoDataGridViewTextBoxColumn";
            idHistoricoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // idContratoOriginalDataGridViewTextBoxColumn
            // 
            idContratoOriginalDataGridViewTextBoxColumn.DataPropertyName = "IdContratoOriginal";
            idContratoOriginalDataGridViewTextBoxColumn.HeaderText = "IdContratoOriginal";
            idContratoOriginalDataGridViewTextBoxColumn.MinimumWidth = 24;
            idContratoOriginalDataGridViewTextBoxColumn.Name = "idContratoOriginalDataGridViewTextBoxColumn";
            idContratoOriginalDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // tipoIdDataGridViewTextBoxColumn
            // 
            tipoIdDataGridViewTextBoxColumn.DataPropertyName = "TipoId";
            tipoIdDataGridViewTextBoxColumn.HeaderText = "TipoId";
            tipoIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            tipoIdDataGridViewTextBoxColumn.Name = "tipoIdDataGridViewTextBoxColumn";
            tipoIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            fechaInicioDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            fechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin";
            fechaFinDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            fechaFinDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.MinimumWidth = 24;
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            salarioDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 24;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            fechaCreacionDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            fechaModificacionDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // horasJornadaDataGridViewTextBoxColumn
            // 
            horasJornadaDataGridViewTextBoxColumn.DataPropertyName = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.HeaderText = "HorasJornada";
            horasJornadaDataGridViewTextBoxColumn.MinimumWidth = 24;
            horasJornadaDataGridViewTextBoxColumn.Name = "horasJornadaDataGridViewTextBoxColumn";
            horasJornadaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // usuarioCambioDataGridViewTextBoxColumn
            // 
            usuarioCambioDataGridViewTextBoxColumn.DataPropertyName = "UsuarioCambio";
            usuarioCambioDataGridViewTextBoxColumn.HeaderText = "UsuarioCambio";
            usuarioCambioDataGridViewTextBoxColumn.MinimumWidth = 24;
            usuarioCambioDataGridViewTextBoxColumn.Name = "usuarioCambioDataGridViewTextBoxColumn";
            usuarioCambioDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            fechaRegistroDataGridViewTextBoxColumn.MinimumWidth = 24;
            fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            fechaRegistroDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // F10Historicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHistoricos);
            Name = "F10Historicos";
            Text = "F10Historicos";
            Load += F10Historicos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricos).EndInit();
            ((System.ComponentModel.ISupportInitialize)contratosHistoricoDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView dgvHistoricos;
        private DataGridViewTextBoxColumn idHistoricoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idContratoOriginalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasJornadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioCambioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private BindingSource contratosHistoricoDTOBindingSource;
    }
}