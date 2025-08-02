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
            panelVentanas = new Panel();
            asistenciasFormBtn = new FontAwesome.Sharp.IconButton();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelControl.BackColor = SystemColors.HotTrack;
            panelControl.Controls.Add(asistenciasFormBtn);
            panelControl.Dock = DockStyle.Left;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(143, 450);
            panelControl.TabIndex = 0;
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
            // asistenciasFormBtn
            // 
            asistenciasFormBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            asistenciasFormBtn.BackColor = Color.Transparent;
            asistenciasFormBtn.FlatStyle = FlatStyle.Flat;
            asistenciasFormBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            asistenciasFormBtn.ForeColor = Color.WhiteSmoke;
            asistenciasFormBtn.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            asistenciasFormBtn.IconColor = Color.WhiteSmoke;
            asistenciasFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            asistenciasFormBtn.IconSize = 30;
            asistenciasFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            asistenciasFormBtn.Location = new Point(0, 47);
            asistenciasFormBtn.Name = "asistenciasFormBtn";
            asistenciasFormBtn.Size = new Size(143, 80);
            asistenciasFormBtn.TabIndex = 0;
            asistenciasFormBtn.Text = "Asistencia";
            asistenciasFormBtn.UseVisualStyleBackColor = false;
            asistenciasFormBtn.Click += asistenciasFormBtn_Click;
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
    }
}