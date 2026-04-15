//Beecrowd Problem 1002 - Área do Círculo
//https://www.beecrowd.com.br/judge/pt/problems/view/1002
//The formula to calculate the area of a circumference is defined as A = π x R^2. 
//Considering to this problem that π = 3.14159:

using DotNetConsole.Beecrowd.Domain.IO;
using DotNetConsole.Beecrowd.Domain.Problems;

namespace DotNetConsole.Problems
{    public class Problem1002 : IProblem
    {
        public void Execute(IInput input, IOutput output)
        {
            double pi = 3.14159;
            double radius = double.Parse(input.Read());
            double area = pi * Math.Pow(radius, 2);
            output.Write($"A={area:F4}");
        }
    }
} 