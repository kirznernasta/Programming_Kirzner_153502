using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(DateService.GetDayOfWeek("23.02.2022"), System.DayOfWeek.Wednesday);
            Assert.AreEqual(DateService.GetDayOfWeek("16.03.2022"), System.DayOfWeek.Wednesday);
            Assert.AreEqual(DateService.GetDayOfWeek("18.03.2022"), System.DayOfWeek.Friday);
            Assert.AreEqual(DateService.GetDayOfWeek("23.02.2004"), System.DayOfWeek.Monday);
        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.AreEqual(DateService.GetDaysSpan(23, 2, 2022), 21); //22
            Assert.AreEqual(DateService.GetDaysSpan(17, 3, 2022), 1); //0
            Assert.AreEqual(DateService.GetDaysSpan(23, 2, 2004), 6596); //6597
            Assert.AreEqual(DateService.GetDaysSpan(16, 3, 2022), 0); //1
            Assert.AreEqual(DateService.GetDaysSpan(18, 3, 2022), 2); //0
        }
    }
}