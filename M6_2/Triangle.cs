using System;
using System.Collections.Generic;
using System.Text;

namespace M6_2
{
    public class Triangle:Rectangle
    {
        public int ThirdSide { get; set; }
        public Triangle(int firstSide, int secondSide, int thirdSide) : base(firstSide, secondSide)
        {
            this.ThirdSide = thirdSide;
        }
        public static int GetPerimeter(Triangle figure)
        {
            int perimeter = 0;
            perimeter = figure.FirstSide+figure.SecondSide+figure.ThirdSide;
            return perimeter;
        }
        public static double GetArea(Triangle figure)
        {
            double area = 0;
            double halfPerimetr = GetPerimeter(figure);
            area = Math.Sqrt(halfPerimetr*(halfPerimetr-figure.FirstSide)* (halfPerimetr - figure.SecondSide)* (halfPerimetr - figure.ThirdSide));
            return area;
        }
    }
}
