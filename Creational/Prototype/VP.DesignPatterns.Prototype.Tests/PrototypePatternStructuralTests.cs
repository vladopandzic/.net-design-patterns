namespace VP.DesignPatterns.Prototype.Tests;

public class PrototypePatternStructuralTests
{
    [Test]
    public void Clone_NotSameInstance()
    {
        // Arrange
        var original = new Employee("John Doe", "IT", "Software Engineer");

        // Act
        var clone = original.Clone() as Employee;

        // Assert
        Assert.That(clone, Is.Not.SameAs(original), "Clone should not be the same instance as original");
    }

    [Test]
    public void Clone_SameAttributes()
    {
        // Arrange
        var original = new Employee("John Doe", "IT", "Software Engineer");

        // Act
        var clone = original.Clone() as Employee;

        // Assert
        Assert.That(clone.Name, Is.EqualTo(original.Name), "Clone should have the same name as original");
        Assert.That(clone.Department, Is.EqualTo(original.Department), "Clone should have the same department as original");
        Assert.That(clone.JobTitle, Is.EqualTo(original.JobTitle), "Clone should have the same job title as original");
    }
}