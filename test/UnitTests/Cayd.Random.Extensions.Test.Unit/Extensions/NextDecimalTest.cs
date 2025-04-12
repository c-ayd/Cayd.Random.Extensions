using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextDecimalTest
    {
        [Fact]
        public void NextDecimal_WhenRangeIsNotGiven_ShouldReturnValueWithinDecimalRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextDecimal();

            // Assert
            Assert.IsType<decimal>(result);
            Assert.True(result >= decimal.MinValue, $"Result: {result}, Min Value: {decimal.MinValue}");
            Assert.True(result <= decimal.MaxValue, $"Result: {result}, Max Value: {decimal.MaxValue}");
        }

        [Fact]
        public void NextDecimal_WhenRangeIsNotOnBoundaries_ShouldReturnValueWithinRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();
            decimal min = -10.0m, max = 10.0m;

            // Act
            var result = rnd.NextDecimal(min, max);

            // Assert
            Assert.IsType<decimal>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Fact]
        public void NextDecimal_WhenRangeIsOnBoundaries_ShouldReturnValueWithinRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();
            decimal min = decimal.MinValue, max = decimal.MaxValue;

            // Act
            var result = rnd.NextDecimal(min, max);

            // Assert
            Assert.IsType<decimal>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
