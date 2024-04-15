namespace VP.DesignPatterns.ChainOfResponsibility;

public abstract class AssemblyZone
{
    protected AssemblyZone? _nextZone;

    public AssemblyZone SetNextZone(AssemblyZone nextZone)
    {
        _nextZone = nextZone;
        return _nextZone;
    }

    public abstract bool Assemble(Car part);
}
