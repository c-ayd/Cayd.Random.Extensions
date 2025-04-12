namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a random 32-bit integer.
        /// </summary>
        /// <returns>A 32-bit signed integer that is between <see cref="int.MinValue"/> and <see cref="int.MaxValue"/>.</returns>
        public static int NextInt(this System.Random random)
            => random.Next(int.MinValue, int.MaxValue);

        /// <summary>
        /// Returns a random 32-bit integer within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A 32-bit signed integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If <paramref name="minValue"/> equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static int NextInt(this System.Random random, int minValue, int maxValue)
            => random.Next(minValue, maxValue);
    }
}
