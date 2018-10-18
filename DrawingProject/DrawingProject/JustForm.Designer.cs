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
            this.JBtn = new System.Windows.Forms.Button();
            this.X0Y0Value = new System.Windows.Forms.NumericUpDown();
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.HeightValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.X0Y0Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).BeginInit();
            this.SuspendLayout();
            // 
            // DPanel
            // 
            this.DPanel.Location = new System.Drawing.Point(2, 43);
            this.DPanel.Name = "DPanel";
            this.DPanel.Size = new System.Drawing.Size(795, 395);
            this.DPanel.TabIndex = 0;
            // 
            // JBtn
            // 
            this.JBtn.Location = new System.Drawing.Point(23, 12);
            this.JBtn.Name = "JBtn";
            this.JBtn.Size = new System.Drawing.Size(75, 23);
            this.JBtn.TabIndex = 1;
            this.JBtn.Text = "Draw";
            this.JBtn.UseVisualStyleBackColor = true;
            this.JBtn.Click += new System.EventHandler(this.JBtn_Click);
            // 
            // X0Y0Value
            // 
            this.X0Y0Value.Location = new System.Drawing.Point(127, 15);
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
            1,
            0,
            0,
            0});
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(209, 15);
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
            this.WidthValue.Size = new System.Drawing.Size(73, 20);
            this.WidthValue.TabIndex = 3;
            this.WidthValue.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(302, 14);
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
            this.HeightValue.Size = new System.Drawing.Size(78, 20);
            this.HeightValue.TabIndex = 4;
            this.HeightValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // JustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeightValue);
            this.Controls.Add(this.WidthValue);
            this.Controls.Add(this.X0Y0Value);
            this.Controls.Add(this.JBtn);
            this.Controls.Add(this.DPanel);
            this.Name = "JustForm";
            this.Text = "cherries on top of the cake";
            this.Load += new System.EventHandler(this.JustForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.X0Y0Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DPanel;
        private System.Windows.Forms.Button JBtn;
        private System.Windows.Forms.NumericUpDown X0Y0Value;
        private System.Windows.Forms.NumericUpDown WidthValue;
        private System.Windows.Forms.NumericUpDown HeightValue;
    }
}

