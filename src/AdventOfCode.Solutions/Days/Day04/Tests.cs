using FluentAssertions;
using Xunit;

namespace AdventOfCode.Solutions.Days.Day04
{
    [Trait("Day", "04")]
    [Collection("Day 04")]
    public class Day04_Tests
    {
        [Theory]
        [InlineData(223450)]
        [InlineData(123789)]
        [InlineData(12345)]
        public void Invalid_Password_Returns_False(int password)
        {
            Day04.Validate(password).Should().BeFalse();
        }

        [Theory(DisplayName = "Valid Password Returns True")]
        [InlineData(122345)]
        [InlineData(111111)]
        public void Valid_Password_Returns_True(int password)
        {
            Day04.Validate(password).Should().BeTrue();
        }
    }
}
