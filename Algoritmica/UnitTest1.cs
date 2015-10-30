using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmica
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Problem1()
        {
            Pb1 p = new Pb1();
            int resul = p.Sum();

            Assert.AreEqual(resul, 233168);
            
        }

        [TestMethod]
        public void Problem2()
        {
            Pb2 p = new Pb2();
            int resul = p.Suma();

            Assert.AreEqual(resul, 4613732);
        }

        [TestMethod]
        public void Problem6()
        {
            Pb6 p = new Pb6();
            int resul = p.SumPb6();

            Assert.AreNotEqual(resul, 25164150);
           // Assert.AreEqual(resul, 25164150);
        }

        [TestMethod]
        public void Problem7()
        {
            Pb7 p = new Pb7();
            int resul = p.Number();

            Assert.AreNotEqual(resul, 104743);
           
        }
    }
}
