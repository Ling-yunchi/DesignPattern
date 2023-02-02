namespace DesignPattern.BehavioralPattern.MediatorPattern;

public class User : IColleague
{
    private readonly string _name;

    public User(string name) {
        _name = name;
    }

    public IMediator Mediator { get; set; }

    public void HandleEvent(string ev) {
        Console.WriteLine($"{_name} received event: {ev}");
    }

    public void Send(string ev) {
        Mediator.Notify(this, ev);
    }
}