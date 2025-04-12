using System;

namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a random 64-bit integer.
        /// </summary>
        /// <returns>A 64-bit signed integer that is between <see cref="long.MinValue"/> and <see cref="long.MaxValue"/>.</returns>
        public static long NextLong(this System.Random random)
#if NET6_0_OR_GREATER
            => random.NextInt64(long.MinValue, long.MaxValue);
#else
            => random.NextLong(long.MinValue, long.MaxValue);
#endif

        /// <summary>
        /// Returns a random 64-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A 64-bit signed integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If minValue equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static long NextLong(this System.Random random, long minValue, long maxValue)
#if NET6_0_OR_GREATER
            => random.NextInt64(minValue, maxValue);
#else
        {
            if (maxValue < minValue)
                throw new ArgumentOutOfRangeException(nameof(minValue), minValue, $"{nameof(minValue)} cannot be greater than {nameof(maxValue)}");
            else if (minValue == maxValue)
                return minValue;

            if (minValue >= 0L || maxValue <= 0L)
                return (long)random.NextULong((ulong)minValue, (ulong)maxValue);

            long numerator, denominator;
            if (maxValue > Math.Abs((decimal)minValue))
            {
                numerator = minValue;
                denominator = maxValue;
            }
            else
            {
                numerator = maxValue;
                denominator = minValue;
            }

            double ratio = (double)Math.Abs((decimal)numerator / denominator);
            if (random.NextBool(ratio))
                return (long)(random.NextDouble() * numerator);

            return (long)(random.NextDouble() * denominator);
        }
#endif
    }
}
