using NUnit.Framework;
using Duplicate_Encoder;

namespace Duplicate_Encoder_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", Program.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Program.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Program.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Program.DuplicateEncode("(( @"));
        }
    }
}