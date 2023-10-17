using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Kata._6Kyu;

public class AlphabetPositionReplaceTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public AlphabetPositionReplaceTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void AlphabetPosition_ShouldReturnProperResult()
    {
        // Arrange
        const string text = "The sunset sets at twelve o' clock.";
        const string expectedResult = "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11";

        // Act
        var actual = AlphabetPositionReplace.AlphabetPosition(text);

        // Assert
        actual.Should().Be(expectedResult);
        _testOutputHelper.WriteLine($"Actual: {actual}");
        _testOutputHelper.WriteLine($"Expected: {expectedResult}");
    } 
}