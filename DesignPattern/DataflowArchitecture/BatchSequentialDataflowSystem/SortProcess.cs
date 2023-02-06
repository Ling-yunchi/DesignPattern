namespace DesignPattern.DataflowArchitecture.BatchSequentialDataflowSystem;

public class SortProcess: IProcess
{
    Stream _input;
    Stream _output;
    public SortProcess(Stream input, Stream output)
    {
        _input = input;
        _output = output;
    }
    public void ProcessData() {
        var reader = new StreamReader(_input);
        var writer = new StreamWriter(_output);
        var lines = new List<string>();
        while (true) {
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
        _output.Position = 0;
    }
}