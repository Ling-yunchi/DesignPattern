namespace DesignPattern.StructuralPattern.BridgePattern;

public class Square : Shape
{
    public float SideLength { get; }

    public Square(Renderer renderer, float sideLength) : base(renderer) {
        SideLength = sideLength;
    }

    public override void Draw() {
        renderer.RenderSquare(SideLength);
    }
}