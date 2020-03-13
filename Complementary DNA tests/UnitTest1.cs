using NUnit.Framework;
using Complementary_DNA;

namespace Complementary_DNA_tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void test01()
        {
            Assert.AreEqual("TTTT", Program.MakeComplement("AAAA"));
        }
        [TestCase]
        public void test02()
        {
            Assert.AreEqual("TAACG", Program.MakeComplement("ATTGC"));
        }
        [TestCase]
        public void test03()
        {
            Assert.AreEqual("CATA", Program.MakeComplement("GTAT"));
        }
    }
}