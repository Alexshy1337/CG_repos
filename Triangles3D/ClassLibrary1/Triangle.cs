using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Triangle
    {
        public Vector3 A { get; set; }

        public Triangle(Vector3 a)
        {
            A = a;
        }


        //turnAroundAxis(axis, angle)

        public List<PolyLine3D> GetLines()
        {
            List<PolyLine3D> l = new List<PolyLine3D>();

            l.Add(
                new PolyLine3D())





            return l;
        }


    }
}
