using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq.Expressions;
using Sprache.Calc;

namespace ParametralGraphicPlotter
{
    public class Plotter
    {
        private double start_t = 0;
        public double StartT
        {
            get
            {
                return start_t;
            }

            set
            {
                if (end_t > value)
                    start_t = value;
            }
        }

        private double end_t = 100;
        public double EndT
        {
            get
            {
                return end_t;
            }

            set
            {
                if (start_t < value)
                    end_t = value;
            }
        }

        public double Step = 0.1;
        public Converter conv;
        public Color AC { get; set; } = Color.Black;
        public Color BC { get; set; } = Color.White;
        public Color LC { get; set; } = Color.Black;
        public Color NC { get; set; } = Color.Cyan;

        public string xt { get; set; }
        public string yt { get; set; }

        public Plotter() { }

        public void DrawRealPlot(Graphics g, string xt, string yt)
        {
            try
            {
                g.Clear(BC);
                DrawAxesNet(g);
                int width = (int)g.ClipBounds.Width, height = (int)g.ClipBounds.Height;
                XtensibleCalculator c = new XtensibleCalculator();
                Func<Dictionary<string, double>, double> fx, fy;
                var exp = c.ParseFunction(xt);
                fx = exp.Compile();
                exp = c.ParseFunction(yt);
                fy = exp.Compile();
                Dictionary<string, double> Dict = new Dictionary<string, double>();
                Dict.Add("t", StartT);
                Point p = new Point(conv.II(fx(Dict)), conv.JJ(-fy(Dict)));
                for (double i = StartT + Step; i < EndT; i += Step)
                {
                    Dict["t"] = i;
                    Point pt = new Point(conv.II(fx(Dict)), conv.JJ(-fy(Dict)));
                    try
                    {
                        g.DrawLine(new Pen(LC), p, pt);
                    }
                    catch (OverflowException)
                    {
                        break;
                    }
                    p = pt;
                }
            }
            catch (Sprache.ParseException)
            {
                g.Clear(BC);
                DrawAxesNet(g);
            }

        }

        public double SearchForT(int x, int y, string xt, string yt)
        {
            XtensibleCalculator c = new XtensibleCalculator();
            Func<Dictionary<string, double>, double> fx, fy;
            var exp = c.ParseFunction(xt);
            fx = exp.Compile();
            exp = c.ParseFunction(yt);
            fy = exp.Compile();
            Dictionary<string, double> Dict = new Dictionary<string, double>();
            Dict.Add("t", 0);
            for (double i = StartT; i < EndT; i += Step/10)
            {
                Dict["t"] = i;
                Point pt = new Point(conv.II(fx(Dict)), conv.JJ(-fy(Dict)));
                if(Math.Abs(pt.X - x) < 5 && Math.Abs(pt.Y - y) < 5)
                    return Dict["t"];
            }

            return 5000;
        }

        public PointF GetPointF(int i, int j)
        {
            return conv.XXYY(new Point(i, j));
        }

        //public double Get_t(int i, int j)
        //{
        //    PointF p = GetPointF(i, j);

        //    //oh sh...
        //    //need to find the reverse func

        //    //but how
        //    if ()

        //}

        private void DrawAxesNet(Graphics g)
        {
            //axes
            g.DrawLine(new Pen(AC, 2), -1, conv.ScreenHeight / 2, conv.ScreenWidth + 1, conv.ScreenHeight / 2);
            g.DrawLine(new Pen(AC, 2), conv.ScreenWidth / 2, -1, conv.ScreenWidth / 2, conv.ScreenHeight + 1);

            //names for axes
            g.DrawString("x", SystemFonts.DefaultFont, new SolidBrush(AC), conv.ScreenWidth - 10, conv.ScreenHeight / 2 - 15);
            g.DrawString("y", SystemFonts.DefaultFont, new SolidBrush(AC), conv.ScreenWidth / 2 + 2, 15);

            //arrows
            g.DrawLine(new Pen(AC, 2), conv.ScreenWidth / 2 - 1, 0, conv.ScreenWidth / 2 - 4, 5);
            g.DrawLine(new Pen(AC, 2), conv.ScreenWidth / 2 - 1, 0, conv.ScreenWidth / 2 + 4, 5);

            g.DrawLine(new Pen(AC, 2), conv.ScreenWidth, conv.ScreenHeight / 2,
                conv.ScreenWidth - 4, conv.ScreenHeight / 2 + 4);

            g.DrawLine(new Pen(AC, 2), conv.ScreenWidth, conv.ScreenHeight / 2,
                conv.ScreenWidth - 4, conv.ScreenHeight / 2 - 5);

            //net for X
            for (int i = 0; i < conv.ScreenWidth; i+=70)
            {
                g.DrawLine(new Pen(NC), i, -1, i, conv.ScreenHeight + 1);

                if(i > 1 && i < conv.ScreenWidth - 50)
                {
                    g.DrawString(Math.Round(GetPointF(i, 0).X, 2).ToString(),
                        SystemFonts.DefaultFont, new SolidBrush(AC), i, 3);
                    g.DrawString(Math.Round(GetPointF(i, 0).X, 2).ToString(), 
                        SystemFonts.DefaultFont, new SolidBrush(AC), i + 3, conv.ScreenHeight - 15);
                }
            }

            //net for Y
            for (int i = 0; i < conv.ScreenHeight; i+=70)
            {
                g.DrawLine(new Pen(NC), -1, i, conv.ScreenWidth + 1, i);
                if(i > 1 && i < conv.ScreenHeight - 50)
                {
                    g.DrawString(Math.Round(-GetPointF(0, i).Y, 2).ToString(),
                        SystemFonts.DefaultFont, new SolidBrush(AC), 1, i - 12);
                    
                    g.DrawString(Math.Round(-GetPointF(0, i).Y, 2).ToString(),
                        SystemFonts.DefaultFont, new SolidBrush(AC), conv.ScreenWidth - 5 -
                        (int)g.MeasureString(Math.Round(GetPointF(0, i).Y, 2).ToString(),
                        SystemFonts.DefaultFont).Width, i - 12);
                }
            }
        }
    }
}
