using AdventOfCode.Solutions.BuildingBlocks;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AdventOfCode.Solutions.Days.Day04
{
    public class Day04 : IDay
    {
        public object First(string input)
        {
            var split = input.Split('-'); ;
            var min = int.Parse(split[0]);
            var max = int.Parse(split[1]);

            ReadOnlySpan<byte> seq = split[0]
                .Select(p => byte.Parse(p.ToString()))
                .ToArray();

            var validPasswords = 0;

            for (int i = min; i < max; i++)
            {
                if (Validate(i))
                    validPasswords++;
            }

            return validPasswords;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining |
            MethodImplOptions.AggressiveOptimization)]
        public static bool Validate(int password)
        {
            Span<byte> sequence = new byte[1 + (int)Math.Log10(password)];
            for (int i = sequence.Length - 1; i >= 0; i--)
            {
                password = Math.DivRem(password, 10, out var d);
                sequence[i] = (byte)d;
            }

            if (sequence.Length != 6)
                return false;

            bool hasDouble = false;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] < sequence[i - 1])
                    return false;

                if (sequence[i - 1] == sequence[i])
                    hasDouble = true;
            }

            return hasDouble;
        }

        public object Second(string input) => 0;
    }
}
