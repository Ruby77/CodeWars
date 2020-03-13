using NUnit.Framework;
using RGB_To_Hex_Conversion;

namespace RGB_To_Hex_Conversion_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("FFFFFF", Program.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", Program.Rgb(255, 255, 300));
            Assert.AreEqual("000000", Program.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", Program.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", Program.Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", Program.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", Program.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}