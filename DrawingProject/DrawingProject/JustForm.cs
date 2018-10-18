using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            for(int x = x0; x <= width + x0; x++)
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

            int xt = x, yt = y;
            while (yt > h + y0)
            {
                yt--;
                bit.SetPixel(xt, yt, p.Color);
                bit.SetPixel(width + x0 * 2 - xt, yt, p.Color);
                bit.SetPixel(xt, height + y0 * 2 - yt, p.Color);
                bit.SetPixel(width + x0 * 2 - xt, height + y0 * 2 - yt, p.Color);
            }

            while (x <= width + x0 && y > h + y0)
            {
                F(x, y, x0, y0, w, h, out x, out y);
                int x1 = x, y1 = y;
                while (y1 > h + y0)
                {
                    y1--;
                    bit.SetPixel(x1, y1, p.Color);
                    bit.SetPixel(width + x0 * 2 - x1, y1, p.Color);
                    bit.SetPixel(x1, height + y0 * 2 - y1, p.Color);
                    bit.SetPixel(width + x0 * 2 - x1, height + y0 * 2 - y1, p.Color);
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
            
            int i = Math.Abs(h*h * (x - w - x0)*(x - w - x0) + w*w * (y - 1 - h - y0)*(y - 1 - h - y0) - w*w * h*h), 

                j = Math.Abs(h*h * (x + 1 - w - x0)*(x + 1 - w - x0) + w*w * (y - h - y0)*(y - h - y0) - w*w * h*h),
                
                k = Math.Abs(h*h * (x + 1 - w - x0)*(x + 1 - w - x0) + w*w * (y - 1 - h - y0)*(y - 1 - h - y0) - w*w * h*h);



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
            /*
            
            
            Color.FromArgb(255, 0, 0); //Red
            Color.FromArgb(0, 255, 0); //Green
            Color.FromArgb(0, 0, 255); //Blue
            Color.FromArgb(255, 255, 0); //Yellow


            */

            /*



               Bitmap bit = new Bitmap(DPanel.Width, DPanel.Height);
             int h = height / 2, w = width / 2;
             double maxDistance = Math.Sqrt(w * w + h * h) + x0 + y0;
             for (int x = x0; x <= width + x0; x++)
                 for (int y = y0; y <= height + y0; y++)
                 {
                     double r = (int)Math.Sqrt((w - x)*(w - x) + (h - y)*(h - y)), k = r/maxDistance;
                     int a = 255 - (int)(255 * k);
                     double c = (h * Math.Sqrt((2 * w - x + x0) * (x - x0))) / w;

                    // if (y < c + y0 + h && y > -c + y0 + h)
                         bit.SetPixel(x, y, Color.FromArgb(a, p.Color));
                 }

              */

            //double a = GetFractionalPart( Math.Abs(h * h * (x - w - x0) * (x - w - x0) + w * w * (y - h - y0) * (y - h - y0) - w * w * h * h));

            //GetFractionalPart(double)
            Bitmap bit = new Bitmap(DPanel.Width, DPanel.Height);
            int h = height / 2, w = width / 2;
            int x = w + x0, y = height + y0;
            bit.SetPixel(w + x0, height + y0, p.Color);
            bit.SetPixel(x0, y0 + h, p.Color);
            bit.SetPixel(w + x0, y0, p.Color);
            bit.SetPixel(width + x0, h + y0, p.Color);
            //double c = (h * Math.Sqrt((2 * w - x + x0) * (x - x0))) / w;

            int xt = x, yt = y;
            while (yt > h + y0)
            {
                yt--;
                bit.SetPixel(xt, yt, p.Color);
                bit.SetPixel(width + x0 * 2 - xt, yt, p.Color);
                bit.SetPixel(xt, height + y0 * 2 - yt, p.Color);
                bit.SetPixel(width + x0 * 2 - xt, height + y0 * 2 - yt, p.Color);
            }

            while (x <= width + x0 && y > h + y0)
            {
                F(x, y, x0, y0, w, h, out x, out y);
                int x1 = x, y1 = y;
                int alpha = 255 - (int)(255 * GetFractionalPart(Math.Sqrt(Math.Abs(((x - x0) * (x - x0) / (w * w) + (y - y0) * (y - y0) / (h * h)) - 1))));

                y1--;
                bit.SetPixel(x1, y1, p.Color);
                bit.SetPixel(width + x0 * 2 - x1, y1, p.Color);
                bit.SetPixel(x1, height + y0 * 2 - y1, p.Color);
                bit.SetPixel(width + x0 * 2 - x1, height + y0 * 2 - y1, p.Color);


                while (y1 > h + y0)
                {
                    y1--;
                    bit.SetPixel(x1, y1, p.Color);
                    bit.SetPixel(width + x0 * 2 - x1, y1, p.Color);
                    bit.SetPixel(x1, height + y0 * 2 - y1, p.Color);
                    bit.SetPixel(width + x0 * 2 - x1, height + y0 * 2 - y1, p.Color);
                }
                bit.SetPixel(x, y, Color.FromArgb(alpha, p.Color));
                bit.SetPixel(width + x0 * 2 - x, y, Color.FromArgb(alpha, p.Color));
                bit.SetPixel(x, height + y0 * 2 - y, Color.FromArgb(alpha, p.Color));
                bit.SetPixel(width + x0 * 2 - x, height + y0 * 2 - y, Color.FromArgb(alpha, p.Color));
            }


            return bit;


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


            //DPanel.CreateGraphics().DrawImage(Fill_Bresenham_Ellipse(Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value,
            //(int)WidthValue.Value, (int)HeightValue.Value), 0, 0);

            DPanel.CreateGraphics().DrawImage(Fill_Wu_Ellipse(Pens.Red, (int)X0Y0Value.Value, (int)X0Y0Value.Value,
            (int)WidthValue.Value, (int)HeightValue.Value), 0, 0);
        }




    }
    }




// ((x-x0)^2)/(width/2)^2 + ((y-y0)^2)/(height/2)^2 = 1




/* 

function line(x0, x1, y0, y1)
int deltax := abs(x1 - x0)
int deltay := abs(y1 - y0)
int error := 0
int deltaerr := deltay
int y := y0
int diry := y1 - y0
if diry > 0 
diry = 1
if diry < 0 
diry = -1
for x from x0 to x1
plot(x,y)
error := error + deltaerr
if 2 * error >= deltax
 y := y + diry
 error := error - deltax
 */


/*

//int i = x, j = y, k = 0;

        //while(i < x + w && j < y + h)
        //{



        //}


        for (int j = y; j < (y + height); j++)
        {
            for (int i = x; i < (x + width); i++)
            {
                double k = (h * Math.Sqrt(w * w - i * i)) / w;

                if (i <= k)
                {
                    bit.SetPixel((int)j, i, p.Color);
                    //bit.SetPixel((int)j, width + x - i, p.Color);
                    //bit.SetPixel(height + y - (int)j, i, p.Color);
                    //bit.SetPixel(height + y - (int)j, width + x - i, p.Color);
                }
            }
        }


    */