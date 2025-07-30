namespace WinModuloNomina.Vista
{
    partial class F4Asistencias
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
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            registroLb = new Label();
            registroCb = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            nomEmpleLb2 = new Label();
            licenciaLb = new Label();
            nombreEmpleadoLbl = new Label();
            licenciaCb = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            empleLb = new Label();
            fecLb = new Label();
            entradaLb = new Label();
            salidaLb = new Label();
            empleCb = new ComboBox();
            fecAsisDtp = new DateTimePicker();
            horaEntraDtp = new DateTimePicker();
            horaSaliDtp = new DateTimePicker();
            asisLb = new Label();
            idAsisTxt = new TextBox();
            limpiarBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            EliminarBtn = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            actualizarBtn = new FontAwesome.Sharp.IconButton();
            ingresarBtn = new FontAwesome.Sharp.IconButton();
            infoLb = new Label();
            label11 = new Label();
            asistenciasFormDTOBindingSource = new BindingSource(components);
            inasisDgv = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            asistenciasDgv = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)asistenciasFormDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inasisDgv).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)asistenciasDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(limpiarBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(infoLb);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 166);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(registroLb, 0, 0);
            tableLayoutPanel4.Controls.Add(registroCb, 0, 1);
            tableLayoutPanel4.Location = new Point(16, 36);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 46.42857F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 53.57143F));
            tableLayoutPanel4.Size = new Size(170, 56);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // registroLb
            // 
            registroLb.AutoSize = true;
            registroLb.Location = new Point(3, 0);
            registroLb.Name = "registroLb";
            registroLb.Size = new Size(69, 15);
            registroLb.TabIndex = 0;
            registroLb.Text = "Registro de:";
            // 
            // registroCb
            // 
            registroCb.FormattingEnabled = true;
            registroCb.Location = new Point(3, 29);
            registroCb.Name = "registroCb";
            registroCb.Size = new Size(164, 23);
            registroCb.TabIndex = 1;
            registroCb.SelectedIndexChanged += registroCb_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.61702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.38298F));
            tableLayoutPanel2.Controls.Add(nomEmpleLb2, 0, 1);
            tableLayoutPanel2.Controls.Add(licenciaLb, 0, 0);
            tableLayoutPanel2.Controls.Add(nombreEmpleadoLbl, 1, 1);
            tableLayoutPanel2.Controls.Add(licenciaCb, 1, 0);
            tableLayoutPanel2.Location = new Point(718, 36);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(282, 54);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // nomEmpleLb2
            // 
            nomEmpleLb2.AutoSize = true;
            nomEmpleLb2.Location = new Point(3, 31);
            nomEmpleLb2.Name = "nomEmpleLb2";
            nomEmpleLb2.Size = new Size(107, 15);
            nomEmpleLb2.TabIndex = 17;
            nomEmpleLb2.Text = "Nombre Empleado";
            nomEmpleLb2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // licenciaLb
            // 
            licenciaLb.AutoSize = true;
            licenciaLb.Location = new Point(3, 0);
            licenciaLb.Name = "licenciaLb";
            licenciaLb.Size = new Size(64, 15);
            licenciaLb.TabIndex = 29;
            licenciaLb.Text = "ID Licencia";
            // 
            // nombreEmpleadoLbl
            // 
            nombreEmpleadoLbl.AutoSize = true;
            nombreEmpleadoLbl.Location = new Point(126, 31);
            nombreEmpleadoLbl.Name = "nombreEmpleadoLbl";
            nombreEmpleadoLbl.Size = new Size(0, 15);
            nombreEmpleadoLbl.TabIndex = 16;
            // 
            // licenciaCb
            // 
            licenciaCb.FormattingEnabled = true;
            licenciaCb.Location = new Point(126, 2);
            licenciaCb.Margin = new Padding(3, 2, 3, 2);
            licenciaCb.Name = "licenciaCb";
            licenciaCb.Size = new Size(153, 23);
            licenciaCb.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2201271F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.77988F));
            tableLayoutPanel1.Controls.Add(empleLb, 0, 1);
            tableLayoutPanel1.Controls.Add(fecLb, 0, 2);
            tableLayoutPanel1.Controls.Add(entradaLb, 0, 3);
            tableLayoutPanel1.Controls.Add(salidaLb, 0, 4);
            tableLayoutPanel1.Controls.Add(empleCb, 1, 1);
            tableLayoutPanel1.Controls.Add(fecAsisDtp, 1, 2);
            tableLayoutPanel1.Controls.Add(horaEntraDtp, 1, 3);
            tableLayoutPanel1.Controls.Add(horaSaliDtp, 1, 4);
            tableLayoutPanel1.Controls.Add(asisLb, 0, 0);
            tableLayoutPanel1.Controls.Add(idAsisTxt, 1, 0);
            tableLayoutPanel1.Location = new Point(249, 36);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(450, 124);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // empleLb
            // 
            empleLb.AutoSize = true;
            empleLb.Location = new Point(3, 24);
            empleLb.Name = "empleLb";
            empleLb.Size = new Size(100, 15);
            empleLb.TabIndex = 18;
            empleLb.Text = "Cédula Empleado";
            // 
            // fecLb
            // 
            fecLb.AutoSize = true;
            fecLb.Location = new Point(3, 48);
            fecLb.Name = "fecLb";
            fecLb.Size = new Size(94, 15);
            fecLb.TabIndex = 20;
            fecLb.Text = "Fecha Asistencia";
            // 
            // entradaLb
            // 
            entradaLb.AutoSize = true;
            entradaLb.Location = new Point(3, 72);
            entradaLb.Name = "entradaLb";
            entradaLb.Size = new Size(92, 15);
            entradaLb.TabIndex = 22;
            entradaLb.Text = "Hora de entrada";
            // 
            // salidaLb
            // 
            salidaLb.AutoSize = true;
            salidaLb.Location = new Point(3, 96);
            salidaLb.Name = "salidaLb";
            salidaLb.Size = new Size(82, 15);
            salidaLb.TabIndex = 24;
            salidaLb.Text = "Hora de salida";
            // 
            // empleCb
            // 
            empleCb.FormattingEnabled = true;
            empleCb.Location = new Point(228, 26);
            empleCb.Margin = new Padding(3, 2, 3, 2);
            empleCb.Name = "empleCb";
            empleCb.Size = new Size(216, 23);
            empleCb.TabIndex = 25;
            empleCb.SelectedIndexChanged += EmpleCb_SelectedIndexChanged;
            // 
            // fecAsisDtp
            // 
            fecAsisDtp.Format = DateTimePickerFormat.Short;
            fecAsisDtp.Location = new Point(228, 50);
            fecAsisDtp.Margin = new Padding(3, 2, 3, 2);
            fecAsisDtp.Name = "fecAsisDtp";
            fecAsisDtp.Size = new Size(216, 23);
            fecAsisDtp.TabIndex = 26;
            // 
            // horaEntraDtp
            // 
            horaEntraDtp.Format = DateTimePickerFormat.Time;
            horaEntraDtp.Location = new Point(228, 74);
            horaEntraDtp.Margin = new Padding(3, 2, 3, 2);
            horaEntraDtp.Name = "horaEntraDtp";
            horaEntraDtp.Size = new Size(216, 23);
            horaEntraDtp.TabIndex = 27;
            // 
            // horaSaliDtp
            // 
            horaSaliDtp.Format = DateTimePickerFormat.Time;
            horaSaliDtp.Location = new Point(228, 98);
            horaSaliDtp.Margin = new Padding(3, 2, 3, 2);
            horaSaliDtp.Name = "horaSaliDtp";
            horaSaliDtp.Size = new Size(216, 23);
            horaSaliDtp.TabIndex = 28;
            // 
            // asisLb
            // 
            asisLb.AutoSize = true;
            asisLb.Location = new Point(3, 0);
            asisLb.Name = "asisLb";
            asisLb.Size = new Size(74, 15);
            asisLb.TabIndex = 7;
            asisLb.Text = "ID Asistencia";
            // 
            // idAsisTxt
            // 
            idAsisTxt.Location = new Point(228, 2);
            idAsisTxt.Margin = new Padding(3, 2, 3, 2);
            idAsisTxt.Name = "idAsisTxt";
            idAsisTxt.ReadOnly = true;
            idAsisTxt.Size = new Size(216, 23);
            idAsisTxt.TabIndex = 7;
            // 
            // limpiarBtn
            // 
            limpiarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            limpiarBtn.IconColor = Color.Black;
            limpiarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiarBtn.Location = new Point(829, 132);
            limpiarBtn.Margin = new Padding(3, 2, 3, 2);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(102, 21);
            limpiarBtn.TabIndex = 13;
            limpiarBtn.Text = "Limpiar datos";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(EliminarBtn);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(actualizarBtn);
            panel2.Controls.Add(ingresarBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1043, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 166);
            panel2.TabIndex = 4;
            // 
            // EliminarBtn
            // 
            EliminarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            EliminarBtn.IconColor = Color.Black;
            EliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EliminarBtn.Location = new Point(16, 97);
            EliminarBtn.Margin = new Padding(3, 2, 3, 2);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(72, 29);
            EliminarBtn.TabIndex = 12;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            EliminarBtn.Click += EliminarBtn_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(16, 136);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(72, 22);
            iconButton2.TabIndex = 10;
            iconButton2.Text = "Buscar";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Visible = false;
            // 
            // actualizarBtn
            // 
            actualizarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            actualizarBtn.IconColor = Color.Black;
            actualizarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            actualizarBtn.Location = new Point(16, 65);
            actualizarBtn.Margin = new Padding(3, 2, 3, 2);
            actualizarBtn.Name = "actualizarBtn";
            actualizarBtn.Size = new Size(72, 28);
            actualizarBtn.TabIndex = 11;
            actualizarBtn.Text = "Actualizar";
            actualizarBtn.UseVisualStyleBackColor = true;
            actualizarBtn.Click += actualizarBtn_Click;
            // 
            // ingresarBtn
            // 
            ingresarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            ingresarBtn.IconColor = Color.Black;
            ingresarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ingresarBtn.Location = new Point(16, 34);
            ingresarBtn.Margin = new Padding(3, 2, 3, 2);
            ingresarBtn.Name = "ingresarBtn";
            ingresarBtn.Size = new Size(72, 28);
            ingresarBtn.TabIndex = 9;
            ingresarBtn.Text = "Ingresar";
            ingresarBtn.UseVisualStyleBackColor = true;
            ingresarBtn.Click += ingresarBtn_Click;
            // 
            // infoLb
            // 
            infoLb.AutoSize = true;
            infoLb.Location = new Point(16, 18);
            infoLb.Name = "infoLb";
            infoLb.Size = new Size(144, 15);
            infoLb.TabIndex = 6;
            infoLb.Text = "CONTROL DE ASISTENCIA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 7);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 5;
            // 
            // inasisDgv
            // 
            inasisDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inasisDgv.Dock = DockStyle.Fill;
            inasisDgv.Location = new Point(3, 91);
            inasisDgv.Margin = new Padding(3, 2, 3, 2);
            inasisDgv.Name = "inasisDgv";
            inasisDgv.Size = new Size(1153, 79);
            inasisDgv.TabIndex = 9;
            inasisDgv.CellClick += inasisDgv_CellClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(inasisDgv, 0, 1);
            tableLayoutPanel3.Controls.Add(asistenciasDgv, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 166);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 51.7441864F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 48.2558136F));
            tableLayoutPanel3.Size = new Size(1159, 172);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // asistenciasDgv
            // 
            asistenciasDgv.AutoGenerateColumns = false;
            asistenciasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            asistenciasDgv.DataSource = asistenciasFormDTOBindingSource;
            asistenciasDgv.Dock = DockStyle.Fill;
            asistenciasDgv.Location = new Point(3, 3);
            asistenciasDgv.Name = "asistenciasDgv";
            asistenciasDgv.Size = new Size(1153, 83);
            asistenciasDgv.TabIndex = 10;
            asistenciasDgv.CellClick += asistenciasDgv_CellClick;
            // 
            // F4Asistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 338);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "F4Asistencias";
            Text = "F4Asistencias";
            Load += F4Asistencias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)asistenciasFormDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inasisDgv).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)asistenciasDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton EliminarBtn;
        private FontAwesome.Sharp.IconButton actualizarBtn;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton ingresarBtn;
        private Label label11;
        private DataGridViewTextBoxColumn idAsistenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresApellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaSalidaDataGridViewTextBoxColumn;
        private BindingSource asistenciasFormDTOBindingSource;
        private Label infoLb;
        private TableLayoutPanel tableLayoutPanel1;
        private Label asisLb;
        private TextBox idAsisTxt;
        private Label empleLb;
        private Label fecLb;
        private Label entradaLb;
        private Label salidaLb;
        private ComboBox empleCb;
        private DateTimePicker fecAsisDtp;
        private DateTimePicker horaEntraDtp;
        private DateTimePicker horaSaliDtp;
        private FontAwesome.Sharp.IconButton limpiarBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label licenciaLb;
        private ComboBox licenciaCb;
        private DataGridView inasisDgv;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView asistenciasDgv;
        private TableLayoutPanel tableLayoutPanel4;
        private Label registroLb;
        private ComboBox registroCb;
        private Label nomEmpleLb2;
        private Label nombreEmpleadoLbl;
    }
}