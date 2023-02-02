namespace DesignPattern.BehavioralPattern.IteratorPattern;

public interface IIterator<out T>
{
    T Current { get; }
    bool MoveNext();
    void Reset();
}
