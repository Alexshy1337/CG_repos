using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            //conv = new Converter()
        }

        Converter conv;
        Color BC = Color.White, LC = Color.Black;
        bool dragging = false;

        private void PlottingPanel_Paint(object sender, PaintEventArgs e)
        {
            Bitmap b = new Bitmap(PlottingPanel.Width, PlottingPanel.Height);
            DrawRealPlot(b, BC, LC, Xtext.Text, Ytext.Text);
            e.Graphics.DrawImage(b, 0, 0);
            b.Dispose();

        }

        private void PlottingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            PlottingPanel.Focus();
            if(dragging)
            {


                PlottingPanel.Invalidate();
            }
        }

        private void PlottingPanel_MouseUp(object sender, MouseEventArgs e)
        {


            PlottingPanel.Invalidate();
        }

        private void PlottingPanel_MouseDown(object sender, MouseEventArgs e)
        {



            PlottingPanel.Invalidate();
        }

        private void PlottingPanel_MouseClick(object sender, MouseEventArgs e)
        {


            PlottingPanel.Invalidate();
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            BC = MyColorDialog.Color;
        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            if (MyColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            LC = MyColorDialog.Color;
        }

        private void PlottingPanel_MouseWheel(object sender, MouseEventArgs e)
        {




            PlottingPanel.Invalidate();
        }

        

        private void DrawRealPlot(Bitmap bit, Color LineColor, Color BackColor, string xt, string yt)
        {
            XtensibleCalculator c = new XtensibleCalculator();

            var exp = c.ParseFunction(xt);
            var fx = exp.Compile();
            exp = c.ParseFunction(yt);
            var fy = exp.Compile();
            Dictionary<string, double> Dict = new Dictionary<string, double>();
            Dict.Add("t", 0);

            for (int i = -bit.Width / 2; i < bit.Width/2; i++ )
            {
                Dict["t"] = i;

                bit.SetPixel(conv.II(fx(Dict)), conv.JJ(fy(Dict)), LineColor);
                
                
                //var calc = new Sprache.Calc.XtensibleCalculator();

                // using expressions
                //var expr = calc.ParseExpression("Sin(y/x)", x => 2, y => System.Math.PI);
                //var func = expr.Compile();


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




 Usage example

var calc = new Sprache.Calc.XtensibleCalculator();

// using expressions
var expr = calc.ParseExpression("Sin(y/x)", x => 2, y => System.Math.PI);
var func = expr.Compile();
Console.WriteLine("Result = {0}", func());

// custom functions
calc.RegisterFunction("Mul", (a, b, c) => a * b * c);
expr = calc.ParseExpression("2 ^ Mul(PI, a, b)", a => 2, b => 10);
Console.WriteLine("Result = {0}", func.Compile()());

    

 */
