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
        
         
        public static void BrLine(Bitmap bmp, Pen p, int x0, int y0, int x1, int y1)
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
                    return;
                if (steep && (y >= bmp.Width || x >= bmp.Height))
                    return;
                if (!steep && (x >= bmp.Width || y >= bmp.Height))
                    return;
                bmp.SetPixel(steep ? y : x, steep ? x : y, p.Color);
                error -= dy;
                if (error < 0)
                {
                    y += ystep;
                    error += dx;
                }
            }

        }






    }
}
