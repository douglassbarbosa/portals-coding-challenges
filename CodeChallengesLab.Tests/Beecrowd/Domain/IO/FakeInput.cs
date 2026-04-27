using CodeChallengesLab.Beecrowd.Domain.IO;
namespace CodeChallengesLab.Tests.Beecrowd.Domain.IO;

public class FakeInput : IInput
{
    private readonly Queue<string> _inputs;

    public FakeInput(params string[] inputs)
    {
        _inputs = new Queue<string>(inputs);
    }

    public string Read()
    {
        if (_inputs.Count > 0)
        {
            return _inputs.Dequeue();
        }
        throw new InvalidOperationException("No more input available.");
    }
}