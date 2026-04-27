using CodeChallengesLab.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Beecrowd.Infrastructure
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string message) => Console.WriteLine(message);
    }
}
