namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextShortTest
    {
        [Fact]
        public void NextShort_WhenRangeIsNotGiven_ShouldReturnValueWithinShortRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextShort();

            // Assert
            Assert.IsType<short>(result);
            Assert.True(result >= short.MinValue, $"Result: {result}, Min Value: {short.MinValue}");
            Assert.True(result <= short.MaxValue, $"Result: {result}, Max Value: {short.MaxValue}");
        }

        [Theory]
        [InlineData(-10, 10)]
        [InlineData(short.MinValue, short.MaxValue)]
        public void NextShort_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(short min, short max)
        {
            // Act
            var result = System.Random.Shared.NextShort(min, max);

            // Assert
            Assert.IsType<short>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
