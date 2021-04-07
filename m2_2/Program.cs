using System;

namespace m2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            var example = array.GetMaxNumber(new int[] { 3, 2, 4, 7, 89, 1 });
            Console.WriteLine(example);
        }
    }
}
