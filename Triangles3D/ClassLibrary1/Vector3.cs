using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Vector3 //из чего будут состоять модели
    {
        private float[] crd;
        public Vector3(Vector4 v)
        {
            crd = new float[3] { v.X, v.Y, v.Z };
        }
        public Vector3(float x, float y, float z)
        {
            crd = new float[] { x, y, z };
        }
        public float X {
            get
            { return crd[0]; }
            set
            { crd[0] = value; }
        }
        public float Y
        {
            get
            { return crd[1]; }
            set
            { crd[1] = value; }
        }
        public float Z
        {
            get
            { return crd[2]; }
            set
            { crd[2] = value; }
        }
        public float this[int i] // перегрузка индексного оператора
        {
            get { return crd[i]; }
            set { crd[i] = value; }
        }

        public static float ScalarMultiplication(Vector3 v1, Vector3 v2)
        {
            return (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z);
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
