namespace VP.DesignPatterns.ChainOfResponsibility.Tests;

public class ChainOfResponsibilityTests
{
    [Test]
    public void GivenCarWithSteelChassisAndPetrolEngine_ShouldAssembleSuccessfully()
    {
        // Arrange
        AssemblyZone carAssembler = new ChassisAssemblyZone();
        carAssembler.SetNextZone(new EngineAssemblyZone())
                     .SetNextZone(new InteriorAssemblyZone());

        var car = new Car(1, "Steel", "Petrol");

        // Act
        var successfullyAssembled = carAssembler.Assemble(car);

        // Assert
        Assert.IsTrue(successfullyAssembled);
    }

    [Test]
    public void GivenCarWithCarbonChassis_ShouldFailToAssembleInChassisZone()
    {
        // Arrange
        AssemblyZone carAssembler = new ChassisAssemblyZone();
        carAssembler.SetNextZone(new EngineAssemblyZone())
                     .SetNextZone(new InteriorAssemblyZone());

        var car = new Car(1, "Carbon", "Petrol");

        // Act
        var successfullyAssembled = carAssembler.Assemble(car);

        // Assert
        Assert.IsFalse(successfullyAssembled);
    }

    [Test]
    public void GivenCarWithPetrolEngine_ShouldAssembleEngineAndInteriorSuccessfully()
    {
        // Arrange
        AssemblyZone carAssembler = new EngineAssemblyZone();
        carAssembler.SetNextZone(new InteriorAssemblyZone());

        var car = new Car(1, "Steel", "Petrol");

        // Act
        var successfullyAssembled = carAssembler.Assemble(car);

        // Assert
        Assert.IsTrue(successfullyAssembled);
    }
}
