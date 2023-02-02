using NUnit.Framework;

namespace DesignPattern.BehavioralPattern.MediatorPattern;

public static class Program
{
    [Test]
    public static void Test() {
        var room = new ChatRoom();
        var john = new User("John");
        var jane = new User("Jane");
        var joe = new User("Joe");
        room.Register(john);
        room.Register(jane);
        room.Register(joe);
        
        john.Send("Hi! I'm John");
        jane.Send("Hey! I'm Jane");
        joe.Send("Hello! I'm Joe");
    }
}