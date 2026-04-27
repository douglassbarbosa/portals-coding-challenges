//Beecrowd Problem1000 - Hello World!
//https://www.beecrowd.com.br/judge/en/problems/view/1000
using CodeChallengesLab.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Beecrowd.Domain.Problems
{
    public class Problem1000 : IProblem
    {
        public void Execute(IInput input, IOutput output)
        {
            //This is a simple problem that requires you to print "Hello World!" to the console.
            output.Write("Hello World!");
        }
    }
}

