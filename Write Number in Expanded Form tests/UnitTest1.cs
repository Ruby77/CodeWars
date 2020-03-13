using NUnit.Framework;
using Write_Number_in_Expanded_Form;

namespace Write_Number_in_Expanded_Form_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(Program.ExpandedForm(12), Is.EqualTo("10 + 2"));
            Assert.That(Program.ExpandedForm(42), Is.EqualTo("40 + 2"));
            Assert.That(Program.ExpandedForm(70304), Is.EqualTo("70000 + 300 + 4"));
        }
    }
}