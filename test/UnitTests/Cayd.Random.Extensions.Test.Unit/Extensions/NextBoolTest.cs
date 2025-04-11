namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextBoolTest
    {
        [Fact]
        public void NextBool_ShouldReturnBoolean()
        {
            // Act
            var result = System.Random.Shared.NextBool();

            // Assert
            Assert.IsType<bool>(result);
        }

        [Theory]
        [InlineData(0.1)]
        [InlineData(1.0)]
        public void NextBool_WhenProbabilityIsWithinRange_ShouldReturnBoolean(double probability)
        {
            // Act
            var result = System.Random.Shared.NextBool(probability);

            // Assert
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void NextBool_WhenProbabilityIsZero_ShouldAlwaysReturnFalse()
        {
            // Act
            var result = System.Random.Shared.NextBool(0.0);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void NextBool_WhenProbabilityIsOne_ShouldAlwaysReturnTrue()
        {
            // Act
            var result = System.Random.Shared.NextBool(1.0);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(-0.1)]
        [InlineData(1.1)]
        public void NextBool_WhenProbabilityIsNotWithinRange_ShouldReturnBoolean(double probability)
        {
            // Act
            var result = Record.Exception(() =>
            {
                System.Random.Shared.NextBool(probability);
            });

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ArgumentOutOfRangeException>(result);
        }
    }
}
