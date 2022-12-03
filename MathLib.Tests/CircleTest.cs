namespace MathLib.Tests
{
    public class CircleTest
    {
        [Fact]
        public void Circle_GetArea_Radius10_ShouldReturnCorrectResult() => Assert.Equal(Math.PI * Math.Pow(10, 2), new Circle(10).GetArea());

        [Fact]
        public void Circle_NotPositiveRadius_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}