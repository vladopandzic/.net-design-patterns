namespace VP.DesignPatterns.Prototype.Tests;

public class PrototypePatternTests
{
    [Test]
    public void Clone_ReturnsNewInstanceWithSameAttributes()
    {
        // Arrange
        var original = new Employee("John Doe", "IT", "Software Engineer");

        // Act
        var clone = original.Clone() as Employee;

        // Assert
        Assert.That(clone, Is.Not.Null, "Clone should not be null");
        Assert.That(clone.Name, Is.EqualTo(original.Name), "Clone should have the same name as original");
        Assert.That(clone.Department, Is.EqualTo(original.Department), "Clone should have the same department as original");
        Assert.That(clone.JobTitle, Is.EqualTo(original.JobTitle), "Clone should have the same job title as original");
    }

    [Test]
    public void Clone_ReturnsNewInstanceWithoutSharedReferences()
    {
        // Arrange
        var original = new Employee("John Doe", "IT", "Software Engineer");

        // Act
        var clone = original.Clone() as Employee;

        // Assert
        Assert.That(clone, Is.Not.SameAs(original), "Clone should not be the same instance as original");
    }
}
