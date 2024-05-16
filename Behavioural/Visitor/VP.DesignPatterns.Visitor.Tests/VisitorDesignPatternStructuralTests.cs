using NSubstitute;

namespace VP.DesignPatterns.Visitor.Tests;

public class VisitorDesignPatternStructuralTests
{
    [Test]
    public void Employee_Accept_VisitsWithVisitor()
    {
        // Arrange
        var visitor = Substitute.For<IEmployeeVisitor>();
        var manager = new EngineeringManager("Alice", 5000) { NumberOfDirectReports = 3 };

        // Act
        manager.Accept(visitor);

        // Assert
        visitor.Received(1).Visit(manager);
    }

    [Test]
    public void SalaryVisitor_Visit_EngineeringManager_CalculatesTotalSalary()
    {
        // Arrange
        var manager = new EngineeringManager("Alice", 5000) { NumberOfDirectReports = 3 };
        var visitor = new SalaryVisitor();

        // Act
        visitor.Visit(manager);

        // Assert
        var expectedTotalSalary = manager.Salary + (100 * manager.NumberOfDirectReports);
        Assert.That(expectedTotalSalary, Is.EqualTo(visitor.TotalSalary));
    }

    [Test]
    public void SalaryVisitor_Visit_ProductManager_CalculatesTotalSalary()
    {
        // Arrange
        var productManager = new ProductManager("Bob", 4000) { ProjectPerformance = 5 };
        var visitor = new SalaryVisitor();

        // Act
        visitor.Visit(productManager);

        // Assert
        var expectedTotalSalary = productManager.Salary + (50 * productManager.ProjectPerformance);
        Assert.That(expectedTotalSalary, Is.EqualTo(visitor.TotalSalary));
    }

    [Test]
    public void SalaryVisitor_Visit_SoftwareEngineer_CalculatesTotalSalary()
    {
        // Arrange
        var engineer = new SoftwareEngineer("Charlie", 3000);
        var visitor = new SalaryVisitor();

        // Act
        visitor.Visit(engineer);

        // Assert
        Assert.That(engineer.Salary, Is.EqualTo(visitor.TotalSalary));
    }
}