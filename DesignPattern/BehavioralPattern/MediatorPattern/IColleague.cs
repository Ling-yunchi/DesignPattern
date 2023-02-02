namespace DesignPattern.BehavioralPattern.MediatorPattern;

public interface IColleague
{
    IMediator Mediator { get; set; }
    void HandleEvent(string ev);
}