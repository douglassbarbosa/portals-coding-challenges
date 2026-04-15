using DotNetConsole.Beecrowd.Domain.IO;

namespace DotNetConsole.Beecrowd.Infrastructure
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string message) => Console.WriteLine(message);
    }
}
