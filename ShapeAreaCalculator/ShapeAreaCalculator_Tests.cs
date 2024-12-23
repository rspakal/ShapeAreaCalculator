using ShapeAreaCalculator;
using System;
using Xunit;


namespace ShapeAreaCalculator_Tests
{
    public class ShapeAreaCalculatorTests
    {
        [Fact]
        public void CalculateCircleArea_WithValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            IAreaCalculator circle = new CircleAreaCalculator(radius);
            double expectedValue = Math.PI * Math.Pow(radius, 2);
            double actualValue = circle.CalculateArea();
            Assert.Equal(expectedValue, actualValue, precision: 5);
        }

        [Fact]
        public void CalculateTriangleArea_WithValidSides_ReturnsCorrectArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            IAreaCalculator triangle = new TriangleAreaCalculator(a, b, c);
            double halfPerimeter = (a + b + c) / 2;
            double expectedValue = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            double actualValue = triangle.CalculateArea();
            Assert.Equal(expectedValue, actualValue, precision: 5);
        }
    }
}