namespace ShapeAreaCalculator
{
    public class CircleAreaCalculator : IAreaCalculator
    {
        private double _radius;
        public CircleAreaCalculator(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            if (_radius <= 0)
            {
                throw new ArgumentException("Invalid value for a radius");
            }
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}
