using FluentAssertions;
using Xunit;

namespace AdventOfCode.Solutions.Days.Day03
{
    [Trait("Day", "03")]
    [Collection("Day 03")]
    public class Day03_Test
    {
        [Theory(DisplayName = "First - Sample Passes")]
        [InlineData("R75,D30,R83,U83,L12,D49,R71,U7,L72\nU62,R66,U55,R34,D71,R55,D58,R83", 159)]
        [InlineData("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51\nU98,R91,D20,R16,D67,R40,U7,R15,U6,R7", 135)]
        public void First_Step_Sample_Passes(string input, int expect) =>
            new Day03().First(input).Should().Be(expect);


        [Theory(DisplayName = "Second - Sample Passes")]
        [InlineData("R75,D30,R83,U83,L12,D49,R71,U7,L72\nU62,R66,U55,R34,D71,R55,D58,R83", 610)]
        [InlineData("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51\nU98,R91,D20,R16,D67,R40,U7,R15,U6,R7", 410)]
        public void Second_Step_Sample_Passes(string input, int expect) =>
            new Day03().Second(input).Should().Be(expect);
    }
}
