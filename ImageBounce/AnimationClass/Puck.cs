using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageBounce
{
    public class Puck
    {
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public Vector2 Acceleration { get; set; }
        public Bitmap Sprite { get; set; }
        
        public float M { get; set; }
        //public float R { get; set; }

        public Puck(Vector2 p, float m, Bitmap s)
        {
            M = m;
            //R = r;
            Position = p;
            Sprite = s;
        }


        public Puck(Vector2 p, float m)
        {
            M = m;
            //R = r;
            Position = p;
        }

    
    }
}
