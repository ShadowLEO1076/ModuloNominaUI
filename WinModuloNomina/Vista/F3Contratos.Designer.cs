namespace WinModuloNomina.Vista
{
    partial class F3Contratos
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
            contratosTipoBindingSource = new BindingSource(components);
            contratosDTOBindingSource = new BindingSource(components);
            panelMostrar = new Panel();
            label3 = new Label();
            panel38 = new Panel();
            btnHistorico = new FontAwesome.Sharp.IconButton();
            btnContratoG = new FontAwesome.Sharp.IconButton();
            btnTipos = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contratosDTOBindingSource).BeginInit();
            panelMostrar.SuspendLayout();
            panel38.SuspendLayout();
            SuspendLayout();
            // 
            // panelMostrar
            // 
            panelMostrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMostrar.Controls.Add(label3);
            panelMostrar.Location = new Point(201, 31);
            panelMostrar.Name = "panelMostrar";
            panelMostrar.Size = new Size(662, 561);
            panelMostrar.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(77, 246);
            label3.Name = "label3";
            label3.Size = new Size(509, 69);
            label3.TabIndex = 1;
            label3.Text = "DR. SOLUTIONS";
            // 
            // panel38
            // 
            panel38.BackColor = SystemColors.HotTrack;
            panel38.Controls.Add(btnHistorico);
            panel38.Controls.Add(panel1);
            panel38.Controls.Add(btnTipos);
            panel38.Controls.Add(btnContratoG);
            panel38.Dock = DockStyle.Left;
            panel38.Location = new Point(0, 0);
            panel38.Name = "panel38";
            panel38.Size = new Size(181, 623);
            panel38.TabIndex = 21;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.Transparent;
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnHistorico.ForeColor = Color.WhiteSmoke;
            btnHistorico.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            btnHistorico.IconColor = Color.WhiteSmoke;
            btnHistorico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHistorico.IconSize = 30;
            btnHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorico.Location = new Point(0, 155);
            btnHistorico.Margin = new Padding(0);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Padding = new Padding(14, 0, 0, 0);
            btnHistorico.Size = new Size(181, 60);
            btnHistorico.TabIndex = 8;
            btnHistorico.Text = "  Historicos";
            btnHistorico.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorico.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnContratoG
            // 
            btnContratoG.BackColor = Color.Transparent;
            btnContratoG.FlatAppearance.BorderSize = 0;
            btnContratoG.FlatStyle = FlatStyle.Flat;
            btnContratoG.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnContratoG.ForeColor = Color.WhiteSmoke;
            btnContratoG.IconChar = FontAwesome.Sharp.IconChar.FeatherPointed;
            btnContratoG.IconColor = Color.WhiteSmoke;
            btnContratoG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContratoG.IconSize = 30;
            btnContratoG.ImageAlign = ContentAlignment.MiddleLeft;
            btnContratoG.Location = new Point(0, 95);
            btnContratoG.Margin = new Padding(0);
            btnContratoG.Name = "btnContratoG";
            btnContratoG.Padding = new Padding(14, 0, 0, 0);
            btnContratoG.Size = new Size(181, 60);
            btnContratoG.TabIndex = 7;
            btnContratoG.Text = "  Contratos";
            btnContratoG.TextAlign = ContentAlignment.MiddleLeft;
            btnContratoG.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContratoG.UseVisualStyleBackColor = false;
            btnContratoG.Click += btnContratoG_Click;
            // 
            // btnTipos
            // 
            btnTipos.BackColor = Color.Transparent;
            btnTipos.FlatAppearance.BorderSize = 0;
            btnTipos.FlatStyle = FlatStyle.Flat;
            btnTipos.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnTipos.ForeColor = Color.WhiteSmoke;
            btnTipos.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnTipos.IconColor = Color.WhiteSmoke;
            btnTipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTipos.IconSize = 30;
            btnTipos.ImageAlign = ContentAlignment.MiddleLeft;
            btnTipos.Location = new Point(0, 35);
            btnTipos.Margin = new Padding(0);
            btnTipos.Name = "btnTipos";
            btnTipos.Padding = new Padding(14, 0, 0, 0);
            btnTipos.Size = new Size(181, 60);
            btnTipos.TabIndex = 6;
            btnTipos.Text = "  Tipos";
            btnTipos.TextAlign = ContentAlignment.MiddleLeft;
            btnTipos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTipos.UseVisualStyleBackColor = false;
            btnTipos.Click += btnTipos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 593);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 30);
            panel1.TabIndex = 0;
            // 
            // F3Contratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(886, 623);
            Controls.Add(panel38);
            Controls.Add(panelMostrar);
            Name = "F3Contratos";
            Text = "F3Contratos";
            Load += F3Contratos_Load;
            ((System.ComponentModel.ISupportInitialize)contratosTipoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contratosDTOBindingSource).EndInit();
            panelMostrar.ResumeLayout(false);
            panelMostrar.PerformLayout();
            panel38.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn idContratoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasJornadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jornadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private BindingSource contratosTipoBindingSource;
        private DataGridViewTextBoxColumn fechaIniciocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFincDataGridViewTextBoxColumn;
        private BindingSource contratosDTOBindingSource;
        private Panel panelMostrar;
        private Panel panel38;
        private FontAwesome.Sharp.IconButton btnTipos;
        private FontAwesome.Sharp.IconButton btnHistorico;
        private FontAwesome.Sharp.IconButton btnContratoG;
        private Label label3;
        private Panel panel1;
    }
}