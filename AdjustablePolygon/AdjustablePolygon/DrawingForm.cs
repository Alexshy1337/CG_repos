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
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, DrawingPanel, new object[] { true });
        }

        bool Dragging = false;
        Converter Conv;
        Polygon polygon;
        MouseEventArgs eTemp;

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Image img = GraphicalClass.DrawPolygon(new Bitmap(DrawingPanel.Width, DrawingPanel.Height), Pens.Black, Conv, polygon);
            e.Graphics.DrawImage(img, 0, 0);
            img.Dispose();
        }

        private void DrawingPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            double x = Conv.XX(e.X), y = Conv.YY(e.Y);
            double changeCoeff = e.Delta > 0 ? 0.75 : 1.25;
            Conv.X1 = x - (x - Conv.X1) * changeCoeff;
            Conv.Y1 = y - (y - Conv.Y1) * changeCoeff;
            Conv.X2 = x + (Conv.X2 - x) * changeCoeff;
            Conv.Y2 = y + (Conv.Y2 - y) * changeCoeff;
            DrawingPanel.Invalidate();
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            eTemp = e;
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            DrawingPanel.Focus();
            if (Dragging)
            {
                double deltaX = Conv.XX(e.X) - Conv.XX(eTemp.X), deltaY = Conv.YY(e.Y) - Conv.YY(eTemp.Y);
                eTemp = e;
                Conv.X1 -= deltaX;
                Conv.Y1 -= deltaY;
                Conv.X2 -= deltaX;
                Conv.Y2 -= deltaY;
                DrawingPanel.Invalidate();
            }
        }

        private void DrawingPanel_Resize(object sender, EventArgs e)
        {
            Conv.ScreenWidth = DrawingPanel.Width; Conv.ScreenHeight = DrawingPanel.Height;
        }


        private void DrawingForm_Load(object sender, EventArgs e)
        {
            Conv = new Converter(DrawingPanel.Width, DrawingPanel.Height);
            polygon = new Polygon((int)AmountOfAnglesNumeric.Value, (int)RADnumeric.Value, (int)StartAngleNumeric.Value);
        }

        private void AmountOfAnglesNumeric_ValueChanged(object sender, EventArgs e)
        {
            polygon.VertAmount = (int)AmountOfAnglesNumeric.Value;
            DrawingPanel.Invalidate();
        }

        private void StartAngleNumeric_ValueChanged(object sender, EventArgs e)
        {
            polygon.StartAngle = (int)StartAngleNumeric.Value;
            DrawingPanel.Invalidate();
        }

        private void RADnumeric_ValueChanged(object sender, EventArgs e)
        {
            polygon.Radius = (int)RADnumeric.Value;
            DrawingPanel.Invalidate();
        }
    }
}
