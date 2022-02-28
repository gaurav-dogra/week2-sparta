using NUnit.Framework;
using OperatorsApp;

namespace OperatorsControlFlowTests;
public class StoneTests
{
    static int input;

    [SetUp]
    public static void init()
    {
        input = 156;
    }

    [Test]
    public void ShouldReturnCorrectStones()
    {
        int expected = 11;
        int actual = Methods.GetStones(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldReturnCorrectPounds()
    {
        int expected = 2;
        int actual = Methods.GetPounds(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
