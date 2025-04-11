namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a random 16-bit integer.
        /// </summary>
        /// <returns>A 16-bit signed integer that is between <see cref="Int16.MinValue"/> and <see cref="Int16.MaxValue"/>.</returns>
        public static short NextShort(this System.Random random)
            => (short)random.Next(Int16.MinValue, Int16.MaxValue);

        /// <summary>
        /// Returns a random 16-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A 16-bit signed integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If minValue equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static short NextShort(this System.Random random, short minValue, short maxValue)
            => (short)random.Next(minValue, maxValue);
    }
}
