using NUnit.Framework;

namespace DesignPattern.BehavioralPattern.StatePattern;

public static class Program
{
    [Test]
    public static void Test() {
        var player = new Player();
        var context = new Context(player);
        context.State = new Walk();
        context.State = new Idle();
    }
}