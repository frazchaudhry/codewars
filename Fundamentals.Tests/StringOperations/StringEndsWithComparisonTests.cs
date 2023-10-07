using FluentAssertions;

namespace Fundamentals.StringOperations;

public class StringEndsWithComparisonTests
{
    [Theory]
    [InlineData("samurai", "ai", true)]
    [InlineData("sumo", "omo", false)]
    [InlineData("ninja", "ja", true)]
    [InlineData("sensei", "i", true)]
    [InlineData("samurai", "ra", false)]
    [InlineData("abc", "abcd", false)]
    [InlineData("abc", "abc", true)]
    [InlineData("abcabc", "bc", true)]
    [InlineData("ails", "fails", false)]
    [InlineData("fails", "ails", true)]
    [InlineData("this", "fails", false)]
    [InlineData("abc", "", true)]
    [InlineData(":-)", ":-(", false)]
    [InlineData("!@#$%^&*() :-)", ":-)", true)]
    [InlineData("abc\n", "abc", false)]
    public void IsFirstStringContainsSecondStringAtTheEnd_ShouldProperResponseIfTheLastTwoCharactersMatch(string first,
        string second, bool expected)
    {
        // Arrange

        // Act
        var actual = StringEndsWithComparison.IsFirstStringContainsSecondStringAtTheEnd(first, second);
        var actualAlt = StringEndsWithComparison.IsFirstStringContainsSecondStringAtTheEndAlt(first, second);
        var actualThird = StringEndsWithComparison.IsFirstStringContainsSecondStringAtTheEndThird(first, second);

        // Assert
        actual.Should().Be(expected);
        actualAlt.Should().Be(expected);
        actualThird.Should().Be(expected);
    }
}