namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextDecimalTest
    {
        [Fact]
        public void NextDecimal_WhenRangeIsNotGiven_ShouldReturnValueWithinDecimalRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextDecimal();

            // Assert
            Assert.IsType<decimal>(result);
            Assert.True(result >= decimal.MinValue, $"Result: {result}, Min Value: {decimal.MinValue}");
            Assert.True(result <= decimal.MaxValue, $"Result: {result}, Max Value: {decimal.MaxValue}");
        }

        [Fact]
        public void NextDecimal_WhenRangeIsNotOnBoundaries_ShouldReturnValueWithinRangeWithSameType()
        {
            // Arrange
            decimal min = -10.0m, max = 10.0m;

            // Act
            var result = System.Random.Shared.NextDecimal(min, max);

            // Assert
            Assert.IsType<decimal>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Fact]
        public void NextDecimal_WhenRangeIsOnBoundaries_ShouldReturnValueWithinRangeWithSameType()
        {
            // Arrange
            decimal min = decimal.MinValue, max = decimal.MaxValue;

            // Act
            var result = System.Random.Shared.NextDecimal(min, max);

            // Assert
            Assert.IsType<decimal>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
