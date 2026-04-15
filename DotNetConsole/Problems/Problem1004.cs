//Beecrowd Problem 1004 - Simple Product
//https://www.beecrowd.com.br/judge/pt/problems/view/1004

using DotNetConsole.Beecrowd.Domain.IO;
using DotNetConsole.Beecrowd.Domain.Problems;
using DotNetConsole.Beecrowd.Domain.Services;

namespace DotNetConsole.Problems
{
    
    public class Problem1004 : IProblem
    {
        private readonly IProductCalculator _calculator;

        public Problem1004(IProductCalculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute(IInput input, IOutput output)
        {
            int valueA = int.Parse(input.Read());
            int valueB = int.Parse(input.Read());

            int result = _calculator.Multiply(valueA, valueB);

            output.Write($"PROD = {result}");
        }
    }
}
