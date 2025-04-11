namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextIntTest
    {
        [Fact]
        public void NextInt_WhenRangeIsNotGiven_ShouldReturnValueWithinIntRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextInt();

            // Assert
            Assert.IsType<int>(result);
            Assert.True(result >= int.MinValue, $"Result: {result}, Min Value: {int.MinValue}");
            Assert.True(result <= int.MaxValue, $"Result: {result}, Max Value: {int.MaxValue}");
        }

        [Theory]
        [InlineData(-10, 10)]
        [InlineData(-2147483648, 2147483647)]
        public void NextInt_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(int min, int max)
        {
            // Act
            var result = System.Random.Shared.NextInt(min, max);

            // Assert
            Assert.IsType<int>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
