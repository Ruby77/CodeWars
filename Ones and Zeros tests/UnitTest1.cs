using NUnit.Framework;
using Ones_and_Zeros;

namespace Ones_and_Zeros_tests
{
    [TestFixture]
    public class Tests
    {
        int[] Test1 = new int[] { 0, 0, 0, 0 };
        int[] Test2 = new int[] { 1, 1, 1, 1 };
        int[] Test3 = new int[] { 0, 1, 1, 0 };
        int[] Test4 = new int[] { 0, 1, 0, 1 };
        [Test]
        public void BasicTesting()
        {
            Assert.AreEqual(0, Program.binaryArrayToNumber(Test1));
            Assert.AreEqual(15, Program.binaryArrayToNumber(Test2));
            Assert.AreEqual(6, Program.binaryArrayToNumber(Test3));
            Assert.AreEqual(5, Program.binaryArrayToNumber(Test4));
        }
    }
}