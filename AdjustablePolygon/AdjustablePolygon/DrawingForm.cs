using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdjustablePolygon
{
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {

           // InfoLabel.Text = "mouse down";
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //InfoLabel.Text = "mouse up";

        }
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //InfoLabel.Text = "mouse move";

        }



    }
}
