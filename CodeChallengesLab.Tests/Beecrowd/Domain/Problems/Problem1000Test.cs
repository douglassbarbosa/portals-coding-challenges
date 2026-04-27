using CodeChallengesLab.Beecrowd.Domain.Problems;
using CodeChallengesLab.Tests.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Tests.Beecrowd.Domain.Problems;

public class Problem1000Test
{
    [Fact]
    public void Execute_ShouldWriteHelloWorld()
    {
        // Arrange
        var input = new FakeInput();
        var output = new FakeOutput();
        var problem = new Problem1000();

        // Act
        problem.Execute(input, output);

        // Assert
        Assert.Equal("Hello World!", output.GetOutputs().First());
    }
}