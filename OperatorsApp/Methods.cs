namespace OperatorsApp;
using System;

public class Methods
{
    public static void Main(string[] args) { }

    public static int GetStones(int totalPounds)
    {
        return totalPounds / 14;
    }

    public static int GetPounds(int totalPounds)
    {
        return totalPounds % 14;
    }
}