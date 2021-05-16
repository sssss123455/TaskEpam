using System;
using System.Collections.Generic;
using System.Text;

namespace M6_2
{
    public class Square
    {
        public int FirstSide { get; set; }
        private const int count = 4;
        public Square(int firstSide)
        {
            this.FirstSide = firstSide;
        }
        public static int GetPerimeter(Square figure)
        {
            int perimeter = 0;
            perimeter = figure.FirstSide * count;
            return perimeter;
        }
        public static double GetArea(Square figure)
        {
            double area = 0;
            area = figure.FirstSide * figure.FirstSide;
            return area;
        }
    }
}
