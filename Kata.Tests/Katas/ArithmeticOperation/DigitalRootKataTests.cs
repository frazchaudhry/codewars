using FluentAssertions;
using Kata.Katas.ArithmeticOperations;
using Xunit;

namespace Kata.Katas.ArithmeticOperation;

public class DigitalRootKataTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(10, 1)]
    [InlineData(16, 7)]
    [InlineData(195, 6)]
    [InlineData(992, 2)]
    [InlineData(167346, 9)]
    [InlineData(999999999999, 9)]
    public void DigitalRoot_ShouldReturnProperResult(long n, int expectedResult)
    {
        // Arrange

        // Act
        var actual = DigitalRootKata.DigitalRoot(n);
        var actualAlt = DigitalRootKata.DigitalRootAlt(n);
        var actualCongruenceFormula = DigitalRootKata.DigitalRootCongruenceFormula(n);
        var actualEfficient = DigitalRootKata.DigitalRootEfficient(n);

        // Assert
        actual.Should().Be(expectedResult);
        actualAlt.Should().Be(expectedResult);
        actualCongruenceFormula.Should().Be(expectedResult);
        actualEfficient.Should().Be(expectedResult);
    }
}