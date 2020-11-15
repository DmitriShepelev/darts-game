using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            var i = (x * x) + (y * y);
            if (i <= 1)
            {
                return 10;
            }
            else if (i <= 25)
            {
                return 5;
            }
            else if (i <= 100)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
