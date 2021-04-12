using System;
using System.Collections.Generic;
using System.Text;

namespace M2_3
{
    public class Array
    {
        private const int N  = 6;
        public int GetNumber(double[] array)
        {
            for (int i = 1; i < array.Length-1; i++)
            {
                var startNumberForsumBeforeNumber = 0;
                var endNumberForsumBeforeNumber = i - 1;
                var startNumberForsumAfterNumber = i + 1;
                var endNumberForsumAfterNumber = array.Length - 1;
                var sumBeforeNumber = Sum(array, startNumberForsumBeforeNumber, endNumberForsumBeforeNumber);
                var sumAfterNumber = Sum(array, startNumberForsumAfterNumber, endNumberForsumAfterNumber);
                if (Math.Round(sumBeforeNumber,N) == Math.Round(sumAfterNumber,N))
                {
                    return i;
                }
            }
            return -1;
        }
        private static double Sum(double[] array, int startNumber, int endNumber)
        {
            double sum = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
