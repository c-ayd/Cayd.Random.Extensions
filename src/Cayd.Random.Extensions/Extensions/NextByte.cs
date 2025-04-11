﻿namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a non-negative random 8-bit integer.
        /// </summary>
        /// <returns>A 8-bit unsigned integer that is between <see cref="Byte.MinValue"/> and <see cref="Byte.MaxValue"/>.</returns>
        public static byte NextByte(this System.Random random)
            => (byte)random.Next(Byte.MinValue, Byte.MaxValue);

        /// <summary>
        /// Returns a non-negative random 8-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A 8-bit unsigned integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If minValue equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static byte NextByte(this System.Random random, byte minValue, byte maxValue)
            => (byte)random.Next(minValue, maxValue);
    }
}
