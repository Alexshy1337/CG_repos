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

        Triangle t1 = new Triangle(new Vector3(1f, 1f, 1f), new Vector3(1f, 4f, 2f), new Vector3(4f, 1f, 4f)),
                 t2 = new Triangle(new Vector3(4f, 3f, 2f), new Vector3(0f, 2f, 4f), new Vector3(3f, 1f, 0f));

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
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(5, 0, 0)));
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(0, 5, 0)));
            scene.Models.Add(new Line3D(new Vector3(0, 0, 0), new Vector3(0, 0, 5)));

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
                double dx = -e.Location.X + last.X;
                double dy =  e.Location.Y - last.Y;
                camera.View =
                    Matrix4.Rotate(1, dx * (double)Math.PI / 180) *
                    Matrix4.Rotate(0, dy * (double)Math.PI / 180) *
                    camera.View;
                MainPanel.Invalidate();
                last = e.Location;
            }
            last = e.Location;
        }

        private void UPDbutton_Click(object sender, EventArgs e)
        {
            t1.Points[0] = new Vector3((double)(t1ax.Value), (double)(t1ay.Value), (double)(t1az.Value));
            t1.Points[1] = new Vector3((double)(t1bx.Value), (double)(t1by.Value), (double)(t1bz.Value));
            t1.Points[2] = new Vector3((double)(t1cx.Value), (double)(t1cy.Value), (double)(t1cz.Value));
            t1.UpdatePlane();

            t2.Points[0] = new Vector3((double)(t2ax.Value), (double)(t2ay.Value), (double)(t2az.Value));
            t2.Points[1] = new Vector3((double)(t2bx.Value), (double)(t2by.Value), (double)(t2bz.Value));
            t2.Points[2] = new Vector3((double)(t2cx.Value), (double)(t2cy.Value), (double)(t2cz.Value));
            t2.UpdatePlane();

            MainPanel.Invalidate();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = scene.DrawAll(camera,
            new ClassLibrary1.Screen(MainPanel.Size,
            new Rectangle(-8, -8, 16, 16)));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();

        }


        private void IntButton_Click(object sender, EventArgs e)
        {
            //if(scene.Models[scene.Models.Count - 1].)
            //scene.Models.Remove(scene.Models.Last());
            List<Vector3> intersectionPoints = new List<Vector3>();

            intersectionPoints = Scene.TriangleIntersection(t1, t2);
            if (intersectionPoints.Count > 0)
            {
                scene.Models.Add(new PolyLine3D(intersectionPoints, Color.Red, true));
                AnswerTextBox.Text = "";
                for (int i = 0; i < intersectionPoints.Count; i++)
                    AnswerTextBox.Text += "(" + (Math.Round(intersectionPoints[i].X, 2)).ToString() + "; " + (Math.Round(intersectionPoints[i].Y, 2)).ToString() + "; " + (Math.Round(intersectionPoints[i].Z, 2)).ToString() + ") ";
                MainPanel.Invalidate();
            }
            else
                AnswerTextBox.Text = "";
        }
    }
}





