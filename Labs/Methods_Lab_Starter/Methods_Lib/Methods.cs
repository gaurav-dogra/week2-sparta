using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            return (weeks: totalDays / 7, days: totalDays % 7);

        }

        public static (int square, int cube, double sqrt) PowersRoot(int n)
        {
            return (n * n, n * n * n, Math.Sqrt(n));
        }

        public static int RollDice(Random rng)
        {
            return rng.Next(1, 13);
        }

    }
}
