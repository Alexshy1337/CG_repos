using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Camera
    {
        public Matrix4 View { get; set; }
        public Matrix4 Projectiom { get; set; }
        public Camera()
        {
            View = Matrix4.One();
            Projectiom = Matrix4.One();
        }
        public Vector3 Convert(Vector3 v)
        {
            Vector4 r = Projectiom * View * new Vector4(v);
            return new Vector3(r);
        }
    }
}
