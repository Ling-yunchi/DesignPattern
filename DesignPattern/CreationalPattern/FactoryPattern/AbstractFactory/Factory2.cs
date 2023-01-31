namespace DesignPattern.CreationalPattern.FactoryPattern.AbstractFactory;

public class Factory2 : IFactory
{
    public IProductA CreateA() {
        return new ProductA2();
    }

    public IProductB CreateB() {
        return new ProductB2();
    }
}