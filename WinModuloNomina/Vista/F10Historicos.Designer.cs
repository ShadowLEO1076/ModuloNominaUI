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
            dgvHistoricos = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricos).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricos
            // 
            dgvHistoricos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoricos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            ResumeLayout(false);
        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView dgvHistoricos;
        private DataGridViewTextBoxColumn horasJornadaDataGridViewTextBoxColumn;
    }
}