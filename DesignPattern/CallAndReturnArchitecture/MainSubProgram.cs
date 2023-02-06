using NUnit.Framework;

namespace DesignPattern.CallAndReturnArchitecture;

public static class MainSubProgram
{
    public static int Data = 0;
    [Test]
    public static void Test() {
        Console.WriteLine("Global Data: " + Data);
        MainProgram();
        Console.WriteLine("Global Data: " + Data);
        Assert.AreEqual(4, Data);
    }

    private static void MainProgram() {
        Data = 1;
        SubProgram1();
        Data += SubProgram2();
    }

    private static void SubProgram1() {
        Data += 1;
    }

    private static int SubProgram2() {
        return 2;
    }
}