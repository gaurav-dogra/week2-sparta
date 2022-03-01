using NUnit.Framework;
using OperatorsApp;

namespace OperatorsControlFlowTests;
public class StoneTests
{

    [Test]
    public void ShouldReturnCorrectStones()
    {
        int input = 156;
        int expected = 11;
        int result = Methods.GetStones(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldReturnCorrectPounds()
    {
        int input = 156;
        int expected = 2;
        int result = Methods.GetPounds(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void WhenGivenWeightIsBelowZero_StonesIsZero()
    {
        int negativeInput = -1;
        int ZERO = 0;
        int result = Methods.GetStones(negativeInput);

        Assert.That(result, Is.EqualTo(ZERO));
    }
    
    [Test]
    public void WhenGivenWeightIsBelowZero_PoundsIsZero()
    {
        int negativeInput = -1;
        int ZERO = 0;
        int result = Methods.GetPounds(negativeInput);

        Assert.That(result, Is.EqualTo(ZERO));
    }
}
