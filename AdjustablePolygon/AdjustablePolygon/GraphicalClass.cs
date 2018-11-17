using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjustablePolygon
{
    class GraphicalClass
    {


        public static Bitmap BrLine(Bitmap bit, Pen p, int x0, int y0, int x1, int y1)
        {
            var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            int bufer;
            if (steep)
            {
                bufer = x0;
                x0 = y0;
                y0 = bufer;
                bufer = x1;
                x1 = y1;
                y1 = bufer;
            }

            if (x0 > x1)
            {
                bufer = x0;
                x0 = x1;
                x1 = bufer;
                bufer = y0;
                y0 = y1;
                y1 = bufer;
            }
            int dx = x1 - x0;
            int dy = Math.Abs(y1 - y0);
            int error = dx / 2;
            int ystep = (y0 < y1) ? 1 : -1;
            int y = y0;
            for (int x = x0; x <= x1; x++)
            {
                if (x <= 0 || y <= 0)
                    return bit;
                if (steep && (y >= bit.Width || x >= bit.Height))
                    return bit;
                if (!steep && (x >= bit.Width || y >= bit.Height))
                    return bit;
                bit.SetPixel(steep ? y : x, steep ? x : y, p.Color);
                error -= dy;
                if (error < 0)
                {
                    y += ystep;
                    error += dx;
                }
            }
            return bit;
        }

        public static Bitmap BrLine(Bitmap bit, Pen p, Point p0, Point p1)
        {
            var steep = Math.Abs(p1.Y - p0.Y) > Math.Abs(p1.X - p0.X);
            int bufer;
            if (steep)
            {
                bufer = p0.X;
                p0.X = p0.Y;
                p0.Y = bufer;
                bufer = p1.X;
                p1.X = p1.Y;
                p1.Y = bufer;
            }

            if (p0.X > p1.X)
            {
                bufer = p0.X;
                p0.X = p1.X;
                p1.X = bufer;
                bufer = p0.Y;
                p0.Y = p1.Y;
                p1.Y = bufer;
            }
            int dx = p1.X - p0.X;
            int dy = Math.Abs(p1.Y - p0.Y);
            int error = dx / 2;
            int ystep = (p0.Y < p1.Y) ? 1 : -1;
            int y = p0.Y;
            for (int x = p0.X; x <= p1.X; x++)
            {
                if (x <= 0 || y <= 0)
                    return bit;
                if (steep && (y >= bit.Width || x >= bit.Height))
                    return bit;
                if (!steep && (x >= bit.Width || y >= bit.Height))
                    return bit;
                bit.SetPixel(steep ? y : x, steep ? x : y, p.Color);
                error -= dy;
                if (error < 0)
                {
                    y += ystep;
                    error += dx;
                }
            }
            return bit;
        }

        public static Bitmap DrawPolygon(Bitmap bit, Pen p, Converter con, Polygon polygon)
        {
            for (int i = 0; i < polygon.VertAmount - 1; i++)
                bit = BrLine(bit, p, con.IIJJ(polygon.Vert[i]), con.IIJJ(polygon.Vert[i + 1]));
            bit = BrLine(bit, p, con.IIJJ(polygon.Vert[0]), con.IIJJ(polygon.Vert[polygon.VertAmount - 1]));

            return bit;
        }

    }
}
