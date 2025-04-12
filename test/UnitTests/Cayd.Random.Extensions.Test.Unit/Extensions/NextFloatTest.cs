using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextFloatTest
    {
        [Fact]
        public void NextFloat_WhenRangeIsNotGiven_ShouldReturnValueWithinFloatRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextFloat();

            // Assert
            Assert.IsType<float>(result);
            Assert.True(result >= float.MinValue, $"Result: {result}, Min Value: {float.MinValue}");
            Assert.True(result <= float.MaxValue, $"Result: {result}, Max Value: {float.MaxValue}");
        }

        [Theory]
        [InlineData(-10.0f, 10.0f)]
        [InlineData(float.MinValue, float.MaxValue)]
        public void NextFloat_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(float min, float max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextFloat(min, max);

            // Assert
            Assert.IsType<float>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Theory]
        [InlineData(10.0f)]
        [InlineData(float.MaxValue)]
        public void NextFloat_WhenOnlyMaxValueIsGiven_ShouldReturnValueBetweenZeroAndMaxWithSameType(float max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextFloat(max);

            // Assert
            Assert.IsType<float>(result);
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
