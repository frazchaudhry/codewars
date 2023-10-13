using FluentAssertions;
using Xunit;

namespace Kata._6Kyu;

public class ValidBraceTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("[(])", false)]
    public void ValidBraces_WhenPassedInWithAStringContainingBraces_ShouldReturnProperResult(string braces, bool expected)
    {
        // Arrange

        // Act
        var actual = ValidBrace.ValidBraces(braces);
        var actualAlt = ValidBrace.ValidBracesAlt(braces);

        // Assert
        actual.Should().Be(expected);
        actualAlt.Should().Be(expected);
    }
}