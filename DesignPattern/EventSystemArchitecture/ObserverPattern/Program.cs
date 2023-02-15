namespace DesignPattern.EventSystemArchitecture.ObserverPattern;

public static class Program
{
    public static void Test()
    {
        TrafficLight trafficLight = new();
        Person person1 = new("Person1", trafficLight);
        trafficLight.Change();
        Person person2 = new("Person2", trafficLight);
        trafficLight.Change();
        Person person3 = new("Person3", trafficLight);
        trafficLight.Change();
        Person person4 = new("Person4", trafficLight);
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
    }
}