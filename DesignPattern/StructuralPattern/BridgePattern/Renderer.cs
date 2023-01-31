namespace DesignPattern.StructuralPattern.BridgePattern;

public abstract class Renderer
{
    public abstract void RenderCircle(float radius);

    public abstract void RenderSquare(float side);
}