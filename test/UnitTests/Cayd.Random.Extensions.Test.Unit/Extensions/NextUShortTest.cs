namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextUShortTest
    {
        [Fact]
        public void NextUShort_WhenRangeIsNotGiven_ShouldReturnValueWithinUShortRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextUShort();

            // Assert
            Assert.IsType<ushort>(result);
            Assert.True(result >= ushort.MinValue, $"Result: {result}, Min Value: {ushort.MinValue}");
            Assert.True(result <= ushort.MaxValue, $"Result: {result}, Max Value: {ushort.MaxValue}");
        }

        [Theory]
        [InlineData(5, 10)]
        [InlineData(ushort.MinValue, ushort.MaxValue)]
        public void NextUShort_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(ushort min, ushort max)
        {
            // Act
            var result = System.Random.Shared.NextUShort(min, max);

            // Assert
            Assert.IsType<ushort>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
