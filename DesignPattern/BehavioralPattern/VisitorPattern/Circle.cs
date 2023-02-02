namespace DesignPattern.BehavioralPattern.VisitorPattern;

public class Circle : IShape
{
    public float Radius { get; set; }

    public void Accept(IShapeVisitor visitor) {
        visitor.Visit(this);
    }
}