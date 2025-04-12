using System;

namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a non-negative random 64-bit integer.
        /// </summary>
        /// <returns>A 64-bit unsigned integer that is between <see cref="ulong.MinValue"/> and <see cref="ulong.MaxValue"/>.</returns>
        public static ulong NextULong(this System.Random random)
        {
            uint higherBits = random.NextUInt();
            uint lowerBits = random.NextUInt();
            return (higherBits << 32) | lowerBits;
        }

        /// <summary>
        /// Returns a non-negative random 64-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A 64-bit unsigned integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static ulong NextULong(this System.Random random, ulong minValue, ulong maxValue)
        {
            if (maxValue < minValue)
                throw new ArgumentOutOfRangeException(nameof(minValue), minValue, $"{nameof(minValue)} cannot be greater than {nameof(maxValue)}");
            else if (minValue == maxValue)
                return minValue;

            uint higherBits = 0;
            uint lowerBits = 0;
            if (maxValue > uint.MaxValue)
            {
                higherBits = random.NextUInt(0, (uint)(maxValue >> 32));
                lowerBits = random.NextUInt((uint)(minValue & uint.MaxValue), uint.MaxValue);
            }
            else
            {
                lowerBits = random.NextUInt((uint)minValue, (uint)maxValue);
            }

            return (higherBits << 32) | lowerBits;
        }
    }
}
