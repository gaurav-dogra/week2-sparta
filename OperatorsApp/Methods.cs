namespace OperatorsApp;
public class Methods
{
    public static void Main(string[] args) {}

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