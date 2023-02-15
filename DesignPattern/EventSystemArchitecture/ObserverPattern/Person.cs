namespace DesignPattern.EventSystemArchitecture.ObserverPattern;

public class Person : IObserver<TrafficLight>
{
    public readonly string Name;
    IDisposable _unsubscriber;

    public Person(string name, IObservable<TrafficLight> trafficLight) {
        Name = name;
        _unsubscriber = trafficLight.Subscribe(this);
    }

    public void OnCompleted() {
        Console.WriteLine($"Person: {Name} Traffic light completed");
    }

    public void OnError(Exception error) {
        Console.WriteLine($"Person: {Name} Traffic light error");
    }

    public void OnNext(TrafficLight value) {
        if (value.State == TrafficLight.LightState.Green) {
            Console.WriteLine($"Person: {Name} Go");
            _unsubscriber.Dispose();
            Console.WriteLine($"Person: {Name} Unsubscribed");
        }
        else if (value.State == TrafficLight.LightState.Yellow) {
            Console.WriteLine($"Person: {Name} Wait");
        }
        else if (value.State == TrafficLight.LightState.Red) {
            Console.WriteLine($"Person: {Name} Stop");
        }
    }
}