using M7_1;
using NUnit.Framework;

namespace TestM7_1
{
    public class Tests
    {
        [TestCase(1, ExpectedResult = "Customer record: Jeffrey Richter,1000000")]
        [TestCase(2, ExpectedResult = "Customer record: Jeffrey Richter,+1 (425) 555-0100")]
        [TestCase(3, ExpectedResult = "Customer record: +1 (425) 555-0100,1000000")]
        [TestCase(4, ExpectedResult = "Customer record: Jeffrey Richter")]
        [TestCase(2133, ExpectedResult = "Customer record: Jeffrey Richter,+1 (425) 555-0100,1000000")]
        public static string GetCustomerRecord(int number)
        {
            return Customer.GetCustomerRecord(number);
        }
    }
}