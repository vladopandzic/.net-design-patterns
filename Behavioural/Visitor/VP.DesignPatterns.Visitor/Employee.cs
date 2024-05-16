namespace VP.DesignPatterns.Visitor;

public abstract class Employee
{
    public string Name { get; set; }

    public decimal Salary { get; set; }

    protected Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public abstract void Accept(IEmployeeVisitor employeeVisitor);
}
