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
            A = (b.Y - a.Y) * (c.Z - a.Z) - (c.Y - a.Y) * (b.Z - a.Z);
            B = (c.X - a.X) * (b.Z - a.Z) - (b.X - a.X) * (c.Z - a.Z);
            C = (b.X - a.X) * (c.Y - a.Y) - (c.X - a.X) * (b.Y - a.Y);
            D = -a.X * ((b.Y - a.Y) * (c.Z - a.Z) - (c.Y - a.Y) * (b.Z - a.Z))
                - a.Y * ((c.X - a.X) * (b.Z - a.Z) - (b.X - a.X) * (c.Z - a.Z))
                - a.Z * ((b.X - a.X) * (c.Y - a.Y) - (c.X - a.X) * (b.Y - a.Y));
            N = new Vector3(A, B, C);
        }

        public Vector3 IntersectionWithLine(StraightLine l)
        {
            float t = (-D - C * l.point.Z - B * l.point.Y - A * l.point.X) / Vector3.ScalarMultiplication(l.DirVector, N);
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
