namespace VP.DesignPatterns.Command;

/// <summary>
/// Represent interface that each of the commands will implements.
/// </summary>
public interface ICommand
{
    /// <summary>
    /// Actual operation that will be executed.
    /// </summary>
    void Execute();

    /// <summary>
    /// Undo operation. Oposite of <see cref="Execute"/>.
    /// </summary>
    void Undo();

}
