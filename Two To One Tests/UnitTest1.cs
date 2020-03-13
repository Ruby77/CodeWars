using NUnit.Framework;
using Two_to_One;

namespace Two_To_One_Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual("aehrsty", Program.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", Program.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", Program.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}