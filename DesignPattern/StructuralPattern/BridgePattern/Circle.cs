namespace DesignPattern.StructuralPattern.BridgePattern;

public class Circle : Shape
{
    public float Radius { get; }

    public Circle(Renderer renderer, float radius) : base(renderer) {
        Radius = radius;
    }

    public override void Draw() {
        renderer.RenderCircle(Radius);
    }
}