using CodeChallengesLab.Beecrowd.Domain.Problems;
using CodeChallengesLab.Tests.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Tests.Beecrowd.Domain.Problems;

public class Problem1003Test
{
    [Fact]
    public void Execute_WhenInputIs30And10_ShouldWriteSoma40()
    {
        // Arrange
        var input = new FakeInput("30", "10");
        var output = new FakeOutput();
        var problem = new Problem1003();

        // Act
        problem.Execute(input, output);

        // Assert
        Assert.Equal("SOMA = 40", output.GetOutputs().First());
    }
}