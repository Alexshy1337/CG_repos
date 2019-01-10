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

        public static bool LineSegmentContainsPoint(Vector3 a, Vector3 b, Vector3 p)
        {
            return (

            StraightLine.StraightLineContainsPoint(new StraightLine(a, b), p))
            &&
            (Math.Min(a.X, b.X) <= p.X && p.X <= Math.Max(a.X, b.X))
            &&
            (Math.Min(a.Y, b.Y) <= p.Y && p.Y <= Math.Max(a.Y, b.Y))
            &&
            (Math.Min(a.Z, b.Z) <= p.Z && p.Z <= Math.Max(a.Z, b.Z));
        }

        public static List<Vector3> LineSegmentsOverlap(List<Vector3> a, List<Vector3> b)
        {
            if (a.Count == 0 || b.Count == 0)
                return new List<Vector3>();
            else if (a.Count == 1 && b.Count == 1)
                return (a[0] == b[0]) ? a : new List<Vector3>();
            else if (a.Count == 1 && b.Count == 2)
                return (LineSegmentContainsPoint(b[0], b[1], a[0])) ? a : new List<Vector3>();
            else if (a.Count == 2 && b.Count == 1)
                return (LineSegmentContainsPoint(a[0], a[1], b[0])) ? b : new List<Vector3>();
            else
            {
                if (LineSegmentContainsPoint(a[0], a[1], b[0]))
                {
                    if (LineSegmentContainsPoint(a[0], a[1], b[1]))
                        return b;
                    else
                    {
                        List<Vector3> q = new List<Vector3>();
                        q.Add(b[0]);

                        if (LineSegmentContainsPoint(b[0], b[1], a[0]))
                            q.Add(a[0]);
                        else
                            q.Add(a[1]);

                        return q;
                    }
                }

                else if (LineSegmentContainsPoint(a[0], a[1], b[1]))
                {
                    if (LineSegmentContainsPoint(a[0], a[1], b[0]))
                        return b;
                    else
                    {
                        List<Vector3> q = new List<Vector3>();
                        q.Add(b[1]);

                        if (LineSegmentContainsPoint(b[0], b[1], a[0]))
                            q.Add(a[0]);
                        else
                            q.Add(a[1]);

                        return q;
                    }

                }

                else if (LineSegmentContainsPoint(b[0], b[1], a[0]) && LineSegmentContainsPoint(b[0], b[1], a[1]))
                    return a;

                else if (a.Count > 2 || b.Count > 2)
                    throw new Exception("Too many points!!!");

                else return new List<Vector3>();
            }
        }

        private static void DeleteRepetitions(List<Vector3> list)
        {
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list.Count; j++)
                    if (i != j)
                        if (list[i] == list[j])
                            list.Remove(list[j]);
        }

        public static List<Vector3> TriangleIntersection(Triangle t1, Triangle t2)
        {
            //плоскости не параллельны
            if (t1.plane.A * t2.plane.B != t1.plane.B * t2.plane.A
            ||
            t1.plane.B * t2.plane.C != t1.plane.C * t2.plane.B
            ||
            t1.plane.A * t2.plane.C != t1.plane.C * t2.plane.A)
            {
                List<Vector3> I1 = new List<Vector3>(), I2 = new List<Vector3>();

                Vector3 temp = t1.plane.Intersection(t2.Points[0], t2.Points[1]);
                if (LineSegmentContainsPoint(t2.Points[0], t2.Points[1], temp))
                    I2.Add(temp);

                temp = t1.plane.Intersection(t2.Points[1], t2.Points[2]);
                if (LineSegmentContainsPoint(t2.Points[1], t2.Points[2], temp))
                    I2.Add(temp);

                temp = t1.plane.Intersection(t2.Points[0], t2.Points[2]);
                if (LineSegmentContainsPoint(t2.Points[0], t2.Points[2], temp))
                    I2.Add(temp);

                temp = t2.plane.Intersection(t1.Points[0], t1.Points[1]);
                if (LineSegmentContainsPoint(t1.Points[0], t1.Points[1], temp))
                    I1.Add(temp);

                temp = t2.plane.Intersection(t1.Points[1], t1.Points[2]);
                if (LineSegmentContainsPoint(t1.Points[1], t1.Points[2], temp))
                    I1.Add(temp);

                temp = t2.plane.Intersection(t1.Points[0], t1.Points[2]);
                if (LineSegmentContainsPoint(t1.Points[0], t1.Points[2], temp))
                    I1.Add(temp);


                DeleteRepetitions(I1);
                DeleteRepetitions(I2);
                return LineSegmentsOverlap(I1, I2);
            }
            else if (t1.plane == t2.plane)
            {
                List<Vector3> output = new List<Vector3>();
                //List<Vector3> I1 = new List<Vector3>(), I2 = new List<Vector3>();

                //StraightLine a = new StraightLine(t1.Points[0], t1.Points[1]),
                //    b = new StraightLine(t2.Points[0], t2.Points[1]);
                //Vector3 temp = a.Intersection(b);

                //if (StraightLine.StraightLineContainsPoint(a, temp) 
                //    && StraightLine.StraightLineContainsPoint(b, temp))
                //    output.Add(temp);

                //a = new StraightLine(t1.Points[1], t1.Points[2]);

                //if (StraightLine.StraightLineContainsPoint(a, temp)
                //    && StraightLine.StraightLineContainsPoint(b, temp))
                //    output.Add(temp);

                //a = new StraightLine(t1.Points[0], t1.Points[2]);

                //if (StraightLine.StraightLineContainsPoint(a, temp)
                //    && StraightLine.StraightLineContainsPoint(b, temp))
                //    output.Add(temp);





                StraightLine a, b;
                Vector3 temp;

                for (int i = 1; i < 3; i++)
                    for (int j = 1; j < 3; j++)
                    {
                        a = new StraightLine(t1.Points[i - 1], t1.Points[i]);
                        b = new StraightLine(t2.Points[j - 1], t2.Points[j]);

                        temp = a.Intersection(b);

                        if (StraightLine.StraightLineContainsPoint(a, temp)
                         && StraightLine.StraightLineContainsPoint(b, temp))
                            output.Add(temp);
                    }

                for(int j = 1; j < 3; j++)
                {
                    a = new StraightLine(t1.Points[0], t1.Points[2]);
                    b = new StraightLine(t2.Points[j - 1], t2.Points[j]);

                    temp = a.Intersection(b);

                    if (StraightLine.StraightLineContainsPoint(a, temp)
                     && StraightLine.StraightLineContainsPoint(b, temp))
                        output.Add(temp);
                }

                a = new StraightLine(t1.Points[0], t1.Points[2]);
                b = new StraightLine(t2.Points[0], t2.Points[2]);

                temp = a.Intersection(b);

                if (StraightLine.StraightLineContainsPoint(a, temp)
                 && StraightLine.StraightLineContainsPoint(b, temp))
                    output.Add(temp);


                DeleteRepetitions(output);
                //DeleteRepetitions(I2);

                return output;
            }
            else //параллельны
                return new List<Vector3>();
        }

        public Bitmap DrawAll(Camera cam, Screen scr)
        {
            Bitmap bmp = new Bitmap(scr.Size.Width, scr.Size.Height);
            Graphics g = Graphics.FromImage(bmp);

            // process of drawing
            List<PolyLine3D> lines = new List<PolyLine3D>();

            foreach (IModel m in Models)
                foreach (PolyLine3D pl in m.GetLines()) // поворот всех точек в систему координат камеры
                {
                    List<Vector3> vl = new List<Vector3>();
                    foreach (Vector3 v in pl.Vertices)
                        vl.Add(cam.Convert(v));
                    lines.Add(new PolyLine3D(vl, pl.color));
                }

            //sort набор линий так, чтобы те, которые дальше экрана, были в начале списка lines.Sort(); (важно в случае полигонов)
            foreach (var pl in lines)
            {
                List<Point> points = new List<Point>();
                foreach (Vector3 v in pl.Vertices)
                    points.Add(scr.Convert(v));
                g.DrawLines(new Pen(pl.color, pl.color != Color.Black? 2f:1f), points.ToArray());
            }

            g.Dispose();
            return bmp;
        }
    }
}
