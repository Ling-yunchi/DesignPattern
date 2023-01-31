namespace DesignPattern.CreationalPattern.FactoryPattern.Factory;

public class HighFactory : IFactory
{
    public IProduct Create() {
        return new HighProduct();
    }
}