using System;

namespace M3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 90, 5, 3, 4 }, { 4, 9, 6, 7 }, { 1, 17, 1, 7 }, { 15, 15, 14, 0 } };

            Sum.Get(matrix);
            Console.WriteLine();
            Max.Get(matrix);
            Console.WriteLine();
            Min.Get(matrix);
        }
    }
}
