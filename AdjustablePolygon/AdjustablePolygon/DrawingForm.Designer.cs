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
            this.ActionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountOfAnglesNumeric = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfAnglesNumeric)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ActionButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LengthNumeric);
            this.panel1.Controls.Add(this.InfoLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AmountOfAnglesNumeric);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 67);
            this.panel1.TabIndex = 1;
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(250, 24);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(79, 23);
            this.ActionButton.TabIndex = 5;
            this.ActionButton.Text = "Нарисовать";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Длина отрезка";
            // 
            // LengthNumeric
            // 
            this.LengthNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LengthNumeric.Location = new System.Drawing.Point(139, 26);
            this.LengthNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LengthNumeric.Name = "LengthNumeric";
            this.LengthNumeric.Size = new System.Drawing.Size(81, 20);
            this.LengthNumeric.TabIndex = 3;
            this.LengthNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(374, 29);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(35, 13);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество углов";
            // 
            // AmountOfAnglesNumeric
            // 
            this.AmountOfAnglesNumeric.Location = new System.Drawing.Point(12, 27);
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
            this.AmountOfAnglesNumeric.Size = new System.Drawing.Size(94, 20);
            this.AmountOfAnglesNumeric.TabIndex = 0;
            this.AmountOfAnglesNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
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
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.77778F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.22222F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(3, 3);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(794, 371);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DrawingForm";
            this.Text = "hard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfAnglesNumeric)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AmountOfAnglesNumeric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LengthNumeric;
        private System.Windows.Forms.Button ActionButton;
    }
}

