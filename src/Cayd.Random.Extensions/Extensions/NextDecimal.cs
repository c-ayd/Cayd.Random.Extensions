using System;

namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a random floating point number.
        /// </summary>
        /// <returns>A high precision floating point number that is between <see cref="decimal.MinValue"/> and <see cref="decimal.MaxValue"/>.</returns>
        public static decimal NextDecimal(this System.Random random)
            => random.NextDecimal(decimal.MinValue, decimal.MaxValue);

        /// <summary>
        /// Returns a random floating point number within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A high precision floating point number greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static decimal NextDecimal(this System.Random random, decimal minValue, decimal maxValue)
        {
            if (maxValue < minValue)
                throw new ArgumentOutOfRangeException(nameof(minValue), minValue, $"{nameof(minValue)} cannot be greater than {nameof(maxValue)}");
            else if (minValue == maxValue)
                return minValue;

            if (minValue >= 0.0m || maxValue <= 0.0m)
                return ((decimal)random.NextDouble() * (maxValue - minValue)) + minValue;

            decimal numerator, denominator;
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

            double ratio = (double)Math.Abs(numerator / denominator);
            if (random.NextBool(ratio))
                return (decimal)random.NextDouble() * numerator;

            return (decimal)random.NextDouble() * denominator;
        }

        /// <summary>
        /// Returns a random floating point number that is less than the specified maximum.
        /// </summary>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to 0.</param>
        /// <returns>
        /// A high precision floating point number greater than or equal to 0 and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0
        /// but not <paramref name="maxValue"/>. However, <paramref name="maxValue"/> equalts to 0, 0 is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
        public static decimal NextDecimal(this System.Random random, decimal maxValue)
            => random.NextDecimal(0m, maxValue);
    }
}
