//Test to Problem 1004 -
using CodeChallengesLab.Beecrowd.Domain.Problems;
using CodeChallengesLab.Tests.Beecrowd.Domain.IO;
using CodeChallengesLab.Beecrowd.Domain.Services;

namespace CodeChallengesLab.Tests.Beecrowd.Domain.Problems;


public class Problem1004Test
{
    [Fact]
    public void Execute_WhenInputIs3And9_ShouldWriteProd27()
    {
        // Arrange 
        var input = new FakeInput("3", "9");
        var output = new FakeOutput();
        var calculator = new ProductCalculator();
        var problem = new Problem1004(calculator);

        // Action
        problem.Execute(input, output);

        // Assert
        Assert.Equal("PROD = 27", output.GetOutputs().First());
    }
}