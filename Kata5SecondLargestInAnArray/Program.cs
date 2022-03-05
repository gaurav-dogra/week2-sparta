using System;
namespace Kata5SecondLargest;

public class Program
{
    public static void Main(string[] args) { }

    public static int GetSecondLargestElement(int[] intArray)
    {
        if (intArray.Length == 0)
            throw new InvalidOperationException("Array is Empty");
        else if (intArray.Length == 1)
            throw new InvalidOperationException("Only one element in the array");
        else if (allElementsSame(intArray))
            throw new InvalidOperationException("All elements are same");
        

        int largest = GetLargestElement(intArray);
        int secondLargest = int.MinValue;

        foreach (int i in intArray)
        {
            if (i == largest) 
                continue; 

            if (i > secondLargest) 
                secondLargest = i;
        }
        return secondLargest;
    }

    private static bool allElementsSame(int[] intArray)
    {
        int firstElement = intArray[0];
        foreach (int element in intArray)
        {
            if (firstElement != element)
                return false;
        }
        return true;
    }

    private static int GetLargestElement(int[] intArray)
    {
        int largest = int.MinValue;

        foreach (int element in intArray)
        {
            if (largest < element)
                largest = element;
        }
        return largest;
    }
}