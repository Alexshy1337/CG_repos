using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Triangles3D
{
    public partial class ModelingForm : Form
    {
        private Scene scene;
        private Camera camera;
        public ModelingForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scene = new Scene();
            //scene.Models.Add(new Brick(new Vector3(0.3f, 0.3f, 0.3f), new Vector3(0.7f, 0.7f, 0.7f)));
            scene.Models.Add(new Triangle(new Vector3(0.1f, 0.1f, 0.1f),new Vector3(0.1f, 0.4f, 0.2f), new Vector3(0.4f, 0.1f, 0.4f)));
            scene.Models.Add(new Triangle(new Vector3(0.4f, 0.3f, 0.2f), new Vector3(0f, 0.2f, 0.4f), new Vector3(0.3f, 0.1f, 0f)));
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(1, 0, 0)));
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(0, 1, 0)));
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(0, 0, 1)));
            camera = new Camera();
            //scene.Models[0]

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = scene.DrawAll(camera,
                new ClassLibrary1.Screen(Size,
                new Rectangle(-1, -1, 2, 2)));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }
        Point last = new Point();


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = e.Location;
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = new Point();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left) && !last.IsEmpty)
            {
                float dx = e.Location.X - last.X;
                float dy = e.Location.Y - last.Y;
                camera.View =
                    Matrix4.Rotate(1, dx * (float)Math.PI / 180) *
                    Matrix4.Rotate(0, dy * (float)Math.PI / 180) *
                    camera.View;
                Invalidate();
                last = e.Location;
            }
            last = e.Location;
        }
    }
}





