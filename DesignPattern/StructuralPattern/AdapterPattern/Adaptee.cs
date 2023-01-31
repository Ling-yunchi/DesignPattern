namespace DesignPattern.StructuralPattern.AdapterPattern;

public class Adaptee
{
    public Adaptee(string info) {
        Info = info;
    }

    public string Info { get; }

    public void SpecificRequest() {
        Console.WriteLine($"Called SpecificRequest() with info: {Info}");
    }
}