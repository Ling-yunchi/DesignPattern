using System.IO.Pipes;

namespace DesignPattern.DataflowArchitecture.PipeFilterDataflowSystem;

public abstract class BaseComponent
{
    protected Thread _thread;
    protected PipeStream _input;
    protected PipeStream _output;
    
    public BaseComponent(PipeStream input, PipeStream output)
    {
        _input = input;
        _output = output;
        _thread = new Thread(ProcessData);
    }
    public void Start() => _thread.Start();
    public void Stop() => _thread.Interrupt();
    public abstract void ProcessData();
}