using System;

namespace M6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(2);
           Console.WriteLine( Square.GetArea(square));
            Circle circle = new Circle(2);
            Console.WriteLine(Circle.GetArea(circle));
        }
    }
}
