using NUnit.Framework;
using Bit_Counting;

namespace Bit_Counting_tests
{
    [TestFixture]
    public class BitCounting
    {
        [Test]
        public void CountBits()
        {
            Assert.AreEqual(0, Program.CountBits(0));
            Assert.AreEqual(1, Program.CountBits(4));
            Assert.AreEqual(3, Program.CountBits(7));
            Assert.AreEqual(2, Program.CountBits(9));
            Assert.AreEqual(2, Program.CountBits(10));
        }
    }
}