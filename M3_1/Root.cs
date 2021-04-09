using System;
using System.Collections.Generic;
using System.Text;

namespace M3_1
{
    public class Root
    {
        public static double FindNthRoot( double num, int power, double eps)
        {
            if (power >= 0 && eps >= 0)
            {
                int length = eps.ToString().Length;
                int number = 0;
                for (int i = 0; i < length; i++)
                {
                    if (eps.ToString()[i] == '.')
                        number = i;
                }
                int roundBefore = length - number - 2;
                double xI = eps;
                for (; ; )
                {
                    double xIPlusOne = ((power - 1) * xI + num / Math.Pow(xI, power - 1)) / power;
                    if (Math.Abs(xI - xIPlusOne) < eps)
                    {
                        xI = xIPlusOne;
                        break;
                    }
                    xI = xIPlusOne;
                }
                Console.WriteLine(xI);
                return Math.Round(xI, roundBefore);
            }
            else { throw new Exception("Power<0 or Eps<0"); }
        }
    }
}
