namespace DesignPattern.StructuralPattern.BridgePattern;

public class RasterRenderer: Renderer
{
    public override void RenderCircle(float radius) {
        Console.WriteLine($"Drawing pixels for a circle of radius {radius}");
    }

    public override void RenderSquare(float sideLength) {
        Console.WriteLine($"Drawing pixels for a square of side length {sideLength}");
    }
}