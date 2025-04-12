namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextDoubleTest
    {
        [Fact]
        public void NextDouble_WhenRangeIsNotGiven_ShouldReturnValueWithinDoubleRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextDoubleLimits();

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
            // Act
            var result = System.Random.Shared.NextDouble(min, max);

            // Assert
            Assert.IsType<double>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
