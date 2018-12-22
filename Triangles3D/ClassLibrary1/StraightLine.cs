using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StraightLine
    {
        public Vector3 point { get; set; }
        public Vector3 DirVector { get; set; }



        public StraightLine() { }

        public StraightLine(Plane pl1, Plane pl2)
        {
            DirVector = new Vector3(pl1.A - pl2.A, pl1.B - pl2.B, pl1.C - pl2.C);
        }

        public Vector3 GetOnePoint(Plane a, Plane b)
        {
            if (a.A / b.A != a.B / b.B
                ||
                a.B / b.B != a.C / b.C
                ||
                a.A / b.A != a.C / b.C) 
            {
                if(a.A !=0 && b.A !=0)
                

                return new Vector3();
            } else


                return new Vector3();
        }


        public static float determinant3 (float a11, float a12, float a13, float a21, float a22, float a23, float a31, float a32, float a33)
        {
            return (a11 * (a22 * a33 - a23 * a32) - a12 * (a21 * a33 - a23 * a31) + a13 * (a21 * a32 - a22 * a31));
        }

    }
}
