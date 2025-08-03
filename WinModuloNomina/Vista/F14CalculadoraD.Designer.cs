namespace WinModuloNomina.Vista
{
    partial class F14CalculadoraD
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
            cbdiasfaltados = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            cbSalario = new ComboBox();
            montoLb = new Label();
            montoTxt = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            idEmpleadoCb = new ComboBox();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tipoTxt = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbdiasfaltados
            // 
            cbdiasfaltados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbdiasfaltados.FormattingEnabled = true;
            cbdiasfaltados.Location = new Point(170, 34);
            cbdiasfaltados.Name = "cbdiasfaltados";
            cbdiasfaltados.Size = new Size(161, 28);
            cbdiasfaltados.TabIndex = 47;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 44;
            label2.Text = "Cantidad faltas";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 67);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 45;
            label5.Text = "Salario Emp..";
            // 
            // cbSalario
            // 
            cbSalario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbSalario.FormattingEnabled = true;
            cbSalario.Location = new Point(170, 65);
            cbSalario.Name = "cbSalario";
            cbSalario.Size = new Size(161, 28);
            cbSalario.TabIndex = 46;
            // 
            // montoLb
            // 
            montoLb.Anchor = AnchorStyles.Left;
            montoLb.AutoSize = true;
            montoLb.Location = new Point(3, 99);
            montoLb.Name = "montoLb";
            montoLb.Size = new Size(53, 20);
            montoLb.TabIndex = 43;
            montoLb.Text = "Monto";
            // 
            // montoTxt
            // 
            montoTxt.Location = new Point(170, 96);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(161, 27);
            montoTxt.TabIndex = 48;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusMinus;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(49, 76);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(331, 26);
            iconButton1.TabIndex = 49;
            iconButton1.Text = "Calcular click";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // idEmpleadoCb
            // 
            idEmpleadoCb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idEmpleadoCb.FormattingEnabled = true;
            idEmpleadoCb.Location = new Point(170, 3);
            idEmpleadoCb.Name = "idEmpleadoCb";
            idEmpleadoCb.Size = new Size(161, 28);
            idEmpleadoCb.TabIndex = 50;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 5);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 51;
            label4.Text = "Empleado";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(idEmpleadoCb, 1, 0);
            tableLayoutPanel1.Controls.Add(montoTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(montoLb, 0, 3);
            tableLayoutPanel1.Controls.Add(cbSalario, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(cbdiasfaltados, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(49, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(334, 125);
            tableLayoutPanel1.TabIndex = 52;
            // 
            // tipoTxt
            // 
            tipoTxt.FormattingEnabled = true;
            tipoTxt.Location = new Point(512, 77);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(151, 28);
            tipoTxt.TabIndex = 53;
            // 
            // F14CalculadoraD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tipoTxt);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(iconButton1);
            Name = "F14CalculadoraD";
            Text = "F14CalculadoraD";
            Load += F14CalculadoraD_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbdiasfaltados;
        private Label label2;
        private Label label5;
        private ComboBox cbSalario;
        private Label montoLb;
        private TextBox montoTxt;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ComboBox idEmpleadoCb;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox tipoTxt;
    }
}