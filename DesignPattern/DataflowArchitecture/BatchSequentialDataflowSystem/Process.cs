using System.IO.Pipes;

namespace DesignPattern.DataflowArchitecture.BatchSequentialDataflowSystem;

public abstract class Process
{
    protected PipeStream _input;
    protected PipeStream _output;
    public Process(PipeStream input, PipeStream output)
    {
        _input = input;
        _output = output;
    }

    public abstract void ProcessData();
}