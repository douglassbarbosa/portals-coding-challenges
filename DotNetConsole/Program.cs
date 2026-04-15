using DotNetConsole.Beecrowd.Application;
using DotNetConsole.Beecrowd.Domain.IO;
using DotNetConsole.Beecrowd.Domain.Problems;
using DotNetConsole.Beecrowd.Domain.Services;
using DotNetConsole.Beecrowd.Infrastructure;
using DotNetConsole.Problems;

namespace DotNetConsole
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
                { 1004, new Problem1004(productCalculator) }
            };

            var runner = new ProblemRunner(problems);

            int selectedProblem = 1000; // You can change this to select a different problem
            runner.Run(selectedProblem, input, output);
        }
    }
}