using DotNetConsole.Beecrowd.Domain.IO;

namespace DotNetConsole.Beecrowd.Domain.Problems
{
    public interface IProblem
    {
        void Execute(IInput input, IOutput output);
    }
}
