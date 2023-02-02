using NUnit.Framework;

namespace DesignPattern.BehavioralPattern.VisitorPattern;

public static class Program
{
    [Test]
    public static void Test() {
        var circle = new Circle { Radius = 2 };
        var rectangle = new Rectangle { Width = 2, Height = 3 };
        var drawVisitor = new DrawVisitor();
        var areaVisitor = new AreaVisitor();
        circle.Accept(drawVisitor);
        circle.Accept(areaVisitor);
        Console.WriteLine($"Area of circle is {areaVisitor.Area}");
        rectangle.Accept(drawVisitor);
        rectangle.Accept(areaVisitor);
        Console.WriteLine($"Area of rectangle is {areaVisitor.Area}");
    }
}