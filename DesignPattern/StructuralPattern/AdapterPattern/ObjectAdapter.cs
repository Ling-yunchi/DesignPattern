namespace DesignPattern.StructuralPattern.AdapterPattern;

public class ObjectAdapter : ITarget
{
    private readonly Adaptee _adaptee;

    public ObjectAdapter(string info) {
        _adaptee = new Adaptee(info);
    }

    public void SpecificRequest() {
        _adaptee.SpecificRequest();
    }

    public void Request() {
        Console.WriteLine("Do something before calling SpecificRequest()");
        _adaptee.SpecificRequest();
        Console.WriteLine("Do something after calling SpecificRequest()");
    }
}