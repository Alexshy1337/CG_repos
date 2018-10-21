using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingProject
{
    public partial class JustForm : Form
    {
        public JustForm()
        {
            InitializeComponent();
        }

        private void JBtn_Click(object sender, EventArgs e)
        {
            DPanel.CreateGraphics().Clear(Color.White);
            Bitmap b = new Bitmap(DPanel.Width, DPanel.Height);

            if(BresenhamRadioButton.Checked)
            {
                if(EllipseRadioButton.Checked)
                    DPanel.CreateGraphics().DrawImage(GraphicsClass.Fill_Bresenham_Ellipse(b, Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value, (int)WidthValue.Value, (int)HeightValue.Value), 0, 0);
                else
                    DPanel.CreateGraphics().DrawImage(GraphicsClass.Fill_Bresenham_Pie(b, Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value, (int)WidthValue.Value, (int)HeightValue.Value, (int)StartAngleValue.Value, (int)SweepAngleValue.Value), 0, 0);
            }
            else
            {
                if(EllipseRadioButton.Checked)
                    DPanel.CreateGraphics().DrawImage(GraphicsClass.Fill_Wu_Ellipse(b, Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value, (int)WidthValue.Value, (int)HeightValue.Value), 0, 0);
                else
                    DPanel.CreateGraphics().DrawImage(GraphicsClass.Fill_Wu_Pie(b, Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value, (int)WidthValue.Value, (int)HeightValue.Value, (int)StartAngleValue.Value, (int)SweepAngleValue.Value), 0, 0);
            }

        }



  
}
    }

