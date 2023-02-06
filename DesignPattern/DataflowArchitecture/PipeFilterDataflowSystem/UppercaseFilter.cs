using System.IO.Pipes;

namespace DesignPattern.DataflowArchitecture.PipeFilterDataflowSystem;

public class UppercaseFilter : BaseComponent
{
    public UppercaseFilter(PipeStream input, PipeStream output) : base(input, output) { }

    public override void ProcessData() {
        var reader = new StreamReader(_input);
        var writer = new StreamWriter(_output);
        while (true) {
            var line = reader.ReadLine();
            if (line == null) {
                continue;
            }

            writer.WriteLine(line.ToUpper());
            writer.Flush();
        }
    }
}