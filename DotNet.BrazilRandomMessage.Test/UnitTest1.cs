using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet.BrazilRandomMessage.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetARandomMessage()
        {
            var a = Messages.GetOne();
        }

        [TestMethod]
        public void RemoveHoliday()
        {
            Messages.NotIncludeHoliday();
            Messages.NotIncludeFriday();
            Messages.NotIncludeWeekend();
            Messages.NotIncludeSunday();
            var a = Messages.GetOne();
        }

        [TestMethod]
        public void Holiday()
        {
            Messages.ToDate(new System.DateTime(System.DateTime.Today.Year, 12, 25));
            var a = Messages.GetOne();
        }
    }
}
