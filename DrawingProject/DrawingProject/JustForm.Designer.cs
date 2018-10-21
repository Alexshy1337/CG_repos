namespace DrawingProject
{
    partial class JustForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.X0Y0Value = new System.Windows.Forms.NumericUpDown();
            this.HeightValue = new System.Windows.Forms.NumericUpDown();
            this.JBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartAngleValue = new System.Windows.Forms.NumericUpDown();
            this.SweepAngleValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WuRadioButton = new System.Windows.Forms.RadioButton();
            this.BresenhamRadioButton = new System.Windows.Forms.RadioButton();
            this.EllipseRadioButton = new System.Windows.Forms.RadioButton();
            this.PieRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X0Y0Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartAngleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SweepAngleValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DPanel
            // 
            this.DPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DPanel.Location = new System.Drawing.Point(3, 96);
            this.DPanel.Name = "DPanel";
            this.DPanel.Size = new System.Drawing.Size(939, 493);
            this.DPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.82418F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.17583F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 592);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(633, 35);
            this.WidthValue.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.WidthValue.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.WidthValue.Name = "WidthValue";
            this.WidthValue.Size = new System.Drawing.Size(66, 20);
            this.WidthValue.TabIndex = 3;
            this.WidthValue.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // X0Y0Value
            // 
            this.X0Y0Value.Location = new System.Drawing.Point(633, 11);
            this.X0Y0Value.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.X0Y0Value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.X0Y0Value.Name = "X0Y0Value";
            this.X0Y0Value.Size = new System.Drawing.Size(66, 20);
            this.X0Y0Value.TabIndex = 2;
            this.X0Y0Value.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(633, 61);
            this.HeightValue.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.HeightValue.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(66, 20);
            this.HeightValue.TabIndex = 4;
            this.HeightValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // JBtn
            // 
            this.JBtn.Location = new System.Drawing.Point(340, 20);
            this.JBtn.Name = "JBtn";
            this.JBtn.Size = new System.Drawing.Size(109, 43);
            this.JBtn.TabIndex = 1;
            this.JBtn.Text = "Draw";
            this.JBtn.UseVisualStyleBackColor = true;
            this.JBtn.Click += new System.EventHandler(this.JBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SweepAngleValue);
            this.panel1.Controls.Add(this.StartAngleValue);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.JBtn);
            this.panel1.Controls.Add(this.HeightValue);
            this.panel1.Controls.Add(this.X0Y0Value);
            this.panel1.Controls.Add(this.WidthValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 87);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Отсутуп от (0,0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Высота";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BresenhamRadioButton);
            this.groupBox1.Controls.Add(this.WuRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(82, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // StartAngleValue
            // 
            this.StartAngleValue.Location = new System.Drawing.Point(840, 21);
            this.StartAngleValue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.StartAngleValue.Name = "StartAngleValue";
            this.StartAngleValue.Size = new System.Drawing.Size(63, 20);
            this.StartAngleValue.TabIndex = 9;
            this.StartAngleValue.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // SweepAngleValue
            // 
            this.SweepAngleValue.Location = new System.Drawing.Point(840, 48);
            this.SweepAngleValue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.SweepAngleValue.Name = "SweepAngleValue";
            this.SweepAngleValue.Size = new System.Drawing.Size(63, 20);
            this.SweepAngleValue.TabIndex = 10;
            this.SweepAngleValue.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Начальный угол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Конечный угол";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PieRadioButton);
            this.groupBox2.Controls.Add(this.EllipseRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(185, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(67, 75);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // WuRadioButton
            // 
            this.WuRadioButton.AutoSize = true;
            this.WuRadioButton.Location = new System.Drawing.Point(6, 42);
            this.WuRadioButton.Name = "WuRadioButton";
            this.WuRadioButton.Size = new System.Drawing.Size(42, 17);
            this.WuRadioButton.TabIndex = 0;
            this.WuRadioButton.Text = "Wu";
            this.WuRadioButton.UseVisualStyleBackColor = true;
            // 
            // BresenhamRadioButton
            // 
            this.BresenhamRadioButton.AutoSize = true;
            this.BresenhamRadioButton.Checked = true;
            this.BresenhamRadioButton.Location = new System.Drawing.Point(6, 19);
            this.BresenhamRadioButton.Name = "BresenhamRadioButton";
            this.BresenhamRadioButton.Size = new System.Drawing.Size(78, 17);
            this.BresenhamRadioButton.TabIndex = 1;
            this.BresenhamRadioButton.TabStop = true;
            this.BresenhamRadioButton.Text = "Bresenham";
            this.BresenhamRadioButton.UseMnemonic = false;
            this.BresenhamRadioButton.UseVisualStyleBackColor = true;
            // 
            // EllipseRadioButton
            // 
            this.EllipseRadioButton.AutoSize = true;
            this.EllipseRadioButton.Checked = true;
            this.EllipseRadioButton.Location = new System.Drawing.Point(6, 20);
            this.EllipseRadioButton.Name = "EllipseRadioButton";
            this.EllipseRadioButton.Size = new System.Drawing.Size(55, 17);
            this.EllipseRadioButton.TabIndex = 0;
            this.EllipseRadioButton.TabStop = true;
            this.EllipseRadioButton.Text = "Ellipse";
            this.EllipseRadioButton.UseVisualStyleBackColor = true;
            // 
            // PieRadioButton
            // 
            this.PieRadioButton.AutoSize = true;
            this.PieRadioButton.Location = new System.Drawing.Point(6, 43);
            this.PieRadioButton.Name = "PieRadioButton";
            this.PieRadioButton.Size = new System.Drawing.Size(40, 17);
            this.PieRadioButton.TabIndex = 1;
            this.PieRadioButton.Text = "Pie";
            this.PieRadioButton.UseVisualStyleBackColor = true;
            // 
            // JustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JustForm";
            this.Text = "cherries on top of the cake";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X0Y0Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartAngleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SweepAngleValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton PieRadioButton;
        private System.Windows.Forms.RadioButton EllipseRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SweepAngleValue;
        private System.Windows.Forms.NumericUpDown StartAngleValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BresenhamRadioButton;
        private System.Windows.Forms.RadioButton WuRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button JBtn;
        private System.Windows.Forms.NumericUpDown HeightValue;
        private System.Windows.Forms.NumericUpDown X0Y0Value;
        private System.Windows.Forms.NumericUpDown WidthValue;
    }
}

