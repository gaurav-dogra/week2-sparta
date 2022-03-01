namespace OperatorsApp;
using System;

public class Methods
{
    public static void Main(string[] args) 
    {
        int a = int.MaxValue;
        Console.WriteLine(a);
        a = a + 1;
        Console.WriteLine(a);
    }

    public static int GetStones(int totalPounds)
    {
        if (totalPounds < 0) { return 0; }
        return totalPounds / 14;
    }

    public static int GetPounds(int totalPounds)
    {
        if (totalPounds < 0) { return 0; }
        return totalPounds % 14;
    }


}