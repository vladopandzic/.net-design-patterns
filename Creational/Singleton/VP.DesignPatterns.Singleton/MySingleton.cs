namespace VP.DesignPatterns.Singleton;

public class MySingleton
{
    /// <summary>
    /// Constuctor must be private to prevent instantiation.
    /// </summary>
    private MySingleton()
    {
        Console.WriteLine("called");
    }
    private static readonly object lockObject = new object();

    private static MySingleton? _instance;

    /// <summary>
    /// Provides access to singleton instance. Must be static to since client will never instantiate <see
    /// cref="MySingleton"/> using new.
    /// </summary>
    public static MySingleton Instance
    {
        get
        {
            lock (lockObject)
            {
                if (_instance is null)
                {
                    _instance = new MySingleton();
                }
            }

            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton doing something");
    }
}
