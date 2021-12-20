using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    class Triangle : AbstractFigure
    {
        private double A { get; set; }
        private double B { get; set; }
        private double MaxSide { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Triangle sides must be positive");
            else if (a + b <= c || a + c <= b || b + c <= a)
                throw new Exception($"Triangle with {a},{b},{c} sides cann't exist");
            else
            {
                double[] arrSide = { a, b, c };
                Array.Sort(arrSide);
                MaxSide = arrSide[2];
                A = arrSide[0];
                B = arrSide[1];
            }
        }
        public bool IsRectangle()
        {
            return (A * A + B * B - MaxSide * MaxSide) / (2 * A * B) == 0;
        }
        public override double FindSquare()
        {
            double p = (A + B + MaxSide) * 0.5;
            if (IsRectangle())
                return 0.5 * A * B;
            else
                return Math.Sqrt(p * (p - A) * (p - B) * (p - MaxSide));
        }
    }
}
