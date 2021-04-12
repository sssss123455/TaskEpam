using System;

namespace M2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            swatch.Start();
            Console.WriteLine(Number.FindNextBiggerNumber(305551));
            swatch.Stop();
            Console.WriteLine("Время на выполнение: "+swatch.Elapsed);
        }
    }
}
