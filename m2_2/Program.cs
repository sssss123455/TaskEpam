using System;

namespace m2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 2, 4, 7, 89, 1 };
          
            Console.WriteLine(Array.GetMaxNumber(array,0,int.MinValue));
        }
    }
}
