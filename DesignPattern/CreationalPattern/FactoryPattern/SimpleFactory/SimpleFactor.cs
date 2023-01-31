namespace DesignPattern.CreationalPattern.FactoryPattern.SimpleFactory;

public static class SimpleFactor
{
    public enum ProductType
    {
        High,
        Low
    }

    public static IProduct Create(ProductType type) {
        return type switch {
            ProductType.High => new HighProduct(),
            ProductType.Low => new LowProduct(),
            // impossible to reach
            _ => throw new ArgumentException("Invalid ProductType", nameof(type))
        };
    }
}