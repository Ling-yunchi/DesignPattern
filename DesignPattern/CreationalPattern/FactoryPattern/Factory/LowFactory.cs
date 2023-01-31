namespace DesignPattern.CreationalPattern.FactoryPattern.Factory;

public class LowFactory : IFactory
{
    public IProduct Create() {
        return new LowProduct();
    }
}