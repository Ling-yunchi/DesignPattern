namespace DesignPattern.CreationalPattern.SingletonPattern;

public class Singleton
{
    private static Singleton? _instance;
    private Singleton() { }

    public static Singleton Instance() {
        return _instance ??= new Singleton();
    }
}