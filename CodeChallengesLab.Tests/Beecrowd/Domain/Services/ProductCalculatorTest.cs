using CodeChallengesLab.Beecrowd.Domain.Services;

namespace CodeChallengesLab.Tests.Beecrowd.Domain.Services;

public class ProductCalculatorTest
{
    [Theory]
    [InlineData(3, 9, 27)]
    [InlineData(5, 5, 25)]
    [InlineData(0, 10, 0)]
    [InlineData(-2, 3, -6)]
    [InlineData(-2, -3, 6)]
    public void Multiply_WhenCalled_ShouldReturnProduct(int a, int b, int expected)
    {
        // Arrange
        var calculator = new ProductCalculator();

        // Act
        var result = calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}