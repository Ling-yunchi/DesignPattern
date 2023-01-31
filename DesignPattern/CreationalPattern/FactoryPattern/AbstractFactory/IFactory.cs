namespace DesignPattern.CreationalPattern.FactoryPattern.AbstractFactory;

public interface IFactory
{
    enum FactoryType {
        Factory1,
        Factory2
    }
    static IFactory GetFactory(FactoryType type) {
        return type switch {
            FactoryType.Factory1 => new Factory1(),
            FactoryType.Factory2 => new Factory2(),
            // impossible
            _ => throw new ArgumentException("Invalid factory type")
        };
    }
    IProductA CreateA();
    IProductB CreateB();
}