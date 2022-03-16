using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Services;

namespace Task2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Solving.GetResult(1, 1, 1), 0.7701, 0.0001);
            Assert.AreEqual(Solving.GetResult(1, 2, 3), 0.5172, 0.0001);
            Assert.AreEqual(Solving.GetResult(4, 3, -1), 13.6645, 0.0001);
            Assert.AreEqual(Solving.GetResult(1, 0, 0), 0);
            Assert.AreEqual(Solving.GetResult(0, 1, 1), 0);
        }
    }
}