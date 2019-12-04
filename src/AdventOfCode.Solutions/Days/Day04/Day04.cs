using AdventOfCode.Solutions.BuildingBlocks;
using System;
using System.Linq;

namespace AdventOfCode.Solutions.Days.Day04
{
    public class Day04 : IDay
    {
        public object First(string input) => RunInput(input, false);
        public object Second(string input) => RunInput(input, true);

        private static object RunInput(string input, bool secondCriterion)
        {
            var split = input.Split('-');
            var min = int.Parse(split[0]);
            var max = int.Parse(split[1]);
            
            var validPasswords = 0;
            for (int i = min; i < max; i++)
                if (Validate(i, secondCriterion))
                    validPasswords++;
            
            return validPasswords;
        }

        public static byte[] s_sequence = new byte[6];
        public static bool Validate(int password, bool validateSecondCriterion = false)
        {
            for (int i = s_sequence.Length - 1; i >= 0; i--)
            {
                password = Math.DivRem(password, 10, out var d);
                s_sequence[i] = (byte)d;
            }

            bool hasDouble = false;
            bool second = false;
            for (int i = 1; i < s_sequence.Length; i++)
            {
                if (s_sequence[i] < s_sequence[i - 1])
                    return false;

                if (s_sequence[i - 1] == s_sequence[i])
                    hasDouble = true;

                if (validateSecondCriterion &&!second && hasDouble &&
                    s_sequence.Count(p => p == s_sequence[i]) == 2)
                    second = true;
            }

            return validateSecondCriterion ? hasDouble && second : hasDouble;
        }
    }
}
