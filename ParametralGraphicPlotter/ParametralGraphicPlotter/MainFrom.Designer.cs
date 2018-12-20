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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ytext = new System.Windows.Forms.TextBox();
            this.Xtext = new System.Windows.Forms.TextBox();
            this.NewFunc = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Ytext);
            this.panel2.Controls.Add(this.Xtext);
            this.panel2.Controls.Add(this.NewFunc);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(594, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 444);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "y(t)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "x(t)";
            // 
            // Ytext
            // 
            this.Ytext.Location = new System.Drawing.Point(43, 66);
            this.Ytext.Name = "Ytext";
            this.Ytext.Size = new System.Drawing.Size(151, 20);
            this.Ytext.TabIndex = 6;
            this.Ytext.Text = "Sin(t)";
            // 
            // Xtext
            // 
            this.Xtext.Location = new System.Drawing.Point(43, 40);
            this.Xtext.Name = "Xtext";
            this.Xtext.Size = new System.Drawing.Size(151, 20);
            this.Xtext.TabIndex = 5;
            this.Xtext.Text = "Cos(t)";
            // 
            // NewFunc
            // 
            this.NewFunc.Location = new System.Drawing.Point(79, 106);
            this.NewFunc.Name = "NewFunc";
            this.NewFunc.Size = new System.Drawing.Size(75, 39);
            this.NewFunc.TabIndex = 3;
            this.NewFunc.Text = "New function";
            this.NewFunc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LineColorButton);
            this.groupBox1.Controls.Add(this.BackColorButton);
            this.groupBox1.Location = new System.Drawing.Point(66, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change color";
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
        private System.Windows.Forms.Button NewFunc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ytext;
        private System.Windows.Forms.TextBox Xtext;
    }
}

