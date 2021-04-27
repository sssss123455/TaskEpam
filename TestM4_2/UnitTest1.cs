using NUnit.Framework;

namespace TestM4_2
{
    public class Tests
    {
        [TestCase(12,14, ExpectedResult = 2)]
        [TestCase(12, 1, ExpectedResult = 1)]
        [TestCase(15, 14, ExpectedResult = 1)]
        [TestCase(123, 234, ExpectedResult = 3)]
        public static int UseEuclid(int firstNum, int secondNum)
        {
            return M4_2.GCD.UseEuclid(firstNum, secondNum);
        }
    }
}