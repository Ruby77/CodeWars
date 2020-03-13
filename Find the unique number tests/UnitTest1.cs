using System.Collections.Generic;
using NUnit.Framework;
using Find_the_unique_number;
using System;

namespace Find_the_unique_number_tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
        [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
        [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
        public int BaseTest(IEnumerable<int> numbers)
        {
            return FindTheUniqueNumber.GetUnique(numbers);
        }
    }
}