using System;

namespace M2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            var example = array.GetNumber(new double[] { 1, 2, 3.4, 5, 1, 2.4, 12.4 });
            Console.WriteLine(example);
        }
    }
}
