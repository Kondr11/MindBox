using NUnit.Framework;
using SquareLibrary;
using System;

namespace LibraryTests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 2, 3)]
        [TestCase(1, 0, 3)]
        [TestCase(1, 2, 0)]
        [TestCase(1, -2, 3)]
        [TestCase(1, 2, -3)]
        [TestCase(-1, -2, 3)]
        [TestCase(1, -1, -3)]
        [TestCase(-1, 1, -3)]
        [TestCase(-2, -1, -3)]
        public void NegativeSides(double a, double b, double c)
        {
            var exception = Assert.Throws<Exception>(() => new Triangle(a, b, c));
            Assert.AreEqual("Triangle sides must be positive", exception.Message);
        }

        [TestCase(1, 2, 3)]
        [TestCase(1, 3, 1)]
        [TestCase(8, 2, 3)]
        public void NotExistTriangles(double a, double b, double c)
        {
            var exception = Assert.Throws<Exception>(() => new Triangle(a, b, c));
            Assert.AreEqual($"Triangle with {a},{b},{c} sides cann't exist", exception.Message);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(3, 4, 4, false)]
        public void RectangleTriangles(double a, double b, double c, bool expectedResult)
        {
            var tr = new Triangle(a, b, c);
            Assert.AreEqual(expectedResult, tr.IsRectangle());
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(3, 3, 4, 4.4721359549995796d)]
        public void SquareTriangles(double a, double b, double c, double expectedResult)
        {
            var tr = new Triangle(a, b, c);
            Assert.AreEqual(expectedResult, tr.FindSquare());
        }
    }
}