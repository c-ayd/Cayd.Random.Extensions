using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextByteTest
    {
        [Fact]
        public void NextByte_WhenRangeIsNotGiven_ShouldReturnValueWithinByteRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextByte();

            // Assert
            Assert.IsType<byte>(result);
            Assert.True(result >= byte.MinValue, $"Result: {result}, Min Value: {byte.MinValue}");
            Assert.True(result <= byte.MaxValue, $"Result: {result}, Max Value: {byte.MaxValue}");
        }

        [Theory]
        [InlineData(5, 10)]
        [InlineData(byte.MinValue, byte.MaxValue)]
        public void NextByte_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(byte min, byte max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextByte(min, max);

            // Assert
            Assert.IsType<byte>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Theory]
        [InlineData(10)]
        [InlineData(byte.MaxValue)]
        public void NextByte_WhenOnlyMaxValueIsGiven_ShouldReturnValueBetweenZeroAndMaxWithSameType(byte max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextByte(max);

            // Assert
            Assert.IsType<byte>(result);
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
