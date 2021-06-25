using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calc;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        //тест на сложение
        [TestMethod]
        public void Summa1and123res124()
        {
            double a = 0.33333;
            double b = 6;
            double ex = 6.33333;
            double res = Writing.Plus(a, b);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void Summa123and123res124()
        {
            double a = 1.255555;
            double b = 35.628;
            double ex = 36.883555;
            double res = Writing.Plus(a, b);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void Summa7and6res1()
        {
            double a = -7;
            double b = 6;
            double ex = -1;
            double res = Writing.Plus(a, b);
            Assert.AreEqual(ex, res);
        }

        //тест на вычитание
        [TestMethod]
        public void Minus1and123res122()
        {
            double a = 1;
            double b = 123;
            double ex = -122;
            double res = Writing.Minus(a, b);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Minus322and322res122()
        {
            double a = -322;
            double b = 322;
            double ex = -644;
            double res = Writing.Minus(a, b);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Minus228and1res122()
        {
            double a = -228;
            double b = 1;
            double ex = -229;
            double res = Writing.Minus(a, b);
            Assert.AreEqual(ex, res);
        }

        //тест на умножение
        [TestMethod]
        public void Multiply0and4res0()
        {
            double a = 0;
            double b = 4;
            double ex = 0;
            double res = Writing.multip(a, b);
            Assert.AreEqual(ex, res);
        }  Assert.AreEqual(ex, res);
        

        [TestMethod]
        public void Multiply0and8res0()
        {
            double a = 0;
            double b = 4;
            double ex = 0;
            double res = Writing.multip(a, b);
            Assert.AreEqual(ex, res);
        }

        // тест на деление
        [TestMethod]
        public void Del0and4res0()
        {
            double a = 0;
            double b = 4;
            double ex = 0;
            double res = Writing.Del(a, b);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]

        //тест на проценты
        public void Proc0and4res0()
        {
            double a = 0;
            double b = 4;
            double ex = 0;
            double res = Writing.Hop(a, b);
            Assert.AreEqual(ex, res);
        }

    }
}
