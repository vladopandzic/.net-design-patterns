namespace VP.DesignPatterns.Composite.Example1;

/// <summary>
/// Interface that both leaf node and composite implement so that client can treat them the same way.
/// </summary>
public interface IMenuItem
{
    public string Name { get; }

    void Display();
}
