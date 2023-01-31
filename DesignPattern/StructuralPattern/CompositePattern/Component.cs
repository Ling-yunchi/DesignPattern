namespace DesignPattern.StructuralPattern.CompositePattern;

public abstract class Component
{
    public string? Name { get; set; }
    public abstract void Add(Component component);
    public abstract void Remove(Component component);
    public abstract void Display(int depth);
}