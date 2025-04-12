using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextDoubleTest
    {
        [Fact]
        public void NextDoubleLimits_WhenRangeIsNotGiven_ShouldReturnValueWithinDoubleRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextDoubleLimits();

            // Assert
            Assert.IsType<double>(result);
            Assert.True(result >= double.MinValue, $"Result: {result}, Min Value: {double.MinValue}");
            Assert.True(result <= double.MaxValue, $"Result: {result}, Max Value: {double.MaxValue}");
        }

        [Theory]
        [InlineData(-10.0, 10.0)]
        [InlineData(double.MinValue, double.MaxValue)]
        public void NextDouble_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(double min, double max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextDouble(min, max);

            // Assert
            Assert.IsType<double>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Theory]
        [InlineData(10.0)]
        [InlineData(double.MaxValue)]
        public void NextDouble_WhenOnlyMaxValueIsGiven_ShouldReturnValueBetweenZeroAndMaxWithSameType(double max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextDouble(max);

            // Assert
            Assert.IsType<double>(result);
            Assert.True(result >= 0.0 && result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
