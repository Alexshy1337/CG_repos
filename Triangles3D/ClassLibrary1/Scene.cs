using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibrary1
{
    public class Scene
    {
        public List<IModel> Models { get; set; }

        public Scene()
        {
            Models = new List<IModel>();
        }

        public static List<PointF> TriangleIntersection(Triangle t1, Triangle t2)
        {
            //плоскости не параллельны
            if (t1.P.A / t2.P.A != t1.P.B / t2.P.B
                &&
                t1.P.B / t2.P.B != t1.P.C / t2.P.C
                &&
                t1.P.A / t2.P.A != t1.P.C / t2.P.C)
            {
                StraightLine intersection = new StraightLine(t1.P, t2.P);

                //найти пересечение прямой intersection с треугольником (получить отрезки для каждого треугольника)
                //проверить наложение найденных отрезков

















                //List<PointF> l = new List<PointF>();

                //return l;

            }
            else
            
            //лежат в одной плоскости
            if (t1.P.A / t2.P.A == t1.P.B / t2.P.B
                &&
                t1.P.B / t2.P.B == t1.P.C / t2.P.C
                &&
                t1.P.A / t2.P.A == t1.P.C / t2.P.C 
                &&
                t1.P.D == t2.P.D)
            {




            } else
                //параллельны в несовпадающих плоскостях
                return new List<PointF>();


            //проверить параллельность, нахождение в одной плоскости и обычное пересечение



        }

        //public 

        public Bitmap DrawAll(Camera cam, Screen scr)
        {
            Bitmap bmp = new Bitmap(scr.Size.Width, scr.Size.Height);
            Graphics g = Graphics.FromImage(bmp);

            // process of drawing
            List<PolyLine3D> lines = new List<PolyLine3D>();

            foreach(IModel m in Models)
                foreach(PolyLine3D pl in m.GetLines()) // поворот всех точек в систему координат камеры
                {
                    List<Vector3> vl = new List<Vector3>();
                    foreach (Vector3 v in pl.Vertices)
                        vl.Add(cam.Convert(v));
                    lines.Add(new PolyLine3D(vl));
                }

            //sort набор линий так, чтобы те, которые дальше экрана, были в начале списка lines.Sort(); (важно в случае полигонов)
            foreach(var pl in lines)
            {
                List<Point> points = new List<Point>();
                foreach (Vector3 v in pl.Vertices)
                    points.Add(scr.Convert(v));
                g.DrawLines(Pens.Black, points.ToArray());
            }

            g.Dispose();
            return bmp;
        }
    }
}
