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
    public partial class DrawPolygonForm : Form
    {
        public DrawPolygonForm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty|
                System.Reflection.BindingFlags.Instance|
                System.Reflection.BindingFlags.NonPublic,
                null, DrawingPanel, new object[] { true });
        }

        bool Dragging = false;
        Converter Conv;
        Polygon polygon;
        MouseEventArgs eTemp;
        public Bitmap output;

        Bitmap img;
        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            img = GraphicalClass.DrawPolygon(new Bitmap(DrawingPanel.Width, DrawingPanel.Height), Pens.Black, Conv, polygon);
            //output = img;
            e.Graphics.DrawImage(img, 0, 0);
            //img.Dispose();
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

        private void FinishButton_Click(object sender, EventArgs e)
        {

            output = img;
            //Close();
        }
    }
}
