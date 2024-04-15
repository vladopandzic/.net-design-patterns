namespace VP.DesignPatterns.ChainOfResponsibility;

public class EngineAssemblyZone : AssemblyZone
{
    public override bool Assemble(Car part)
    {
        if (part.EngineType != "Diesel")
        {
            Console.WriteLine("Assembled engine");
            return _nextZone?.Assemble(part) ?? true;
        }
        return false;
    }
}
