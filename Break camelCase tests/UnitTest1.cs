using System.Collections.Generic;
using NUnit.Framework;
using Break_camelCase;

namespace Break_camelCase_tests
{
    public class Tests
    {
        [TestFixture]
        public class Sample_Tests
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData("camelCasing").Returns("camel Casing");
                    yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
                }
            }

            [Test, TestCaseSource("testCases")]
            public string Test(string str) => Program.BreakCamelCase(str);
        }
    }
}