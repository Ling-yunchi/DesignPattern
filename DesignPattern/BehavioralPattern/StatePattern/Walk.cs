namespace DesignPattern.BehavioralPattern.StatePattern;

public class Walk : IState
{
    public void Operation(Context context) {
        context.Player.Speed = 1.0f;
    }
}