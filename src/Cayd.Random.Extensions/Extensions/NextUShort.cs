using System;

namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a non-negative random 16-bit integer.
        /// </summary>
        /// <returns>A 16-bit unsigned integer that is between <see cref="ushort.MinValue"/> and <see cref="ushort.MaxValue"/>.</returns>
        public static ushort NextUShort(this System.Random random)
            => (ushort)random.Next(ushort.MinValue, ushort.MaxValue);

        /// <summary>
        /// Returns a non-negative random 16-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A 16-bit unsigned integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static ushort NextUShort(this System.Random random, ushort minValue, ushort maxValue)
            => (ushort)random.Next(minValue, maxValue);

        /// <summary>
        /// Returns a non-negative random 16-bit integer that is less than the specified maximum.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to 0.</param>
        /// <returns>
        /// A 16-bit unsigned integer greater than or equal to 0 and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0
        /// but not <paramref name="maxValue"/>. However, <paramref name="maxValue"/> equalts to 0, 0 is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
        public static ushort NextUShort(this System.Random random, ushort maxValue)
            => (ushort)random.Next(maxValue);
    }
}
