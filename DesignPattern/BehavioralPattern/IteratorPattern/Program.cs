using NUnit.Framework;

namespace DesignPattern.BehavioralPattern.IteratorPattern;

public static class Program
{
    [Test]
    public static void Test() {
        var tree = new BinarySearchTree<int>();
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);
        tree.Insert(1);
        tree.Insert(4);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(2);
        tree.Insert(9);
        tree.Insert(10);
        var itor = tree.CreateIterator();
        while (itor.MoveNext()) {
            Console.WriteLine(itor.Current);
        }
    }
}