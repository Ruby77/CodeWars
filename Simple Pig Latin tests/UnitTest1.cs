using NUnit.Framework;
using Simple_Pig_Latin;

namespace Simple_Pig_Latin_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Program.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Program.PigIt("This is my string"));
        }
    }
}