namespace ParametralGraphicPlotter
{
    partial class MainFrom
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlottingPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartT = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.NumericUpDown();
            this.EndT = new System.Windows.Forms.NumericUpDown();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ytext = new System.Windows.Forms.TextBox();
            this.Xtext = new System.Windows.Forms.TextBox();
            this.NewFunc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AxisColorButton = new System.Windows.Forms.Button();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.MyColorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.125F));
            this.tableLayoutPanel1.Controls.Add(this.PlottingPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PlottingPanel
            // 
            this.PlottingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlottingPanel.Location = new System.Drawing.Point(3, 3);
            this.PlottingPanel.Name = "PlottingPanel";
            this.PlottingPanel.Size = new System.Drawing.Size(720, 597);
            this.PlottingPanel.TabIndex = 0;
            this.PlottingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlottingPanel_Paint);
            this.PlottingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlottingPanel_MouseClick);
            this.PlottingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlottingPanel_MouseDown);
            this.PlottingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlottingPanel_MouseMove);
            this.PlottingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlottingPanel_MouseUp);
            this.PlottingPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PlottingPanel_MouseWheel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.ErrorLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Ytext);
            this.panel2.Controls.Add(this.Xtext);
            this.panel2.Controls.Add(this.NewFunc);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(729, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 597);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.StartT);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Step);
            this.groupBox3.Controls.Add(this.EndT);
            this.groupBox3.Location = new System.Drawing.Point(16, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 109);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Start";
            // 
            // StartT
            // 
            this.StartT.Location = new System.Drawing.Point(41, 20);
            this.StartT.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StartT.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.StartT.Name = "StartT";
            this.StartT.Size = new System.Drawing.Size(61, 20);
            this.StartT.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Step";
            // 
            // Step
            // 
            this.Step.DecimalPlaces = 4;
            this.Step.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Step.Location = new System.Drawing.Point(40, 72);
            this.Step.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(62, 20);
            this.Step.TabIndex = 9;
            this.Step.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // EndT
            // 
            this.EndT.Location = new System.Drawing.Point(41, 46);
            this.EndT.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.EndT.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.EndT.Name = "EndT";
            this.EndT.Size = new System.Drawing.Size(61, 20);
            this.EndT.TabIndex = 13;
            this.EndT.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(129, 272);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "y(t)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "x(t)";
            // 
            // Ytext
            // 
            this.Ytext.Location = new System.Drawing.Point(64, 239);
            this.Ytext.Name = "Ytext";
            this.Ytext.Size = new System.Drawing.Size(151, 20);
            this.Ytext.TabIndex = 6;
            this.Ytext.Text = "20*t*Sin(t)";
            // 
            // Xtext
            // 
            this.Xtext.Location = new System.Drawing.Point(64, 213);
            this.Xtext.Name = "Xtext";
            this.Xtext.Size = new System.Drawing.Size(151, 20);
            this.Xtext.TabIndex = 5;
            this.Xtext.Text = "20*t*Cos(t)";
            // 
            // NewFunc
            // 
            this.NewFunc.Location = new System.Drawing.Point(100, 301);
            this.NewFunc.Name = "NewFunc";
            this.NewFunc.Size = new System.Drawing.Size(75, 39);
            this.NewFunc.TabIndex = 3;
            this.NewFunc.Text = "New function";
            this.NewFunc.UseVisualStyleBackColor = true;
            this.NewFunc.Click += new System.EventHandler(this.NewFunc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AxisColorButton);
            this.groupBox1.Controls.Add(this.LineColorButton);
            this.groupBox1.Controls.Add(this.BackColorButton);
            this.groupBox1.Location = new System.Drawing.Point(135, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change color";
            // 
            // AxisColorButton
            // 
            this.AxisColorButton.Location = new System.Drawing.Point(13, 80);
            this.AxisColorButton.Name = "AxisColorButton";
            this.AxisColorButton.Size = new System.Drawing.Size(77, 23);
            this.AxisColorButton.TabIndex = 2;
            this.AxisColorButton.Text = "Axes";
            this.AxisColorButton.UseVisualStyleBackColor = true;
            this.AxisColorButton.Click += new System.EventHandler(this.AxisColorButton_Click);
            // 
            // LineColorButton
            // 
            this.LineColorButton.Location = new System.Drawing.Point(13, 52);
            this.LineColorButton.Name = "LineColorButton";
            this.LineColorButton.Size = new System.Drawing.Size(77, 23);
            this.LineColorButton.TabIndex = 1;
            this.LineColorButton.Text = "Line";
            this.LineColorButton.UseVisualStyleBackColor = true;
            this.LineColorButton.Click += new System.EventHandler(this.LineColorButton_Click);
            // 
            // BackColorButton
            // 
            this.BackColorButton.Location = new System.Drawing.Point(13, 24);
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(77, 22);
            this.BackColorButton.TabIndex = 0;
            this.BackColorButton.Text = "Background";
            this.BackColorButton.UseVisualStyleBackColor = true;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainFrom";
            this.Text = "Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PlottingPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog MyColorDialog;
        private System.Windows.Forms.Button LineColorButton;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.Button NewFunc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ytext;
        private System.Windows.Forms.TextBox Xtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Step;
        private System.Windows.Forms.Button AxisColorButton;
        private System.Windows.Forms.NumericUpDown StartT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown EndT;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

