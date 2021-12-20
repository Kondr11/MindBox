using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    class Circle : AbstractFigure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new Exception("Radius must be positive");
            else
                Radius = radius;
        }

        public override double FindSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
