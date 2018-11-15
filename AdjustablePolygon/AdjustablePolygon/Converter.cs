using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjustablePolygon
{
    class Converter
    {


        private double x1, x2, y1, y2;

        public double X1 { get { return x1; } set { x1 = value; } }
        public double Y1 { get { return y1; } set { y1 = value; } }
        public double X2 { get { return x2; } set { x2 = value; } }
        public double Y2 { get { return y2; } set { y2 = value; } }
        public int ScreenHeight { get; private set; }
        public int ScreenWidth { get; private set; }
        public Converter(int sw, int sh)
        {

            x1 = -100;
            x2 = 100;
            y1 = -100;
            y2 = 100;
            ScreenWidth = sw;
            ScreenHeight = sh;

        }

        public int II(double x)
        {
            return (int)(ScreenWidth * ((x - x1) / (x2 - x1)));
        }

        public int JJ(double y)
        {
            return (int)((y - y1) * ScreenHeight / (y2 - y1));
        }

        public double XX(int I)
        {
            return x1 + I * (x2 - x1) / ScreenWidth;
        }

        public double YY(int J)
        {
            return y1 + J * (y2 - y1) / ScreenHeight;
        }
    }
}
