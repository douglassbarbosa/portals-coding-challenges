//Beecrowd Problem 1001 - Extremamente Básico
//https://www.beecrowd.com.br/judge/pt/problems/view/1001
using DotNetConsole.Beecrowd.Domain.IO;
using DotNetConsole.Beecrowd.Domain.Problems;

namespace DotNetConsole.Problems
{
    public class Problem1001 : IProblem
    {
        public void Execute(IInput input, IOutput output)
        {
            int valueA = int.Parse(input.Read());
            int valueB = int.Parse(input.Read());
            output.Write($"X = {valueA + valueB}");
        }
    }
}