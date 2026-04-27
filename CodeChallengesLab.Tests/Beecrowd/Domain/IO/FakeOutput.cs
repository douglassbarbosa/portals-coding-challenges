using CodeChallengesLab.Beecrowd.Domain.IO;

namespace CodeChallengesLab.Tests.Beecrowd.Domain.IO;

public class FakeOutput : IOutput
{
    private readonly List<string> _outputs = new List<string>();

    public void Write(string output)
    {
        _outputs.Add(output);
    }

    public IReadOnlyList<string> GetOutputs() => _outputs.AsReadOnly();
}