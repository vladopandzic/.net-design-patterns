namespace VP.DesignPatterns.Prototype;

internal class Program
{
    static void Main(string[] args)
    {
        // Create and customize employees
        var john = new Employee("John Doe", "IT", "Software Engineer");
        var jane = john.Clone() as Employee;

        jane!.Display(); // Display the original employee

        jane = new Employee("Jane Smith", "Marketing", "Marketing Manager");

        jane.Display(); // Display the customized employee
    }
}
