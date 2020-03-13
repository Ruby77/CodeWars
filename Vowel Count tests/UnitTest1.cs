using NUnit.Framework;
using Vowel_Count;

namespace Vowel_Count_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, Program.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}