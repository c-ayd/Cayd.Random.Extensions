using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextULongTest
    {
        [Fact]
        public void NextULong_WhenRangeIsNotGiven_ShouldReturnValueWithinULongRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextULong();

            // Assert
            Assert.IsType<ulong>(result);
            Assert.True(result >= ulong.MinValue, $"Result: {result}, Min Value: {ulong.MinValue}");
            Assert.True(result <= ulong.MaxValue, $"Result: {result}, Max Value: {ulong.MaxValue}");
        }

        [Theory]
        [InlineData(5, 10)]
        [InlineData(ulong.MinValue, ulong.MaxValue)]
        public void NextULong_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(ulong min, ulong max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextULong(min, max);

            // Assert
            Assert.IsType<ulong>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
