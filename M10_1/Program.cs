using System;
using System.Collections.Generic;

namespace M10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(Binary.Show<int>(list, 3));
        }
    }
}
