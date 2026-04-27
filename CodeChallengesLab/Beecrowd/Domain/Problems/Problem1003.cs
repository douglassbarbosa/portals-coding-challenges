//Beecrowd Poblem 1003 - Simple Sum

using CodeChallengesLab.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Beecrowd.Domain.Problems
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