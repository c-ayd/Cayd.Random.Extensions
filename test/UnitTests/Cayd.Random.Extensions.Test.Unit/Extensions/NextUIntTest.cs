namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextUIntTest
    {
        [Fact]
        public void NextUInt_WhenRangeIsNotGiven_ShouldReturnValueWithinUIntRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextUInt();

            // Assert
            Assert.IsType<uint>(result);
            Assert.True(result >= uint.MinValue, $"Result: {result}, Min Value: {uint.MinValue}");
            Assert.True(result <= uint.MaxValue, $"Result: {result}, Max Value: {uint.MaxValue}");
        }

        [Theory]
        [InlineData(5, 10)]
        [InlineData(uint.MinValue, uint.MaxValue)]
        public void NextUInt_WhenRangeIsGiven_ShouldReturnValueWithinRangeWithSameType(uint min, uint max)
        {
            // Act
            var result = System.Random.Shared.NextUInt(min, max);

            // Assert
            Assert.IsType<uint>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
