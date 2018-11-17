namespace AdjustablePolygon
{
    partial class DrawingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StartAngleNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountOfAnglesNumeric = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RADnumeric = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartAngleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfAnglesNumeric)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RADnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RADnumeric);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StartAngleNumeric);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AmountOfAnglesNumeric);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 93);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начальный угол";
            // 
            // StartAngleNumeric
            // 
            this.StartAngleNumeric.Location = new System.Drawing.Point(202, 47);
            this.StartAngleNumeric.Maximum = new decimal(new int[] {
            395,
            0,
            0,
            0});
            this.StartAngleNumeric.Name = "StartAngleNumeric";
            this.StartAngleNumeric.Size = new System.Drawing.Size(70, 20);
            this.StartAngleNumeric.TabIndex = 2;
            this.StartAngleNumeric.ValueChanged += new System.EventHandler(this.StartAngleNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество углов";
            // 
            // AmountOfAnglesNumeric
            // 
            this.AmountOfAnglesNumeric.Location = new System.Drawing.Point(202, 21);
            this.AmountOfAnglesNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.AmountOfAnglesNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.AmountOfAnglesNumeric.Name = "AmountOfAnglesNumeric";
            this.AmountOfAnglesNumeric.Size = new System.Drawing.Size(70, 20);
            this.AmountOfAnglesNumeric.TabIndex = 0;
            this.AmountOfAnglesNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.AmountOfAnglesNumeric.ValueChanged += new System.EventHandler(this.AmountOfAnglesNumeric_ValueChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.DrawingPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.26273F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.73727F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(780, 526);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(3, 3);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(774, 421);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            this.DrawingPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseWheel);
            this.DrawingPanel.Resize += new System.EventHandler(this.DrawingPanel_Resize);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Радиус описанной окружности";
            // 
            // RADnumeric
            // 
            this.RADnumeric.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.RADnumeric.Location = new System.Drawing.Point(496, 32);
            this.RADnumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RADnumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RADnumeric.Name = "RADnumeric";
            this.RADnumeric.Size = new System.Drawing.Size(99, 20);
            this.RADnumeric.TabIndex = 5;
            this.RADnumeric.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.RADnumeric.ValueChanged += new System.EventHandler(this.RADnumeric_ValueChanged);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 526);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DrawingForm";
            this.Text = "Polly";
            this.Load += new System.EventHandler(this.DrawingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartAngleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfAnglesNumeric)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RADnumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AmountOfAnglesNumeric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown StartAngleNumeric;
        private System.Windows.Forms.NumericUpDown RADnumeric;
        private System.Windows.Forms.Label label3;
    }
}

