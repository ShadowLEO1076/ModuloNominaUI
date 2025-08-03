namespace WinModuloNomina.Vista
{
    partial class F4AsistenciasMenu
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
            panelControl = new Panel();
            historialBtn = new FontAwesome.Sharp.IconButton();
            asistenciasFormBtn = new FontAwesome.Sharp.IconButton();
            panelVentanas = new Panel();
            historialInasBtn = new FontAwesome.Sharp.IconButton();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelControl.BackColor = SystemColors.HotTrack;
            panelControl.Controls.Add(historialInasBtn);
            panelControl.Controls.Add(historialBtn);
            panelControl.Controls.Add(asistenciasFormBtn);
            panelControl.Dock = DockStyle.Left;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(143, 450);
            panelControl.TabIndex = 0;
            // 
            // historialBtn
            // 
            historialBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            historialBtn.BackColor = Color.Transparent;
            historialBtn.FlatStyle = FlatStyle.Flat;
            historialBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            historialBtn.ForeColor = Color.Transparent;
            historialBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            historialBtn.IconColor = Color.WhiteSmoke;
            historialBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            historialBtn.IconSize = 30;
            historialBtn.ImageAlign = ContentAlignment.MiddleLeft;
            historialBtn.Location = new Point(0, 68);
            historialBtn.Name = "historialBtn";
            historialBtn.Size = new Size(143, 56);
            historialBtn.TabIndex = 1;
            historialBtn.Text = "Historial Asistencias";
            historialBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            historialBtn.UseVisualStyleBackColor = false;
            historialBtn.Click += historialBtn_Click;
            // 
            // asistenciasFormBtn
            // 
            asistenciasFormBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            asistenciasFormBtn.BackColor = Color.Transparent;
            asistenciasFormBtn.FlatStyle = FlatStyle.Flat;
            asistenciasFormBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            asistenciasFormBtn.ForeColor = Color.Transparent;
            asistenciasFormBtn.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            asistenciasFormBtn.IconColor = Color.WhiteSmoke;
            asistenciasFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            asistenciasFormBtn.IconSize = 30;
            asistenciasFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            asistenciasFormBtn.Location = new Point(0, 12);
            asistenciasFormBtn.Name = "asistenciasFormBtn";
            asistenciasFormBtn.Size = new Size(143, 56);
            asistenciasFormBtn.TabIndex = 0;
            asistenciasFormBtn.Text = "Asistencia";
            asistenciasFormBtn.UseVisualStyleBackColor = false;
            asistenciasFormBtn.Click += asistenciasFormBtn_Click;
            // 
            // panelVentanas
            // 
            panelVentanas.BackColor = Color.FromArgb(64, 64, 64);
            panelVentanas.Dock = DockStyle.Fill;
            panelVentanas.Location = new Point(143, 0);
            panelVentanas.Name = "panelVentanas";
            panelVentanas.Size = new Size(657, 450);
            panelVentanas.TabIndex = 1;
            // 
            // historialInasBtn
            // 
            historialInasBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            historialInasBtn.BackColor = Color.Transparent;
            historialInasBtn.FlatStyle = FlatStyle.Flat;
            historialInasBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            historialInasBtn.ForeColor = Color.Transparent;
            historialInasBtn.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            historialInasBtn.IconColor = Color.WhiteSmoke;
            historialInasBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            historialInasBtn.IconSize = 30;
            historialInasBtn.ImageAlign = ContentAlignment.MiddleLeft;
            historialInasBtn.Location = new Point(0, 124);
            historialInasBtn.Name = "historialInasBtn";
            historialInasBtn.Size = new Size(143, 56);
            historialInasBtn.TabIndex = 2;
            historialInasBtn.Text = "Historial Inasistencias";
            historialInasBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            historialInasBtn.UseVisualStyleBackColor = false;
            historialInasBtn.Click += historialInasBtn_Click;
            // 
            // F4AsistenciasMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelVentanas);
            Controls.Add(panelControl);
            Name = "F4AsistenciasMenu";
            Text = "F4AsistenciasMenu";
            panelControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private Panel panelVentanas;
        private FontAwesome.Sharp.IconButton asistenciasFormBtn;
        private FontAwesome.Sharp.IconButton historialBtn;
        private FontAwesome.Sharp.IconButton historialInasBtn;
    }
}