using System;
using System.Collections.Generic;

namespace Op_CtrlFlow;
    public class Exercises
    {
        private static readonly int MAX_HUMAN_AGE = 120;
        private static readonly int MAX_POSSIBLE_MARKS = 100;

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            if (nums.Count == 0) { return 0; }
            int sum = 0;
            foreach(var n in nums)
            {
                sum += n;
            }

            return sum / (double) nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            if (age >= 0 && age < 5)
            {
                return "Free";
            } else if (age >=5 && age <= 12)
            {
                return "Child";
            } else if (age >= 13 && age <= 17)
            {
                return "Student";
            } else if (age >= 18 && age <= 59)
            {
                return "Standard";
            } else if (age >= 60 && age <= MAX_HUMAN_AGE)
            {
                return "OAP";
            } else
            {
                return "Invalid age";
            }
        }

        public static Result Grade(int marks)
        {
            if (marks >= 0 && marks <= 64)
            {
                return Result.Fail;
            }
            else if (marks >= 65 && marks <= 84)
            {
                return Result.Pass;
            } 
            else if (marks >= 85 && marks <= MAX_POSSIBLE_MARKS)
            {
                return Result.Distinction;
            } 
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }

}
