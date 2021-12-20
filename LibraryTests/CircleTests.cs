using NUnit.Framework;
using SquareLibrary;
using System;

namespace LibraryTests
{
    public class CircleTests
    {
        [TestCase(-1)]
        public void NegativeRadius(double r)
        {
            var exception = Assert.Throws<Exception>(() => new Circle(r));
            Assert.AreEqual("Radius must be positive", exception.Message);
        }

        [TestCase(3, 9 * Math.PI)]
        public void SquareFindSquare(double r, double expectedResult)
        {
            var cr = new Circle(r);
            Assert.AreEqual(expectedResult, cr.FindSquare());
        }
    }
}
