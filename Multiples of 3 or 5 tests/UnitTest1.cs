using NUnit.Framework;
using Multiples_of_3_or_5;

namespace Multiples_of_3_or_5_tests
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Program.Solution(10));
        }
    }
}