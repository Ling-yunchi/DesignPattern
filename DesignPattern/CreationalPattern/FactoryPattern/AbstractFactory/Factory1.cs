namespace DesignPattern.CreationalPattern.FactoryPattern.AbstractFactory;

public class Factory1 : IFactory
{
    public IProductA CreateA() {
        return new ProductA1();
    }

    public IProductB CreateB() {
        return new ProductB1();
    }
}