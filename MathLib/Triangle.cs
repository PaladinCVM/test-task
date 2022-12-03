namespace MathLib
{
    public class Triangle : Shape
    {
        private readonly List<double> _sides;
        private readonly List<double> cathetuses;
        private readonly double hypotenuse;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Given side is not a positive number");
            if (a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException("Triangle with given sides does not exist");

            _sides = new List<double>() { a, b, c };

            hypotenuse = _sides.Max();
            cathetuses = _sides.FindAll(s => s != hypotenuse);
        }

        /// <summary>
        /// Returns true if triangle is right-angled
        /// </summary>
        public bool IsRight => Math.Pow(cathetuses[0], 2) + Math.Pow(cathetuses[1], 2) == Math.Pow(hypotenuse, 2);

        /// <summary>
        /// Returns area of a triangle
        /// </summary>
        public override double GetArea()
        {
            double sp = _sides.Sum() / 2;

            return Math.Sqrt(sp * (sp - _sides[0]) * (sp - _sides[1]) * (sp - _sides[2]));
        }
    }
}