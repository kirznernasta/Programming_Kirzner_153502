using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Calculate.Result(0, 23), 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Calculate.Result(-23, 23), 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Calculate.Result(-5, 5), 0);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(Calculate.Result(-10, 5), 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(Calculate.Result(-20, 15), 1);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(Calculate.Result(23, 23), -1);
        }

    }
}