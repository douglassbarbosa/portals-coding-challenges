using CodeChallengesLab.Beecrowd.Application;
using CodeChallengesLab.Beecrowd.Domain.Problems;
using CodeChallengesLab.Tests.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Tests.Beecrowd.Application;

public class ProblemRunnerTest
{
    [Fact]
    public void Run_WhenProblemExists_ShouldExecuteProblem()
    {
        // Arrange
        var input = new FakeInput();
        var output = new FakeOutput();

        var problems = new Dictionary<int, IProblem>
        {
            { 1000, new Problem1000() }
        };

        var runner = new ProblemRunner(problems);

        // Act
        runner.Run(1000, input, output);

        // Assert
        Assert.Equal("Hello World!", output.GetOutputs().First());
    }

    [Fact]
    public void Run_WhenProblemDoesNotExist_ShouldWriteProblemNotFound()
    {
        // Arrange
        var input = new FakeInput();
        var output = new FakeOutput();

        var problems = new Dictionary<int, IProblem>();
        var runner = new ProblemRunner(problems);

        // Act
        runner.Run(9999, input, output);

        // Assert
        Assert.Equal("Problem 9999 not found.", output.GetOutputs().First());
    }
}