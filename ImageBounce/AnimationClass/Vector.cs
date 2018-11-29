using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationClass
{
    public struct Vector2 
    {
        float x, y;
       public float X { get { return x; } set { x = value; } }
       public float Y { get { return y; } set { y = value; } }
       public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float Length
        {
            get { return (float)Math.Sqrt(X * X + Y * Y); }
        }
        public Vector2 Normalize
        {
            get { float l = Length;
                return (l < 1e-15) ? this : new Vector2(X / l, Y / l);
            }
        }
        public static Vector2 operator*(Vector2 c, float n)
        {
            return new Vector2(c.X * n, c.Y * n);
        }
        public static Vector2 operator *(float n, Vector2 v)
        {
            return v * n;
        }
        public static Vector2 operator +(Vector2 c1, Vector2 c2)
        {
            return new Vector2(c1.X + c2.X, c1.Y+c2.Y);
        }
        public static Vector2 operator -(Vector2 c1, Vector2 c2)
        {
            return new Vector2(c1.X - c2.X, c1.Y - c2.Y);
        }
    }
}
