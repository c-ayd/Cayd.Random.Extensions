using System;

namespace Cayd.Random.Extensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Returns a random boolean.
        /// </summary>
        /// <returns>true with a probability of 0.5.</returns>
        public static bool NextBool(this System.Random random)
            => random.Next(0, 2) == 1;

        /// <summary>
        /// Returns a random boolean with a specified probability.
        /// </summary>
        /// <param name="probability">The probability of the result being true. probability must be between 0.0 and 1.0.</param>
        /// <returns>true with the specified probability.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="probability"/> is not between 0.0 and 1.0.</exception>
        public static bool NextBool(this System.Random random, double probability)
        {
            if (probability < 0.0 || probability > 1.0)
                throw new ArgumentOutOfRangeException(nameof(probability), probability, "Probability must be between 0.0 and 1.0");

            return random.NextDouble() < probability;
        }
    }
}
