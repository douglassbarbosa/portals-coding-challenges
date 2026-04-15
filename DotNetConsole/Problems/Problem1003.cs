//Beecrowd Poblem 1003 - Simple Sum

using DotNetConsole.Beecrowd.Domain.IO;
using DotNetConsole.Beecrowd.Domain.Problems;

namespace DotNetConsole.Problems
{
    public class Problem1003 : IProblem
    {
        public void Execute(IInput input, IOutput output)
        {
            int valueA = int.Parse(input.Read());
            int valueB = int.Parse(input.Read());
            output.Write($"SOMA = {valueA + valueB}");
        }
    }
} 