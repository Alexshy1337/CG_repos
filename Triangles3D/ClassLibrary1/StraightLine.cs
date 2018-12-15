using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StraightLine
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float D { get; set; }
        public Vector3 DirVector { get; set; }

        public StraightLine() { }

        public StraightLine(Plane pl1, Plane pl2)
        {
            A = pl1.A - pl2.A;
            B = pl1.B - pl2.B;
            C = pl1.C - pl2.C;
            D = pl1.D - pl2.D;
            DirVector = new Vector3(A, B, C);
        }

        //public void IntersectionOfPlanes(Plane pl1, Plane pl2)
        //{
        //    A = pl1.A - pl2.A;
        //    B = pl1.B - pl2.B;
        //    C = pl1.C - pl2.C;
        //    D = pl1.D - pl2.D;
        //    DirVector = new Vector3(A, B, C);
        //}



    }
}
