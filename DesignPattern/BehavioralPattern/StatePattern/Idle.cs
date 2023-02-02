namespace DesignPattern.BehavioralPattern.StatePattern;

public class Idle:IState
{
    public void Operation(Context context) {
        context.Player.Speed = 0.0f;
    }
}