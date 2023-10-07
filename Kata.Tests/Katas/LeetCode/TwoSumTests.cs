using FluentAssertions;
using Xunit;

namespace Kata.Katas.LeetCode;

public class TwoSumTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 4, new[] { 0, 2 })]
    [InlineData(new[] { 1234, 5678, 9012 }, 14690, new[] { 1, 2 })]
    [InlineData(new[] { 2, 2, 3 }, 4, new[] { 0, 1 })]
    public void TwoSum_ShouldReturnProperResult(int[] number, int target, int[] expected)
    {
        // Arrange

        // Act
        var actual = TwoSumKata.TwoSum(number, target);
        var actualBruteForce = TwoSumKata.TwoSumBruteForce(number, target);

        // Assert
        actualBruteForce.Should().NotBeNull();
        actualBruteForce.Should().NotContainNulls();
        actualBruteForce.Should().HaveCount(2);
        actualBruteForce.Should().BeEquivalentTo(expected);
        
        actual.Should().NotBeNull();
        actual.Should().NotContainNulls();
        actual.Should().HaveCount(2);
        actual.Should().BeEquivalentTo(expected);
    }
}