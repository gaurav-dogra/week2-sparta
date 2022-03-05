using NUnit.Framework;
using Kata5SecondLargest;
using System;

namespace Kata5SecondLargestInAnArray_Test;
public class Program_Tests
{

    [Test]
    public void ShouldThrow_InvalidOperationException_OnEmptyArray()
    {
        int[] emptyArray = new int[] { };

        Assert.That(() => Program.GetSecondLargestElement(emptyArray), Throws.TypeOf<InvalidOperationException>()
            .With.Message
            .Contain("Array is Empty"));
    }

    [Test]
    public void ShouldThrow_InvalidOperationException_SameElementsArray()
    {
        int[] array = new[] { 7, 7, 7, 7 };
        Assert.That(() => Program.GetSecondLargestElement(array), Throws.TypeOf<InvalidOperationException>()
                    .With.Message
                    .Contain("All elements are same"));
    }

    [Test]
    public void ShouldThrow_InvalidOperationException_On1ElementArray()
    {
        int[] oneElementArray = new int[] { 7 };

        Assert.That(() => Program.GetSecondLargestElement(oneElementArray), Throws.TypeOf<InvalidOperationException>()
            .With.Message
            .Contain("Only one element in the array"));
    }

    [Test]
    public void ShouldReturnSecondLargestElement()
    {
        int[] array = new[] { 1, 2, 3, 5, 7 };
        int expected = 5;
        int actual = Program.GetSecondLargestElement(array);
        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test]
    public void WhenSecondLargestElementsIs_IntMinVal()
    {
        int[] array = new[] { -2_147_483_648, -2_147_483_648, -2_147_483_647 };
        int expected = -2_147_483_648;
        int actual = Program.GetSecondLargestElement(array);
        Assert.That(actual, Is.EqualTo(expected));
    }



}
