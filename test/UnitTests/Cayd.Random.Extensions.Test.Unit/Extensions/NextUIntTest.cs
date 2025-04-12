using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextUIntTest
    {
        [Fact]
        public void NextUInt_WhenRangeIsNotGiven_ShouldReturnValueWithinUIntRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextUInt();

            // Assert
            Assert.IsType<uint>(result);
            Assert.True(result >= uint.MinValue, $"Result: {result}, Min Value: {uint.MinValue}");
            Assert.True(result <= uint.MaxValue, $"Result: {result}, Max Value: {uint.MaxValue}");
        }

        [Theory]
        [InlineData(5u, 10u)]
        [InlineData(uint.MinValue, uint.MaxValue)]
        public void NextUInt_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(uint min, uint max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextUInt(min, max);

            // Assert
            Assert.IsType<uint>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Theory]
        [InlineData(10u)]
        [InlineData(uint.MaxValue)]
        public void NextUInt_WhenOnlyMaxValueIsGiven_ShouldReturnValueBetweenZeroAndMaxWithSameType(uint max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextUInt(max);

            // Assert
            Assert.IsType<uint>(result);
            Assert.True(result >= 0u && result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
