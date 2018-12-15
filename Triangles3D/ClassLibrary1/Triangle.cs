using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : IModel
    {
        public Vector3 A { get; set; }
        public Vector3 B { get; set; }
        public Vector3 C { get; set; }
        public Plane P { get; set; }

        public Triangle() { }

        public Triangle(Vector3 a, Vector3 b, Vector3 c)
        {
            A = a;
            B = b;
            C = c;
            P = new Plane(a, b, c);
        }

        public List<PolyLine3D> GetLines()
        {
            List<PolyLine3D> l = new List<PolyLine3D>
            {new PolyLine3D(new List<Vector3>{A, B, C}, true)};
            return l;
        }



        //turnAroundAxis(axis, angle)

    }
}
