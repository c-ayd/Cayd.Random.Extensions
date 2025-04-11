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
            Assert.True(result >= Int16.MinValue, $"Result: {result}, Min Value: {Int16.MinValue}");
            Assert.True(result <= Int16.MaxValue, $"Result: {result}, Max Value: {Int16.MaxValue}");
        }

        [Theory]
        [InlineData(-10, 10)]
        [InlineData(-32768, 32767)]
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
