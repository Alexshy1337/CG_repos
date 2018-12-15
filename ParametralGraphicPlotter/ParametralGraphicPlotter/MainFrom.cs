using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        Plotter P;
        Color BC, LC;

        private void PlottingPanel_Paint(object sender, PaintEventArgs e)
        {
            Bitmap b = new Bitmap(PlottingPanel.Width, PlottingPanel.Height);
            P.DrawRealPlot(b, BC, LC);
        }

        private void PlottingPanel_MouseMove(object sender, MouseEventArgs e)
        {

            PlottingPanel.Invalidate();
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
