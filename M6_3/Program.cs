using System;

namespace M6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial polynomial = new Polynomial(new int[] { 1, 3, 45, 5 });
            Polynomial polynomial1 = new Polynomial(new int[] { 1, 323, 45, 5 ,43});
            Console.WriteLine(polynomial.ToString());
            Console.WriteLine(polynomial.Equals(polynomial1));
            Console.WriteLine((polynomial - polynomial1).ToString());
        }
    }
}
