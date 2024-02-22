namespace VP.DesignPatterns.Singleton;

internal class Program
{
    static void Main(string[] args)
    {
        MySingleton singleton = MySingleton.Instance;

        singleton.DoSomething();

        Console.ReadLine();
    }
}
