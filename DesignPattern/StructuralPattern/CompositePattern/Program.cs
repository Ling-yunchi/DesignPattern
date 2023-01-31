using NUnit.Framework;

namespace DesignPattern.StructuralPattern.CompositePattern;

public static class Program
{
    [Test]
    public static void Test() {
        var root = new Directory { Name = "root" };
        var bin = new Directory { Name = "bin" };
        var tmp = new Directory { Name = "tmp" };
        var usr = new Directory { Name = "usr" };
        root.Add(bin);
        root.Add(tmp);
        root.Add(usr);
        bin.Add(new File { Name = "vi" });
        bin.Add(new File { Name = "latex" });
        root.Display(1);
    }
}