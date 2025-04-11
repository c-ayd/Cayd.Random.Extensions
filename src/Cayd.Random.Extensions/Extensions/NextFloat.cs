namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a random floating point number.
        /// </summary>
        /// <returns>A single precision floating point number that is between <see cref="float.MinValue"/> and <see cref="float.MaxValue"/>.</returns>
        public static float NextFloat(this System.Random random)
            => (float)(random.NextDouble() * ((double)float.MaxValue - (double)float.MinValue) + (double)float.MinValue);

        /// <summary>
        /// Returns a random floating point number within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive lower bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>
        /// A single precision floating point number greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
        /// but not <paramref name="maxValue"/>. If minValue equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
        public static float NextFloat(this System.Random random, float minValue, float maxValue)
            => (float)(random.NextDouble() * ((double)maxValue - (double)minValue) + (double)minValue);
    }
}
