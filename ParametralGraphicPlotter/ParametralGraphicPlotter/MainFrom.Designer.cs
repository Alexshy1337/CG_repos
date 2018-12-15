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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.MyColorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PlottingPanel
            // 
            this.PlottingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlottingPanel.Location = new System.Drawing.Point(3, 3);
            this.PlottingPanel.Name = "PlottingPanel";
            this.PlottingPanel.Size = new System.Drawing.Size(585, 444);
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(594, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 444);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Function?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LineColorButton);
            this.groupBox1.Controls.Add(this.BackColorButton);
            this.groupBox1.Location = new System.Drawing.Point(27, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change color";
            // 
            // LineColorButton
            // 
            this.LineColorButton.Location = new System.Drawing.Point(31, 51);
            this.LineColorButton.Name = "LineColorButton";
            this.LineColorButton.Size = new System.Drawing.Size(77, 23);
            this.LineColorButton.TabIndex = 1;
            this.LineColorButton.Text = "Line";
            this.LineColorButton.UseVisualStyleBackColor = true;
            this.LineColorButton.Click += new System.EventHandler(this.LineColorButton_Click);
            // 
            // BackColorButton
            // 
            this.BackColorButton.Location = new System.Drawing.Point(31, 23);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainFrom";
            this.Text = "Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

