using CodeChallengesLab.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Beecrowd.Domain.Problems
{
    public interface IProblem
    {
        void Execute(IInput input, IOutput output);
    }
}
