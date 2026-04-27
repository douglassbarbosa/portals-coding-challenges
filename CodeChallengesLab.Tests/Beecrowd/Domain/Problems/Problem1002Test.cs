using CodeChallengesLab.Beecrowd.Domain.Problems;
using CodeChallengesLab.Tests.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Tests.Beecrowd.Domain.Problems;

public class Problem1002Test
{
    [Theory]
    [InlineData("2.00", "A=12.5664")]
    [InlineData("100.64", "A=31819.3103")]
    [InlineData("150.00", "A=70685.7750")]
    public void Execute_WhenInputIsRadius_ShouldWriteCircleArea(string radius, string expected)
    {
        // Arrange
        var input = new FakeInput(radius);
        var output = new FakeOutput();
        var problem = new Problem1002();

        // Act
        problem.Execute(input, output);

        // Assert
        Assert.Equal(expected, output.GetOutputs().First());
    }
}