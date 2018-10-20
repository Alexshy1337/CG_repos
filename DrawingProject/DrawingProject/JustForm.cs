using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingProject
{
    public partial class JustForm : Form
    {
        public JustForm()
        {
            InitializeComponent();
        }

        private Bitmap Irrational_Fill_Bresenham_Ellipse(Pen p, int x0, int y0, int width, int height)
        {
            Bitmap bit = new Bitmap(DPanel.Width, DPanel.Height);
            int h = height / 2, w = width / 2;

            for (int x = x0; x <= width + x0; x++)
                for (int y = y0; y <= height + y0; y++)
                    if (y <= (h * Math.Sqrt((2 * w - x + x0) * (x - x0))) / w + y0 + h &&
                       y >= -(h * Math.Sqrt((2 * w - x + x0) * (x - x0))) / w + y0 + h)
                        bit.SetPixel(x, y, p.Color);

            return bit;
        }

        private Bitmap Fill_Bresenham_Ellipse(Pen p, int x0, int y0, int width, int height)
        {
            Bitmap bit = new Bitmap(DPanel.Width, DPanel.Height);
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

        private void F(int x, int y, int x0, int y0, int w, int h, out int xn, out int yn)
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

        //private Bitmap Fill_Normal_Region(Bitmap bit, Color color, int xs, int ys)
        //{
        //    int x = xs, y = ys, s = 1;
        //    bool a = true;

        //    while (bit.GetPixel(x, y) == color)
        //        x++;
        //    y++;

        //    while (bit.GetPixel(x, y) == color || a)
        //    {
        //        x--;
        //        if (bit.GetPixel(x, y) == color)
        //            a = false;
        //    }

        //    while(bit.GetPixel(x, y) != color || a)
        //    {
        //        if (bit.GetPixel(x, y) != color)
        //        {
        //            bit.SetPixel(x, y, color);
        //            x--;
        //        }

        //        if(!a && bit.GetPixel(x, y) == color)
        //            a = !a;




        //    }

        //    if()
        //    //while (bit.GetPixel(x, y) != color)
        //    //{
        //    //    x += s;
        //    //    if()
        //    //}



        //        return bit;
        //}

        private static double GetFractionalPart(double a)
        {
            if (a >= (int)a)
                return a - (int)a;
            else
                return a - (int)a + 1;
        }

        private Bitmap Fill_Wu_Ellipse(Pen p, int x0, int y0, int width, int height)
        {

            Bitmap bit = new Bitmap(DPanel.Width, DPanel.Height);
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



        private Bitmap DrawStepForEllipse(Bitmap bit, int x, int y, int x0, int y0, int width, int height, Color BaseColor)
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

        private int TwiceAsBright(int alpha)
        {
            if (alpha > 127)
                return 255;
            else return alpha * 2;
        }

        private void JustForm_Load(object sender, EventArgs e)
        {

        }

        private void JBtn_Click(object sender, EventArgs e)
        {
            DPanel.CreateGraphics().Clear(Color.White);


            //DPanel.CreateGraphics().DrawImage(Irrational_Fill_Bresenham_Ellipse(Pens.Red, 30, 20, 15, 10, 0, 0);


            //DPanel.CreateGraphics().DrawImage(Irrational_Fill_Bresenham_Ellipse(Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value,
            //  (int)WidthValue.Value, (int)HeightValue.Value), 0, 0);
            //


            //DPanel.CreateGraphics().DrawImage(Fill_Bresenham_Ellipse(Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value, (int)WidthValue.Value, (int)HeightValue.Value), 0, 0);

            DPanel.CreateGraphics().DrawImage(Fill_Wu_Ellipse(Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value, (int)WidthValue.Value, (int)HeightValue.Value), 0, 0);
        }



  
}
    }

