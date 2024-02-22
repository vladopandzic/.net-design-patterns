namespace VP.DesignPatterns.Builder.Tests;

public class Tests
{
    [Test]
    public void ComputerBuilder_Should_Implement_Interface()
    {
        // Arrange
        var builderType = typeof(GamingComputerBuilder);

        // Act
        var implementedInterfaces = builderType.GetInterfaces();

        // Assert
        Assert.Contains(typeof(IComputerBuilder), implementedInterfaces, "ComputerBuilder should implement IBuilder interface.");
    }
}