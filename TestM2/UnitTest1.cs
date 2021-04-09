using NUnit.Framework;

namespace TestM2
{
    public class Tests
    {
        [TestCase(15,15,0,0, ExpectedResult = 15)]
        [TestCase(8,15,0,0, ExpectedResult = 9)]
        [TestCase(8,15,3,8, ExpectedResult = 120)]
        
        public int InsertNumber(int firstNumber, int secondNumber, int i, int j)
        {
            return M2.Number.InsertNumber(firstNumber, secondNumber, i, j);
        }
    }
}