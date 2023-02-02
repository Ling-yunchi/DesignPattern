namespace DesignPattern.BehavioralPattern.IteratorPattern;

public interface IAggregate<out T>
{
    IIterator<T> CreateIterator();
}

