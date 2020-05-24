using NUnit.Framework;
using Detect_Pangram;

namespace Detect_Pangram_tests
{
    public class Tests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(true, Program.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
    }
}