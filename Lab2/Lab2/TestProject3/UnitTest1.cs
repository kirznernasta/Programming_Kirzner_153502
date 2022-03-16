using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Calc.getResult(300), 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Calc.getResult(567), -1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Calc.getResult(111), 0);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(Calc.getResult(999), 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(Calc.getResult(123), -1);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(Calc.getResult(321), 1);
        }
    }
}