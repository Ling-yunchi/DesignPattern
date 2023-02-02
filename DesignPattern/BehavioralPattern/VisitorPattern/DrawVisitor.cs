namespace DesignPattern.BehavioralPattern.VisitorPattern;

public class DrawVisitor : IShapeVisitor
{
    public void Visit(Circle circle) {
        Console.WriteLine($"Draw a circle with radius {circle.Radius}");
    }

    public void Visit(Rectangle rectangle) {
        Console.WriteLine($"Draw a rectangle with width {rectangle.Width} and height {rectangle.Height}");
    }
}