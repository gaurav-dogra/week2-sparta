using NUnit.Framework;
using System;
using System.Linq;
using week2_sparta;

namespace Kata4DuplicateLetters_Test;
public class DuplicateLettersTest
{
    [TestCase("Nishant Mandal", "na")]
    [TestCase("Gaurav Dogra", "gar")]
    [TestCase("Nice one", "ne")]
    [TestCase("121213", "12")]
    public void Test1(string word, string expected)
    {
        //anyone found a better way
        char[] result = Program.GetArrayDuplicateLetters(word.ToLower());
        Array.Sort(result);
        string resultString = new string(result);

        char[] charArray = expected.ToArray();
        Array.Sort(charArray);
        expected = new string(charArray);

        Assert.That(resultString, Is.EqualTo(expected));
    }
}
