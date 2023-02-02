namespace DesignPattern.BehavioralPattern.CommandPatterm;

public class MoveCommand : ICommand
{
    private readonly Player _player;
    private readonly int _x;
    private readonly int _y;

    public MoveCommand(Player player, int x, int y) {
        _player = player;
        _x = x;
        _y = y;
    }

    public void Execute() {
        Console.WriteLine($"player move ({_x}, {_y})");
        _player.Move(_x, _y);
        Console.WriteLine($"player {_player}");
    }

    public void Undo() {
        Console.WriteLine($"player undo move ({-_x}, {-_y})");
        _player.Move(-_x, -_y);
        Console.WriteLine($"player {_player}");
    }
}