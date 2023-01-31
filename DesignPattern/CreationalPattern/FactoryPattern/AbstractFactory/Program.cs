using NUnit.Framework;

namespace DesignPattern.CreationalPattern.FactoryPattern.AbstractFactory;

public static class Program
{
    [Test]
    public static void Test() {
        IFactory factory = new Factory1();
        var product1 = factory.CreateA();
        var product2 = factory.CreateB();
        Console.WriteLine($"Factory1 create a {product1.Name()} and a {product2.Name()}");
        IFactory factory2 = new Factory2();
        var product3 = factory2.CreateA();
        var product4 = factory2.CreateB();
        Console.WriteLine($"Factory2 create a {product3.Name()} and a {product4.Name()}");
    }
}