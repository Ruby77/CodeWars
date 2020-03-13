using NUnit.Framework;
using Sum_of_odd_numbers;

namespace Sum_of_odd_numbers_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(1, SumOfOddNumbers.rowSumOddNumbers(1));
            Assert.AreEqual(74088, SumOfOddNumbers.rowSumOddNumbers(42));
        }
    }
}