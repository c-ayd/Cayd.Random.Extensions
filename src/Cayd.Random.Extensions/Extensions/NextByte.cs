namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a non-negative random 8-bit integer.
        /// </summary>
        /// <returns>An 8-bit unsigned integer that is between <see cref="byte.MinValue"/> and <see cref="byte.MaxValue"/>.</returns>
        public static byte NextByte(this System.Random random)
            => (byte)random.Next(byte.MinValue, byte.MaxValue);

        /// <summary>
        /// Returns a non-negative random 8-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// An 8-bit unsigned integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If minValue equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static byte NextByte(this System.Random random, byte minValue, byte maxValue)
            => (byte)random.Next(minValue, maxValue);
    }
}
