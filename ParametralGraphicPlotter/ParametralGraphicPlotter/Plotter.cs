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
        public Plotter() { }

        public Plotter(string expr)
        {
            var calc = new ScientificCalculator();            
        }




        public void DrawRealPlot(Bitmap bit, Color LineColor, Color BackColor)
        {


        }

    }
}
