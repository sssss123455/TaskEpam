using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M7_6
{
    public class Number
    {
        public static string GetSumBigNumbers(string[] numbers)
        {
            int count = numbers.Length;
            decimal[] arrayNumbers = new decimal[count];
            for (int i = 0; i < count; i++)
            {
                arrayNumbers[i] = Convert.ToDecimal(numbers[i]);
            }
            arrayNumbers=arrayNumbers.OrderByDescending(x=>x).ToArray();
            return (arrayNumbers[0] + arrayNumbers[1]).ToString();
        }
    }
}
