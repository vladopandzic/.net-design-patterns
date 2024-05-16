namespace VP.DesignPatterns.Visitor;

public class SoftwareEngineer : Employee
{
    public SoftwareEngineer(string name, decimal salary) : base(name, salary)
    {
    }

    public override void Accept(IEmployeeVisitor visitor)
    {
        visitor.Visit(this);
    }
}
