namespace WinModuloNomina.Vista
{
    partial class LoginForm
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
            panel1 = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtContraseña = new TextBox();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtCedula = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 364);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(21, 267);
            label1.Name = "label1";
            label1.Size = new Size(245, 36);
            label1.TabIndex = 1;
            label1.Text = "DR. SOLUTIONS";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = SystemColors.HotTrack;
            iconPictureBox1.ForeColor = Color.Gainsboro;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Keycdn;
            iconPictureBox1.IconColor = Color.Gainsboro;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 198;
            iconPictureBox1.Location = new Point(46, 38);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(198, 201);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnIngresar);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(286, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 364);
            panel2.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LightCoral;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnCerrar.IconColor = Color.Black;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(248, 265);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(12, 0, 0, 0);
            btnCerrar.Size = new Size(143, 57);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Ingresar";
            btnCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.SteelBlue;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(67, 265);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Padding = new Padding(12, 0, 0, 0);
            btnIngresar.Size = new Size(143, 57);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(txtContraseña, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Location = new Point(48, 139);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(360, 82);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(3, 44);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(354, 27);
            txtContraseña.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(100, 18);
            label3.TabIndex = 0;
            label3.Text = "Contraseña:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtCedula, 0, 1);
            tableLayoutPanel1.Location = new Point(48, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(360, 82);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 0;
            label2.Text = "Usuario:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(3, 44);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(354, 27);
            txtCedula.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 364);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtContraseña;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox txtCedula;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}