using System;

namespace Kata6;

public class Program
{
    public static void Main(string[] args) { }

    public static int findClosestToZero(int[] array)
    {
        int currentMinimum = int.MaxValue;

        foreach (int i in array)
        {
            int v = Math.Abs(i);
            if (v < currentMinimum)
            {
                currentMinimum = v;
            }
        }
        return currentMinimum;
    }
}