namespace VP.DesignPatterns.ChainOfResponsibility.Tests;

[TestFixture]
public class ChainStructureTests
{
    [Test]
    public void GivenChassisAssemblyZone_ShouldHaveNextZoneSetToEngineAssemblyZone()
    {
        // Arrange
        var chassisZone = new ChassisAssemblyZone();
        var engineZone = new EngineAssemblyZone();

        // Act
        var nextZone = chassisZone.SetNextZone(engineZone);

        // Assert
        Assert.That(engineZone, Is.SameAs(nextZone));
    }

    [Test]
    public void GivenEngineAssemblyZone_ShouldHaveNextZoneSetToInteriorAssemblyZone()
    {
        // Arrange
        var engineZone = new EngineAssemblyZone();
        var interiorZone = new InteriorAssemblyZone();

        // Act
        var nextZone = engineZone.SetNextZone(interiorZone);

        // Assert
        Assert.That(interiorZone, Is.SameAs(nextZone));
    }

}