using NUnit.Framework;
using Persistent_Bugger;

namespace Persistent_Bugger_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, Program.Persistence(39));
            Assert.AreEqual(0, Program.Persistence(4));
            Assert.AreEqual(2, Program.Persistence(25));
            Assert.AreEqual(4, Program.Persistence(999));
        }
    }
}