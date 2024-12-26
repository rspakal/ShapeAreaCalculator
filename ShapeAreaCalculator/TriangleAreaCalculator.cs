using System;
using System.Linq;

namespace ShapeAreaCalculator
{
    public class TriangleAreaCalculator : IAreaCalculator
    {
        private double[] sides;
        public TriangleAreaCalculator(double sideA, double sideB, double sideC)
        {
            sides = new double[] { sideA, sideB , sideC };
            Array.Sort(sides);
        }

        private bool IsRightTriangle()
        {
         foreach (var side in sides)
            {
                if (side <= 0)
                    throw new ArgumentException("Invalid value for a side lenght");

            }
            
           if (sides[0] + sides[1] <= sides[2] || sides[0] + sides[1] <= sides[2] || sides[0] + sides[1] <= sides[2])
            {
                throw new ArgumentException("No triangle with provided sides");
            }
            
            return Math.Pow(sides[2], 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
        }
        public double CalculateArea()
        {

            if (IsRightTriangle())
            {
                return .5 * sides[0] * sides[1];
            }

            var halfPerimeter = sides.Sum() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) * (halfPerimeter - sides[1]) * (halfPerimeter - sides[2]));
        }
    }
}
