using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ImageBounce
{
    public class Screen
    {
        public Size Size { get; set; }
        public RectangleF Rectangle { get; set; }
        public float Scale { get { return Size.Width / Rectangle.Width; } }
        public Screen(Size sz, RectangleF r)
        {
            Size = sz;
            Rectangle = r;
        }
        public Point Convert(Vector2 v)
        {
            float x = (v.X - Rectangle.X) / Rectangle.Width * Size.Width;
            float y = (v.Y - Rectangle.Y) / Rectangle.Height * Size.Height;
            return new Point((int)x, (int)y);
        }

    }
}
