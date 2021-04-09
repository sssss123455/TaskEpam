using NUnit.Framework;
using System.Collections.Generic;

namespace TestM2_6
{   
    public class Tests
    {
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7, ExpectedResult = new int[] { 7, 7, 70, 17 })]
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 8, ExpectedResult = new int[] { 68 })]
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 123, ExpectedResult = new int[] { })]

        public static List<int> FilterDigit(int[] array, int number)
        {
            return M2_6.Array.FilterDigit(array,number);
        }
    }
}