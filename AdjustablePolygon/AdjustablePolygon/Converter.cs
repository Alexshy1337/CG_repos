using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjustablePolygon
{
    class Converter
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public int ScreenHeight { get; private set; }
        public int ScreenWidth { get; private set; }

        public Converter(int sw, int sh)
        {
            X1 = -300;
            X2 = 300;
            Y1 = -300;
            Y2 = 300;
            ScreenWidth = sw;
            ScreenHeight = sh;
        }

        public int II(double X)
        {
            return (int)(ScreenWidth * (X - X1) / (X2 - X1));
        }

        public int JJ(double Y)
        {
            return (int)(ScreenHeight * (Y1 - Y) / (Y1 - Y2));
        }

        public double XX(int I)
        {
            return X1 + I * (X2 - X1) / ScreenWidth;
        }

        public double YY(int J)
        {
            return Y1 - J * (Y2 - Y1) / ScreenHeight;
        }

        public Point IIJJ(PointF point)
        {
            return new Point(II(point.X), JJ(point.Y));
        }

        public PointF XXYY(Point point)
        {
            return new PointF((float)XX(point.X), (float)YY(point.Y));
        }
    }
}
