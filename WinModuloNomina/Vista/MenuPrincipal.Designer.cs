
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
            btnMenu = new FontAwesome.Sharp.IconButton();
            panelLogo2 = new Panel();
            labelTitulo = new Label();
            panel3 = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            panelMenu = new FlowLayoutPanel();
            panel2 = new Panel();
            btnPuestos = new FontAwesome.Sharp.IconButton();
            btnEmpleados = new FontAwesome.Sharp.IconButton();
            btnContratos = new FontAwesome.Sharp.IconButton();
            btnAsistencias = new FontAwesome.Sharp.IconButton();
            btnBonos = new FontAwesome.Sharp.IconButton();
            btnDescuentos = new FontAwesome.Sharp.IconButton();
            btnNomina = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnVacaciones = new FontAwesome.Sharp.IconButton();
            panelEscritorio = new Panel();
            label3 = new Label();
            panelLogo2.SuspendLayout();
            panel3.SuspendLayout();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panelEscritorio.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(6, -3);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(5, 0, 0, 0);
            btnMenu.Size = new Size(211, 80);
            btnMenu.TabIndex = 2;
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelLogo2
            // 
            panelLogo2.BackColor = SystemColors.HotTrack;
            panelLogo2.Controls.Add(labelTitulo);
            panelLogo2.Controls.Add(panel3);
            panelLogo2.Dock = DockStyle.Top;
            panelLogo2.Location = new Point(220, 0);
            panelLogo2.Name = "panelLogo2";
            panelLogo2.Size = new Size(963, 80);
            panelLogo2.TabIndex = 4;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(422, 28);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(159, 20);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "HOME S.NOMINA";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCerrar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(98, 80);
            panel3.TabIndex = 5;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnCerrar.IconColor = Color.Gainsboro;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.Location = new Point(6, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(85, 60);
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 6;
            label2.Text = "MENU";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.HotTrack;
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(btnPuestos);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(btnContratos);
            panelMenu.Controls.Add(btnAsistencias);
            panelMenu.Controls.Add(btnBonos);
            panelMenu.Controls.Add(btnDescuentos);
            panelMenu.Controls.Add(btnNomina);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnVacaciones);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 696);
            panelMenu.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnMenu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 77);
            panel2.TabIndex = 0;
            // 
            // btnPuestos
            // 
            btnPuestos.BackColor = Color.Transparent;
            btnPuestos.FlatAppearance.BorderSize = 0;
            btnPuestos.FlatStyle = FlatStyle.Flat;
            btnPuestos.Font = new Font("Microsoft Sans Serif", 9F);
            btnPuestos.ForeColor = Color.Gainsboro;
            btnPuestos.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            btnPuestos.IconColor = Color.Gainsboro;
            btnPuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPuestos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPuestos.Location = new Point(0, 83);
            btnPuestos.Margin = new Padding(0);
            btnPuestos.Name = "btnPuestos";
            btnPuestos.Padding = new Padding(14, 0, 0, 0);
            btnPuestos.Size = new Size(220, 60);
            btnPuestos.TabIndex = 5;
            btnPuestos.Text = "    Puestos";
            btnPuestos.TextAlign = ContentAlignment.MiddleLeft;
            btnPuestos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPuestos.UseVisualStyleBackColor = false;
            btnPuestos.Click += btnPuestos_Click_1;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 9F);
            btnEmpleados.ForeColor = Color.Gainsboro;
            btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            btnEmpleados.IconColor = Color.Gainsboro;
            btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(0, 143);
            btnEmpleados.Margin = new Padding(0);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(14, 0, 0, 0);
            btnEmpleados.Size = new Size(220, 60);
            btnEmpleados.TabIndex = 6;
            btnEmpleados.Text = "    Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnContratos
            // 
            btnContratos.BackColor = Color.Transparent;
            btnContratos.FlatAppearance.BorderSize = 0;
            btnContratos.FlatStyle = FlatStyle.Flat;
            btnContratos.Font = new Font("Microsoft Sans Serif", 9F);
            btnContratos.ForeColor = Color.Gainsboro;
            btnContratos.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            btnContratos.IconColor = Color.Gainsboro;
            btnContratos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContratos.ImageAlign = ContentAlignment.MiddleLeft;
            btnContratos.Location = new Point(0, 203);
            btnContratos.Margin = new Padding(0);
            btnContratos.Name = "btnContratos";
            btnContratos.Padding = new Padding(14, 0, 0, 0);
            btnContratos.Size = new Size(220, 60);
            btnContratos.TabIndex = 7;
            btnContratos.Text = "    Contratos";
            btnContratos.TextAlign = ContentAlignment.MiddleLeft;
            btnContratos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContratos.UseVisualStyleBackColor = false;
            btnContratos.Click += btnContratos_Click;
            // 
            // btnAsistencias
            // 
            btnAsistencias.BackColor = Color.Transparent;
            btnAsistencias.FlatAppearance.BorderSize = 0;
            btnAsistencias.FlatStyle = FlatStyle.Flat;
            btnAsistencias.Font = new Font("Microsoft Sans Serif", 9F);
            btnAsistencias.ForeColor = Color.Gainsboro;
            btnAsistencias.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            btnAsistencias.IconColor = Color.Gainsboro;
            btnAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsistencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.Location = new Point(0, 263);
            btnAsistencias.Margin = new Padding(0);
            btnAsistencias.Name = "btnAsistencias";
            btnAsistencias.Padding = new Padding(14, 0, 0, 0);
            btnAsistencias.Size = new Size(220, 60);
            btnAsistencias.TabIndex = 8;
            btnAsistencias.Text = "    Asistencias";
            btnAsistencias.TextAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsistencias.UseVisualStyleBackColor = false;
            btnAsistencias.Click += btnAsistencias_Click;
            // 
            // btnBonos
            // 
            btnBonos.BackColor = Color.Transparent;
            btnBonos.FlatAppearance.BorderSize = 0;
            btnBonos.FlatStyle = FlatStyle.Flat;
            btnBonos.Font = new Font("Microsoft Sans Serif", 9F);
            btnBonos.ForeColor = Color.Gainsboro;
            btnBonos.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            btnBonos.IconColor = Color.Gainsboro;
            btnBonos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBonos.ImageAlign = ContentAlignment.MiddleLeft;
            btnBonos.Location = new Point(0, 323);
            btnBonos.Margin = new Padding(0);
            btnBonos.Name = "btnBonos";
            btnBonos.Padding = new Padding(14, 0, 0, 0);
            btnBonos.Size = new Size(220, 60);
            btnBonos.TabIndex = 9;
            btnBonos.Text = "    Bonos";
            btnBonos.TextAlign = ContentAlignment.MiddleLeft;
            btnBonos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBonos.UseVisualStyleBackColor = false;
            btnBonos.Click += btnBonos_Click;
            // 
            // btnDescuentos
            // 
            btnDescuentos.BackColor = Color.Transparent;
            btnDescuentos.FlatAppearance.BorderSize = 0;
            btnDescuentos.FlatStyle = FlatStyle.Flat;
            btnDescuentos.Font = new Font("Microsoft Sans Serif", 9F);
            btnDescuentos.ForeColor = Color.Gainsboro;
            btnDescuentos.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            btnDescuentos.IconColor = Color.Gainsboro;
            btnDescuentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescuentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnDescuentos.Location = new Point(0, 383);
            btnDescuentos.Margin = new Padding(0);
            btnDescuentos.Name = "btnDescuentos";
            btnDescuentos.Padding = new Padding(14, 0, 0, 0);
            btnDescuentos.Size = new Size(220, 60);
            btnDescuentos.TabIndex = 10;
            btnDescuentos.Text = "    Descuentos";
            btnDescuentos.TextAlign = ContentAlignment.MiddleLeft;
            btnDescuentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDescuentos.UseVisualStyleBackColor = false;
            btnDescuentos.Click += btnDescuentos_Click;
            // 
            // btnNomina
            // 
            btnNomina.BackColor = Color.Transparent;
            btnNomina.FlatAppearance.BorderSize = 0;
            btnNomina.FlatStyle = FlatStyle.Flat;
            btnNomina.Font = new Font("Microsoft Sans Serif", 9F);
            btnNomina.ForeColor = Color.Gainsboro;
            btnNomina.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnNomina.IconColor = Color.Gainsboro;
            btnNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNomina.ImageAlign = ContentAlignment.MiddleLeft;
            btnNomina.Location = new Point(0, 443);
            btnNomina.Margin = new Padding(0);
            btnNomina.Name = "btnNomina";
            btnNomina.Padding = new Padding(14, 0, 0, 0);
            btnNomina.Size = new Size(220, 60);
            btnNomina.TabIndex = 11;
            btnNomina.Text = "    Nomina";
            btnNomina.TextAlign = ContentAlignment.MiddleLeft;
            btnNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNomina.UseVisualStyleBackColor = false;
            btnNomina.Click += btnNomina_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Transparent;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Microsoft Sans Serif", 9F);
            btnReportes.ForeColor = Color.Gainsboro;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnReportes.IconColor = Color.Gainsboro;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 503);
            btnReportes.Margin = new Padding(0);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(14, 0, 0, 0);
            btnReportes.Size = new Size(220, 60);
            btnReportes.TabIndex = 12;
            btnReportes.Text = "    Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVacaciones
            // 
            btnVacaciones.BackColor = Color.Transparent;
            btnVacaciones.FlatAppearance.BorderSize = 0;
            btnVacaciones.FlatStyle = FlatStyle.Flat;
            btnVacaciones.Font = new Font("Microsoft Sans Serif", 9F);
            btnVacaciones.ForeColor = Color.Gainsboro;
            btnVacaciones.IconChar = FontAwesome.Sharp.IconChar.Hourglass2;
            btnVacaciones.IconColor = Color.Gainsboro;
            btnVacaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVacaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnVacaciones.Location = new Point(0, 563);
            btnVacaciones.Margin = new Padding(0);
            btnVacaciones.Name = "btnVacaciones";
            btnVacaciones.Padding = new Padding(14, 0, 0, 0);
            btnVacaciones.Size = new Size(220, 60);
            btnVacaciones.TabIndex = 13;
            btnVacaciones.Text = "    Vacaciones";
            btnVacaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnVacaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVacaciones.UseVisualStyleBackColor = false;
            btnVacaciones.Click += btnVacaciones_Click;
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = Color.DimGray;
            panelEscritorio.Controls.Add(label3);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(220, 80);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(963, 616);
            panelEscritorio.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(240, 243);
            label3.Name = "label3";
            label3.Size = new Size(509, 69);
            label3.TabIndex = 0;
            label3.Text = "DR. SOLUTIONS";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1183, 696);
            Controls.Add(panelEscritorio);
            Controls.Add(panelLogo2);
            Controls.Add(panelMenu);
            Name = "MenuPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += MenuPrincipal_Load;
            panelLogo2.ResumeLayout(false);
            panelLogo2.PerformLayout();
            panel3.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
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

        private FontAwesome.Sharp.IconButton btnMenu;
        private Panel panelLogo2;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Label labelTitulo;
        private Panel panel3;
        private Label label2;
        private FlowLayoutPanel panelMenu;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnPuestos;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnContratos;
        private FontAwesome.Sharp.IconButton btnAsistencias;
        private FontAwesome.Sharp.IconButton btnBonos;
        private FontAwesome.Sharp.IconButton btnDescuentos;
        private FontAwesome.Sharp.IconButton btnNomina;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnVacaciones;
        private Panel panelEscritorio;
        private Label label3;
    }
}