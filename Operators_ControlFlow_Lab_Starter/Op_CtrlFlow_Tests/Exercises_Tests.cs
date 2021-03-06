using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {     
        // write unit test(s) for MyMethod here


        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, Result.Fail)]
        [TestCase(80, Result.Pass)]
        [TestCase(90, Result.Distinction)]
        [TestCase(100, Result.Distinction)]
        public void GradeTest(int marks, Result expected)
        {
            var actual = Exercises.Grade(marks);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(110)]
        public void GradeTest_ArgumentException(int marks)
        {
            Assert.Throws<ArgumentException>(() => Exercises.Grade(marks));
        }

        [TestCase(4, 20)]
        [TestCase(3, 50)]
        [TestCase(2, 50)]
        [TestCase(1, 100)]
        [TestCase(0, 200)]
        public void ShouldReturnCorrectAttendees(int alertLevel, int expected)
        {
            int actual = Exercises.MaxNoOfAttendeesAtScottishWedding(alertLevel);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ShouldThrow_ArgumentOutOfRangeException()
        {
            int outOfRangeValue = -1;
            Assert.That(() => Exercises.MaxNoOfAttendeesAtScottishWedding(outOfRangeValue),
                Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Value can only be from 0-4 inclusive"));
        }
    }
}
