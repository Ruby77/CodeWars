using New_Cashier_Does_Not_Know_About_Space_or_Shift;
using NUnit.Framework;

namespace New_Cashier_Does_Not_Know_About_Spaces_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke",
            Program.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("Burger Fries Fries Chicken Pizza Sandwich Milkshake Coke",
            Program.GetOrder("pizzachickenfriesburgercokemilkshakefriessandwich"));
        }
    }
}