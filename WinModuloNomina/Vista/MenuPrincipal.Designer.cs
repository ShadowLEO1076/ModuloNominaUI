
namespace WinModuloNomina.Vista
{
    partial class MenuPrincipal
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
            panelLogo2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPuestos = new FontAwesome.Sharp.IconButton();
            btnEmpleados = new FontAwesome.Sharp.IconButton();
            btnContratos = new FontAwesome.Sharp.IconButton();
            btnAsistencias = new FontAwesome.Sharp.IconButton();
            btnDescuentos = new FontAwesome.Sharp.IconButton();
            btnVacaciones = new FontAwesome.Sharp.IconButton();
            btnBonos = new FontAwesome.Sharp.IconButton();
            btnNomina = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            labelTitulo = new Label();
            panelMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panelEscritorio = new Panel();
            label3 = new Label();
            panelLogo2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelEscritorio.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo2
            // 
            panelLogo2.BackColor = SystemColors.HotTrack;
            panelLogo2.Controls.Add(tableLayoutPanel1);
            panelLogo2.Controls.Add(panel3);
            panelLogo2.Dock = DockStyle.Top;
            panelLogo2.Location = new Point(10, 0);
            panelLogo2.Name = "panelLogo2";
            panelLogo2.Size = new Size(1180, 63);
            panelLogo2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(btnPuestos, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEmpleados, 1, 0);
            tableLayoutPanel1.Controls.Add(btnContratos, 2, 0);
            tableLayoutPanel1.Controls.Add(btnAsistencias, 3, 0);
            tableLayoutPanel1.Controls.Add(btnDescuentos, 4, 0);
            tableLayoutPanel1.Controls.Add(btnVacaciones, 7, 0);
            tableLayoutPanel1.Controls.Add(btnBonos, 5, 0);
            tableLayoutPanel1.Controls.Add(btnNomina, 6, 0);
            tableLayoutPanel1.Location = new Point(81, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1087, 46);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // btnPuestos
            // 
            btnPuestos.BackColor = Color.Transparent;
            btnPuestos.Dock = DockStyle.Fill;
            btnPuestos.FlatAppearance.BorderSize = 0;
            btnPuestos.FlatStyle = FlatStyle.Flat;
            btnPuestos.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnPuestos.ForeColor = Color.WhiteSmoke;
            btnPuestos.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            btnPuestos.IconColor = Color.WhiteSmoke;
            btnPuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPuestos.IconSize = 30;
            btnPuestos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPuestos.Location = new Point(0, 0);
            btnPuestos.Margin = new Padding(0);
            btnPuestos.Name = "btnPuestos";
            btnPuestos.Size = new Size(135, 46);
            btnPuestos.TabIndex = 5;
            btnPuestos.Text = "   Puestos";
            btnPuestos.TextAlign = ContentAlignment.MiddleLeft;
            btnPuestos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPuestos.UseVisualStyleBackColor = false;
            btnPuestos.Click += btnPuestos_Click_1;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.Dock = DockStyle.Fill;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnEmpleados.ForeColor = Color.WhiteSmoke;
            btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            btnEmpleados.IconColor = Color.WhiteSmoke;
            btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpleados.IconSize = 30;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(135, 0);
            btnEmpleados.Margin = new Padding(0);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(135, 46);
            btnEmpleados.TabIndex = 6;
            btnEmpleados.Text = "   Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnContratos
            // 
            btnContratos.BackColor = Color.Transparent;
            btnContratos.Dock = DockStyle.Fill;
            btnContratos.FlatAppearance.BorderSize = 0;
            btnContratos.FlatStyle = FlatStyle.Flat;
            btnContratos.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnContratos.ForeColor = Color.WhiteSmoke;
            btnContratos.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            btnContratos.IconColor = Color.WhiteSmoke;
            btnContratos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContratos.IconSize = 30;
            btnContratos.ImageAlign = ContentAlignment.MiddleLeft;
            btnContratos.Location = new Point(270, 0);
            btnContratos.Margin = new Padding(0);
            btnContratos.Name = "btnContratos";
            btnContratos.Size = new Size(135, 46);
            btnContratos.TabIndex = 7;
            btnContratos.Text = "  Contratos";
            btnContratos.TextAlign = ContentAlignment.MiddleLeft;
            btnContratos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContratos.UseVisualStyleBackColor = false;
            btnContratos.Click += btnContratos_Click;
            // 
            // btnAsistencias
            // 
            btnAsistencias.BackColor = Color.Transparent;
            btnAsistencias.Dock = DockStyle.Fill;
            btnAsistencias.FlatAppearance.BorderSize = 0;
            btnAsistencias.FlatStyle = FlatStyle.Flat;
            btnAsistencias.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnAsistencias.ForeColor = Color.WhiteSmoke;
            btnAsistencias.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            btnAsistencias.IconColor = Color.WhiteSmoke;
            btnAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsistencias.IconSize = 30;
            btnAsistencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.Location = new Point(405, 0);
            btnAsistencias.Margin = new Padding(0);
            btnAsistencias.Name = "btnAsistencias";
            btnAsistencias.Size = new Size(135, 46);
            btnAsistencias.TabIndex = 8;
            btnAsistencias.Text = "  Asistencias";
            btnAsistencias.TextAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsistencias.UseVisualStyleBackColor = false;
            btnAsistencias.Click += btnAsistencias_Click;
            // 
            // btnDescuentos
            // 
            btnDescuentos.BackColor = Color.Transparent;
            btnDescuentos.Dock = DockStyle.Fill;
            btnDescuentos.FlatAppearance.BorderSize = 0;
            btnDescuentos.FlatStyle = FlatStyle.Flat;
            btnDescuentos.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnDescuentos.ForeColor = Color.WhiteSmoke;
            btnDescuentos.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            btnDescuentos.IconColor = Color.WhiteSmoke;
            btnDescuentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescuentos.IconSize = 30;
            btnDescuentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnDescuentos.Location = new Point(540, 0);
            btnDescuentos.Margin = new Padding(0);
            btnDescuentos.Name = "btnDescuentos";
            btnDescuentos.Size = new Size(135, 46);
            btnDescuentos.TabIndex = 10;
            btnDescuentos.Text = "  Descuentos";
            btnDescuentos.TextAlign = ContentAlignment.MiddleLeft;
            btnDescuentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDescuentos.UseVisualStyleBackColor = false;
            btnDescuentos.Click += btnDescuentos_Click;
            // 
            // btnVacaciones
            // 
            btnVacaciones.BackColor = Color.Transparent;
            btnVacaciones.Dock = DockStyle.Fill;
            btnVacaciones.FlatAppearance.BorderSize = 0;
            btnVacaciones.FlatStyle = FlatStyle.Flat;
            btnVacaciones.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVacaciones.ForeColor = Color.WhiteSmoke;
            btnVacaciones.IconChar = FontAwesome.Sharp.IconChar.Hourglass2;
            btnVacaciones.IconColor = Color.WhiteSmoke;
            btnVacaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVacaciones.IconSize = 30;
            btnVacaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnVacaciones.Location = new Point(945, 0);
            btnVacaciones.Margin = new Padding(0);
            btnVacaciones.Name = "btnVacaciones";
            btnVacaciones.Size = new Size(142, 46);
            btnVacaciones.TabIndex = 13;
            btnVacaciones.Text = "   Vacaciones";
            btnVacaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnVacaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVacaciones.UseVisualStyleBackColor = false;
            btnVacaciones.Click += btnVacaciones_Click;
            // 
            // btnBonos
            // 
            btnBonos.BackColor = Color.Transparent;
            btnBonos.Dock = DockStyle.Fill;
            btnBonos.FlatAppearance.BorderSize = 0;
            btnBonos.FlatStyle = FlatStyle.Flat;
            btnBonos.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnBonos.ForeColor = Color.WhiteSmoke;
            btnBonos.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            btnBonos.IconColor = Color.WhiteSmoke;
            btnBonos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBonos.IconSize = 30;
            btnBonos.ImageAlign = ContentAlignment.MiddleLeft;
            btnBonos.Location = new Point(675, 0);
            btnBonos.Margin = new Padding(0);
            btnBonos.Name = "btnBonos";
            btnBonos.Size = new Size(135, 46);
            btnBonos.TabIndex = 9;
            btnBonos.Text = "   Bonos";
            btnBonos.TextAlign = ContentAlignment.MiddleLeft;
            btnBonos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBonos.UseVisualStyleBackColor = false;
            btnBonos.Click += btnBonos_Click;
            // 
            // btnNomina
            // 
            btnNomina.BackColor = Color.Transparent;
            btnNomina.Dock = DockStyle.Fill;
            btnNomina.FlatAppearance.BorderSize = 0;
            btnNomina.FlatStyle = FlatStyle.Flat;
            btnNomina.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnNomina.ForeColor = Color.WhiteSmoke;
            btnNomina.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnNomina.IconColor = Color.WhiteSmoke;
            btnNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNomina.IconSize = 30;
            btnNomina.ImageAlign = ContentAlignment.MiddleLeft;
            btnNomina.Location = new Point(810, 0);
            btnNomina.Margin = new Padding(0);
            btnNomina.Name = "btnNomina";
            btnNomina.Size = new Size(135, 46);
            btnNomina.TabIndex = 11;
            btnNomina.Text = "   Nomina";
            btnNomina.TextAlign = ContentAlignment.MiddleLeft;
            btnNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNomina.UseVisualStyleBackColor = false;
            btnNomina.Click += btnNomina_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCerrar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(78, 63);
            panel3.TabIndex = 5;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.WhiteSmoke;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnCerrar.IconColor = Color.WhiteSmoke;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 40;
            btnCerrar.Location = new Point(0, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 60);
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(64, 64, 64);
            labelTitulo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(504, 12);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(159, 20);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "HOME S.NOMINA";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.HotTrack;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.Black;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(10, 706);
            panelMenu.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(10, 696);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 10);
            panel1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1180, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 633);
            panel4.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(labelTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 41);
            panel2.TabIndex = 8;
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = SystemColors.Menu;
            panelEscritorio.Controls.Add(label3);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(10, 104);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(1170, 592);
            panelEscritorio.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(330, 238);
            label3.Name = "label3";
            label3.Size = new Size(509, 69);
            label3.TabIndex = 0;
            label3.Text = "DR. SOLUTIONS";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1190, 706);
            Controls.Add(panelEscritorio);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panelLogo2);
            Controls.Add(panelMenu);
            Name = "MenuPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += MenuPrincipal_Load;
            panelLogo2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelEscritorio.ResumeLayout(false);
            panelEscritorio.PerformLayout();
            ResumeLayout(false);
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panelLogo2;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Label labelTitulo;
        private Panel panel3;
        private FlowLayoutPanel panelMenu;
        private FontAwesome.Sharp.IconButton btnPuestos;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnContratos;
        private FontAwesome.Sharp.IconButton btnBonos;
        private FontAwesome.Sharp.IconButton btnDescuentos;
        private FontAwesome.Sharp.IconButton btnNomina;
        private Panel panel1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnAsistencias;
        private FontAwesome.Sharp.IconButton btnVacaciones;
        private Panel panel2;
        private Panel panelEscritorio;
        private Label label3;
    }
}