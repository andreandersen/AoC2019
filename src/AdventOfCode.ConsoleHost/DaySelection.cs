using AdventOfCode.Solutions.BuildingBlocks;

using System;

namespace AdventOfCode.ConsoleHost
{
    public class DaySelection
    {
        public DaySelection(string name, Type type, string inputFile)
        {
            Name = name;
            Type = type;
            InputFile = inputFile;
        }

        public string Name { get; }
        public string InputFile { get; set; }
        public Type Type { get; }

        public IDay Instance => Activator.CreateInstance(Type) as IDay;
    }
}
