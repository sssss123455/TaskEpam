using NUnit.Framework;

namespace TestM4_3
{
    public class Tests
    {
        [TestCase("Kathy", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = true)]
        public static bool IsNull( object value)
        {
           return M4_3.ObjectExtension.IsNull(value);
        }
    }
}