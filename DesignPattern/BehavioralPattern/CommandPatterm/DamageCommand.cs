namespace DesignPattern.BehavioralPattern.CommandPatterm;

public class DamageCommand : ICommand
{
    private readonly Player _player;
    private readonly int _damage;

    public DamageCommand(Player player, int damage) {
        _player = player;
        _damage = damage;
    }

    public void Execute() {
        Console.WriteLine($"player take {_damage} damage");
        _player.TakeDamage(_damage);
        Console.WriteLine($"player {_player}");
    }

    public void Undo() {
        Console.WriteLine($"player undo damage {_damage} hp");
        _player.TakeDamage(-_damage);
        Console.WriteLine($"player {_player}");
    }
}