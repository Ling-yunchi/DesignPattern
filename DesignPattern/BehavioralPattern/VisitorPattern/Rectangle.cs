namespace DesignPattern.BehavioralPattern.VisitorPattern;

public class Rectangle : IShape
{
    public float Width { get; set; }
    public float Height { get; set; }

    public void Accept(IShapeVisitor visitor) {
        visitor.Visit(this);
    }
}