using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageBounce
{
    public class World
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public float g { get; set; }
        public float mu { get; set; }

        public Puck p { get; set; }

        public World(float g, float mu, float w, float h)
        {
            this.g = g;
            this.mu = mu;
            Width = w;
            Height = h;
        }

        public void Update(Vector2 Fvn, float t)
        {
            if (p == null)
                return;
            Vector2 F = Fvn - mu * p.M * g * p.Velocity.Normalize;
            Vector2 pos = p.Position + p.Velocity * t + F * (0.5f / p.M) * t * t;
            Vector2 v = p.Velocity + F * (t / p.M);

            if (pos.Y < - p.Sprite.Height || pos.Y > Height + p.Sprite.Height)
                pos = new Vector2(Width / 2, Height / 2);
            if (pos.X < - p.Sprite.Width || pos.X > p.Sprite.Width + Width)
                pos = new Vector2(Width / 2, Height / 2);


            if (pos.X - p.Sprite.Width < 0 || pos.X + p.Sprite.Width > Width)
                v = new Vector2(-v.X, v.Y);
            if (pos.Y - p.Sprite.Height < 0 || pos.Y + p.Sprite.Height > Height)
                v = new Vector2(v.X, -v.Y);

            p.Velocity = v;
            p.Position = pos;
        }

        public void Draw(Graphics g, MyScreen scr)
        {
            float xs = p.Sprite.Width * scr.Scale, ys = p.Sprite.Height * scr.Scale;
            g.DrawImage(p.Sprite, new Rectangle((int)(p.Position.X - xs / 2), (int)(p.Position.Y - ys / 2), (int)xs, (int)ys));
        }
    }
}
