using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [Test]
        public void GivenANumberReturns_Square_Cube_Sqrt()
        {
            int input = 9;
            var expected = (81, 729, 3.0d);
            var actual = Methods.PowersRoot(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}