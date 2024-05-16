namespace VP.DesignPatterns.Visitor;

public class ProductManager : Employee
{

    public int ProjectPerformance { get; set; }

    public ProductManager(string name, decimal salary) : base(name, salary)
    {
    }

    public override void Accept(IEmployeeVisitor visitor)
    {
        visitor.Visit(this);
    }
}
