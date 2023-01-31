namespace DesignPattern.StructuralPattern.AdapterPattern;

public class ClassAdapter : Adaptee, ITarget
{
    public ClassAdapter(string info) : base(info) { }

    public void Request() {
        Console.WriteLine("Do something before calling SpecificRequest()");
        SpecificRequest();
        Console.WriteLine("Do something after calling SpecificRequest()");
    }
}