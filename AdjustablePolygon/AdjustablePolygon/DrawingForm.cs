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
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        int RAD;
        bool Dragging = false;
        Bitmap bit;
        Converter Conv;
        List<Point> PolygonPoints;
        MouseEventArgs eTemp;

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawingPanel.CreateGraphics().Clear(Color.White);
            bit = GraphicalClass.DrawPolygon(bit, Pens.Black, Conv, PolygonPoints);
            DrawingPanel.CreateGraphics().DrawImage(bit, 0, 0);
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
            if(Dragging)
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

        private void AmountOfAnglesNumeric_ValueChanged(object sender, EventArgs e)
        {
            
            GraphicalClass.CalcPoints(DrawingPanel.Height / 4, (int)AmountOfAnglesNumeric.Value, out PolygonPoints);
            DrawingPanel.Invalidate();
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
            RAD = DrawingPanel.Height / 5;
            bit = new Bitmap(DrawingPanel.Width, DrawingPanel.Height);
            Conv = new Converter(DrawingPanel.Width, DrawingPanel.Height);
            PolygonPoints.Clear();
            GraphicalClass.CalcPoints(DrawingPanel.Height / 4, (int)AmountOfAnglesNumeric.Value, out PolygonPoints);
        }
    }
}
