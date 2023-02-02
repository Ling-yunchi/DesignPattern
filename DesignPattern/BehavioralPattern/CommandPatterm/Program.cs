using NUnit.Framework;

namespace DesignPattern.BehavioralPattern.CommandPatterm;

public static class Program
{
    [Test]
    public static void Test() {
        var invoker = new Invoker();
        var player = new Player(10, 0, 0);

        invoker.ExecuteCommand(new MoveCommand(player, 1, 1));
        invoker.ExecuteCommand(new DamageCommand(player, 5));
        invoker.ExecuteCommand(new MoveCommand(player, 2, 2));
        invoker.UndoCommand();
        invoker.ExecuteCommand(new MoveCommand(player, -1, 3));
        invoker.ExecuteCommand(new DamageCommand(player, 3));
        invoker.UndoCommand();
        invoker.ExecuteCommand(new MoveCommand(player, 1, 1));
    }
}