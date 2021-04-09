using System;

namespace M2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Array.FilterDigit(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 },7))
            {
                Console.Write(item + " ");
            }
        }
    }
}
