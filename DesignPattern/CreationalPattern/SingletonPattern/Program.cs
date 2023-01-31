using NUnit.Framework;

namespace DesignPattern.CreationalPattern.SingletonPattern;

public class Program
{
    [Test]
    public static void Test()
    {
        var s1 = Singleton.Instance();
        var s2 = Singleton.Instance();
        Assert.AreSame(s1, s2);
    }
}