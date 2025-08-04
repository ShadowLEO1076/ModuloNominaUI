namespace WinModuloNomina.Vista
{
    partial class F15FaltasD
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
            label7 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            dateTimePicker1 = new DateTimePicker();
            dgvDescuentosF = new Zuby.ADGV.AdvancedDataGridView();
            btndescontar = new FontAwesome.Sharp.IconButton();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentosF).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(830, 47);
            panel3.TabIndex = 24;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(270, 9);
            label7.Name = "label7";
            label7.Size = new Size(297, 18);
            label7.TabIndex = 2;
            label7.Text = "Generar Descuentos por Inasistencias";
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top;
            iconButton2.BackColor = Color.SandyBrown;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            iconButton2.ForeColor = Color.WhiteSmoke;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(181, 119);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(12, 0, 0, 0);
            iconButton2.Size = new Size(227, 60);
            iconButton2.TabIndex = 31;
            iconButton2.Text = "Buscar Todos";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CustomFormat = "MM - yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(329, 71);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(197, 27);
            dateTimePicker1.TabIndex = 30;
            dateTimePicker1.Value = new DateTime(2025, 7, 21, 20, 56, 31, 0);
            // 
            // dgvDescuentosF
            // 
            dgvDescuentosF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDescuentosF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescuentosF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentosF.FilterAndSortEnabled = true;
            dgvDescuentosF.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvDescuentosF.Location = new Point(0, 207);
            dgvDescuentosF.MaxFilterButtonImageHeight = 23;
            dgvDescuentosF.Name = "dgvDescuentosF";
            dgvDescuentosF.RightToLeft = RightToLeft.No;
            dgvDescuentosF.RowHeadersWidth = 51;
            dgvDescuentosF.Size = new Size(830, 325);
            dgvDescuentosF.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvDescuentosF.TabIndex = 32;
            // 
            // btndescontar
            // 
            btndescontar.Anchor = AnchorStyles.Top;
            btndescontar.BackColor = Color.RoyalBlue;
            btndescontar.FlatAppearance.BorderSize = 0;
            btndescontar.FlatStyle = FlatStyle.Flat;
            btndescontar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btndescontar.ForeColor = Color.WhiteSmoke;
            btndescontar.IconChar = FontAwesome.Sharp.IconChar.Skull;
            btndescontar.IconColor = Color.White;
            btndescontar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btndescontar.ImageAlign = ContentAlignment.MiddleLeft;
            btndescontar.Location = new Point(430, 119);
            btndescontar.Name = "btndescontar";
            btndescontar.Padding = new Padding(12, 0, 0, 0);
            btndescontar.Size = new Size(227, 60);
            btndescontar.TabIndex = 33;
            btndescontar.Text = "Generar Todos";
            btndescontar.TextAlign = ContentAlignment.MiddleLeft;
            btndescontar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndescontar.UseVisualStyleBackColor = false;
            btndescontar.Click += btndescontar_Click;
            // 
            // F15FaltasD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 532);
            Controls.Add(btndescontar);
            Controls.Add(dgvDescuentosF);
            Controls.Add(iconButton2);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel3);
            Name = "F15FaltasD";
            Text = "F15FaltasD";
            Load += F15FaltasD_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentosF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DateTimePicker dateTimePicker1;
        private Zuby.ADGV.AdvancedDataGridView dgvDescuentosF;
        private FontAwesome.Sharp.IconButton btndescontar;
    }
}