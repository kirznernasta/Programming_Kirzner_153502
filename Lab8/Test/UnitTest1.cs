using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Store riga = new Store();
            riga.AddProduct(" bread", 3200, 25);
            riga.AddProduct("milk", 1200);
            Assert.AreEqual(riga.FindMinimal().ToString(), "milk 1200");

            riga.AddProduct("cookie", 2000, 50);
            Assert.AreEqual(riga.FindMinimal().ToString(), "cookie 1000");

            Product product = new Product("serum", 900, 20);
            Assert.AreEqual(product.GetPrice(), 720);
        }
    }
}