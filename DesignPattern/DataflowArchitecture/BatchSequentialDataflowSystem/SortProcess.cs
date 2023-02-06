using System.IO.Pipes;

namespace DesignPattern.DataflowArchitecture.BatchSequentialDataflowSystem;

public class SortProcess: Process
{
    public SortProcess(PipeStream input, PipeStream output) : base(input, output) { }
    public override void ProcessData() {
        var reader = new StreamReader(_input);
        var writer = new StreamWriter(_output);
        var lines = new List<string>();
        while (reader.Peek() != -1) {
            var line = reader.ReadLine();
            if (line == null) {
                break;
            }
            lines.Add(line);
        }
        lines.Sort();
        foreach (var line in lines) {
            writer.WriteLine(line);
        }
        writer.Flush();
    }
}