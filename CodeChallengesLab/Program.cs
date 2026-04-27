using CodeChallengesLab.Beecrowd.Application;
using CodeChallengesLab.Beecrowd.Domain.IO;
using CodeChallengesLab.Beecrowd.Domain.Problems;
using CodeChallengesLab.Beecrowd.Domain.Services;
using CodeChallengesLab.Beecrowd.Infrastructure;

namespace CodeChallengesLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IInput input = new ConsoleInput();
            IOutput output = new ConsoleOutput();

            IProductCalculator productCalculator = new ProductCalculator();

            var problems = new Dictionary<int, IProblem>
            {
                { 1000, new Problem1000() },
                { 1001, new Problem1001() },
                { 1002, new Problem1002() },
                { 1003, new Problem1003() },
                { 1004, new Problem1004(productCalculator) }
            };

            var runner = new ProblemRunner(problems);

            int selectedProblem = 1000; // You can change this to select a different problem
            runner.Run(selectedProblem, input, output);
        }
    }
}