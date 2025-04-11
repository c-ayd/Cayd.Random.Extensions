namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextLongTest
    {
        [Fact]
        public void NextLong_WhenRangeIsNotGiven_ShouldReturnValueWithinLongRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextLong();

            // Assert
            Assert.IsType<long>(result);
            Assert.True(result >= long.MinValue, $"Result: {result}, Min Value: {long.MinValue}");
            Assert.True(result <= long.MaxValue, $"Result: {result}, Max Value: {long.MaxValue}");
        }

        [Theory]
        [InlineData(-10, 10)]
        [InlineData(-9223372036854775808, 9223372036854775807)]
        public void NextLong_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(long min, long max)
        {
            // Act
            var result = System.Random.Shared.NextLong(min, max);

            // Assert
            Assert.IsType<long>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
