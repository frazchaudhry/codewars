using FluentAssertions;
using Xunit;

namespace Kata._6Kyu;

public class Worda10NAbbreviationTests
{
    [Theory]
    [InlineData("internationalization", "i18n")]
    [InlineData("my. dog, isn't feeling very well.", "my. dog, isn't f5g v2y w2l.")]
    public void Abbreviate(string input, string expected)
    {
        // Arrange

        // Act
        var actual = Worda10NAbbreviation.Abbreviate(input);
        var actualAlt = Worda10NAbbreviation.AbbreviateAlt(input);
        var actualAlt2 = Worda10NAbbreviation.AbbreviateAlt2(input);

        // Assert
        actual.Should().Be(expected);
        actualAlt.Should().Be(expected);
        actualAlt2.Should().Be(expected);
    }
}