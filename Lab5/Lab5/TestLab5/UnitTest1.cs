using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5;

namespace TestLab5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Store Riga = new Store("Riga");

            Riga.AddProduct("milk", 2.56);
            Riga.AddProduct("bread", 1.2);
            Riga.AddProduct("cucumber", 0.3);
            Riga.AddProduct("potato", 0.4);
            Riga.AddProduct("sousege", 0.7);
            Riga.AddProduct("coca-cola", 2.69);

            Riga.StartCall("Vlad", PaymentType.Cashless);

            Riga.MakeOrder("coca-cola");
            Riga.MakeOrder("coca-cola");
            Riga.MakeOrder("cucumber");
            Riga.MakeOrder("tomato");

            Riga.EndCall();

            Riga.StartCall("Nastya", PaymentType.Cash);

            Riga.MakeOrder("potato");
            Riga.MakeOrder("potato");
            Riga.MakeOrder("potato");
            Riga.MakeOrder("potato");
            Riga.MakeOrder("potato");
            Riga.MakeOrder("potato");
            Riga.MakeOrder("potato");

            Riga.MakeOrder("coca-cola");
            Riga.MakeOrder("coca-cola");
            Riga.MakeOrder("coca-cola");

            Riga.MakeOrder("sousege");
            Riga.MakeOrder("sousege");
            Riga.MakeOrder("sousege");
            Riga.MakeOrder("sousege");

            Riga.EndCall();

            Assert.AreEqual(Riga.GetTotalPrice("Vlad"), 5.68, 0.001);

            Assert.AreEqual(Riga.GetTotalPrice("Nastya"), 13.669, 0.001);

            Assert.AreEqual(Riga.GetAllProducts("Nastya"), "Customer: Nastya\npotato\npotato\npotato" +
                "\npotato\npotato\npotato\npotato\ncoca-cola\ncoca-cola\ncoca-cola\n" +
                "sousege\nsousege\nsousege\nsousege\nThe type of payment: cash\n");

            Assert.AreEqual(Riga.GetAllProducts("Vlad"), "Customer: Vlad\ncoca-cola\ncoca-cola\ncucumber\nThe type of payment: cashless payment\n");
        }
    }
}