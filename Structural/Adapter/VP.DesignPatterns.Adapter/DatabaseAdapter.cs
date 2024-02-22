namespace VP.DesignPatterns.Adapter;

public class DatabaseAdapter : IDatabaseService
{
    readonly LegacySqlDatabase _legacySqlDatabase;
    public DatabaseAdapter(LegacySqlDatabase legacySqlDatabase)
    {
        _legacySqlDatabase = legacySqlDatabase;
    }

    public void ExecuteModernQuery(string query)
    {
        _legacySqlDatabase.ExecuteQuery(query);
    }
}
