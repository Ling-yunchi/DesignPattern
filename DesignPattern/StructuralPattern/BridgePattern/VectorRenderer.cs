namespace DesignPattern.StructuralPattern.BridgePattern;

public class VectorRenderer: Renderer
{
    public override void RenderCircle(float radius) {
        Console.WriteLine($"Drawing a circle of radius {radius}");
    }

    public override void RenderSquare(float sideLength) {
        Console.WriteLine($"Drawing a square of side length {sideLength}");
    }
}