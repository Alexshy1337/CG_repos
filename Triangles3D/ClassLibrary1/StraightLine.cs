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

        public Vector3 Intersection(StraightLine l)//если знаем, что они в одной плоскости
        {
            if (Math.Abs(l.DirVector.X * DirVector.Y - l.DirVector.Y * DirVector.X) < 0.0001 ||
                Math.Abs(l.DirVector.Z * DirVector.Y - l.DirVector.Y * DirVector.Z) < 0.0001 ||
                Math.Abs(l.DirVector.X * DirVector.Z - l.DirVector.Z * DirVector.X) < 0.0001 )
                return new Vector3();
            else
            {
                //избавиться от деления
                //но как?
                double t = (l.point.X - point.X) / (DirVector.X - l.DirVector.X);
                return new Vector3(point.X + t * DirVector.X, point.Y + t * DirVector.Y, point.Z + t * DirVector.Z);
            }

        }
        
        public static bool StraightLineContainsPoint(StraightLine l, Vector3 a)
        {
            if (!a.IsEmpty())
                return
                    (
                    Math.Abs((a.X - l.point.X) * l.DirVector.Y - (a.Y - l.point.Y) * l.DirVector.X) < 0.0001
                    &&
                    Math.Abs((a.Y - l.point.Y) * l.DirVector.Z - (a.Z - l.point.Z) * l.DirVector.Y) < 0.0001
                    &&
                    Math.Abs((a.X - l.point.X) * l.DirVector.Z - (a.Z - l.point.Z) * l.DirVector.X) < 0.0001
                    );
            return false;

        }

        //public static double determinant3(double a11, double a12, double a13, double a21, double a22, double a23, double a31, double a32, double a33)
        //{
        //    return (a11 * (a22 * a33 - a23 * a32) - a12 * (a21 * a33 - a23 * a31) + a13 * (a21 * a32 - a22 * a31));
        //}

    }
}
