using System.IO.Pipes;
using System.Text;
using NUnit.Framework;

namespace DesignPattern.DataflowArchitecture.BatchSequentialDataflowSystem;

public static class Program
{
    private const string DATA =
"To see a world in a grain of sand,\nAnd a heaven in a wild flower,\nHold infinity in the palm of your hand,\nAnd eternity in an hour.\n";

    [Test]
    public static void Test() {
        var pipeServer1 = new AnonymousPipeServerStream(PipeDirection.Out);
        var pipeClient1 = new AnonymousPipeClientStream(PipeDirection.In, pipeServer1.GetClientHandleAsString());
        var pipeServer2 = new AnonymousPipeServerStream(PipeDirection.Out);
        var pipeClient2 = new AnonymousPipeClientStream(PipeDirection.In, pipeServer2.GetClientHandleAsString());
        var pipeServer3 = new AnonymousPipeServerStream(PipeDirection.Out);
        var pipeClient3 = new AnonymousPipeClientStream(PipeDirection.In, pipeServer3.GetClientHandleAsString());
        var process1 = new UppercaseProcess(pipeClient1, pipeServer2);
        var process2 = new SortProcess(pipeClient2, pipeServer3);
        pipeServer1.Write(Encoding.UTF8.GetBytes(DATA));
        pipeServer1.Close();
        process1.ProcessData();
        process2.ProcessData();
        // the pipe must be closed or the reader will block
        pipeServer3.Close();
        var reader = new StreamReader(pipeClient3);
        while (true) {
            var line = reader.ReadLine();
            if (line == null) {
                break;
            }

            Console.WriteLine(line);
        }
    }
}