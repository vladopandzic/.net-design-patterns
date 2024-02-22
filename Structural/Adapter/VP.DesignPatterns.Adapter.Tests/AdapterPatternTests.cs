using NSubstitute;

namespace VP.DesignPatterns.Adapter.Tests;

public class AdapterPatternTests
{
    [Test]
    public void Adapter_ExecuteModernQuery_Calls_LegacySqlDatabase_ExecuteQuery()
    {
        // Arrange
        var legacySqlDatabase = Substitute.For<LegacySqlDatabase>();
        var adapter = new DatabaseAdapter(legacySqlDatabase);
        string query = "SELECT * FROM Table";

        // Act
        adapter.ExecuteModernQuery(query);

        // Assert
        legacySqlDatabase.Received().ExecuteQuery(query);
    }
}
