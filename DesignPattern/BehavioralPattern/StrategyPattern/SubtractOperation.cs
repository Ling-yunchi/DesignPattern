namespace DesignPattern.BehavioralPattern.StrategyPattern;

public class SubtractOperation:IStrategy
{
    public void Operation(Context context) {
        Console.WriteLine($"{context.Env} do Subtract Operation");
    }
}