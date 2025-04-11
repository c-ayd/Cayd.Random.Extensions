namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a non-negative random 32-bit integer.
        /// </summary>
        /// <returns>A 32-bit unsigned integer that is between <see cref="uint.MinValue"/> and <see cref="uint.MaxValue"/>.</returns>
        public static uint NextUInt(this System.Random random)
            => (uint)random.NextInt64(uint.MinValue, uint.MaxValue);

        /// <summary>
        /// Returns a non-negative random 32-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A 32-bit signed uninteger greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If minValue equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static uint NextUInt(this System.Random random, uint minValue, uint maxValue)
            => (uint)random.NextInt64(minValue, maxValue);
    }
}
