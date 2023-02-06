namespace DesignPattern.DataflowArchitecture.BatchSequentialDataflowSystem;

public class UppercaseProcess : IProcess
{
    Stream _input;
    Stream _output;
    public UppercaseProcess(Stream input, Stream output)
    {
        _input = input;
        _output = output;
    }

    public void ProcessData() {
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
        _output.Position = 0;
    }
}