namespace DesignPattern.BehavioralPattern.MediatorPattern;

public class ChatRoom : IMediator
{
    private readonly List<IColleague> _users = new();
    
    public void Register(IColleague colleague) {
        _users.Add(colleague);
        colleague.Mediator = this;
    }

    public void Notify(object sender, string ev) {
        _users.ForEach(user => {
            if (user != sender) {
                user.HandleEvent(ev);
            }
        });
    }
}