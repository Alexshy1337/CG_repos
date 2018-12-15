using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametralGraphicPlotter
{
    //binary_Tree
    public class Plotter
    {
        //whaaaaaaaaaaaaaaaaaaaat
        public PlotterNode RootX;
        public PlotterNode RootY;

        public Plotter() { }

        public Plotter(string xt, string yt)
        {
            RootX = Parser(xt);
            RootY = Parser(yt);

        }


        public PlotterNode Parser (string a)
        {
            //recursion is a curse


            return new PlotterNode();
        }


        public void DrawRealPlot(Bitmap bit, Color LineColor, Color BackColor)
        {


        }

    }

    public class PlotterNode
    {
        public PlotterNode Left { get; set; }
        public PlotterNode Right { get; set; }
        public PlotterNode Parent { get; set; }



        public PlotterNode() { }

        public PlotterNode(PlotterNode p)
        {
            Parent = p;
        }



    }
}
