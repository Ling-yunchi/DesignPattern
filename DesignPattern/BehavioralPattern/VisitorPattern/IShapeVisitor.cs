namespace DesignPattern.BehavioralPattern.VisitorPattern;

public interface IShapeVisitor
{
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
}