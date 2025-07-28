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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            licenciaLb = new Label();
            licenciaCb = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            idAsisTxt = new TextBox();
            empleLb = new Label();
            fecLb = new Label();
            entradaLb = new Label();
            salidaLb = new Label();
            empleCb = new ComboBox();
            fecAsisDtp = new DateTimePicker();
            horaEntraDtp = new DateTimePicker();
            horaSaliDtp = new DateTimePicker();
            asisLb = new Label();
            limpiarBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            EliminarBtn = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            actualizarBtn = new FontAwesome.Sharp.IconButton();
            ingresarBtn = new FontAwesome.Sharp.IconButton();
            infoLb = new Label();
            label11 = new Label();
            asistenciasDgv = new DataGridView();
            asistenciasFormDTOBindingSource = new BindingSource(components);
            inasisDgv = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)asistenciasDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)asistenciasFormDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inasisDgv).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.5555573F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.44444F));
            tableLayoutPanel2.Controls.Add(licenciaLb, 0, 0);
            tableLayoutPanel2.Controls.Add(licenciaCb, 1, 0);
            tableLayoutPanel2.Location = new Point(604, 24);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(211, 31);
            tableLayoutPanel2.TabIndex = 14;
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
            // licenciaCb
            // 
            licenciaCb.FormattingEnabled = true;
            licenciaCb.Location = new Point(78, 2);
            licenciaCb.Margin = new Padding(3, 2, 3, 2);
            licenciaCb.Name = "licenciaCb";
            licenciaCb.Size = new Size(121, 23);
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
            tableLayoutPanel1.Controls.Add(idAsisTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(empleLb, 0, 1);
            tableLayoutPanel1.Controls.Add(fecLb, 0, 2);
            tableLayoutPanel1.Controls.Add(entradaLb, 0, 3);
            tableLayoutPanel1.Controls.Add(salidaLb, 0, 4);
            tableLayoutPanel1.Controls.Add(empleCb, 1, 1);
            tableLayoutPanel1.Controls.Add(fecAsisDtp, 1, 2);
            tableLayoutPanel1.Controls.Add(horaEntraDtp, 1, 3);
            tableLayoutPanel1.Controls.Add(horaSaliDtp, 1, 4);
            tableLayoutPanel1.Controls.Add(asisLb, 0, 0);
            tableLayoutPanel1.Location = new Point(48, 24);
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
            tableLayoutPanel1.Size = new Size(529, 129);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // idAsisTxt
            // 
            idAsisTxt.Location = new Point(267, 2);
            idAsisTxt.Margin = new Padding(3, 2, 3, 2);
            idAsisTxt.Name = "idAsisTxt";
            idAsisTxt.ReadOnly = true;
            idAsisTxt.Size = new Size(216, 23);
            idAsisTxt.TabIndex = 7;
            // 
            // empleLb
            // 
            empleLb.AutoSize = true;
            empleLb.Location = new Point(3, 25);
            empleLb.Name = "empleLb";
            empleLb.Size = new Size(60, 15);
            empleLb.TabIndex = 18;
            empleLb.Text = "Empleado";
            // 
            // fecLb
            // 
            fecLb.AutoSize = true;
            fecLb.Location = new Point(3, 50);
            fecLb.Name = "fecLb";
            fecLb.Size = new Size(94, 15);
            fecLb.TabIndex = 20;
            fecLb.Text = "Fecha Asistencia";
            // 
            // entradaLb
            // 
            entradaLb.AutoSize = true;
            entradaLb.Location = new Point(3, 75);
            entradaLb.Name = "entradaLb";
            entradaLb.Size = new Size(92, 15);
            entradaLb.TabIndex = 22;
            entradaLb.Text = "Hora de entrada";
            // 
            // salidaLb
            // 
            salidaLb.AutoSize = true;
            salidaLb.Location = new Point(3, 100);
            salidaLb.Name = "salidaLb";
            salidaLb.Size = new Size(82, 15);
            salidaLb.TabIndex = 24;
            salidaLb.Text = "Hora de salida";
            // 
            // empleCb
            // 
            empleCb.FormattingEnabled = true;
            empleCb.Location = new Point(267, 27);
            empleCb.Margin = new Padding(3, 2, 3, 2);
            empleCb.Name = "empleCb";
            empleCb.Size = new Size(216, 23);
            empleCb.TabIndex = 25;
            // 
            // fecAsisDtp
            // 
            fecAsisDtp.Format = DateTimePickerFormat.Short;
            fecAsisDtp.Location = new Point(267, 52);
            fecAsisDtp.Margin = new Padding(3, 2, 3, 2);
            fecAsisDtp.Name = "fecAsisDtp";
            fecAsisDtp.Size = new Size(216, 23);
            fecAsisDtp.TabIndex = 26;
            // 
            // horaEntraDtp
            // 
            horaEntraDtp.Format = DateTimePickerFormat.Time;
            horaEntraDtp.Location = new Point(267, 77);
            horaEntraDtp.Margin = new Padding(3, 2, 3, 2);
            horaEntraDtp.Name = "horaEntraDtp";
            horaEntraDtp.Size = new Size(216, 23);
            horaEntraDtp.TabIndex = 27;
            // 
            // horaSaliDtp
            // 
            horaSaliDtp.Format = DateTimePickerFormat.Time;
            horaSaliDtp.Location = new Point(267, 102);
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
            // limpiarBtn
            // 
            limpiarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            limpiarBtn.IconColor = Color.Black;
            limpiarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiarBtn.Location = new Point(630, 126);
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
            panel2.Controls.Add(EliminarBtn);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(actualizarBtn);
            panel2.Controls.Add(ingresarBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1064, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(95, 166);
            panel2.TabIndex = 4;
            // 
            // EliminarBtn
            // 
            EliminarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            EliminarBtn.IconColor = Color.Black;
            EliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EliminarBtn.Location = new Point(11, 92);
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
            iconButton2.Location = new Point(11, 126);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(72, 22);
            iconButton2.TabIndex = 10;
            iconButton2.Text = "Buscar";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // actualizarBtn
            // 
            actualizarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            actualizarBtn.IconColor = Color.Black;
            actualizarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            actualizarBtn.Location = new Point(11, 61);
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
            ingresarBtn.Location = new Point(11, 29);
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
            infoLb.Location = new Point(48, 7);
            infoLb.Name = "infoLb";
            infoLb.Size = new Size(108, 15);
            infoLb.TabIndex = 6;
            infoLb.Text = "DATOS ASISTENCIA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 7);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 5;
            // 
            // asistenciasDgv
            // 
            asistenciasDgv.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            asistenciasDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            asistenciasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            asistenciasDgv.DataSource = asistenciasFormDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            asistenciasDgv.DefaultCellStyle = dataGridViewCellStyle2;
            asistenciasDgv.Dock = DockStyle.Fill;
            asistenciasDgv.Location = new Point(3, 2);
            asistenciasDgv.Margin = new Padding(3, 2, 3, 2);
            asistenciasDgv.Name = "asistenciasDgv";
            asistenciasDgv.RowHeadersWidth = 51;
            asistenciasDgv.Size = new Size(1153, 82);
            asistenciasDgv.TabIndex = 8;
            asistenciasDgv.CellClick += asistenciasDgv_CellClick;
            // 
            // inasisDgv
            // 
            inasisDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inasisDgv.Dock = DockStyle.Fill;
            inasisDgv.Location = new Point(3, 88);
            inasisDgv.Margin = new Padding(3, 2, 3, 2);
            inasisDgv.Name = "inasisDgv";
            inasisDgv.Size = new Size(1153, 82);
            inasisDgv.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(asistenciasDgv, 0, 0);
            tableLayoutPanel3.Controls.Add(inasisDgv, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 166);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1159, 172);
            tableLayoutPanel3.TabIndex = 10;
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)asistenciasDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)asistenciasFormDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inasisDgv).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView asistenciasDgv;
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
    }
}