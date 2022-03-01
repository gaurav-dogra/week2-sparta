using NUnit.Framework;
using Greeting;
using System;

namespace Greeting_Tests;
public class Greeting_Tests
{

    [TestCase(5, "Good Morning")]
    [TestCase(17, "Good Afternoon")]
    [TestCase(23, "Good Evening")]
    [TestCase(4, "Good Evening")]
    [TestCase(0, "Good Evening")]
    public void MustSayGreetingAccordingToTime(int time, string expected)
    {
        string actual = Program.GetGreeting(time);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void MustThrow_ArgumentOutOfRangeException()
    {
        int input = 24;
        Assert.That(() => Program.GetGreeting(input),
            Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("must be 0 - 23 inclusive"));
    }
    
}
