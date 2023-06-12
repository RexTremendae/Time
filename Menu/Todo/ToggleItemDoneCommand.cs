namespace Paraclete.Menu.ToDo;

public class ToggleItemDoneCommand : ICommand
{
    public ConsoleKey Shortcut => ConsoleKey.D;

    public string Description => "Toggle [d]one status";

    private readonly ToDoList _toDoList;

    public ToggleItemDoneCommand(ToDoList toDoList)
    {
        _toDoList = toDoList;
    }

    public Task Execute()
    {
        _toDoList.ToggleSelectedDoneState();
        return Task.CompletedTask;
    }
}