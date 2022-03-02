using System;
namespace Kata5SecondLargest;

public class Program
{
    public static void Main(string[] args) { }

    public static int GetSecondLargestElement(int[] intArray)
    {
        if (allValuesSame(intArray))
        {
            return intArray[0];
        }

        int largest = GetLargestElement(intArray);
        int secondLargest = int.MinValue;

        foreach(int i in intArray)
        {
            if (i == largest)
            {
                continue;
            }
            if (i > secondLargest)
            {
                secondLargest = i;
            }
        }
        return secondLargest;
    }

    private static bool allValuesSame(int[] intArray)
    {
        int oneElement = intArray[0];
        foreach(int element in intArray)
        {
            if (oneElement != element)
            {
                return false;
            }
        }
        return true;
    }

    private static int GetLargestElement(int[] intArray)
    {
        int largest = int.MinValue;

        foreach (int element in intArray)
        {
            if (largest < element)
            {
                largest = element;
            }
        }
        return largest;
    }
}