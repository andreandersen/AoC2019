using System;
using System.Linq;

namespace AdventOfCode.Solutions.BuildingBlocks
{
    public interface IDay
    {
        public object First(string input);
        public object Second(string input);
    }
}
