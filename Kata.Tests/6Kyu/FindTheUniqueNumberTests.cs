using FluentAssertions;
using Xunit;

namespace Kata._6Kyu;

public class FindTheUniqueNumberTests
{
   [Theory]
   [InlineData(new [] {1, 2, 2, 2}, 1)]
   [InlineData(new [] {-2, 2, 2, 2}, -2)]
   [InlineData(new [] {11, 11, 14, 11, 11}, 14)]
   public void GetUnique_WhenPassedInAnArrayOfIntegers_ShouldReturnTheUniqueInteger(int[] numbers, int expected)
   {
      // Arrange

      // Act
      var actual = FindTheUniqueNumber.GetUnique(numbers);

      // Assert
      actual.Should().Be(expected);
   }
}