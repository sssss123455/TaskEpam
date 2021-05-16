using System;
using M3_2;

namespace M6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 90, 5, 3, 4 }, { 4, 9, 6, 7 }, { 1, 17, 1, 7 }, { 15, 15, 14, 0 } };

            Sum.Get(matrix,"down");
            Console.WriteLine();
            Max.Get(matrix,"up");
            Console.WriteLine();
            Min.Get(matrix,"dsds");
        }
    }
}
