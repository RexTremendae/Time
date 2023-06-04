namespace Paraclete.Menu.Stopwatch;

public class MarkTimeCommand : ICommand
{
    private readonly Paraclete.Stopwatch _stopwatch;

    public MarkTimeCommand(Paraclete.Stopwatch stopwatch)
    {
        _stopwatch = stopwatch;
    }

    public ConsoleKey Shortcut => ConsoleKey.M;
    public string Description => "[M]ark";
    public bool IsScreenSaverResistant => true;

    public Task Execute()
    {
        _stopwatch.Mark();

        return Task.CompletedTask;
    }
}
