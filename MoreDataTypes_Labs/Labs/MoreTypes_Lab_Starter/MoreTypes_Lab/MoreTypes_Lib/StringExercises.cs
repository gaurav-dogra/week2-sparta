using System;
using System.Text;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            var sb = new StringBuilder(input.Trim().ToUpper());
            for (int i = 0; i < num; i++)
            {
                sb.Append(i);
            }
            return sb.ToString();
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return new StringBuilder(number.ToString())
                .Append($" {street},")
                .Append($" {city}")
                .Append($" {postcode}.")
                .ToString();
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            return $"You got {score} out of {outOf}: {score / Convert.ToDouble(outOf):P1}";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            double failureValue = -999;
            if (double.TryParse(numString, out double returnVal))
            {
                return returnVal;
            } else
            {
                return failureValue;
            }
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                switch(letter)
                {
                    case 'A':
                        countA++;
                        break;
                    case 'B':
                        countB++;
                        break;
                    case 'C':
                        countC++;
                        break;
                    case 'D':
                        countD++;
                        break;

                }
            }
            return $"A:{countA} B:{countB} C:{countC} D:{countD}";
        }
    }
}
