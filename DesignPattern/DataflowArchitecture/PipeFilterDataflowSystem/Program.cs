using System.IO.Pipes;
using NUnit.Framework;

namespace DesignPattern.DataflowArchitecture.PipeFilterDataflowSystem;

public static class Program
{
    // [Test]
    public static void Test() {
        var pipeServer1 = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.None);
        var pipeClient1 = new AnonymousPipeClientStream(PipeDirection.In, pipeServer1.GetClientHandleAsString());
        var pipeServer2 = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.None);
        var pipeClient2 = new AnonymousPipeClientStream(PipeDirection.In, pipeServer2.GetClientHandleAsString());
        var pipeServer3 = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.None);
        var pipeClient3 = new AnonymousPipeClientStream(PipeDirection.In, pipeServer3.GetClientHandleAsString());
        var trimFilter = new TrimFilter(pipeClient1, pipeServer2);
        var uppercaseFilter = new UppercaseFilter(pipeClient2, pipeServer3);
        trimFilter.Start();
        uppercaseFilter.Start();
        var writer = new StreamWriter(pipeServer1);
        var reader = new StreamReader(pipeClient3);
        var dataProvider = new Thread(() => {
            while (true) {
                writer.WriteLine("  Hello World!  ");
                writer.Flush();
                Thread.Sleep(1000);
            }
        });
        var dataOutputer = new Thread(() => {
            while (true) {
                var line = reader.ReadLine();
                if (line != null) {
                    Console.WriteLine(line);
                }
            }
        });
        dataProvider.Start();
        dataOutputer.Start();
        Thread.Sleep(10000);
        dataProvider.Interrupt();
        dataOutputer.Interrupt();
        trimFilter.Stop();
        uppercaseFilter.Stop();
    }
}