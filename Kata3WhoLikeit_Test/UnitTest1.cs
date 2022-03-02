using NUnit.Framework;
using Kata3WhoLikeit;
using System.Linq;

namespace Kata3WhoLikeit_Test;
public class Tests
{
    //Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
    //Assert.AreEqual("Peter likes this", Kata.Likes(new string[] {"Peter"}));
    //Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] {"Jacob", "Alex"}));
    //Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
    //Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));

    [TestCase(new object[] { }, "no one likes this")]
    [TestCase(new object[] { "Peter" }, "Peter likes this")]
    [TestCase(new object[] { "Jacob", "Alex" }, "Jacob and Alex like this")]
    [TestCase(new object[] { "Max", "John", "Mark" }, "Max, John and Mark like this")]
    [TestCase(new object[] { "Alex", "Jacob", "Mark", "Max" }, "Alex, Jacob and 2 others like this")]
    public void Like_Test(object[] objectArray, string expResponse)
    {
        string[] stringArray = objectArray.Cast<string>().ToArray();
        string actual = Program.Likes(stringArray);
        Assert.That(actual, Is.EqualTo(expResponse));
    }
}