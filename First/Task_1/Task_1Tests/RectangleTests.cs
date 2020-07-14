using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod]
        public void CalculateSquare_5and5_25returned()
        {
            // arrange - подготавливать
            double x = 5;
            double y = 5;
            double expected = 25;

            // act - действие
            Rectangle rectangle = new Rectangle("Rectangle", x, y, x, y);
            double actual = rectangle.CalculateSquare(x, y);

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
            Rectangle rectangle = new Rectangle("Rectangle", a, b, c, d);
            double actual = rectangle.CalculatePerimeter(a, b, c, d);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }
    }
}