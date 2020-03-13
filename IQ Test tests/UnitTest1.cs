using NUnit.Framework;
using IQ_Test;

namespace IQ_Test_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, Program.Test("2 4 7 8 10"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Program.Test("1 2 2"));
        }
    }
}