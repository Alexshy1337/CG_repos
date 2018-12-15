using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametralGraphicPlotter
{
    class Converter
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        private int screenHeight;
        private int screenWidth;
        public int ScreenHeight
        {
            get
            {
                return screenHeight;
            }
            set
            {
                X1 = -screenWidth / 2;
                X2 = screenWidth / 2;
                Y1 = -value / 2;
                Y2 = value / 2;
                screenHeight = value;
            }
        }
        public int ScreenWidth
        {
            get
            {
                return screenWidth;
            }

            set
            {
                X1 = -value / 2;
                X2 = value / 2;
                Y1 = -screenHeight / 2;
                Y2 = screenHeight / 2;
                screenWidth = value;
            }
        }

        public Converter(int sw, int sh)
        {
            X1 = -sw / 2;
            X2 = sw / 2;
            Y1 = -sh / 2;
            Y2 = sh / 2;
            ScreenWidth = sw;
            ScreenHeight = sh;
        }

        public int II(double X)
        {
            return (int)(ScreenWidth * (X - X1) / (X2 - X1));
        }

        public int JJ(double Y)
        {
            return (int)(ScreenHeight * (Y - Y1) / (Y2 - Y1));
        }

        public double XX(int I)
        {
            return X1 + I * (X2 - X1) / ScreenWidth;
        }

        public double YY(int J)
        {
            return Y1 + J * (Y2 - Y1) / ScreenHeight;
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
