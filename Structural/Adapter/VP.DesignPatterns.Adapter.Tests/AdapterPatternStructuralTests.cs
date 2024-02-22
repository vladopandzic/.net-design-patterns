using NSubstitute;

namespace VP.DesignPatterns.Adapter.Tests;

public class AdapterPatternStructuralTests
{

    [Test]
    public void Adapter_Implements_Interface()
    {
        // Arrange
        var adapter = new DatabaseAdapter(Substitute.For<LegacySqlDatabase>());

        // Assert
        Assert.IsTrue(adapter is IDatabaseService);
    }

    [Test]
    public void Adapter_Wraps_Legacy_System()
    {
        // Arrange
        var legacySqlDatabase = Substitute.For<LegacySqlDatabase>();

        // Act
        var adapter = new DatabaseAdapter(legacySqlDatabase);

        // Assert
        Assert.IsNotNull(adapter);
        legacySqlDatabase.Received(1).ExecuteQuery(Arg.Any<string>());
    }

    [Test]
    public void Adapter_Constructor_Accepts_LegacySqlDatabase_As_Parameter()
    {
        // Arrange

        // Act
        var constructor = typeof(DatabaseAdapter).GetConstructor(new[] { typeof(LegacySqlDatabase) });

        // Assert
        Assert.IsNotNull(constructor);
    }

}