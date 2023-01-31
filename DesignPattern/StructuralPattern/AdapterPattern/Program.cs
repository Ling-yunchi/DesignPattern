using NUnit.Framework;

namespace DesignPattern.StructuralPattern.AdapterPattern;

public static class Program
{
    [Test]
    public static void Test() {
        ITarget classAdapter = new ClassAdapter("ClassAdapter");
        classAdapter.Request();
        ITarget objectAdapter = new ObjectAdapter("ObjectAdapter");
        objectAdapter.Request();
    }
}