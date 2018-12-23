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

        public StraightLine(Vector3 a, Vector3 b)
        {
            DirVector = new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
            point = a;
        }

        //public Vector3 IntersectionWithLine(StraightLine l)//если знаем, что они в одной плоскости
        //{
        //    if (l.DirVector.X / DirVector.X == l.DirVector.Y / DirVector.Y ||
        //        l.DirVector.Z / DirVector.Z == l.DirVector.Y / DirVector.Y ||
        //        l.DirVector.X / DirVector.X == l.DirVector.Z / DirVector.Z)
        //        return new Vector3();
        //    else
        //    {
        //        float t;
        //        if(
        //            (l.point.X - point.X) / (DirVector.X - l.DirVector.X) == (l.point.Y - point.Y) / (DirVector.Y - l.DirVector.Y)
        //            &&
        //            (l.point.Y - point.Y) / (DirVector.Y - l.DirVector.Y) == (l.point.Z - point.Z) / (DirVector.Z - l.DirVector.Z)
        //            )
        //        {
        //            t = (l.point.X - point.X) / (DirVector.X - l.DirVector.X);
        //        }
        //    }

        //}

        public static float determinant3 (float a11, float a12, float a13, float a21, float a22, float a23, float a31, float a32, float a33)
        {
            return (a11 * (a22 * a33 - a23 * a32) - a12 * (a21 * a33 - a23 * a31) + a13 * (a21 * a32 - a22 * a31));
        }

    }
}
