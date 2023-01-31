using NUnit.Framework;

namespace DesignPattern.CreationalPattern.FactoryPattern.SimpleFactory;

public static class Program
{
    [Test]
    public static void Test() {
        var product1 = SimpleFactor.Create(SimpleFactor.ProductType.High);
        Console.WriteLine($"Product1 is a {product1.Name()}");
        var product2 = SimpleFactor.Create(SimpleFactor.ProductType.Low);
        Console.WriteLine($"Product2 is a {product2.Name()}");
    }
}