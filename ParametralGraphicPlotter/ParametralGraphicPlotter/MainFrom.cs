using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sprache.Calc;

namespace ParametralGraphicPlotter
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, PlottingPanel, new object[] { true });
        }

        Converter conv;
        //Point LastMouseLocation;
        Color BC = Color.White, LC = Color.Black, AC = Color.Black;
        bool dragging = false;

        private void PlottingPanel_Paint(object sender, PaintEventArgs e)
        {
            conv = new Converter(PlottingPanel.Width, PlottingPanel.Height);
            Bitmap b = new Bitmap(PlottingPanel.Width, PlottingPanel.Height);
            Graphics g = Graphics.FromImage(b);
            DrawRealPlot(g, Xtext.Text, Ytext.Text);
            e.Graphics.DrawImage(b, 0, 0);
            b.Dispose();
            g.Dispose();
        }

        private void PlottingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            PlottingPanel.Focus();
            if(dragging)
            {
                //e.Location

                PlottingPanel.Invalidate();
            }
        }

        private void PlottingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PlottingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
        }

        private void PlottingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {



                PlottingPanel.Invalidate();
            }

        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                BC = MyColorDialog.Color;
                PlottingPanel.Invalidate();
            }
            else return;
        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                LC = MyColorDialog.Color;
                PlottingPanel.Invalidate();
            } else return;
        }

        private void AxisColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                AC = MyColorDialog.Color;
                PlottingPanel.Invalidate();
            }
            else return;
        }

        private void PlottingPanel_MouseWheel(object sender, MouseEventArgs e)
        {




            PlottingPanel.Invalidate();
        }

        private void NewFunc_Click(object sender, EventArgs e)
        {
            PlottingPanel.Invalidate();
        }

        private void DrawRealPlot(Graphics g, string xt, string yt)
        {
            try
            {
                g.Clear(BC);
                int width = (int)g.ClipBounds.Width, height = (int)g.ClipBounds.Height;
                XtensibleCalculator c = new XtensibleCalculator();

                Func<Dictionary<string, double>, double> fx, fy;


                var exp = c.ParseFunction(xt);
                fx = exp.Compile();
                exp = c.ParseFunction(yt);
                fy = exp.Compile();
                Dictionary<string, double> Dict = new Dictionary<string, double>();

                Dict.Add("t", (double)StartT.Value);

                //rough axes
                g.DrawLine(new Pen(AC), -1, height / 2, width + 1, height / 2);
                g.DrawLine(new Pen(AC), width / 2, -1, width / 2, height + 1);



                //rough plotting
                Point p = new Point(conv.II(fx(Dict)), conv.JJ(-fy(Dict)));
                for (double i = (double)StartT.Value + (double)Step.Value; i < (double)EndT.Value; i += (double)Step.Value)
                {
                    Dict["t"] = i;
                    Point pt = new Point(conv.II(fx(Dict)), conv.JJ(-fy(Dict)));
                    if (p.X >= -width && p.Y >= -height && pt.X >= -width && pt.Y >= -height && p.X <= width && p.Y <= height && pt.X <= width && pt.Y <= height)
                        g.DrawLine(new Pen(LC), p, pt);
                    p = pt;
                }
            }

            catch (Sprache.ParseException)
            {
                ErrorLabel.Text = "Wrong input!";
            }



        }

    }
}


/*
 
    x(t)
    y(t)

    -масштаб
    -перемещение листа
    -смена цвета фона/линий
    -вывод координат мыши + значение t(при нажатии на правую кнопку?)


     Построить график функции, заданной параметрическими уравнениями.
     При выполнении этого проекта предполагается развитый интерфейс,
     позволяющий изменять масштаб, сдвигать окно на бумаге, менять цвета фона и линий. 
     Также должна быть предусмотрена возможность выводить координаты курсора мыши
     и параметра t при нажатии на правую кнопку.
     
     */


/*


    перетаксивание, архитектура, вычисление по клику, оси и сетка


 */
