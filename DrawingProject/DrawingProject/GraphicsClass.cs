using System;
using System.Drawing;

namespace DrawingProject
{
    class GraphicsClass
    {

        public static Bitmap Fill_Bresenham_Ellipse(Bitmap bit, Pen p, int x0, int y0, int width, int height)
        {
            int h = height / 2, w = width / 2;
            int x = 0, y = -h;

            while (x <= w && y < 0)
            {
                int y1 = y;
                while (y1 < 1)
                {
                    bit.SetPixel(x + x0 + w, y1 + y0 + h, p.Color);
                    bit.SetPixel(w + x0 - x, y1 + y0 + h, p.Color);
                    bit.SetPixel(x + x0 + w, h + y0 - y1, p.Color);
                    bit.SetPixel(w + x0 - x, h + y0 - y1, p.Color);
                    y1++;
                }
                F(x, y, 1, 1, w, h, out x, out y);
            }

            return bit;
        }

        public static Bitmap Fill_Bresenham_Pie(Bitmap bit, Pen p, int x0, int y0, int width, int height, double StartAngle, double SweepAngle)
        {
            int w = width / 2, h = height / 2;
            int SA = (int)StartAngle;
            //переводим в радианы
            double EndAngle = (Math.PI / 180.0) * ((StartAngle + SweepAngle) % 360);
            StartAngle = (Math.PI / 180.0) * (StartAngle % 360);
            
            //точки начала и конца дуги в реальных координатах
            int xs = (int)Math.Round(w * Math.Cos(StartAngle)), x = xs,
                ys = (int)Math.Round(h * Math.Sin(StartAngle)), y = ys,
                xe = (int)Math.Round(w * Math.Cos(EndAngle)),
                ye = (int)Math.Round(h * Math.Sin(EndAngle));

            if (x == xe && y == ye)
                return Fill_Bresenham_Ellipse(bit, p, x0, y0, width, height);
            
            //выбор начального направления
            int xsign, ysign;
            if (x != 0 && y != 0)
            {
                xsign = y > 0 ? -1 : 1;
                ysign = x > 0 ? 1 : -1;
            }
            else if (y == 0)
            {
                if (x > 0)
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
                if (y > 0)
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

            while (x != xe || y != ye)
            {
                bit.SetPixel(w + x0 + x, h + y0 - y, p.Color);
                F(x, y, xsign, ysign, w, h, out x, out y);

                if (y == 0)
                    xsign = -xsign;
                if (x == 0)
                    ysign = -ysign;
            }

            bit = DrawBrLine(bit, p, w + x0, h + y0, xe + w + x0, h + y0 - ye);

            //if (SA >= 0 && SA < 90)
            //{
            //    bit = PieFiller(bit, p, w + x0, h + y0, 0);// I
            //    bit = DrawBrLineWithFilling(bit, p, w + x0, h + y0, xs + w + x0, h + y0 - ys, 0, 1);
            //}
            //else if (SA >= 90 && SA < 180)
            //{ 
            //    bit = PieFiller(bit, p, w + x0, h + y0, 1);// II
            //    bit = DrawBrLineWithFilling(bit, p, w + x0, h + y0, xs + w + x0, h + y0 - ys, -1, 0);
            //}
            //else if (SA >= 180 && SA < 270)
            //{
            //    bit = PieFiller(bit, p, w + x0, h + y0, 2);// III
            //    bit = DrawBrLineWithFilling(bit, p, w + x0, h + y0, xs + w + x0, h + y0 - ys, 0, -1);
            //}
            //else
            //{
            //    bit = PieFiller(bit, p, w + x0, h + y0, 3);// IV
            //    bit = DrawBrLineWithFilling(bit, p, w + x0, h + y0, xs + w + x0, h + y0 - ys, 1, 0);
            //}
            return bit;
        }

        private static Bitmap DrawBrLine(Bitmap bit, Pen p, int x0, int y0, int x1, int y1)
        {
                int x = x0, y = y0;
                int xsign = x1 / Math.Abs(x1), ysign = y1 / Math.Abs(y1);
                while (x != x0 || y != y0)
                {
                    bit.SetPixel(x, y, p.Color);
                    int k = Math.Abs((x + xsign) * y0 - (y + ysign) * x0),
                        j = Math.Abs((x + xsign) * y0 - y * x0),
                        i = Math.Abs(x * y0 - (y + ysign) * x0);

                    int xn = x,
                    yn = y + y0;
                    if (j < i)
                    {
                        i = j;
                        xn = x + x0;
                        yn = y;
                    }
                    if (k < i)
                    {
                        xn = x + x0;
                        yn = y + y0;
                    }

                    x = xn; y = yn;
                }


                return bit;
        }

        private static Bitmap DrawBrLineWithFilling(Bitmap bit, Pen p, int x0, int y0, int x1, int y1, int xd, int yd)
        {
            int x = x0, y = y0;
            int xsign = x1 / Math.Abs(x1), ysign = y1 / Math.Abs(y1);
            while (x != x0 || y != y0)
            {
                bit.SetPixel(x, y, p.Color);

                bit = StraightLine(bit, p, x, y, xd, yd);

                int k = Math.Abs((x + xsign) * y0 - (y + ysign) * x0),
                    j = Math.Abs((x + xsign) * y0 - y * x0),
                    i = Math.Abs(x * y0 - (y + ysign) * x0);

                int xn = x,
                yn = y + y0;
                if (j < i)
                {
                    i = j;
                    xn = x + x0;
                    yn = y;
                }
                if (k < i)
                {
                    xn = x + x0;
                    yn = y + y0;
                }

                x = xn; y = yn;
            }


            return bit;
        }

        private static Bitmap StraightLine(Bitmap bit, Pen p, int x, int y, int xd, int yd)
        {
            do
            {
                bit.SetPixel(x, y, p.Color);
                x += xd;
                y += yd;
            } while (bit.GetPixel(x, y) == Color.White);

            return bit;
        }

        //c = center, d = direction
        private static Bitmap PieFiller (Bitmap bit, Pen p, int xc, int yc, int d)
        {
            int x = xc, y = yc;
            int xd = 0, yd = 0;
            if (d == 0)
                yd++;
            else if (d == 1)
                xd--;
            else if (d == 2)
                yd--;
            else xd++;

            while(bit.GetPixel(x, y) == Color.White)
            {
                bit.SetPixel(x, y, p.Color);
                if (d == 3)
                    d = 0;
                else d++;
                bit = PieFiller(bit, p, x, y, d);
                x += xd;
                y += yd;
            }

            return bit;
        }

        private static void F(int x, int y, int xs, int ys, int w, int h, out int xn, out int yn)
        {

            int i = Math.Abs(h * h * x * x + w * w * (y + ys) * (y + ys) - w * w * h * h),

                j = Math.Abs(h * h * (x + xs) * (x + xs) + w * w * y * y - w * w * h * h),

                k = Math.Abs(h * h * (x + xs) * (x + xs) + w * w * (y + ys) * (y + ys) - w * w * h * h);



            xn = x;
            yn = y + ys;

            if (j < i)
            {
                i = j;
                xn = x + xs;
                yn = y;
            }

            if (k < i)
            {
                xn = x + xs;
                yn = y + ys;
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
