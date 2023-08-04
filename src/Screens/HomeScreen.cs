namespace Paraclete.Screens;

using Paraclete.Ansi;
using Paraclete.Layouts;
using Paraclete.Menu;
using Paraclete.Menu.General;
using Paraclete.Painting;

public class HomeScreen : IScreen
{
    private const int _1stColumnWidth = 59;

    private readonly Stopwatch _stopWatch;
    private readonly ScreenInvalidator _screenInvalidator;
    private readonly ToDoListPainter _toDoListPainter;

    private readonly TimeWriter _currentTimeWriter;
    private readonly TimeWriter _stopWatchWriter;
    private readonly TimeWriter _markTimeWriter;

    private (int x, int y) _currentTimePosition;
    private (int x, int y) _stopWatchPosition;
    private (int x, int y) _markTimesPosition;

    public HomeScreen(Stopwatch stopWatch, MainMenu mainMenu, ScreenInvalidator screenInvalidator, ToDoListPainter toDoListPainter)
    {
        Menu = mainMenu;

        _stopWatch = stopWatch;
        _screenInvalidator = screenInvalidator;
        _toDoListPainter = toDoListPainter;

        _currentTimePosition = (x: 5, y: 1);
        _stopWatchPosition   = (x: 2, y: 1);
        _markTimesPosition   = (x: 2, y: 7);

        var currentTimeSettings = new TimeWriterSettings() with {
            FontSize = Font.Size.L,
            SecondsFontSize = Font.Size.M,
            Color = AnsiSequences.ForegroundColors.White,
            SecondsColor = AnsiSequences.ForegroundColors.Gray,
            ShowHours = true,
            ShowSeconds = true,
            ShowMilliseconds = false
        };

        var stopWatchSettings = new TimeWriterSettings() with {
            FontSize = Font.Size.M,
            MillisecondsFontSize = Font.Size.S,
            ShowHours = true,
            ShowSeconds = true,
            ShowMilliseconds = true,
            Color = AnsiSequences.ForegroundColors.Magenta,
            SecondsColor = AnsiSequences.ForegroundColors.Magenta,
            MillisecondsColor = AnsiSequences.ForegroundColors.DarkMagenta
        };

        var markTimeSettings = new TimeWriterSettings() with {
            FontSize = Font.Size.XS,
            ShowHours = true,
            ShowSeconds = true,
            ShowMilliseconds = true,
            Color = AnsiSequences.ForegroundColors.Magenta,
            SecondsColor = AnsiSequences.ForegroundColors.Magenta,
            MillisecondsColor = AnsiSequences.ForegroundColors.DarkMagenta
        };

        _currentTimeWriter = new TimeWriter(currentTimeSettings);
        _stopWatchWriter = new TimeWriter(stopWatchSettings);
        _markTimeWriter = new TimeWriter(markTimeSettings);
    }

    public string Name => "Home";
    public ConsoleKey Shortcut => ConsoleKey.F1;
    public bool ShowCurrentTime => false;
    public int[] AutoRefreshingPaneIndices => new[] { 0, 1 };

    public MenuBase Menu { get; }

    public ILayout Layout { get; } = new ColumnBasedLayout(new ColumnBasedLayout.ColumnDefinition[]
    {
        new (width: _1stColumnWidth, 9),
    });

    public Action GetPaintPaneAction(Painter painter, int paneIndex) =>
        paneIndex switch
        {
            0 => () =>
            {
                // Current time
                var now = DateTime.Now;
                _currentTimeWriter.Write(now, _currentTimePosition, painter, Layout.Panes[0]);
            },

            1 => () =>
            {
                // Stopwatch
                if (_stopWatch.Start != default)
                {
                    var stopWatchTime = (_stopWatch.IsRunning ? DateTime.Now : _stopWatch.Stop)
                        - _stopWatch.Start;
                    _stopWatchWriter.Write(stopWatchTime, _stopWatchPosition, painter, Layout.Panes[1]);
                }

                // Marked time
                var mx = _markTimesPosition.x;
                var my = _markTimesPosition.y;
                foreach (var mark in _stopWatch.MarkedTimes)
                {
                    _markTimeWriter.Write(mark, (mx, my++), painter, Layout.Panes[1]);
                }
            },

            2 => () =>
            {
                // ToDos
                _toDoListPainter.Paint(Layout.Panes[2], (1, 1));
            },

            _ => () => { }
        };
}
