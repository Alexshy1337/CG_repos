namespace theDrawing
{
    partial class imsodumb
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
            this.DrawingSpace = new System.Windows.Forms.Panel();
            this.ClearBTTN = new System.Windows.Forms.Button();
            this.DrawBTTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawingSpace
            // 
            this.DrawingSpace.Location = new System.Drawing.Point(0, 60);
            this.DrawingSpace.Name = "DrawingSpace";
            this.DrawingSpace.Size = new System.Drawing.Size(798, 391);
            this.DrawingSpace.TabIndex = 0;
            this.DrawingSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingSpace_Paint);
            // 
            // ClearBTTN
            // 
            this.ClearBTTN.Location = new System.Drawing.Point(41, 21);
            this.ClearBTTN.Name = "ClearBTTN";
            this.ClearBTTN.Size = new System.Drawing.Size(75, 23);
            this.ClearBTTN.TabIndex = 1;
            this.ClearBTTN.Text = "Clear";
            this.ClearBTTN.UseVisualStyleBackColor = true;
            this.ClearBTTN.Click += new System.EventHandler(this.ClearBTTN_Click);
            // 
            // DrawBTTN
            // 
            this.DrawBTTN.Location = new System.Drawing.Point(175, 20);
            this.DrawBTTN.Name = "DrawBTTN";
            this.DrawBTTN.Size = new System.Drawing.Size(75, 23);
            this.DrawBTTN.TabIndex = 2;
            this.DrawBTTN.Text = "Draw?..";
            this.DrawBTTN.UseVisualStyleBackColor = true;
            this.DrawBTTN.Click += new System.EventHandler(this.DrawBTTN_Click);
            // 
            // imsodumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.DrawBTTN);
            this.Controls.Add(this.ClearBTTN);
            this.Controls.Add(this.DrawingSpace);
            this.Name = "imsodumb";
            this.Text = "toobaditstrue";
            this.Load += new System.EventHandler(this.imsodumb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawingSpace;
        private System.Windows.Forms.Button ClearBTTN;
        private System.Windows.Forms.Button DrawBTTN;
    }
}

