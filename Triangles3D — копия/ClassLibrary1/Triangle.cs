using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : IModel
    {
        public Vector3[] Points { get; set; }
        public Plane plane { get; set; }

        public Triangle() { }

        public Triangle(Vector3 a, Vector3 b, Vector3 c)
        {
            Points = new Vector3[3];
            Points[0] = a;
            Points[1] = b;
            Points[2] = c;
            plane = new Plane(a, b, c);
        }

        public List<PolyLine3D> GetLines()
        {
            List<PolyLine3D> l = new List<PolyLine3D>
            {new PolyLine3D(new List<Vector3>{Points[0],Points[1],Points[2]}, true)};
            return l;
        }



        //turnAroundAxis(axis, angle)

    }
}
