namespace DesignPattern.StructuralPattern.CompositePattern;

public class Directory : Component
{
    private readonly List<Component> _children = new();

    public override void Add(Component component) {
        _children.Add(component);
    }

    public override void Remove(Component component) {
        _children.Remove(component);
    }

    public override void Display(int depth) {
        Console.WriteLine(new string('-', depth) + Name);
        foreach (var component in _children) component.Display(depth + 1);
    }
}