using FluentAssertions;
using Kata.Katas.StringOperations;
using Xunit;

namespace Kata.Katas.StringOperation
{
    public class BreakCamelCaseTests
    {
        [Theory]
        [InlineData("camelCasing", "camel Casing")]
        [InlineData("camelCasingTest", "camel Casing Test")]
        public void BreakCamelCase_ShouldReturnStringBrokenUpByCamelCase(string str, string expected)
        {
            // Arrange

            // Act
            var actual = BreakCamelCase.Break(str);

            // Assert
            actual.Should().Be(expected);
        }
        
        [Theory]
        [InlineData("camelCasing", "camel Casing")]
        [InlineData("camelCasingTest", "camel Casing Test")]
        public void BreakCamelCaseBetter_ShouldReturnStringBrokenUpByCamelCase(string str, string expected)
        {
            // Arrange

            // Act
            var actual = BreakCamelCase.BreakBetter(str);

            // Assert
            actual.Should().Be(expected);
        }
    }
}