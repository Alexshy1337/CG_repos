using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdjustablePolygon
{
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
        }

        Converter Conv;
        List<Point> Polygon;
        //Point p0, p1;

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawingPanel.CreateGraphics().Clear(Color.White);
            Conv = new Converter(DrawingPanel.Width, DrawingPanel.Height);
            Bitmap bit = new Bitmap(DrawingPanel.Width, DrawingPanel.Height);

            DrawingPanel.CreateGraphics().DrawImage(GraphicalClass.DrawPolygon(bit, Pens.Black, DrawingPanel.Width / 2, DrawingPanel.Height / 3, (int)LengthNumeric.Value, (int)AmountOfAnglesNumeric.Value, out Polygon), 0, 0);

        }


        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //p0 = new Point(e.X, e.Y);
            //DrawingPanel.CreateGraphics().DrawRectangle(Pens.Black, p0.X, p0.Y, 1, 1);

            InfoLabel.Text = "mouse down";
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {

            InfoLabel.Text = "mouse up";

        }
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            InfoLabel.Text = "mouse move";

        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            DrawingPanel.CreateGraphics().Clear(Color.White);

        }
    }
}
