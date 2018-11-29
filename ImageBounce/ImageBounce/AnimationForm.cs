using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBounce
{
    public partial class AnimationForm : Form
    {
        World world;
        DateTime lastTime;
        Vector2 f;


        public AnimationForm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, MainPanel, new object[] { true });
            world = new World(9.8f, 0f, MainPanel.Width, MainPanel.Height);
            ResetPuck();
            lastTime = DateTime.Now;
            f = new Vector2(0, 0);
        }

        private void ResetPuck()
        {
            Bitmap b = new Bitmap(25, 25);
            Graphics g = Graphics.FromImage(b);
            g.FillEllipse(Brushes.Black, 1, 1, 23, 23);
            world.p = new Puck(new Vector2(MainPanel.Width/2, MainPanel.Height/2), 0.15f, b);
            g.Dispose();
        }

        private void ResetPuck(Vector2 pos)
        {
            world.p.Sprite.Dispose();
            Bitmap b = new Bitmap(25, 25);
            Graphics g = Graphics.FromImage(b);
            g.FillEllipse(Brushes.Black, 1, 1, 23, 23);
            world.p = new Puck(pos, 0.15f, b);
            g.Dispose();
        }

        private void ResetPuck(Vector2 pos, Bitmap b)
        {
            world.p.Sprite.Dispose();
            world.p.Sprite = b;
        }

        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResetPuck();
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPuck(world.p.Position);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFD.ShowDialog() == DialogResult.Cancel) return;
            Bitmap picture = new Bitmap(OpenFD.FileName);
            ResetPuck(world.p.Position, picture);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage();
            //world.Draw(e.Graphics, new Screen(new Size(world.Width, world.Height), new RectangleF(0, 0, world.Width, world.Height)));
            world.Draw(e.Graphics, new Screen(new Size(MainPanel.Width, MainPanel.Height), new RectangleF(0, 0, world.Width, world.Height)));
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            MainPanel.Invalidate();
        }

        private void MainPanel_mouseDown(object sender, MouseEventArgs e)
        {
            f = new Vector2(e.X - world.p.Position.X, e.Y - world.p.Position.Y);
            TestLabel.Text = "mousedown" + f.X.ToString() + " " + f.Y.ToString();
        }

        private void MainPanel_mouseUp(object sender, MouseEventArgs e)
        {
            f = new Vector2(0,0);
        }

        private void RealTimer_Tick(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now;
            float deltaT = 0.0006f * (curTime - lastTime).Milliseconds;
            world.Update(f, deltaT);
            lastTime = curTime;
            RealLabel.Text = "";
        }

       
    }
}
