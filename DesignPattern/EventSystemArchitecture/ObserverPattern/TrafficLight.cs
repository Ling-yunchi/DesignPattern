namespace DesignPattern.EventSystemArchitecture.ObserverPattern;

public class TrafficLight : IObservable<TrafficLight>
{
    public enum LightState { Red, Green, Yellow }
    private LightState _lightState = LightState.Red;
    public LightState State => _lightState;
    public void Change() {
        _lightState = _lightState switch {
            LightState.Red => LightState.Green,
            LightState.Green => LightState.Yellow,
            LightState.Yellow => LightState.Red,
            _ => _lightState
        };
        foreach (var observer in _observers) {
            observer.OnNext(this);
        }
    }
    HashSet<IObserver<TrafficLight>> _observers = new();
    public IDisposable Subscribe(IObserver<TrafficLight> observer) {
        _observers.Add(observer);
        Console.WriteLine($"Traffic light: {((Person)observer).Name} subscribed");
        return new Unsubscriber(_observers, observer);
    }
    
    public class Unsubscriber : IDisposable
    {
        private HashSet<IObserver<TrafficLight>> _observers;
        private IObserver<TrafficLight> _observer;

        public Unsubscriber(HashSet<IObserver<TrafficLight>> observers, IObserver<TrafficLight> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}