using NUnit.Framework;
using Sum_of_Numbers;

namespace Sum_of_Numbers_Tests
{
    public class Tests
    {
        SumOfNumbers s = new SumOfNumbers();

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, s.GetSum(0, 1));
            Assert.AreEqual(-1, s.GetSum(0, -1));
        }
    }
}