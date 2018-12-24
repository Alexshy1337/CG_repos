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
        private Point last;

        Triangle t1 = new Triangle(new Vector3(0.1f, 0.1f, 0.1f), new Vector3(0.1f, 0.4f, 0.2f), new Vector3(0.4f, 0.1f, 0.4f)),
                 t2 = new Triangle(new Vector3(0.4f, 0.3f, 0.2f), new Vector3(0.0f, 0.2f, 0.4f), new Vector3(0.3f, 0.1f, 0.0f));

        public ModelingForm()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, MainPanel, new object[] { true });
            Reset();
        }

        private void Reset()
        {
            scene = new Scene();
            scene.Models.Add(t1);
            scene.Models.Add(t2);
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(1, 0, 0)));
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(0, 1, 0)));
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(0, 0, 1)));

            UPDbutton_Click(new object(), new EventArgs());

            camera = new Camera();
            last = new Point();
            MainPanel.Invalidate();
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = e.Location;
        }

        private void MainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = new Point();
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left) && !last.IsEmpty)
            {
                float dx = -e.Location.X + last.X;
                float dy =  e.Location.Y - last.Y;
                camera.View =
                    Matrix4.Rotate(1, dx * (float)Math.PI / 180) *
                    Matrix4.Rotate(0, dy * (float)Math.PI / 180) *
                    camera.View;
                MainPanel.Invalidate();
                last = e.Location;
            }
            last = e.Location;
        }

        private void UPDbutton_Click(object sender, EventArgs e)
        {
            t1.Points[0] = new Vector3((float)(t1ax.Value / 10), (float)(t1ay.Value / 10), (float)(t1az.Value / 10));
            t1.Points[1] = new Vector3((float)(t1bx.Value / 10), (float)(t1by.Value / 10), (float)(t1bz.Value / 10));
            t1.Points[2] = new Vector3((float)(t1cx.Value / 10), (float)(t1cy.Value / 10), (float)(t1cz.Value / 10));
            t1.UpdatePlane();

            t2.Points[0] = new Vector3((float)(t2ax.Value / 10), (float)(t2ay.Value / 10), (float)(t2az.Value / 10));
            t2.Points[1] = new Vector3((float)(t2bx.Value / 10), (float)(t2by.Value / 10), (float)(t2bz.Value / 10));
            t2.Points[2] = new Vector3((float)(t2cx.Value / 10), (float)(t2cy.Value / 10), (float)(t2cz.Value / 10));
            t2.UpdatePlane();

            MainPanel.Invalidate();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = scene.DrawAll(camera,
            new ClassLibrary1.Screen(Size,
            new Rectangle(-1, -1, 2, 2)));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();

        }

        private void IntButton_Click(object sender, EventArgs e)
        {
            List<Vector3> points = Scene.TriangleIntersection(t1, t2);
            if(points.Count > 0)
            {
                scene.Models.Add(new PolyLine3D(points, Color.Red, true));
                AnswerTextBox.Text = "";
                for (int i = 0; i < points.Count; i++)
                    AnswerTextBox.Text += "(" + (points[i].X * 10).ToString() + ", " + (points[i].Y * 10).ToString() + ", " + (points[i].Z * 10).ToString() + ")";
                MainPanel.Invalidate();
            }
        }
    }
}





