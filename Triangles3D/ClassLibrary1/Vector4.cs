using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Vector4
    {
        private double[] crd;

        public Vector4(Vector3 v)
        {
            crd = new double[4] { v.X, v.Y, v.Z, 1};
        }
        //public Vector4(Vector3 v) : this.(v.X, v.Y, v.Z)
        //{
        //    crd = new double[4] { X, Y, Z, w };
        //}

        public Vector4(double x, double y, double z, double w = 1)
        {
            crd = new double[] { x, y, z, w };
        }

        public double X
        {
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

        public double W
        {
            get
            { return crd[3]; }
            set
            { crd[3] = value; }
        }

        public double this[int i] // перегрузка индексного оператора
        {
            get { return crd[i]; }
            set { crd[i] = value; }
        }

        public static Vector4 Zero()
        {
            return new Vector4(0, 0, 0, 0);
        }
        public Vector4 Normalized
        {
            get
            {
                if (Math.Abs(W) > 1e-10)
                    return new Vector4(X / W, Y / W, Z / W);
                else
                    return new Vector4(X, Y, Z, 0);
            }
        }
    }
}
