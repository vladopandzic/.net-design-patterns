
namespace VP.DesignPatterns.Adapter;

internal class Program
{
    static void Main(string[] args)
    {
        IDatabaseService databaseService = new DatabaseAdapter(new LegacySqlDatabase());

        databaseService.ExecuteModernQuery("SELECT * from OldSystem.Products");

        Console.ReadKey();
    }
}
