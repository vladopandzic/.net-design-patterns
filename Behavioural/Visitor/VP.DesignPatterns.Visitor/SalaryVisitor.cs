namespace VP.DesignPatterns.Visitor;

public class SalaryVisitor : IEmployeeVisitor
{
    public decimal TotalSalary { get; set; }

    public void Visit(EngineeringManager engineeringManager)
    {
        const decimal bonusPerDirectReport = 100;
        TotalSalary += engineeringManager.Salary + bonusPerDirectReport * engineeringManager.NumberOfDirectReports;
    }

    public void Visit(ProductManager productManager)
    {
        const decimal bonusPerProjectPerformance = 50;
        TotalSalary += productManager.Salary + bonusPerProjectPerformance * productManager.ProjectPerformance;
    }

    public void Visit(SoftwareEngineer softwareEngineer)
    {
        TotalSalary += softwareEngineer.Salary;
    }
}
