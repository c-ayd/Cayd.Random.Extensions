using System;

namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a random floating point number.
        /// </summary>
        /// <returns>A double precision floating point number that is between <see cref="double.MinValue"/> and <see cref="double.MaxValue"/>.</returns>
        public static double NextDoubleLimits(this System.Random random)
            => random.NextDouble(double.MinValue, double.MaxValue);

        /// <summary>
        /// Returns a random floating point number within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A double precision floating point number greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static double NextDouble(this System.Random random, double minValue, double maxValue)
        {
            if (maxValue < minValue)
                throw new ArgumentOutOfRangeException(nameof(minValue), minValue, $"{nameof(minValue)} cannot be greater than {nameof(maxValue)}");
            else if (minValue == maxValue)
                return minValue;

            if (minValue >= 0.0 || maxValue <= 0.0)
                return (random.NextDouble() * (maxValue - minValue)) + minValue;

            double numerator, denominator;
            if (maxValue > Math.Abs(minValue))
            {
                numerator = minValue;
                denominator = maxValue;
            }
            else
            {
                numerator = maxValue;
                denominator = minValue;
            }

            double ratio = Math.Abs(numerator / denominator);
            if (random.NextBool(ratio))
                return random.NextDouble() * numerator;

            return random.NextDouble() * denominator;
        }
    }
}
