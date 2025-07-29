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
            dgvInasistenciasL = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInasistenciasL).BeginInit();
            SuspendLayout();
            // 
            // dgvInasistenciasL
            // 
            dgvInasistenciasL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInasistenciasL.FilterAndSortEnabled = true;
            dgvInasistenciasL.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvInasistenciasL.Location = new Point(64, 76);
            dgvInasistenciasL.MaxFilterButtonImageHeight = 23;
            dgvInasistenciasL.Name = "dgvInasistenciasL";
            dgvInasistenciasL.RightToLeft = RightToLeft.No;
            dgvInasistenciasL.RowHeadersWidth = 51;
            dgvInasistenciasL.Size = new Size(672, 298);
            dgvInasistenciasL.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvInasistenciasL.TabIndex = 1;
            // 
            // F9Inasistencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvInasistenciasL);
            Name = "F9Inasistencias";
            Text = "F9Inasistencias";
            Load += F9Inasistencias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInasistenciasL).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView dgvInasistenciasL;
    }
}