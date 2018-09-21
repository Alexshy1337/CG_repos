using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theDrawing
{
    class DrawingAlg
    {



    }
}



/*

    Далее создаем класс для рисования DrawAlgorihms
void DrawLine(Bitmap bmp,Color color,int x, int y, int w)//рисование прямой линии
{
for(int i=0;i<w;i++)
bmp.SetPixel(x+i,y,color);
}

void DrawWLine(Bitmap bmp,Color color,int x, int y, int h)
{
for(int i=0;i<h;i++)
bmp.setpixel(x,y+i,color);
}

void DrawLine(Bitmap bmp,Color color,int x1,int y1,int x2,int y2)
{
if(x2<x1)//свапнуть их чтобы избежать отрицательной разности
int diffx = x2-x1;
int diify = y2-y1;

float dy = diffy/(float)diffx;

for(int i=0;i<=diffx;i++)
bmp.SetPixel(x1+i,(int)(y1+i*dy),color);
}

 */
