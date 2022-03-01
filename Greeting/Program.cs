using System;
namespace Greeting;

public class Program
{
    public static void Main(string[] args) { }

    public static string GetGreeting(int time)
    {
        if (time >= 5 && time <= 12)
        {
            return "Good Morning";
        }
        else if (time >= 13 && time <= 18)
        {
            return "Good Afternoon";
        }
        else if (time >= 19 && time <= 23 ||
          time >= 0 && time <= 4)
        {
            return "Good Evening";
        } else
        {
            throw new ArgumentOutOfRangeException("Error! time: " + time + "must be 0 - 23 inclusive");
        }
    }

}
