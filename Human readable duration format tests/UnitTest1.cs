using NUnit.Framework;
using Human_readable_duration_format;

namespace Human_readable_duration_format_tests
{
    public class Tests
    {
        [Test]
        public void basicTests()
        {
            Assert.AreEqual("now", Program.formatDuration(0));
            Assert.AreEqual("1 second", Program.formatDuration(1));
            Assert.AreEqual("1 minute and 2 seconds", Program.formatDuration(62));
            Assert.AreEqual("2 minutes", Program.formatDuration(120));
            Assert.AreEqual("1 hour, 1 minute and 2 seconds", Program.formatDuration(3662));
            Assert.AreEqual("182 days, 1 hour, 44 minutes and 40 seconds", Program.formatDuration(15731080));
            Assert.AreEqual("4 years, 68 days, 3 hours and 4 minutes", Program.formatDuration(132030240));
            Assert.AreEqual("6 years, 192 days, 13 hours, 3 minutes and 54 seconds", Program.formatDuration(205851834));
            Assert.AreEqual("8 years, 12 days, 13 hours, 41 minutes and 1 second", Program.formatDuration(253374061));
            Assert.AreEqual("7 years, 246 days, 15 hours, 32 minutes and 54 seconds", Program.formatDuration(242062374));
            Assert.AreEqual("3 years, 85 days, 1 hour, 9 minutes and 26 seconds", Program.formatDuration(101956166));
            Assert.AreEqual("1 year, 19 days, 18 hours, 19 minutes and 46 seconds", Program.formatDuration(33243586));
        }
    }
}