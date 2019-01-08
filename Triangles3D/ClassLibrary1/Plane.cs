using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Plane
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float D { get; set; }
        public Vector3 N { get; set; }

        public Plane() { }

        public Plane(Vector3 a, Vector3 b, Vector3 c)
        {
            Vector3 w = new Vector3(a, b), v = new Vector3(a, c);


            A = v[1] * w[2] - v[2] * w[1];

            B = v[2] * w[0] - v[0] * w[2];

            C = v[0] * w[1] - v[1] * w[0];

            D = a.Y * B - a.X * A - a.Z * C;

            N = new Vector3(A, B, C);
        }

        public Vector3 Intersection(StraightLine l)
        {

            //добавить проверку параллельности прямой и плоскости
            float t = (-D - C * l.point.Z - B * l.point.Y - A * l.point.X)
                        / Vector3.ScalarMultiplication(l.DirVector, N);

            return new Vector3((l.point.X + t * l.DirVector.X), (l.point.Y + t * l.DirVector.Y), (l.point.Z + t * l.DirVector.Z));
        }

        public static bool operator ==(Plane a, Plane b)
        {
            return (a.A / b.A == a.B / b.B
            &&
            a.B / b.B == a.C / b.C
            &&
            a.A / b.A == a.C / b.C
            &&
            a.D == b.D);
        }

        public static bool operator !=(Plane a, Plane b)
        {
            return (a.A / b.A != a.B / b.B
            ||
            a.B / b.B != a.C / b.C
            ||
            a.A / b.A != a.C / b.C
            ||
            a.D != b.D);
        }

    }
}
