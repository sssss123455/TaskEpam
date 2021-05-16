using System;
using System.Collections.Generic;
using System.Text;

namespace M6_2
{
    public class Rectangle : Square
    {
        public int SecondSide { get; set; }
        private const int count = 2;
        public Rectangle(int firstSide,int secondSide):base(firstSide)
        {
            this.SecondSide = secondSide;
        }
        public static int GetPerimeter(Rectangle figure)
        {
            int perimeter = 0;
            perimeter = (figure.FirstSide+figure.SecondSide)* count;
            return perimeter;
        }
        public static double GetArea(Rectangle figure)
        {
            double area = 0;
            area = figure.FirstSide * figure.SecondSide;
            return area;
        }
    }
}
