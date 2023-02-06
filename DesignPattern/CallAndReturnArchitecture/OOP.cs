using NUnit.Framework;

namespace DesignPattern.CallAndReturnArchitecture;

public class OOP
{
    public class Program
    {
        public int Data { get; private set; }

        public Program() {
            Data = 0;
        }

        public void MainProgram() {
            Data = 1;
            SubProgram1();
            Data += SubProgram2();
        }

        private void SubProgram1() {
            Data += 1;
        }

        private int SubProgram2() {
            return 2;
        }
    }
    
    [Test]
    public static void Test() {
        var program = new Program();
        Console.WriteLine("Data: " + program.Data);
        program.MainProgram();
        Console.WriteLine("Data: " + program.Data);
        Assert.AreEqual(4, program.Data);
    }
}