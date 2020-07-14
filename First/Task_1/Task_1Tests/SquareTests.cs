using Task_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void CalculateSquare_5and5_25returned()
        {
            // arrange - подготавливать
            double x = 5;
            double y = 5;
            double expected = 25;

            // act - действие
            Square square = new Square("Square", x, y, x, y);
            double actual = square.CalculateSquare(x, y);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePerimeter_5and5and5and5_20returned()
        {
            // arrange - подготавливать
            double a = 5;
            double b = 5;
            double c = 5;
            double d = 5;
            double expected = 20;

            // act - действие
            Square square = new Square("Square", a, b, c, d);
            double actual = square.CalculatePerimeter(a, b, c, d);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }
    }
}