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
            if (l.DirVector.X / DirVector.X == l.DirVector.Y / DirVector.Y ||
                l.DirVector.Z / DirVector.Z == l.DirVector.Y / DirVector.Y ||
                l.DirVector.X / DirVector.X == l.DirVector.Z / DirVector.Z)
                return new Vector3();
            else
            {
                float t = (l.point.X - point.X) / (DirVector.X - l.DirVector.X);
                return new Vector3(point.X + t * DirVector.X, point.Y + t * DirVector.Y, point.Z + t * DirVector.Z);
            }

        }
        
        public static bool StraightLineContainsPoint(StraightLine l, Vector3 a)
        {
            float t = (a.X - l.point.X) / l.DirVector.X;
            if ((l.point.Y + l.DirVector.Y * t) == a.Y && (l.point.Z + l.DirVector.Z * t) == a.Z)
                return true;
            else return false;

        }

        public static float determinant3(float a11, float a12, float a13, float a21, float a22, float a23, float a31, float a32, float a33)
        {
            return (a11 * (a22 * a33 - a23 * a32) - a12 * (a21 * a33 - a23 * a31) + a13 * (a21 * a32 - a22 * a31));
        }

    }
}
