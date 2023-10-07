using FluentAssertions;
using Kata.Katas.ArithmeticOperations;
using Xunit;

namespace Kata.Katas.ArithmeticOperation;

public class MatrixAdditionKataTests
{
    [Fact]
    public void MatrixAddition_ShouldAddTheMatricesProperly()
    {
        // Arrange
        var a = new[]
        {
            new[] { 1, 2 },
            new[] { 1, 2 }
        };

        var b = new[]
        {
            new[] { 2, 3 },
            new[] { 2, 3 }
        };

        var expected = new[]
        {
            new[] { 3, 5 },
            new[] { 3, 5 }
        };

        // Act
        var actual = MatrixAdditionKata.MatrixAddition(a, b);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.ComparingByValue<int>()
            .Using<int>(ctx => ctx.Subject.Should().Be(ctx.Expectation)).WhenTypeIs<int>());
    }
}