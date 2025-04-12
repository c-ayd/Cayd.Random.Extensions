using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextLongTest
    {
        [Fact]
        public void NextLong_WhenRangeIsNotGiven_ShouldReturnValueWithinLongRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextLong();

            // Assert
            Assert.IsType<long>(result);
            Assert.True(result >= long.MinValue, $"Result: {result}, Min Value: {long.MinValue}");
            Assert.True(result <= long.MaxValue, $"Result: {result}, Max Value: {long.MaxValue}");
        }

        [Theory]
        [InlineData(-10L, 10L)]
        [InlineData(long.MinValue, long.MaxValue)]
        public void NextLong_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(long min, long max)
        {
            // Arrange

            var rnd = new System.Random();
            // Act
            var result = rnd.NextLong(min, max);

            // Assert
            Assert.IsType<long>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Theory]
        [InlineData(10L)]
        [InlineData(long.MaxValue)]
        public void NextLong_WhenOnlyMaxValueIsGiven_ShouldReturnValueBetweenZeroAndMaxWithSameType(long max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextLong(max);

            // Assert
            Assert.IsType<long>(result);
            Assert.True(result >= 0L && result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
