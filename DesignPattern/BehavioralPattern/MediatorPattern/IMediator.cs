namespace DesignPattern.BehavioralPattern.MediatorPattern;

public interface IMediator
{
    void Register(IColleague colleague);
    void Notify(object sender, string ev);
}