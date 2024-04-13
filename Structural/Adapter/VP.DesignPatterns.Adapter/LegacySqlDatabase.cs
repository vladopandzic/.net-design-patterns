namespace VP.DesignPatterns.Adapter;

public class LegacySqlDatabase
{
    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"Executing old sql query:{query}");
    }
}
