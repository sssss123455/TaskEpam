using System;
using System.Collections.Generic;
using System.Text;

namespace M6_2
{
    class Circle
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public static double GetPerimeter(Circle figure)
        {
            double perimeter = 0;
            perimeter = 2*Math.PI*figure.Radius;
            return perimeter;
        }
        public static double GetArea(Circle figure)
        {
            double area = 0;
            int pow = 2;
            area = Math.PI*Math.Pow(figure.Radius, pow);
            return area;
        }
    }
}
