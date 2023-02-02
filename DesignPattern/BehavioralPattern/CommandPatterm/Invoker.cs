namespace DesignPattern.BehavioralPattern.CommandPatterm;

public class Invoker
{
    private readonly Stack<ICommand> _commands = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command) {
        command.Execute();
        _commands.Push(command);
    }

    public void UndoCommand() {
        if (_commands.Count > 0) {
            var command = _commands.Pop();
            command.Undo();
        }
    }
}