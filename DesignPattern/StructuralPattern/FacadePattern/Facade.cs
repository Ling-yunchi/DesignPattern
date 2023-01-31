namespace DesignPattern.StructuralPattern.FacadePattern;

public class Facade
{
    private SubsystemA _a = new SubsystemA();
    private SubsystemB _b = new SubsystemB();

    public string Operation() {
        string result = "";
        result += _a.OperationA1();
        result += " " + _b.OperationB1();
        result += " " + _a.OperationA2();
        result += " " + _b.OperationB2();
        return result;
    }
}