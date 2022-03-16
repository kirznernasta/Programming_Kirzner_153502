using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(ThreeDigitNumber.ChangeDigits(123), 321);
            Assert.AreEqual(ThreeDigitNumber.ChangeDigits(321), 123);

            Assert.AreEqual(ThreeDigitNumber.ChangeDigits(-456), -654);
            Assert.AreEqual(ThreeDigitNumber.ChangeDigits(-654), -456);

            Assert.AreEqual(ThreeDigitNumber.ChangeDigits(541), 145);

            Assert.AreEqual(ThreeDigitNumber.ChangeDigits(-111), -111);

            Assert.AreEqual(ThreeDigitNumber.ChangeDigits(-102), -201);
        }
    }
}