namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextSByteTest
    {
        [Fact]
        public void NextSByte_WhenRangeIsNotGiven_ShouldReturnValueWithinSByteRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextSByte();

            // Assert
            Assert.IsType<sbyte>(result);
            Assert.True(result >= SByte.MinValue, $"Result: {result}, Min Value: {SByte.MinValue}");
            Assert.True(result <= SByte.MaxValue, $"Result: {result}, Max Value: {SByte.MaxValue}");
        }

        [Theory]
        [InlineData(-10, 10)]
        [InlineData(-128, 127)]
        public void NextSByte_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(sbyte min, sbyte max)
        {
            // Act
            var result = System.Random.Shared.NextSByte(min, max);

            // Assert
            Assert.IsType<sbyte>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
