namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextFloatTest
    {
        [Fact]
        public void NextFloat_WhenRangeIsNotGiven_ShouldReturnValueWithinFloatRangeWithSameType()
        {
            // Act
            var result = System.Random.Shared.NextFloat();

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
            // Act
            var result = System.Random.Shared.NextFloat(min, max);

            // Assert
            Assert.IsType<float>(result);
            Assert.True(result >= min, $"Result: {result}, Min Value: {min}");
            Assert.True(result <= max, $"Result: {result}, Max Value: {max}");
        }
    }
}
