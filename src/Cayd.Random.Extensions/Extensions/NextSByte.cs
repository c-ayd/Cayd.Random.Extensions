using System;

namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a random 8-bit integer.
        /// </summary>
        /// <returns>An 8-bit signed integer that is between <see cref="sbyte.MinValue"/> and <see cref="sbyte.MaxValue"/>.</returns>
        public static sbyte NextSByte(this System.Random random)
            => (sbyte)random.Next(sbyte.MinValue, sbyte.MaxValue);

        /// <summary>
        /// Returns a random 8-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// An 8-bit signed integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static sbyte NextSByte(this System.Random random, sbyte minValue, sbyte maxValue)
            => (sbyte)random.Next(minValue, maxValue);

        /// <summary>
        /// Returns a random 8-bit integer that is less than the specified maximum.
        /// </summary>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to 0.</param>
        /// <returns>
        /// An 8-bit signed integer greater than or equal to 0 and less than <paramref name="maxValue"/>; that is, the range of return values ordinarily includes 0
        /// but not <paramref name="maxValue"/>. However, <paramref name="maxValue"/> equalts to 0, 0 is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than 0.</exception>
        public static sbyte NextSByte(this System.Random random, sbyte maxValue)
            => (sbyte)random.Next(maxValue);
    }
}
