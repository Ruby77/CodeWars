using NUnit.Framework;
using Human_Readable_Time;

namespace Human_Readable_Time_tests
{
    public class Tests
    {
        [Test]
        public void HumanReadableTest()
        {
            Assert.AreEqual("00:00:00", Program.GetReadableTime(0));
            Assert.AreEqual("00:00:05", Program.GetReadableTime(5));
            Assert.AreEqual("00:01:00", Program.GetReadableTime(60));
            Assert.AreEqual("23:59:59", Program.GetReadableTime(86399));
            Assert.AreEqual("99:59:59", Program.GetReadableTime(359999));
        }
    }
}