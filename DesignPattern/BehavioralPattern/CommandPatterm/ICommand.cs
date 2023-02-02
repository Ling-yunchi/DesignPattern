namespace DesignPattern.BehavioralPattern.CommandPatterm;

public interface ICommand
{
    void Execute();
    void Undo();
}