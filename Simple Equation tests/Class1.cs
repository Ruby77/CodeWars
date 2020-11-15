using NUnit.Framework;
using Simple_Equation;

namespace Simple_Equation_tests
{
    [TestFixture]
    public class EquationTest
    {

        [Test]
        public void TestPlus()
        {
            StringAssert.AreEqualIgnoringCase("x = 17", Kata.SolveTheEquation("x + 85 = 102"),
                "Plus operator test failed");
        }

        [Test]
        public void TestMultiply()
        {
            StringAssert.AreEqualIgnoringCase("x = 68.15", Kata.SolveTheEquation("x * 1358 = 92548"),
                "Multiply operator test failed");
        }

        [Test]
        public void TestMinus()
        {
            StringAssert.AreEqualIgnoringCase("x = 6553", Kata.SolveTheEquation("x - 1003 = 5550"),
                "Minus operator test failed");
        }

        [Test]
        public void TestDivide()
        {
            StringAssert.AreEqualIgnoringCase("x = 63250", Kata.SolveTheEquation("x / 5 = 12650"),
                "Divide operator test failed");
        }

    }
}
