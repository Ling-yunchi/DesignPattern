using System.IO.Pipes;

namespace DesignPattern.DataflowArchitecture.BatchSequentialDataflowSystem;

public class UppercaseProcess : Process
{
    public UppercaseProcess(PipeStream input, PipeStream output) : base(input, output) { }
    public override void ProcessData() {
        var reader = new StreamReader(_input);
        var writer = new StreamWriter(_output);
        while (true) {
            var line = reader.ReadLine();
            if (line == null) {
                break;
            }
            writer.WriteLine(line.ToUpper());
        }
        writer.Flush();
    }
}