namespace VP.DesignPatterns.ChainOfResponsibility;

public class InteriorAssemblyZone : AssemblyZone
{
    public override bool Assemble(Car part)
    {
        Console.WriteLine("Assembled interior");

        return _nextZone?.Assemble(part) ?? true;
    }
}

