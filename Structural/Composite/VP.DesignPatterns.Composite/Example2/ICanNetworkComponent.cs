namespace VP.DesignPatterns.Composite.Example2;

/// <summary>
/// Interface that both leaf node and composite implement so that client can treat them the same way.
/// </summary>
public interface ICanNetworkComponent
{
    string Name { get; }

    void Display();
}
