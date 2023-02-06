using System.IO.Pipes;
using NUnit.Framework;

namespace DesignPattern.DataflowArchitecture.BatchSequentialDataflowSystem;

public static class Program
{
    private const string DATA =
        @"To see a world in a grain of sand,
And a heaven in a wild flower,
Hold infinity in the palm of your hand,
And eternity in an hour.";

    [Test]
    public static void Test() {
        var data = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(DATA));
        var stream1 = new MemoryStream();
        var stream2 = new MemoryStream();
        var process1 = new UppercaseProcess(data, stream1);
        var process2 = new SortProcess(stream1, stream2);
        process1.ProcessData();
        process2.ProcessData();
        var reader = new StreamReader(stream2);
        while (true) {
            var line = reader.ReadLine();
            if (line == null) {
                break;
            }

            Console.WriteLine(line);
        }
    }
}