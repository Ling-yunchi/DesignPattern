namespace DesignPattern.BehavioralPattern.VisitorPattern;

public interface IShape
{
    void Accept(IShapeVisitor visitor);
}