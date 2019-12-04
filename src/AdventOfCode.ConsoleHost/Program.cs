using AdventOfCode.Solutions.BuildingBlocks;

using FluentAssertions.Common;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AdventOfCode.ConsoleHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var days = GetDays();

            Console.WriteLine(
                "Advent of Code 2019\n" +
                "-------------------\n\n" +
                "Available days:\n");

            foreach (var day in days)
            {
                Console.WriteLine($" - {day.Name}");
            }

            if (days.Count == 0)
            {
                Console.WriteLine("No input files or solutions found, I guess");
                return;
            }

            DaySelection:

            Console.WriteLine();
            Console.Write($"Enter day to run [{days.Last().Name[^2..]}]: ");

            DaySelection dayToRun = null;

            var read = Console.ReadLine();

            if (read.Length == 1)
                read = "0" + read;

            if (read.Length > 2)
                goto DaySelection;

            if (string.IsNullOrWhiteSpace(read))
            {
                dayToRun = days.Last();
            } else
            {
                var day = days.FirstOrDefault(p => p.Name.EndsWith(read));
                if (day == null)
                    goto DaySelection;

                dayToRun = day;
            }

            RunDay(dayToRun);
        }

        private static void RunDay(DaySelection day)
        {
            Console.WriteLine($"\nRunning {day.Name}: ");
            var instance = day.Instance;
            var input = File.ReadAllText(day.InputFile);
            var first = instance.First(input);
            Console.WriteLine($"First:  {first}");

            var second = instance.Second(input);
            Console.WriteLine($"Second: {second}\n");
        }

        private static IReadOnlyList<DaySelection> GetDays()
        {
            var inputDirectory =
                new FileInfo(Assembly.GetExecutingAssembly().Location)
                .Directory
                .GetDirectories()
                .First(p => p.Name == "Inputs");

            var inputFiles = inputDirectory
                .EnumerateFiles("input??.txt")
                .Select(p => p.FullName)
                .ToList();

            var exportedTypes = typeof(IDay)
                .Assembly.GetExportedTypes()
                .Where(p => p.Implements(typeof(IDay)))
                .ToList();

            return exportedTypes.Select(t =>
            {
                var name = t.Name;
                var day = name[^2..];

                var input = inputFiles.FirstOrDefault(
                    p => p.EndsWith(day + ".txt"));

                return new DaySelection("Day " + day, t, input);
            }).Where(p => !string.IsNullOrEmpty(p.InputFile)).ToList();
        }
    }
}
