using NUnit.Framework;
using Exes_and_Ohs;

namespace Exes_and_Ohs_tests
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, ExesAndOhs.XO("xo"));
            Assert.AreEqual(true, ExesAndOhs.XO("xxOo"));
            Assert.AreEqual(false, ExesAndOhs.XO("xxxm"));
            Assert.AreEqual(false, ExesAndOhs.XO("Oo"));
            Assert.AreEqual(false, ExesAndOhs.XO("ooom"));
        }
    }
}