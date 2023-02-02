namespace DesignPattern.BehavioralPattern.StrategyPattern;

public class AddOperation:IStrategy
{
    public void Operation(Context context) {
        Console.WriteLine($"{context.Env} do Add Operation");
    }
}