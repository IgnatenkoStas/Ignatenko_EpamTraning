using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateSquare_4and4and4_3and5decimalReturned()
        {
            // arrange - подготавливать
            double x = 4;
            double y = 4;
            double z = 4;
            double expected = 7;

            // act - действие
            Triangle triangle = new Triangle("Triangle", x, y, z);
            double actual = triangle.CalculateSquare(x, y, z);

            // assert - доказывать
            if(expected > actual && expected - 0.1 < actual)
            {
                Assert.IsTrue(true); 
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CalculatePerimeter_5and5and5_15returned()
        {
            // arrange - подготавливать
            double a = 5;
            double b = 5;
            double c = 5;
            double expected = 15;

            // act - действие
            Triangle triangle = new Triangle("Triangle", a, b, c);
            double actual = triangle.CalculatePerimeter(a, b, c);

            // assert - доказывать
            Assert.AreEqual(expected, actual);
        }
    }
}