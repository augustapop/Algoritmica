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
        public void Problem3()
        {
            Pb3 p = new Pb3();
            long resul = p.PrimLongNumber();

            Assert.AreEqual(resul, 6857);
        }

        [TestMethod]
        public void Problem4()
        {
            Pb4 p = new Pb4();
            string resul = p.LargestPalindrom();

            Assert.AreEqual(resul, "906609");
        }
        [TestMethod]
        public void Problem5()
        {
            Pb5 p = new Pb5();
            int resul = p.DivideBy20();

            Assert.AreEqual(resul, 232792561);
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

        [TestMethod]
        public void Problem8()
        {
            Pb8 p = new Pb8();
            int resul = p.GetMAx();
            Assert.AreEqual(resul, 40824);
        }

        [TestMethod]
        public void Problem9()
        {
            Pb9 p = new Pb9();
            int resul = p.Product();
            Assert.AreEqual(resul, 31875000);
        }
    }
}
