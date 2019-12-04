using FluentAssertions;
using Xunit;

namespace AdventOfCode.Solutions.Days.Day04
{
    [Trait("Day", "04")]
    [Collection("Day 04")]
    public class Day04_Tests
    {
        [Theory(DisplayName = "First - Invalid Password Returns False")]
        [InlineData(223450)]
        [InlineData(123789)]
        [InlineData(12345)]
        public void First_Invalid_Password_Returns_False(int password)
        {
            Day04.Validate(password).Should().BeFalse();
        }

        [Theory(DisplayName = "First - Valid Password Returns True")]
        [InlineData(122345)]
        [InlineData(111111)]
        public void First_Valid_Password_Returns_True(int password)
        {
            Day04.Validate(password).Should().BeTrue();
        }

        [Theory(DisplayName = "Second - Valid Password Returns True")]
        [InlineData(112233)]
        [InlineData(111122)]
        public void Second_Valid_Password_Returns_True(int password)
        {
            Day04.Validate(password, true).Should().BeTrue();
        }

        [Theory(DisplayName = "Second - Invalid Password Returns False")]
        [InlineData(123444)]
        public void Second_Valid_Password_Returns_False(int password)
        {
            Day04.Validate(password, true).Should().BeFalse();
        }

        const string PuzzleInput = "123257-647015";
        const int FirstCorrectAnswer = 2220;
        const int SecondCorrectAnswer = 1515;

        [Fact(DisplayName = "First Solution Correct")]
        public void First_Correct_Solution() =>
            new Day04().First(PuzzleInput).Should().Be(2220);


        [Fact(DisplayName = "Second Solution Correct")]
        public void Second_Correct_Solution() =>
            new Day04().Second(PuzzleInput).Should().Be(SecondCorrectAnswer);
    }
}
