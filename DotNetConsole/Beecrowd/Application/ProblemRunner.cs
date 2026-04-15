using DotNetConsole.Beecrowd.Domain.IO;
using DotNetConsole.Problems;
using DotNetConsole.Beecrowd.Domain.Problems;

namespace DotNetConsole.Beecrowd.Application
{
    public class ProblemRunner
    {
        private readonly Dictionary<int, IProblem> _problems;

        public ProblemRunner(Dictionary<int, IProblem> problems)
        {
            _problems = problems;
        }

        public void Run(int problemId, IInput input, IOutput output)
        {
            if (_problems.TryGetValue(problemId, out var problem))
            {
                problem.Execute(input, output);
                return;
            }

            output.Write($"Problem {problemId} not found.");
        }
    }
}