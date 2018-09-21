using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theDrawing
{
    public partial class imsodumb : Form
    {
        public imsodumb()
        {
            InitializeComponent();
        }



        private void DrawingSpace_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void imsodumb_Load(object sender, EventArgs e)
        {

        }

        private void ClearBTTN_Click(object sender, EventArgs e)
        {
            DrawingSpace.CreateGraphics().Clear(Color.Cyan);
        }

        private void DrawBTTN_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(DrawingSpace.Width, DrawingSpace.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.Clear(Color.White);


            Point a1 = new Point(440,230), a2 = new Point(400,250),
               a3 = new Point(370,250), a4 = new Point(334,225),
               a5 = new Point(320,200), a6 = new Point(318,180), a7 = new Point(340,165),
               a8 = new Point(335,172), a9 = new Point(355, 180), a10 = new Point(340,190),
               a11 = new Point(375,180), a12 = new Point(330,165), a13 = new Point(380,130),
               a14 = new Point(355,165), a15 = new Point(395,170), a16 = new Point(385,190),
               a17 = new Point(415,175), a18 = new Point(410,160), a19 = new Point(396,145),
               a20 = new Point(430, 160), a21 = new Point(430, 175), a22 = new Point(415, 190),
               a23 = new Point(445, 180), a24 = new Point(440, 165), a25 = new Point(438, 160),
               a26 = new Point(460, 170), a27 = new Point(465, 215);

            Pen pen_for_bezier = new Pen(Color.Red, 2.0F);

            Point[] array_for_bezier = 
                {
                a1, a2, a3, a4,
                a5, a6, a7,
                a8, a9, a10,
                a11, a12, a13,
                a14, a15, a16,
                a17, a18, a19,
                a20, a21, a22,
                a23, a24, a25,
                a26, a27, a1
                };
            g.DrawBeziers(pen_for_bezier, array_for_bezier);


            Rectangle body = new Rectangle(150, 100, 70, 50), 

                left_arm = new Rectangle(137, 105, 11, 40), right_arm = new Rectangle(223, 105, 11, 40), 

                l_a_c_t = new Rectangle(137, 100, 10, 10), l_a_c_b = new Rectangle(137, 140, 10, 10),

                r_a_c_t = new Rectangle(223, 100, 10, 10), r_a_c_b = new Rectangle(223, 140, 10, 10),

                left_leg = new Rectangle(170, 150, 11, 30), right_leg = new Rectangle(190, 150, 11, 30),

                llc = new Rectangle(170, 175, 10, 10), rlc = new Rectangle(190, 175, 10, 10),

                white_space = new Rectangle(147, 97, 80, 70), head_rect = new Rectangle(150, 70, 70, 56),
                
                left_eye = new Rectangle(165, 80, 5, 5), right_eye = new Rectangle(200, 80, 5, 5);

            Pen p = new Pen(Color.GreenYellow, 3.0F);



            //168, 75; 161, 55
            //201, 75; 208, 55
            g.FillEllipse(Brushes.GreenYellow, head_rect);
            g.FillRectangle(Brushes.White, white_space);

            g.FillEllipse(Brushes.White, left_eye);
            g.FillEllipse(Brushes.White, right_eye);

            g.DrawLine(p, 168, 75, 159, 59);
            g.DrawLine(p, 201, 75, 210, 59);

            g.FillEllipse(Brushes.GreenYellow, l_a_c_t);
            g.FillEllipse(Brushes.GreenYellow, l_a_c_b);

            g.FillEllipse(Brushes.GreenYellow, r_a_c_t);
            g.FillEllipse(Brushes.GreenYellow, r_a_c_b);

            g.FillEllipse(Brushes.GreenYellow, llc);
            g.FillEllipse(Brushes.GreenYellow, rlc);

            g.FillRectangle(Brushes.GreenYellow, body);

            g.FillRectangle(Brushes.GreenYellow, left_arm);
            g.FillRectangle(Brushes.GreenYellow, right_arm);

            g.FillRectangle(Brushes.GreenYellow, left_leg);
            g.FillRectangle(Brushes.GreenYellow, right_leg);

            g.DrawString("Testing the methods", SystemFonts.DefaultFont, Brushes.Black, 337.0F, 205.0F);

            DrawingSpace.CreateGraphics().DrawImage(bmp, 0, 0);
            bmp.Dispose();
            g.Dispose();
        }
    }
}


/*

Переименовать формы, классы и так далее
не создавать графикс
в методы передавать графикс

private void DrawPicture(Bitmap bmp)
{
}

private void DrawAll(Graphics g,Rectangle rect)
{
Bitmap bmp= new Bitmap(r.Width,r.Height);
DrawPicture(bmp);
g.drawimage(bmp,r);
bmp.dispose();
}


обработчик соытия пэинт
{
DrawAll(e.graphics,e.cliprectangle);
}


*/