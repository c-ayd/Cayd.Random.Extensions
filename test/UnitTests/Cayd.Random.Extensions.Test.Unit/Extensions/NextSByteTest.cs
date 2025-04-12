using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextSByteTest
    {
        [Fact]
        public void NextSByte_WhenRangeIsNotGiven_ShouldReturnValueWithinSByteRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextSByte();

            // Assert
            Assert.IsType<sbyte>(result);
            Assert.True(result >= sbyte.MinValue, $"Result: {result}, Min Value: {sbyte.MinValue}");
            Assert.True(result <= sbyte.MaxValue, $"Result: {result}, Max Value: {sbyte.MaxValue}");
        }

        [Theory]
        [InlineData(-10, 10)]
        [InlineData(sbyte.MinValue, sbyte.MaxValue)]
        public void NextSByte_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(sbyte min, sbyte max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextSByte(min, max);

            // Assert
            Assert.IsType<sbyte>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Theory]
        [InlineData(10)]
        [InlineData(sbyte.MaxValue)]
        public void NextSByte_WhenOnlyMaxValueIsGiven_ShouldReturnValueBetweenZeroAndMaxWithSameType(sbyte max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextSByte(max);

            // Assert
            Assert.IsType<sbyte>(result);
            Assert.True(result >= 0 && result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
