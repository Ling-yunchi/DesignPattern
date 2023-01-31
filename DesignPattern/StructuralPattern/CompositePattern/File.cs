namespace DesignPattern.StructuralPattern.CompositePattern;

public class File : Component
{
    public override void Add(Component component) {
        throw new Exception("Cannot add to a file");
    }

    public override void Remove(Component component) {
        throw new Exception("Cannot remove from a file");
    }

    public override void Display(int depth) {
        Console.WriteLine(new string('-', depth) + Name);
    }
}