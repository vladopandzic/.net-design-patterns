namespace VP.DesignPatterns.Visitor;

public class EngineeringManager : Employee
{
    public int NumberOfDirectReports { get; set; }

    public EngineeringManager(string name, decimal salary) : base(name, salary)
    {
    }

    public override void Accept(IEmployeeVisitor visitor)
    {
        visitor.Visit(this);
    }
}
