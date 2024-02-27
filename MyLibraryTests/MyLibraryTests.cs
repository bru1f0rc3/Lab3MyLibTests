using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyLibrary;

namespace MyLibraryTests
{
    [TestClass]
    public class MyLibraryTests
    {
        [TestMethod]
        public void F_Enter1357921_TrueReturn()
        {
            int x = 1357921;
            int expected = 27; // 27
            int actual = MyLibrary.MyLibrary.F(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void F_Enter102030_FalseReturn()
        {
            int x = 102030;
            int expected = 3; // 0
            int actual = MyLibrary.MyLibrary.F(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void F_Enter246_TrueReturn()
        {
            int x = 369;
            int expected = 162;
            int actual = MyLibrary.MyLibrary.F(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Enter13_TrueReturn()
        {
            int number = 13;
            string expected = "Простое число";
            string actual = MyLibrary.MyLibrary.IsPrime(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Enter50_FalseReturn()
        {
            int number = 50;
            string expected = "Составное число";
            string actual = MyLibrary.MyLibrary.IsPrime(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Enter27_FalseReturn()
        {
            int number = 27;
            string expected = "Составное число";
            string actual = MyLibrary.MyLibrary.IsPrime(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Enter23_TrueReturn()
        {
            int number = 23;
            string expected = "Простое число";
            string actual = MyLibrary.MyLibrary.IsPrime(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumbertoWords_Enter159_TrueReturn()
        {
            int number = 159;
            string expected = "сто пятьдесят девять";
            string actual = MyLibrary.MyLibrary.NumbertoWords(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumbertoWords_Enter354_TrueReturn()
        {
            int number = 354;
            string expected = "триста пятьдесят четыре";
            string actual = MyLibrary.MyLibrary.NumbertoWords(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumbertoWords_Enter799_TrueReturn()
        {
            int number = 799;
            string expected = "семьсот девяносто девять";
            string actual = MyLibrary.MyLibrary.NumbertoWords(number);
            Assert.AreEqual(expected, actual);
        }
    }
}