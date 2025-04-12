using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextIntTest
    {
        [Fact]
        public void NextInt_WhenRangeIsNotGiven_ShouldReturnValueWithinIntRangeWithSameType()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextInt();

            // Assert
            Assert.IsType<int>(result);
            Assert.True(result >= int.MinValue, $"Result: {result}, Min Value: {int.MinValue}");
            Assert.True(result <= int.MaxValue, $"Result: {result}, Max Value: {int.MaxValue}");
        }

        [Theory]
        [InlineData(-10, 10)]
        [InlineData(int.MinValue, int.MaxValue)]
        public void NextInt_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(int min, int max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextInt(min, max);

            // Assert
            Assert.IsType<int>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }

        [Theory]
        [InlineData(10)]
        [InlineData(int.MaxValue)]
        public void NextInt_WhenOnlyMaxValueIsGiven_ShouldReturnValueBetweenZeroAndMaxWithSameType(int max)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextInt(max);

            // Assert
            Assert.IsType<int>(result);
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
