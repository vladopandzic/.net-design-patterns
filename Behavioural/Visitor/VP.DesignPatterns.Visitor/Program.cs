
// Create some employees
using VP.DesignPatterns.Visitor;

var manager = new EngineeringManager("Alice", 5000) { NumberOfDirectReports = 3 };
var productManager = new ProductManager("Bob", 4000) { ProjectPerformance = 5 };
var engineer = new SoftwareEngineer("Charlie", 3000);

// Create a visitor
var salaryVisitor = new SalaryVisitor();

// Apply the visitor to each employee
manager.Accept(salaryVisitor);
productManager.Accept(salaryVisitor);
engineer.Accept(salaryVisitor);

// Output total salary calculated by the visitor
Console.WriteLine($"Total salary: {salaryVisitor.TotalSalary}");

// Wait for user input before closing console window
Console.ReadLine();