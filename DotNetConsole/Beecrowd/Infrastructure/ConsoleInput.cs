using DotNetConsole.Beecrowd.Domain.IO;

namespace DotNetConsole.Beecrowd.Infrastructure
{
    public class ConsoleInput : IInput
    {
        public string Read() => Console.ReadLine() ?? string.Empty;
    }
}