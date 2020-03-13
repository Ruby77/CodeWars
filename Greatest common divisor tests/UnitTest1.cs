using System.Collections.Generic;
using NUnit.Framework;
using Greatest_common_divisor;

namespace Greatest_common_divisor_tests
{
    public class Tests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(30, 12).Returns(6);
                yield return new TestCaseData(8, 9).Returns(1);
                yield return new TestCaseData(1, 1).Returns(1);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(int a, int b) => Program.Gcd(a, b);
    }
}
