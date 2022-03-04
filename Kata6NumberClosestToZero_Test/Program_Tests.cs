using Kata6;
using NUnit.Framework;

namespace Kata6NumberClosestToZero_Test
{
    public class Program_Tests
    {
        [Test]
        public void MustReturnCorrectValue_PositiveNumbers()
        {
            int[] input = { 1, 2, 3 };
            int expected = 1;
            int actual = Program.findClosestToZero(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void MustReturnCorrectValue_PositiveAndNegativeNumbers()
        {
            int[] input = { -1, 2, 3, -1, -2, -3 };
            int expected = 1;
            int actual = Program.findClosestToZero(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void MustReturnCorrectValue_Positive_Negative_ZeroNumbers()
        {
            int[] input = { 1, 2, 3, 0, 0, -1, -2, -3 };
            int expected = 0;
            int actual = Program.findClosestToZero(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}