namespace MathLib
{
    public class Circle : Shape
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Given radius is not a positive number");
            _radius = radius;
        }

        /// <summary>
        /// Returns area of a circle
        /// </summary>
        public override double GetArea() => Math.PI * Math.Pow(_radius, 2);
    }
}
