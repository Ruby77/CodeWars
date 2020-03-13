using NUnit.Framework;
using Split_Strings;

namespace Split_Strings_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, Program.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, Program.Solution("abcdef"));
        }
    }
}