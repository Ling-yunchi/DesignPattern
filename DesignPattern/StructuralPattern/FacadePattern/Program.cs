using NUnit.Framework;

namespace DesignPattern.StructuralPattern.FacadePattern;

public static class Program
{
    [Test]
    public static void Test()
    {
        var facade = new Facade();
        var res = facade.Operation();
        Console.WriteLine(res);
    }
}