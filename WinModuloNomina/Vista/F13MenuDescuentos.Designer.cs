namespace WinModuloNomina.Vista
{
    partial class F13MenuDescuentos
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
            panel38 = new Panel();
            btnCalculadora = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnIndividual = new FontAwesome.Sharp.IconButton();
            btnPorInasistir = new FontAwesome.Sharp.IconButton();
            panelMostrar2 = new Panel();
            label3 = new Label();
            panel38.SuspendLayout();
            panelMostrar2.SuspendLayout();
            SuspendLayout();
            // 
            // panel38
            // 
            panel38.BackColor = SystemColors.HotTrack;
            panel38.Controls.Add(btnCalculadora);
            panel38.Controls.Add(panel1);
            panel38.Controls.Add(btnIndividual);
            panel38.Controls.Add(btnPorInasistir);
            panel38.Dock = DockStyle.Left;
            panel38.Location = new Point(0, 0);
            panel38.Name = "panel38";
            panel38.Size = new Size(181, 660);
            panel38.TabIndex = 22;
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackColor = Color.Transparent;
            btnCalculadora.FlatAppearance.BorderSize = 0;
            btnCalculadora.FlatStyle = FlatStyle.Flat;
            btnCalculadora.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnCalculadora.ForeColor = Color.WhiteSmoke;
            btnCalculadora.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btnCalculadora.IconColor = Color.WhiteSmoke;
            btnCalculadora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalculadora.IconSize = 30;
            btnCalculadora.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalculadora.Location = new Point(0, 155);
            btnCalculadora.Margin = new Padding(0);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Padding = new Padding(14, 0, 0, 0);
            btnCalculadora.Size = new Size(181, 60);
            btnCalculadora.TabIndex = 8;
            btnCalculadora.Text = "  Calculadora";
            btnCalculadora.TextAlign = ContentAlignment.MiddleLeft;
            btnCalculadora.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalculadora.UseVisualStyleBackColor = false;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 630);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 30);
            panel1.TabIndex = 0;
            // 
            // btnIndividual
            // 
            btnIndividual.BackColor = Color.Transparent;
            btnIndividual.FlatAppearance.BorderSize = 0;
            btnIndividual.FlatStyle = FlatStyle.Flat;
            btnIndividual.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnIndividual.ForeColor = Color.WhiteSmoke;
            btnIndividual.IconChar = FontAwesome.Sharp.IconChar.Usd;
            btnIndividual.IconColor = Color.WhiteSmoke;
            btnIndividual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIndividual.IconSize = 30;
            btnIndividual.ImageAlign = ContentAlignment.MiddleLeft;
            btnIndividual.Location = new Point(0, 35);
            btnIndividual.Margin = new Padding(0);
            btnIndividual.Name = "btnIndividual";
            btnIndividual.Padding = new Padding(14, 0, 0, 0);
            btnIndividual.Size = new Size(181, 60);
            btnIndividual.TabIndex = 6;
            btnIndividual.Text = "  Individual";
            btnIndividual.TextAlign = ContentAlignment.MiddleLeft;
            btnIndividual.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIndividual.UseVisualStyleBackColor = false;
            btnIndividual.Click += btnIndividual_Click;
            // 
            // btnPorInasistir
            // 
            btnPorInasistir.BackColor = Color.Transparent;
            btnPorInasistir.FlatAppearance.BorderSize = 0;
            btnPorInasistir.FlatStyle = FlatStyle.Flat;
            btnPorInasistir.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnPorInasistir.ForeColor = Color.WhiteSmoke;
            btnPorInasistir.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            btnPorInasistir.IconColor = Color.WhiteSmoke;
            btnPorInasistir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPorInasistir.IconSize = 30;
            btnPorInasistir.ImageAlign = ContentAlignment.MiddleLeft;
            btnPorInasistir.Location = new Point(0, 95);
            btnPorInasistir.Margin = new Padding(0);
            btnPorInasistir.Name = "btnPorInasistir";
            btnPorInasistir.Padding = new Padding(14, 0, 0, 0);
            btnPorInasistir.Size = new Size(181, 60);
            btnPorInasistir.TabIndex = 7;
            btnPorInasistir.Text = "  Inasistencias";
            btnPorInasistir.TextAlign = ContentAlignment.MiddleLeft;
            btnPorInasistir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPorInasistir.UseVisualStyleBackColor = false;
            btnPorInasistir.Click += btnPorInasistir_Click;
            // 
            // panelMostrar2
            // 
            panelMostrar2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMostrar2.Controls.Add(label3);
            panelMostrar2.Location = new Point(207, 35);
            panelMostrar2.Name = "panelMostrar2";
            panelMostrar2.Size = new Size(721, 593);
            panelMostrar2.TabIndex = 23;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(116, 269);
            label3.Name = "label3";
            label3.Size = new Size(509, 69);
            label3.TabIndex = 1;
            label3.Text = "DR. SOLUTIONS";
            // 
            // F13MenuDescuentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(951, 660);
            Controls.Add(panelMostrar2);
            Controls.Add(panel38);
            Name = "F13MenuDescuentos";
            Text = "F13MenuDescuentos";
            Load += F13MenuDescuentos_Load;
            panel38.ResumeLayout(false);
            panelMostrar2.ResumeLayout(false);
            panelMostrar2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel38;
        private FontAwesome.Sharp.IconButton btnCalculadora;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnIndividual;
        private FontAwesome.Sharp.IconButton btnPorInasistir;
        private Panel panelMostrar2;
        private Label label3;
    }
}