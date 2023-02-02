namespace DesignPattern.BehavioralPattern.VisitorPattern;

public class AreaVisitor : IShapeVisitor
{
    public float Area { get; private set; }

    public void Visit(Circle circle) {
        Area = circle.Radius * circle.Radius * 3.14f;
    }

    public void Visit(Rectangle rectangle) {
        Area = rectangle.Width * rectangle.Height;
    }
}