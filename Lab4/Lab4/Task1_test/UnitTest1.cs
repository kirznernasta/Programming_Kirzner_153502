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
            tv.internetShop("shop");
            tv.Cost = 300;
            tv.InternetShop.Purchases = 10;

            Assert.AreEqual(3000, tv.InternetShop.GetEarnings());

            tv.ChangeCost(-30);
            Assert.AreEqual(2700, tv.InternetShop.GetEarnings());

            tv.ChangeCost(80);
            Assert.AreEqual(3500, tv.InternetShop.GetEarnings());

            tv.ChangeCost(-1000);
            Assert.AreEqual(0, tv.InternetShop.GetEarnings());
        }
    }
}