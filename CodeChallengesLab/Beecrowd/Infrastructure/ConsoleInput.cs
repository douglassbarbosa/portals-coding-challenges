using CodeChallengesLab.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Beecrowd.Infrastructure
{
    public class ConsoleInput : IInput
    {
        public string Read() => Console.ReadLine() ?? string.Empty;
    }
}