namespace DesignPattern.BehavioralPattern.StatePattern;

public class Context
{
    private IState _state;

    public IState State {
        get => _state;
        set {
            _state = value;
            _state.Operation(this);
            Console.WriteLine($"state: {_state.GetType().Name}, player speed: {Player.Speed}");
        }
    }

    public Player Player { get; set; }

    public Context(Player player, IState? state = null) {
        Player = player;
        State = state ?? new Idle();
    }
}