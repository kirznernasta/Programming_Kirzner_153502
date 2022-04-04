using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TV tv = new TV();

            tv.Cost = 300;
            tv.Purchases = 10;

            Assert.AreEqual(3000, tv.GetEarnings());

            tv.ChangeCost(-30);
            Assert.AreEqual(2700, tv.GetEarnings());

            tv.ChangeCost(80);
            Assert.AreEqual(3500, tv.GetEarnings());

            tv.ChangeCost(-1000);
            Assert.AreEqual(0, tv.GetEarnings());
        }
    }
}