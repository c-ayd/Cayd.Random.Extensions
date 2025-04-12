using System;
using Xunit;

namespace Cayd.Random.Extensions.Test.Unit.Extensions
{
    public class NextBoolTest
    {
        [Fact]
        public void NextBool_ShouldReturnBoolean()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextBool();

            // Assert
            Assert.IsType<bool>(result);
        }

        [Theory]
        [InlineData(0.1)]
        [InlineData(1.0)]
        public void NextBool_WhenProbabilityIsWithinRange_ShouldReturnBoolean(double probability)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextBool(probability);

            // Assert
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void NextBool_WhenProbabilityIsZero_ShouldAlwaysReturnFalse()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextBool(0.0);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void NextBool_WhenProbabilityIsOne_ShouldAlwaysReturnTrue()
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = rnd.NextBool(1.0);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(-0.1)]
        [InlineData(1.1)]
        public void NextBool_WhenProbabilityIsNotWithinRange_ShouldThrowArgumentOutOfRangeException(double probability)
        {
            // Arrange
            var rnd = new System.Random();

            // Act
            var result = Record.Exception(() =>
            {
                rnd.NextBool(probability);
            });

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ArgumentOutOfRangeException>(result);
        }
    }
}
