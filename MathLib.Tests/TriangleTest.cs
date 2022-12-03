namespace MathLib.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_GetArea_Sides_3_4_5_ShouldReturnCorrectResult() => Assert.Equal(6.0, new Triangle(3, 4, 5).GetArea());

        [Fact]
        public void Triangle_IsRight_Sides_6_10_8_ShouldReturnTrue() => Assert.True(new Triangle(6, 10, 8).IsRight);

        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        public void Triangle_NotPositiveSides_ShouldThrowArgumentException(double value_1, double value_2, double value_3) 
            => Assert.Throws<ArgumentException>(() => new Triangle(value_1, value_2, value_3));

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 2)]
        [InlineData(3, 2, 1)]
        public void Triangle_Nonexistent_ShouldThrowArgumentException(double value_1, double value_2, double value_3)
            => Assert.Throws<ArgumentException>(() => new Triangle(value_1, value_2, value_3));
    }
}
