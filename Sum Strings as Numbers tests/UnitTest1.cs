using NUnit.Framework;
using Sum_Strings_as_Numbers;

namespace Sum_Strings_as_Numbers_tests
{
    public class Tests
    {
        [Test]
        public void Given123And456Returns579()
        {
            Assert.AreEqual("579", Program.sumStrings("123", "456"));
        }
    }
}