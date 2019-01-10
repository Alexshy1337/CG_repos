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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, PlottingPanel, new object[] { true });
            ForPlot = new Plotter();
            ForPlot.conv = new Converter(PlottingPanel.Width, PlottingPanel.Height);
        }

        //Converter conv;
        //Point LastMouseLocation;
        Plotter ForPlot;
        Point lastPoint = new Point(0,0);
        bool dragging = false;

        private void PlottingPanel_Paint(object sender, PaintEventArgs e)
        {
            ForPlot.StartT = (double)StartT.Value;
            ForPlot.EndT = (double)EndT.Value;
            ForPlot.Step = (double)Step.Value;
            Bitmap b = new Bitmap(PlottingPanel.Width, PlottingPanel.Height);
            Graphics g = Graphics.FromImage(b);
            ForPlot.DrawRealPlot(g, Xtext.Text, Ytext.Text);
            e.Graphics.DrawImage(b, 0, 0);
            b.Dispose();
            g.Dispose();
        }

        private void PlottingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            PlottingPanel.Focus();
            PointF temp = ForPlot.GetPointF(e.X, e.Y);
            XYLabel.Text = "(x, y) = (" + Math.Round(temp.X, 2).ToString() + "; " + Math.Round(temp.Y, 2).ToString() + ")";


            if(dragging)
            {
                double deltaX = ForPlot.conv.XX(e.X) - ForPlot.conv.XX(lastPoint.X),
                    deltaY = ForPlot.conv.YY(e.Y) - ForPlot.conv.YY(lastPoint.Y);
                ForPlot.conv.X1 -= deltaX;
                ForPlot.conv.X2 -= deltaX;
                ForPlot.conv.Y1 -= deltaY;
                ForPlot.conv.Y2 -= deltaY;

                PlottingPanel.Invalidate();
                lastPoint = e.Location;
            }
        }

        private void PlottingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PlottingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            dragging = true;
        }

        private void PlottingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                double t = ForPlot.SearchForT(e.X, e.Y, Xtext.Text, Ytext.Text);
                if (t > 3000)
                    TLabel.Text = "t is undefined around here";
                else
                    TLabel.Text = "t ≈ " + Math.Round(t, 3).ToString();

                PlottingPanel.Invalidate();
            }

        }

        private void PlottingPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if(CRB.Checked)
            {
                double x = ForPlot.conv.XX(e.X), y = ForPlot.conv.YY(e.Y);
                double changeCoeff = e.Delta > 0 ? 0.75 : 1.25;
                ForPlot.conv.X1 = x - (x - ForPlot.conv.X1) * changeCoeff;
                ForPlot.conv.Y1 = y - (y - ForPlot.conv.Y1) * changeCoeff;
                ForPlot.conv.X2 = x + (ForPlot.conv.X2 - x) * changeCoeff;
                ForPlot.conv.Y2 = y + (ForPlot.conv.Y2 - y) * changeCoeff;
            }
            else 
            if (ForPlot.conv.X2 - ForPlot.conv.ScreenWidth * e.Delta / 300 > 0
                &&
                ForPlot.conv.Y2 - ForPlot.conv.ScreenHeight * e.Delta / 300 > 0
                ||
                e.Delta < 0)
            {
                ForPlot.conv.X1 += ForPlot.conv.ScreenWidth * e.Delta / 300;
                ForPlot.conv.X2 -= ForPlot.conv.ScreenWidth * e.Delta / 300;
                ForPlot.conv.Y1 += ForPlot.conv.ScreenHeight * e.Delta / 300;
                ForPlot.conv.Y2 -= ForPlot.conv.ScreenHeight * e.Delta / 300;
            }
            PlottingPanel.Invalidate();
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                ForPlot.BC = MyColorDialog.Color;
                PlottingPanel.Invalidate();
            }
            else return;
        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                ForPlot.LC = MyColorDialog.Color;
                PlottingPanel.Invalidate();
            } else return;
        }

        private void AxisColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                ForPlot.AC = MyColorDialog.Color;
                PlottingPanel.Invalidate();
            }
            else return;
        }

        private void NetColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                ForPlot.NC = MyColorDialog.Color;
                PlottingPanel.Invalidate();
            }
            else return;

        }

        private void FuncTextDone(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                PlottingPanel.Invalidate();
        }

        //private void MainForm_ResizeEnd(object sender, EventArgs e)
        //{
            //if ((PlottingPanel.Width / 2) % 70 != 0)
            //    Width += 70 - ((PlottingPanel.Width / 2) % 70);
            //if ((PlottingPanel.Height / 2) % 70 != 0)
            //    Height += 70 - ((PlottingPanel.Height / 2) % 70);
            //ForPlot.conv = new Converter(PlottingPanel.Width, PlottingPanel.Height);
            //PlottingPanel.Invalidate();
        //}

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ForPlot.conv = new Converter(PlottingPanel.Width, PlottingPanel.Height);
            PlottingPanel.Invalidate();
        }

        private void TParams_Changed(object sender, EventArgs e)
        {
            PlottingPanel.Invalidate();
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

DONE перетаксивание, 
DONE масштабирование,
DONE автоматическое построение (убрать кнопку "new func"), 
DONE архитектура,         
no t вычисление по клику, kind of impossible??? a little???
DONE оси и сетка          


 */
