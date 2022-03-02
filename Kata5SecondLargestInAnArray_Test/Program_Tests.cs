using NUnit.Framework;
using Kata5SecondLargest;

namespace Kata5SecondLargestInAnArray_Test;
public class Program_Tests
{

    [Test]
    public void ShouldReturnSecondLargestElement()
    {
        int[] array = new[] { 1, 2, 3, 5, 7 };
        int expected = 5;
        int actual = Program.GetSecondLargestElement(array);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void ShouldReturnAElementWhenAllElementsAreSame()
    {
        int[] array = new[] { 1, 1, 1, 1  };
        int expected = 1;
        int actual = Program.GetSecondLargestElement(array);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldReturnAElementWhenSecondLargestElementsIs_IntMinVal()
    {
        int[] array = new[] { -2_147_483_648, -2_147_483_647 };
        int expected = -2_147_483_648;
        int actual = Program.GetSecondLargestElement(array);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldReturnElementWhenOnly_1ElementInArray()
    {
        int[] array = new[] { -2 };
        int expected = -2;
        int actual = Program.GetSecondLargestElement(array);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
