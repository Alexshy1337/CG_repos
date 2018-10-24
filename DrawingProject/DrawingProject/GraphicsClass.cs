using System;
using System.Drawing;

namespace DrawingProject
{
    class GraphicsClass
    {

        public static Bitmap Fill_Bresenham_Ellipse(Bitmap bit, Pen p, int x0, int y0, int width, int height)
        {
            int h = height / 2, w = width / 2;
            int x = w + x0, y = height + y0;

            while (x <= width + x0 && y > h + y0)
            {
                int y1 = y;
                while (y1 > h + y0 - 1)
                {
                    bit.SetPixel(x, y1, p.Color);
                    bit.SetPixel(width + x0 * 2 - x, y1, p.Color);
                    bit.SetPixel(x, height + y0 * 2 - y1, p.Color);
                    bit.SetPixel(width + x0 * 2 - x, height + y0 * 2 - y1, p.Color);
                    y1--;
                }
                F(x, y, x0, y0, w, h, out x, out y);
            }

            return bit;
        }

        public static Bitmap Fill_Bresenham_Pie(Bitmap bit, Pen p, int x0, int y0, int width, int height, double StartAngle, double SweepAngle)
        {
            int w = width / 2, h = height / 2;

            //переводим в радианы
            double StartAngleR = (Math.PI / 180.0) * (StartAngle % 360);
            double EndAngleR = (Math.PI / 180.0) * ((StartAngle + SweepAngle) % 360);

            //точка начала дуги в реальных координатах
            int xs = (int)Math.Round(w * Math.Cos(StartAngleR));
            int ys = (int)Math.Round(h * Math.Sin(StartAngleR));

            //точка конца дуги в реальных координатах
            int xe = (int)Math.Round(w * Math.Cos(EndAngleR));
            int ye = (int)Math.Round(h * Math.Sin(EndAngleR));

            bool started = false;

            int x = xs;
            int y = ys;

            int xsign, ysign;

            //выбор начального направления
            if(xs != 0 && ys != 0)
            {
                xsign = ys > 0 ? -1 : 1;
                ysign = xs > 0 ? 1 : -1;
            }
            else if (ys == 0)
            {
                if (xs > 0)
                {
                    xsign = -1;
                    ysign = 1;
                }
                else
                {
                    xsign = 1;
                    ysign = -1;
                }
            }
            else
            {
                if (ys > 0)
                {
                    xsign = -1;
                    ysign = -1;
                }
                else
                {
                    xsign = 1;
                    ysign = 1;
                }
            }

            int px = 0;
            int py = 0;

            while (Math.Abs(x - xe) > 1 || Math.Abs(y - ye) > 1)
            {
                

                bit.SetPixel( w + x0 + x, h + y0 - y, p.Color);

                int f1 = PossibleNextPoint(w, h, x + xsign, y + ysign);
                int f2 = PossibleNextPoint(w, h, x + xsign, y);
                int f3 = PossibleNextPoint(w, h, x, y + ysign);

                px = x;
                py = y;

                x += xsign;
                y += ysign;

                if (f2 < Math.Min(f1, f3))
                    y -= ysign;
                else if (f3 < Math.Min(f1, f2))
                    x -= xsign;

                started = true;


                if (y == 0 && started == true)
                    xsign = -xsign;
                if (x == 0 && started == true)
                    ysign = -ysign;






            }









            return bit;
    }

        private static int PossibleNextPoint(int w, int h, int x, int y)
        {
            return Math.Abs(h * h * (x - w) * (x - w) + w * w * (y - 1 - h) * (y - 1 - h) - w * w * h * h);
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

            while (x <= width + x0 && y > h + y0)
            {
                bit = DrawStepForEllipse(bit, x, y, x0, y0, width, height, p.Color);
                F(x, y, x0, y0, w, h, out x, out y);
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

            while (y > height / 2 + y0 - 1)
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


/*
 
     
     
     
     
     
     
                 int w = width / 2, h = height / 2;

            //получаем угол обязательно меньший полного круга
            StartAngle = StartAngle % 360;
            SweepAngle = SweepAngle % 360;

            //переводим в радианы
            double StartAngleR = -(Math.PI / 180.0) * StartAngle;
            double EndAngleR = -(Math.PI / 180.0) * (StartAngle + SweepAngle);

            //точка начала дуги
            int xs = (int)Math.Round(w * Math.Cos(StartAngleR));
            int ys = (int)Math.Round(h * Math.Sin(StartAngleR));

            //точка конца дуги
            int xe = (int)Math.Round(w * Math.Cos(EndAngleR));
            int ye = (int)Math.Round(h * Math.Sin(EndAngleR));

            bool started = false;

            int x = xs;
            int y = ys;

            //направление 
            int xsign = ys > 0 ? +1 : -1;
            int ysign = xs > 0 ? -1 : +1;

            if (x == 0 && y > 0)
                ysign = -1;
            else if (x == 0 && y < 0)
                ysign = 1;

            if (y == 0 && x < 0)
                xsign = 1;

            int px = 0;
            int py = 0;

            while (Math.Abs(x - xe) > 1 || Math.Abs(y - ye) > 1)
            {
                if (y == 0 && started == true)
                    xsign = -xsign;
                if (x == 0 && started == true)
                    ysign = -ysign;

                bit.SetPixel(x0 + x, y0 - y, p.Color);

                int f1 = PossibleNextPoint(w, h, x + xsign, y + ysign);
                int f2 = PossibleNextPoint(w, h, x + xsign, y);
                int f3 = PossibleNextPoint(w, h, x, y + ysign);

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

     
     
     */
