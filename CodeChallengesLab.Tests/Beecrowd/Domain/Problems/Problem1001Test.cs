using CodeChallengesLab.Beecrowd.Domain.Problems;
using CodeChallengesLab.Tests.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Tests.Beecrowd.Domain.Problems;

public class Problem1001Test
{
    [Fact]
    public void Execute_WhenInputIs10And9_ShouldWriteX19()
    {
        // Arrange
        var input = new FakeInput("10", "9");
        var output = new FakeOutput();
        var problem = new Problem1001();

        // Act
        problem.Execute(input, output);

        // Assert
        Assert.Equal("X = 19", output.GetOutputs().First());
    }
}