using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Tests
{
    [TestClass()]
    public class EuclidFirstTests
    {
        [TestMethod()]
        public void EuclidTest_5and10_5returned()
        {
            // arrange - подготавливать
            int a = 5;
            int b = 10;
            int expected = 5;

            // act - действие
            int actual = EuclidFirst.Euclid(a, b);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EuclidTest_5and10and15_5returned()
        {
            // arrange - подготавливать
            int a = 5;
            int b = 10;
            int c = 15;
            int expected = 5;

            // act - действие
            int actual = EuclidFirst.Euclid(a, b, c);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EuclidTest_5and10and15and20_5returned()
        {
            // arrange - подготавливать
            int a = 5;
            int b = 10;
            int c = 15;
            int d = 20;
            int expected = 5;

            // act - действие
            int actual = EuclidFirst.Euclid(a, b, c, d);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EuclidTest_5and10and15and20and25_5returned()
        {
            // arrange - подготавливать
            int a = 5;
            int b = 10;
            int c = 15;
            int d = 20;
            int e = 25;
            int expected = 5;

            // act - действие
            int actual = EuclidFirst.Euclid(a, b, c, d, e);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinEuclidTest_5and10_5returned()
        {
            // arrange - подготавливать
            int a = 5;
            int b = 10;
            int expected = 5;

            // act - действие
            int actual = EuclidFirst.BinEuclid(a, b);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }
    }
}