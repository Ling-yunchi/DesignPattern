using NUnit.Framework;

namespace DesignPattern.BehavioralPattern.StrategyPattern;

public static class Program
{
    [Test]
    public static void Test() {
        var context = new Context(new AddOperation()) {
            Env = "User1"
        };
        context.Operation();
        context.Strategy = new SubtractOperation();
        context.Env = "User2";
        context.Operation();
    }
}