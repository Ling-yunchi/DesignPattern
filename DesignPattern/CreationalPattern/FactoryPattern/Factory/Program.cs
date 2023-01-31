using NUnit.Framework;

namespace DesignPattern.CreationalPattern.FactoryPattern.Factory;

public static class Program
{
    [Test]
    public static void Test() {
        IFactory factory = new HighFactory();
        var product = factory.Create();
        Console.WriteLine($"HighFactory create a {product.Name()}");
        IFactory factory2 = new LowFactory();
        var product2 = factory2.Create();
        Console.WriteLine($"LowFactory create a {product2.Name()}");
    }
}