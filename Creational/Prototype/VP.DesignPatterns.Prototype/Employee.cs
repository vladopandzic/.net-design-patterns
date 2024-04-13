namespace VP.DesignPatterns.Prototype;

public class Employee : IEmployeePrototype
{
    public Employee(string name, string department, string jobTitle)
    {
        Name = name;
        Department = department;
        JobTitle = jobTitle;
    }

    public string Name { get; set; }

    public string Department { get; set; }

    public string JobTitle { get; set; }

    public IEmployeePrototype Clone()
    {
        // Perform a shallow copy
        return (this.MemberwiseClone() as IEmployeePrototype)!;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}. Department: {Department}. Job title: {JobTitle}");
    }
}
