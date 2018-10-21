using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProject
{
    class GraphicsClass
    {

        public static Bitmap Fill_Bresenham_Ellipse(Bitmap bit, Pen p, int x0, int y0, int width, int height)
        {
            int h = height / 2, w = width / 2;
            int x = w + x0, y = height + y0;

            bit.SetPixel(w + x0, height + y0, p.Color);
            bit.SetPixel(x0, y0 + h, p.Color);
            bit.SetPixel(w + x0, y0, p.Color);
            bit.SetPixel(width + x0, h + y0, p.Color);

            int yt = y;
            while (yt > h + y0)
            {
                yt--;
                bit.SetPixel(x, yt, p.Color);
                bit.SetPixel(width + x0 * 2 - x, yt, p.Color);
                bit.SetPixel(x, height + y0 * 2 - yt, p.Color);
                bit.SetPixel(width + x0 * 2 - x, height + y0 * 2 - yt, p.Color);
            }

            while (x <= width + x0 && y > h + y0)
            {
                F(x, y, x0, y0, w, h, out x, out y);
                int y1 = y;
                while (y1 > h + y0)
                {
                    y1--;
                    bit.SetPixel(x, y1, p.Color);
                    bit.SetPixel(width + x0 * 2 - x, y1, p.Color);
                    bit.SetPixel(x, height + y0 * 2 - y1, p.Color);
                    bit.SetPixel(width + x0 * 2 - x, height + y0 * 2 - y1, p.Color);
                }
                bit.SetPixel(x, y, p.Color);
                bit.SetPixel(width + x0 * 2 - x, y, p.Color);
                bit.SetPixel(x, height + y0 * 2 - y, p.Color);
                bit.SetPixel(width + x0 * 2 - x, height + y0 * 2 - y, p.Color);
            }


            return bit;
        }

        public static Bitmap Fill_Bresenham_Pie(Bitmap bit, Pen p, int x0, int y0, int width, int height, double StartAngle, double SweepAngle)
        {



            int w = width / 2, h = height / 2;
             
            StartAngle = StartAngle % 360;
            SweepAngle = SweepAngle % 360;
 
            double StartAngleR = -(Math.PI / 180.0) * StartAngle;
            double EndAngleR = -(Math.PI / 180.0) * (StartAngle + SweepAngle);
 
            int xstart = (int)(Math.Round(w * Math.Cos(StartAngleR)));
            int ystart = (int)(Math.Round(h * Math.Sin(StartAngleR)));
 
            int xend = (int)(Math.Round(w * Math.Cos(EndAngleR)));
            int yend = (int)(Math.Round(h * Math.Sin(EndAngleR)));
 
            bool started = false;
 
            int x = xstart;
            int y = ystart;
 
            int xsign = ystart > 0 ? +1 : -1;
            int ysign = xstart > 0 ? -1 : +1;
 
            if (x == 0 && y > 0)
                ysign = -1;
            else if (x == 0 && y < 0)
                ysign = 1;
 
            if (y == 0 && x < 0)
                xsign = 1;
 
            int px = 0;
            int py = 0;
 
            while (Math.Abs(x - xend) > 1 || Math.Abs(y - yend) > 1)
            {
                if (y == 0 && started == true)
                    xsign = -xsign;
                if (x == 0 && started == true)
                    ysign = -ysign;
 
                bit.SetPixel(x0 + x, y0 - y, p.Color);

                int f1 = CalcElipseSigm(a, b, x + xsign, y + ysign);
                int f2 = CalcElipseSigm(a, b, x + xsign, y);
                int f3 = CalcElipseSigm(a, b, x, y + ysign);

                px = x;
                py = y;
 
                x += xsign;
                y += ysign;
 
                if (f2 < Math.Min(f1, f3))
                    y -= ysign;
                else if (f3 < Math.Min(f1, f2))
                    x -= xsign;
 
                started = true;
            }

            //DrawLine(bit, color, x0, y0, x0 + xstart, y0 - ystart);
            //DrawLine(bit, color, x0, y0, x0 + px, y0 - py);









            return bit;
        }


        private static void F(int x, int y, int x0, int y0, int w, int h, out int xn, out int yn)
        {

            int i = Math.Abs(h * h * (x - w - x0) * (x - w - x0) + w * w * (y - 1 - h - y0) * (y - 1 - h - y0) - w * w * h * h),

                j = Math.Abs(h * h * (x + 1 - w - x0) * (x + 1 - w - x0) + w * w * (y - h - y0) * (y - h - y0) - w * w * h * h),

                k = Math.Abs(h * h * (x + 1 - w - x0) * (x + 1 - w - x0) + w * w * (y - 1 - h - y0) * (y - 1 - h - y0) - w * w * h * h);



            xn = x;
            yn = y - 1;

            if (j < i)
            {
                i = j;
                xn = x + 1;
                yn = y;
            }
            if (k < i)
            {
                xn = x + 1;
                yn = y - 1;
            }
        }

        public static Bitmap Fill_Wu_Ellipse(Bitmap bit, Pen p, int x0, int y0, int width, int height)
        {
            int h = height / 2, w = width / 2;
            int x = w + x0, y = height + y0;

            bit = DrawStepForEllipse(bit, x, y, x0, y0, width, height, p.Color);

            while (x <= width + x0 && y > h + y0)
            {
                F(x, y, x0, y0, w, h, out x, out y);
                bit = DrawStepForEllipse(bit, x, y, x0, y0, width, height, p.Color);
            }


            return bit;


        }

        public static Bitmap Fill_Wu_Pie(Bitmap bit, Pen p, int x0, int y0, int width, int height, double StartAngle, double SweepAngle)
        {


            return bit;
        }

        private static Bitmap DrawStepForEllipse(Bitmap bit, int x, int y, int x0, int y0, int width, int height, Color BaseColor)
        {
            int alpha, w = width / 2, h = height / 2;

            double a = Math.Sqrt(Math.Abs(((x - x0) * (x - x0) / (w * w) + (y - y0) * (y - y0) / (h * h)) - 1));
            if (a >= (int)a)
                alpha = 255 - (int)(255 * (a - (int)a));
            else
                alpha = 255 - (int)(255 * (a - (int)a + 1));


            bit.SetPixel(x, y, Color.FromArgb(alpha, BaseColor));
            bit.SetPixel(width + x0 * 2 - x, y, Color.FromArgb(alpha, BaseColor));
            bit.SetPixel(x, height + y0 * 2 - y, Color.FromArgb(alpha, BaseColor));
            bit.SetPixel(width + x0 * 2 - x, height + y0 * 2 - y, Color.FromArgb(alpha, BaseColor));

            y--;
            bit.SetPixel(x, y, Color.FromArgb(TwiceAsBright(alpha), BaseColor));
            bit.SetPixel(width + x0 * 2 - x, y, Color.FromArgb(TwiceAsBright(alpha), BaseColor));
            bit.SetPixel(x, height + y0 * 2 - y, Color.FromArgb(TwiceAsBright(alpha), BaseColor));
            bit.SetPixel(width + x0 * 2 - x, height + y0 * 2 - y, Color.FromArgb(TwiceAsBright(alpha), BaseColor));

            while (y > height / 2 + y0)
            {
                y--;
                bit.SetPixel(x, y, BaseColor);
                bit.SetPixel(width + x0 * 2 - x, y, BaseColor);
                bit.SetPixel(x, height + y0 * 2 - y, BaseColor);
                bit.SetPixel(width + x0 * 2 - x, height + y0 * 2 - y, BaseColor);
            }



            return bit;
        }

        private static int TwiceAsBright(int alpha)
        {
            if (alpha > 127)
                return 255;
            else return alpha * 2;
        }
























    }
}
