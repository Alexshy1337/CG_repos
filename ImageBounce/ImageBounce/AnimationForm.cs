using AdjustablePolygon;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ImageBounce
{
    public partial class AnimationForm : Form
    {
        World world;
        DateTime lastTime;
        Vector2 force;
        DrawPolygonForm form;

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
            force = new Vector2(0, 0);
        }

        private void ResetPuck()
        {
            Bitmap b = new Bitmap(25, 25);
            Graphics g = Graphics.FromImage(b);
            g.FillEllipse(Brushes.Black, 1, 1, 23, 23);
            world.p = new Puck(new Vector2(MainPanel.Width/2, MainPanel.Height/2), 0.15f, b);
            g.Dispose();
        }

        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResetPuck();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFD.ShowDialog() == DialogResult.Cancel) return;
            world.p.Sprite.Dispose();
            world.p.Sprite = new Bitmap(OpenFD.FileName);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            world.Draw(e.Graphics, new MyScreen(new Size(MainPanel.Width, MainPanel.Height), new RectangleF(0, 0, world.Width, world.Height)));
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if(form != null)
            {
                if(form.output != null)
                {
                    world.p.Sprite.Dispose();
                    world.p.Sprite = (Bitmap)form.output.Clone();
                    form.Close();
                    form.Dispose();
                    form = null;
                }
            }
            MainPanel.Invalidate();
        }

        private void MainPanel_mouseDown(object sender, MouseEventArgs e)
        {
            force = new Vector2(e.X - world.p.Position.X, e.Y - world.p.Position.Y);
        }

        private void MainPanel_mouseUp(object sender, MouseEventArgs e)
        {
            force = new Vector2(0,0);
        }

        private void RealTimer_Tick(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now;
            float deltaT = 0.0006f * (curTime - lastTime).Milliseconds;
            world.Update(force, deltaT);
            lastTime = curTime;
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = new DrawPolygonForm();
            form.Show();
        }

        private void MainPanel_Resize(object sender, EventArgs e)
        {
            world.Height = MainPanel.Height;
            world.Width = MainPanel.Width;
        }
    }
}
