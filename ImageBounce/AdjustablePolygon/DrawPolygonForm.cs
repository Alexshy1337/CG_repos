using System;
using System.Drawing;
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

        Converter Conv;
        Polygon polygon;
        public Bitmap output;
        Bitmap img;

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            img = GraphicalClass.DrawPolygon(new Bitmap(2 * (int)RADnumeric.Value + 1, 2 * (int)RADnumeric.Value + 1), Pens.Black, Conv, polygon);
            e.Graphics.DrawImage(img, DrawingPanel.Width/2 - (int)RADnumeric.Value, DrawingPanel.Height/2 - (int)RADnumeric.Value);
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
            Conv = new Converter(2 * (int)RADnumeric.Value + 4, 2 * (int)RADnumeric.Value + 4);
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
            Conv = new Converter(2 * (int)RADnumeric.Value + 4, 2 * (int)RADnumeric.Value + 4);
            DrawingPanel.Invalidate();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            output = img;
        }
    }
}
