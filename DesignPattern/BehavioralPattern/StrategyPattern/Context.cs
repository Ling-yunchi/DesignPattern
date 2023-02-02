namespace DesignPattern.BehavioralPattern.StrategyPattern;

public class Context
{
    public IStrategy Strategy { get; set; }
    public string Env { get; set; }

    public Context(IStrategy strategy) {
        Strategy = strategy;
    }

    public void Operation() {
        Strategy.Operation(this);
    }
    
}