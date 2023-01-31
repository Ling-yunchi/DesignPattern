using NUnit.Framework;

namespace DesignPattern.StructuralPattern.BridgePattern;

public static class Programs
{
    [Test]
    public static void Test()
    {
        var vectorRenderer = new VectorRenderer();
        var rasterRenderer = new RasterRenderer();
        var shapes = new List<Shape>
        {
            new Circle(vectorRenderer, 5),
            new Circle(rasterRenderer, 5),
            new Square(vectorRenderer, 5),
            new Square(rasterRenderer, 5)
        };
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}