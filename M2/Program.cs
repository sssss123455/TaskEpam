using System;

namespace M2
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            var example = number.InsertNumber(8, 15, 0, 0);
            Console.WriteLine(example);
        }
    }
}
