using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Vector3 //из чего будут состоять модели
    {
        private double[] crd;

        public Vector3(Vector4 v)
        {
            crd = new double[] { v.X, v.Y, v.Z };
        }

        public Vector3(double x, double y, double z)
        {
            crd = new double[] { x, y, z };
        }

        public Vector3(Vector3 a, Vector3 b)
        {
            crd = new double[] { b.X - a.X, b.Y - a.Y, b.Z - a.Z };
        }

        public double X {
            get
            { return crd[0]; }
            set
            { crd[0] = value; }
        }

        public double Y
        {
            get
            { return crd[1]; }
            set
            { crd[1] = value; }
        }

        public double Z
        {
            get
            { return crd[2]; }
            set
            { crd[2] = value; }
        }

        public bool IsEmpty()
        {
            return crd == null;
        }

        public double this[int i] // перегрузка индексного оператора
        {
            get { return crd[i]; }
            set { crd[i] = value; }
        }

        public static double ScalarMultiplication(Vector3 v1, Vector3 v2)
        {
            return (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z);
        }

        public static Vector3 Vector_Multiplication_OfVectors(Vector3 a, Vector3 b)
        {
            return new Vector3((a.Y * b.Z - a.Z * b.Y), -(a.X * b.Z - a.Z * b.X), (a.X * b.Y - a.Y * b.X));
        }

        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return (a.X == b.X && a.Y == b.Y && a.Z == b.Z);
        }

        public static bool operator != (Vector3 a, Vector3 b)
        {
            return !(a == b);
        }

        public static Vector3 operator-(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3 operator+(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
    }
}
