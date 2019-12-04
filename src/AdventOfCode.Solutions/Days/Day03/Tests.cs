using FluentAssertions;
using Xunit;

namespace AdventOfCode.Solutions.Days.Day03
{
    [Trait("Day", "03")]
    [Collection("Day 03")]
    public class Day03_Test
    {
        [Fact]
        public void First_Step_Sample_Passes()
        {
            var day = new Day03();

            var input1 =
                "R75,D30,R83,U83,L12,D49,R71,U7,L72\n" +
                "U62,R66,U55,R34,D71,R55,D58,R83";

            day.First(input1).Should().Be(159);

            var input2 =
                "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51\n" +
                "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7";

            day.First(input2).Should().Be(135);
        }

        [Fact]
        public void Second_Step_Sample_Passes()
        {
            new Day03()
                .Second(
                    "R75,D30,R83,U83,L12,D49,R71,U7,L72\n" +
                    "U62,R66,U55,R34,D71,R55,D58,R83")
                .Should().Be(610);

            new Day03()
                .Second(
                    "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51\n" +
                    "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7")
                .Should().Be(410);
        }
    }
}
