using AdventOfCode.Solutions.BuildingBlocks;

using System;
using System.Linq;

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


            return 0;
        }

        public object Second(string input) => 0;
    }
}
