using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdjustablePolygon
{
    public class Polygon
    {
        private int vertamount, radius;
        private double startangle;

        public double StartAngle 
        {
            get
            {
                return startangle;
            }
            set 
            {
                startangle = (value + 90) * Math.PI / 180;
                CalcPoints();
            } 
        }
        public List<Point> Vert { get; private set; }
        public int VertAmount
        {
            get
            {
                return vertamount;
            }
            set
            {
                vertamount = value;
                CalcPoints();
            }
        }
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                CalcPoints();
            }
        }


        public Polygon(int vertAmount, int RAD, double startAngle)
        {
            vertamount = vertAmount;
            radius = RAD;
            startangle = (startAngle + 90) * Math.PI / 180;
            CalcPoints();
        }

        private void CalcPoints()
        {
            Vert = new List<Point>();
            double angle = 2 * Math.PI / vertamount, tempAngle = startangle;
            int x = 0, y = 0;
            for (int i = 0; i < vertamount; i++)
            {
                x = (int)(radius * Math.Cos(tempAngle));
                y = (int)(radius * Math.Sin(tempAngle));
                tempAngle += angle;
                Vert.Add(new Point(x, -y));
            }
        }





    }
}
