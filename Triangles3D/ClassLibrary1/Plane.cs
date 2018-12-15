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

        public Vector3 IntersectionWithLine(Vector3 v)
        {
            Vector3 p = new Vector3();




            return p;
        }

        //public void PlaneFromThreePoints(Vector3 a, Vector3 b, Vector3 c)
        //{
        //    A = (b.Y - a.Y) * (c.Z - a.Z) - (c.Y - a.Y) * (b.Z - a.Z);
        //    B = (c.X - a.X) * (b.Z - a.Z) - (b.X - a.X) * (c.Z - a.Z);
        //    C = (b.X - a.X) * (c.Y - a.Y) - (c.X - a.X) * (b.Y - a.Y);
        //    D = -a.X * ((b.Y - a.Y) * (c.Z - a.Z) - (c.Y - a.Y) * (b.Z - a.Z))
        //        - a.Y * ((c.X - a.X) * (b.Z - a.Z) - (b.X - a.X) * (c.Z - a.Z))
        //        - a.Z * ((b.X - a.X) * (c.Y - a.Y) - (c.X - a.X) * (b.Y - a.Y));
        //    N = new Vector3(A, B, C);
        //}
    }
}
