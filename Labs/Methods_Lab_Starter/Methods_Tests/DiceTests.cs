using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {

        [Test]
        public static void MustReturnANumberWithinSpecifiedRange()
        {
            // checking 100 times
            for (int i = 0; i < 100; i++)
            {
                int random = Methods.RollDice(new Random());
                Assert.That(random, Is.AtLeast(1).And.AtMost(12));
            }

        }

    }
}
