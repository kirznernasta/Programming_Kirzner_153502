using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Triangle tr = new Triangle();
            tr.A = 3;
            tr.B = 4;
            tr.C = 5;

            Assert.AreEqual(3, tr.A);
            Assert.AreEqual(4, tr.B);
            Assert.AreEqual(5, tr.C);
            Assert.AreEqual("3 4 5", tr.ToString());
            Assert.AreEqual(tr.GetSquare(), 6);
            Assert.AreEqual(tr.GetPerimetr(), 12);

            tr++;

            Assert.AreEqual("4 5 6", tr.ToString());
            Assert.AreEqual(tr.GetSquare(), 9.921, 0.001);
            Assert.AreEqual(tr.GetPerimetr(), 15);

            tr *= 3;

            Assert.AreEqual("12 15 18", tr.ToString());
            Assert.AreEqual(tr.GetSquare(), 89.294, 0.001);
            Assert.AreEqual(tr.GetPerimetr(), 45);

            tr -= 5;
            Assert.AreEqual("7 10 13", tr.ToString());
            Assert.AreEqual(tr.GetSquare(), 34.641, 0.001);
            Assert.AreEqual(tr.GetPerimetr(), 30);

            Triangle tr2 = new Triangle(3, 3, 3);

            Assert.AreEqual("3 3 3", tr2.ToString());

            Assert.AreEqual(tr2 < tr, true);

        }
    }
}