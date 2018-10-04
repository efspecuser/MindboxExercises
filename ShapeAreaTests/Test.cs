using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaCalc;

namespace ShapeAreaTests
{
    [TestClass]
    public class Test
    {
        private double _accuracy = 0.0000001;

        [TestMethod]
        public void TestCircle()
        {
            var circle = new Circle(4);
            var area = circle.CalculateArea();
            var expectedArea = Math.PI * 16;
            Assert.IsTrue(Math.Abs(area - expectedArea) / expectedArea < this._accuracy);
        }

        [TestMethod]
        public void TestTriangle()
        {
            var triangle = new Triangle(2, 3, 7);
            var area = triangle.CalculateArea();
            var expectedArea = 72*72;
            Assert.IsTrue(Math.Abs(expectedArea - area) / expectedArea < this._accuracy);
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            var rightTriangle = new Triangle(3, 5, 5.830951894);
            Assert.IsTrue(rightTriangle.IsRight);
        }
    }
}
